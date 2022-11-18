using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

using QuanLyQuanCafe.BSLayer;

namespace QuanLyQuanCafe.Views
{
    public partial class fPos : Form
    {
        BLPos blPos = new BLPos();

        int soLuongMonDangGoi = 0;
        public static string maBanDangChon { get; set; }
        public static string maHD { get; set; }

        DanhSachGoiMon[] lstGoiMon = new DanhSachGoiMon[200];

        public fPos()
        {
            InitializeComponent();
        }

        public void fPos_Close()
        {
            this.Close();
        }

        private void fPos_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadBan();
            LoadDVT();
            LoadTenBanTu();
            LoadTenBanDen();
        }

        // tạo một kiểu dữ liệu phục vụ cho quá trình gọi món
        public struct DanhSachGoiMon
        {
            public string maMon;
            public string tenMon;
            public int donGia;
            public int soLuong;
            public string maBan;
            public bool check; // kiểm tra phẩn tử đã được đổi hay chưa
        }

        private void LoadTenBanTu()
        {
            DataTable dtTenBan = new DataTable();
            dtTenBan.Clear();

            DataSet ds = blPos.LoadTenBan();
            dtTenBan = ds.Tables[0];

            cbbTuBan.ValueMember = "TenBan";
            cbbTuBan.DataSource = dtTenBan;
        }

        private void LoadTenBanDen()
        {
            DataTable dtTenBan = new DataTable();
            dtTenBan.Clear();

            DataSet ds = blPos.LoadTenBan();
            dtTenBan = ds.Tables[0];

            cbbDenBan.ValueMember = "TenBan";
            cbbDenBan.DataSource = dtTenBan;
        }

        private void LoadDVT()
        {
            DataSet ds = new DataSet();
            ds = blPos.LoadDVT();
            DataTable dtMenu = ds.Tables[0];
            lblDVT.Text = dtMenu.Rows[0][0].ToString();
        }

        private void LoadMenu()
        {
            DataSet ds = new DataSet();
            ds = blPos.LoadMenu();
            DataTable dtMenu = ds.Tables[0];

            foreach (DataRow row in dtMenu.Rows)
            {
                MenuCard menuCard = new MenuCard(row[0].ToString(), row[1].ToString(), Int32.Parse(row[2].ToString()), row[3].ToString());
                menuCard.TopLevel = false;
                menuCard.AutoScroll = false;
                menuCard.ChooseEvent += menuCard_ChooseEvent;
                menuCard.Show();
                pnlMenu.Controls.Add(menuCard);
            }    
        }

        private void LoadMenuTheoLoai(string tenLoai)
        {
            pnlMenu.Controls.Clear();

            // trả về chuỗi không có dấu nháy
            string strN = "N";
            strN = strN.Substring(1, strN.Length - 1);

            DataSet ds = new DataSet();
            ds = blPos.LoadMenuTheoLoai(strN, tenLoai);
            DataTable dtMenu = ds.Tables[0];

            foreach (DataRow row in dtMenu.Rows)
            {
                MenuCard menuCard = new MenuCard(row[0].ToString(), row[1].ToString(), Int32.Parse(row[2].ToString()), row[3].ToString());
                menuCard.TopLevel = false;
                menuCard.AutoScroll = false;
                menuCard.ChooseEvent += menuCard_ChooseEvent;
                menuCard.Show();
                pnlMenu.Controls.Add(menuCard);
            }
        }

        private void LoadOrder()
        {
            int tongTien = 0;
            pnlOrder.Controls.Clear();

            bool exists = false;

            for (int i = 0; i < soLuongMonDangGoi; i++)
            {
                if(lstGoiMon[i].maBan == maBanDangChon)
                {
                    exists = true;
                    DanhSachGoiMon data = lstGoiMon[i];
                    theOrder theOrder = new theOrder(data.maMon, data.tenMon, data.donGia, data.soLuong, data.maBan);
                    theOrder.TopLevel = false;
                    theOrder.AutoScroll = false;
                    theOrder.clickEvent += TheOrder_clickEvent;
                    theOrder.Show();

                    pnlOrder.Controls.Add(theOrder);
                    tongTien += data.donGia * data.soLuong;
                }
                lblTongTien.Text = tongTien.ToString();
            }
            if (exists == false)
                lblTongTien.Text = "0";
        }

