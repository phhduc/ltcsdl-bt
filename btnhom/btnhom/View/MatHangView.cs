using btnhom.Data;
using btnhom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btnhom.View
{
    public partial class MatHangView : Form
    {
        private bool isAdmin;
        public MatHang currHang;
        public bool isUpdate;
        public MatHangView(bool isAdmin, MatHang hang)
        {          
            InitializeComponent();
            this.isAdmin = isAdmin;
            isUpdate = true;
            if (hang == null)
            {
                currHang = new MatHang();
                isUpdate = false;
            }
            else this.currHang = hang;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MatHang_Load(object sender, EventArgs e)
        {
            List<LoaiHang> ls = LoaiBL.GetAll();
            cbLoai.DataSource = ls;
            cbLoai.DisplayMember = "name";
            cbLoai.ValueMember = "id";
            if (isAdmin)
            {
                numGiaNhap.ReadOnly = false;
                numSoLuong.ReadOnly = false;
            }
            if(isUpdate) LoadHang();
        }
        private void LoadHang()
        {
            txtTen.Text = currHang.name;
            txtNhaSanXuat.Text = currHang.NhaSX;
            txtXuatXu.Text = currHang.XuatXu;
            txtDoTuoi.Text = currHang.DoTuoi;
            txtGhiChu.Text=currHang.GhiChu;
            numSoLuong.Value = currHang.SoLuongTon;
            numGiaBan.Value=currHang.GiaBan;
            numGiaNhap.Value=currHang.GiaNhap;
            cbLoai.SelectedValue = currHang.idLH;
        }
        private void GetData()
        {
            currHang.name=txtTen.Text;
            currHang.NhaSX = txtNhaSanXuat.Text;
            currHang.XuatXu= txtXuatXu.Text;
            currHang.DoTuoi=txtDoTuoi.Text;
            currHang.GhiChu= txtGhiChu.Text;
            currHang.idLH = int.Parse(cbLoai.SelectedValue.ToString());
            currHang.SoLuongTon = (int)numSoLuong.Value;
            currHang.GiaBan = (long)numGiaBan.Value;
            currHang.GiaNhap = (long)numGiaBan.Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            GetData();
            if (isUpdate)
            {
                if (!MatHangBL.UpdateMatHang(currHang, currHang.id))
                    MessageBox.Show("Lỗi");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                if (!MatHangBL.AddMatHang(currHang)) MessageBox.Show("Lỗi");
                DialogResult= DialogResult.OK;
            }
            this.Close();
        }
    }
}
