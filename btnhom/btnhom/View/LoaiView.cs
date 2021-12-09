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
    public partial class LoaiView : Form
    {
        public bool isUpdate = false;
        public LoaiHang currLoai;
        public LoaiView(LoaiHang x)
        {
            InitializeComponent();
            if( x == null ) currLoai= new LoaiHang();
            else { isUpdate = true; currLoai = x; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoaiView_Load(object sender, EventArgs e)
        {
            List<LoaiHang> dsLoai = LoaiBL.GetAll();
            cbLoai.DataSource = dsLoai;
            cbLoai.DisplayMember = "name";
            cbLoai.ValueMember = "id";
            if (isUpdate)
            {
                txtNote.Text = currLoai.description;
                txtTen.Text = currLoai.name;
                cbLoai.SelectedValue= currLoai.id;
            }
        }
        private void GetData()
        {
            currLoai.name = txtTen.Text;
            currLoai.description = txtNote.Text;
            currLoai.idLH = (int)cbLoai.SelectedValue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetData();
            if (isUpdate)
            {
                LoaiBL.UpdateLoaiHang(currLoai, currLoai.id);
                DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                LoaiBL.AddLoaiHang(currLoai);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