        private void LoadBan()
        {
            DataSet ds = new DataSet();
            ds = blPos.LoadBan();
            DataTable dtBan = ds.Tables[0];

            pnlBan.Controls.Clear();

            foreach (DataRow row in dtBan.Rows)
            {
                Button newButton = new Button();
                newButton.Text = row[1].ToString();
                newButton.Size = new Size(50, 50);
                if ((bool)row[2] == false)
                    newButton.BackColor = Color.White;
                else
                    newButton.BackColor = Color.Red;

                void eventClick(object sender, EventArgs e)
                {
                    maBanDangChon = row[0].ToString();
                    newButton.BackColor = Color.Yellow;
                    lblTenBan.Text = row[1].ToString();

                    LoadOrder();
                }
                void eventLeave(object sender, EventArgs e)
                {
                    if ((bool)row[2] == true)
                        newButton.BackColor = Color.Red;
                    else
                        newButton.BackColor = Color.White;

                    LoadOrder();
                }

                newButton.Click += new EventHandler(eventClick);
                newButton.Leave += new EventHandler(eventLeave);
                pnlBan.Controls.Add(newButton);
            }
        }

        private void CapNhatBanKhiOrder()
        {
            int dem = 0;
            for (int i = 0; i < soLuongMonDangGoi; i++)
            {
                if (lstGoiMon[i].maBan == maBanDangChon)
                    dem++;
            }

            if (dem != 0)
                blPos.CapNhatBan(maBanDangChon, 1);
            else
            {
                string maHD = LayMaHD(maBanDangChon);
                blPos.XoaHoaDon(maHD);
                blPos.CapNhatBan(maBanDangChon, 0);
            }
            LoadBan();
        }

        private bool KiemTraHoaDonCuaBan()
        {
            DataSet ds = blPos.KiemTraHoaDonCuaBan(maBanDangChon);
            DataTable dt = ds.Tables[0];
            if(dt.Rows.Count > 0)
                return true;
            return false;
        }


        private void menuCard_ChooseEvent(string maMon)
        {
            if(maBanDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }    
            DataSet ds = blPos.LoadThucDonChoGoiMonTheoMa(maMon);
            DataTable dtMenu = ds.Tables[0];

            string _maMon = "";
            string _tenMon = "";
            int _donGia = -1;
            foreach (DataRow row in dtMenu.Rows)
            {
                _maMon = row[0].ToString();
                _tenMon = row[2].ToString();
                _donGia = Convert.ToInt32(row[3].ToString());
            }

            if (dtMenu.Rows.Count > 0)
            {
                bool check = KiemTraHoaDonCuaBan();

                // check = false khi bàn chưa có hóa đơn
                if (check == false)
                {
                    string newMaHD = TaoMaHD();
                    DataSet dsHD = blPos.KiemTraMaHD(newMaHD);
                    DataTable dtHD = dsHD.Tables[0];
                    bool checkMaHD = (bool)dtHD.Rows[0][0];
                    int trung = 0;
                    
                    // checkMaHD == true : đã tồn tại mã hóa đơn -> tạo mã hóa đơn mới
                    while(checkMaHD == true)
                    {
                        trung++;
                        newMaHD = TaoMaHDNew(trung);
                        DataSet dsHDNew = blPos.KiemTraMaHD(newMaHD);
                        DataTable dtHDNew = dsHDNew.Tables[0];
                        checkMaHD = (bool)dtHDNew.Rows[0][0];
                    }    
                    string ngayTao = DateTime.Now.ToString("yyyy/MM/dd");
                    string maNV = fProfile.maNV;
                    try
                    {
                        blPos.ThemHoaDon(newMaHD, maNV, maBanDangChon, ngayTao, 0, 0, 0);
                        LoadBan();
                    }
                    catch (Exception)
                    {
                        int temp = Int32.Parse(newMaHD);
                        newMaHD = temp++.ToString();
                        //MessageBox.Show("Không thêm hóa đơn được, Lỗi!");

                    }
                }
                
                // Kiểm tra món đã có trong hóa đơn của bàn này hay chưa
                bool exist = false;
                for (int i = 0; i < soLuongMonDangGoi; i++)
                {
                    if (lstGoiMon[i].maMon == _maMon && lstGoiMon[i].maBan == maBanDangChon)
                        exist = true;
                }
                if (exist == false)
                {
                    DanhSachGoiMon order = new DanhSachGoiMon();
                    order.maMon = _maMon;
                    order.soLuong = 1;
                    order.donGia = _donGia;
                    order.tenMon = _tenMon;
                    order.maBan = maBanDangChon;
                    lstGoiMon[soLuongMonDangGoi++] = order;
                }
                else
                {
                    for (int i = 0; i < soLuongMonDangGoi; i++)
                    {
                        if (lstGoiMon[i].maMon == _maMon && lstGoiMon[i].maBan == maBanDangChon)
                        {
                            lstGoiMon[i].soLuong++;
                        }
                    }
                }
            }
            LoadOrder();
        }

