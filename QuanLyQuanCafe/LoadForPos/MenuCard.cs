using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Views
{
    public partial class MenuCard : Form
    {
        public delegate void Choose(string MaMon);
        public event Choose ChooseEvent;

        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int DonGia { get; set; }
        public string TenLoai { get; set; }
        public MenuCard()
        {
            InitializeComponent();
        }

        public MenuCard(string maMon, string tenMon, int donGia, string tenLoai)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.DonGia = donGia;
            this.TenLoai = tenLoai;
            InitializeComponent();
        }

        private void LoadImage()
        {
            if (this.TenLoai == "Đồ ăn")
                pbMenu.BackgroundImage = Properties.Resources.cakee;
            else
                pbMenu.BackgroundImage = Properties.Resources.drinkicon;
        }

        private void LoadData()
        {
            this.lblName.Text = TenMon;
            this.lblGia.Text = DonGia + " VND";
            LoadImage();
        }

        private void MenuCard_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (ChooseEvent != null) ChooseEvent(this.MaMon);
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (ChooseEvent != null) ChooseEvent(this.MaMon);
        }

        private void lblGia_Click(object sender, EventArgs e)
        {
            if (ChooseEvent != null) ChooseEvent(this.MaMon);
        }

    }
}
