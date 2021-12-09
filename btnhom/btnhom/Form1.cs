using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btnhom.Data;
using btnhom.Model;
using btnhom.View;

namespace btnhom
{
    public partial class Form1 : Form
    {
        NhanVien _currNv;
        public Form1()
        {
            var f = new Login();
            f.ShowDialog(this);
            if(f.DialogResult == DialogResult.OK)
            {
                _currNv = f.curr;
            }else Application.Exit();
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Refresh();
            pnView.Controls.Add(new NhanVienView());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnView.Controls.Clear();
            pnView.Refresh();
            pnView.Controls.Add(new ProductView(_currNv.VaiTro));
        }
    }
}