        private void TheOrder_clickEvent(string maMon, string maBan)
        {
            int index = -1;
            for (int i = 0; i < soLuongMonDangGoi; i++)
            {
                if (lstGoiMon[i].maMon == maMon && lstGoiMon[i].maBan == maBan) 
                    index = i;
                if (index != -1) 
                    lstGoiMon[i] = lstGoiMon[i + 1];
            }
            lblTongTien.Text = (Int32.Parse(lblTongTien.Text) - lstGoiMon[index].donGia * lstGoiMon[index].soLuong).ToString();
            soLuongMonDangGoi -= 1;
            CapNhatBanKhiOrder();
            LoadOrder();
        }

        // xóa tất cả các món được gọi của bàn đang chọn khi ấn thanh toán
        private void XoaOrderCuaBan()
        {
            for(int i = soLuongMonDangGoi - 1; i >= 0; i--)
            {
                if(lstGoiMon[i].maBan == maBanDangChon)
                {
                    for (int j = i; j < soLuongMonDangGoi - 1; j++)
                        lstGoiMon[j] = lstGoiMon[j + 1];
                    soLuongMonDangGoi--;
                }    
            }    
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenloai = null;
            int loai = cbbType.SelectedIndex;
            if (loai == 0)
                tenloai = "Đồ ăn";
            if (loai == 1)
                tenloai = "Đồ uống";
            LoadMenuTheoLoai(tenloai);
        }


        // cộng thêm số lần bị trùng
        private string TaoMaHDNew(int trung)
        {
            DataSet ds = new DataSet();
            ds = blPos.LayTongSoLuongHoaDon();
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            ketqua++; // tạo mã hóa đơn tiếp theo => + 1
            ketqua += trung;
            string maHD = null;
            if (ketqua < 10)
                maHD = "HD0" + ketqua.ToString();
            else
                maHD = "HD" + ketqua.ToString();
            return maHD;
        }


