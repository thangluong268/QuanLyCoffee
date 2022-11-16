using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Views
{
    public partial class theOrder : Form
    {

        public delegate void Click(string MaMon, string MaBan);
        public event Click clickEvent;

        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string MaBan { get; set; }

        public theOrder()
        {
            InitializeComponent();
        }

        public theOrder(string maMon, string tenMon, int donGia, int soLuong, string maBan)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.MaBan = maBan;
            InitializeComponent();
        }

        private void setInfor()
        {

            lblTenMon.Text = TenMon;
            lblSoLuong.Text = "x" + SoLuong;
            lblGia.Text = DonGia + " VND";
            DonGia = DonGia * SoLuong;
            lblTongTien.Text = DonGia + " VND";
        }

        private void theOrder_Load(object sender, EventArgs e)
        {
            setInfor();
        }

        private void btnTatTheOrder_Click(object sender, EventArgs e)
        {
            if (clickEvent != null) clickEvent(this.MaMon, this.MaBan);
        }
    }
}