        private string TaoMaHD()
        {
            DataSet ds = new DataSet();
            ds = blPos.LayTongSoLuongHoaDon();
            DataTable dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            ketqua++; // tạo mã hóa đơn tiếp theo => + 1
            string maHD = null;
            if(ketqua < 10)
                maHD = "HD0" + ketqua.ToString();
            else
                maHD = "HD" + ketqua.ToString();
            return maHD;
        }
        private string TaoMaCTHD()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = blPos.LayTongSoLuongCTHD();
            dt = ds.Tables[0];
            int ketqua = Int32.Parse(dt.Rows[0][0].ToString());
            ketqua++; // tạo mã chi tiết hóa đơn tiếp theo => + 1
            string maCTHD = null;
            if (ketqua < 10)
                maCTHD = "CTHD0" + ketqua.ToString();
            else
                maCTHD = "CTHD" + ketqua.ToString();
            return maCTHD;
        }

        private string LayMaHD(string maBan)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = blPos.LayMaHoaDon(maBan);
            dt = ds.Tables[0];
            string maHD = dt.Rows[0][0].ToString();
            return maHD;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            maHD = LayMaHD(maBanDangChon); // lấy mã hóa đơn của bàn đang chọn
            int tongTien = Int32.Parse(lblTongTien.Text);
            try
            {
                blPos.CapNhatHoaDon(maHD, tongTien, 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Không cập nhật được hóa đơn, Lỗi!");
            }
            try
            {
                for (int i = 0; i < soLuongMonDangGoi; i++)
                {
                    if(lstGoiMon[i].maBan == maBanDangChon)
                    {
                        DanhSachGoiMon data = lstGoiMon[i];
                        string maCTHD = TaoMaCTHD();
                        string maMon = data.maMon;
                        string soLuong = data.soLuong.ToString();
                        blPos.ThemCTHD(maCTHD, maHD, maMon, soLuong);
                    }    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thêm được CTHD, Lỗi!");
            }

            fBillPay formBillPay = new fBillPay();
            formBillPay.ShowDialog();

            XoaOrderCuaBan();
            LoadOrder();
            LoadBan();
            lblTongTien.Text = "0";
        }

        private string LayMaBan(string tenBan)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = blPos.LayMaBan(tenBan);
            dt = ds.Tables[0];
            string maBan = dt.Rows[0][0].ToString();
            return maBan;
        }

        private bool KiemTraTrangThaiBan(string maBan)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            ds = blPos.KiemTraTrangThaiBan(maBan);
            dt = ds.Tables[0];
            bool trangThai = (bool)dt.Rows[0][0];
            return trangThai;
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            string tenBanTu = cbbTuBan.SelectedValue.ToString();
            string tenBanDen = cbbDenBan.SelectedValue.ToString();

            string maBanTu = LayMaBan(tenBanTu);
            string maBanDen = LayMaBan(tenBanDen);

            bool trangThaiBanTu = KiemTraTrangThaiBan(maBanTu);
            bool trangThaiBanDen = KiemTraTrangThaiBan(maBanDen);

            // chuyển từ bàn có người sang bàn trống
            if(trangThaiBanTu == true && trangThaiBanDen == false)
            {
                string maHDBanTu = LayMaHD(maBanTu);
                try
                {
                    blPos.CapNhatMaBanCuaHoaDon(maHDBanTu, maBanDen);
                    for(int i = 0; i < soLuongMonDangGoi; i++)
                    {
                        if (lstGoiMon[i].maBan == maBanTu)
                            lstGoiMon[i].maBan = maBanDen;
                    }
                    blPos.CapNhatBan(maBanTu, 0);
                    blPos.CapNhatBan(maBanDen, 1);
                }
                catch(Exception)
                {
                    MessageBox.Show("Không chuyển bàn được, Lỗi!");
                }
            }

            // chuyền từ bàn trống sang bàn có người
            else if (trangThaiBanTu == false && trangThaiBanDen == true)
            {
                string maHDBanDen = LayMaHD(maBanDen);
                try
                {
                    blPos.CapNhatMaBanCuaHoaDon(maHDBanDen, maBanTu);
                    for (int i = 0; i < soLuongMonDangGoi; i++)
                    {
                        if (lstGoiMon[i].maBan == maBanDen)
                            lstGoiMon[i].maBan = maBanTu;
                    }
                    blPos.CapNhatBan(maBanTu, 1);
                    blPos.CapNhatBan(maBanDen, 0);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không chuyển bàn được, Lỗi!");
                }
            }

            // chuyển từ bàn có người sang bàn có người <=> đổi bàn
            else if (trangThaiBanTu == true && trangThaiBanDen == true)
            {
                string maHDBanTu = LayMaHD(maBanTu);
                string maHDBanDen = LayMaHD(maBanDen);
                try
                {
                    blPos.CapNhatMaBanCuaHoaDon(maHDBanTu, maBanDen);
                    blPos.CapNhatMaBanCuaHoaDon(maHDBanDen, maBanTu);
                    for (int i = 0; i < soLuongMonDangGoi; i++)
                    {
                        if (lstGoiMon[i].maBan == maBanDen && lstGoiMon[i].check != true)
                        {
                            lstGoiMon[i].maBan = maBanTu;
                            lstGoiMon[i].check = true;
                        }
                        if (lstGoiMon[i].maBan == maBanTu && lstGoiMon[i].check != true)
                        {
                            lstGoiMon[i].maBan = maBanDen;
                            lstGoiMon[i].check = true;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không chuyển bàn được, Lỗi!");
                }

                // đặt lại check = false cho tất cả
                for (int i = 0; i < soLuongMonDangGoi; i++)
                {
                    if (lstGoiMon[i].check == true)
                        lstGoiMon[i].check = false;
                }
            }

            LoadBan();
        }
    }
}
