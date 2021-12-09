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

namespace btnhom.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool  CheckText()
        {
            if (string.IsNullOrEmpty(this.txtPass.Text) || string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return false;
            }
            return true;
        }
        public NhanVien curr;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CheckText()) return;
            ToyStoreEntities db = new ToyStoreEntities();
            curr = db.NhanViens.Where(x => (x.userName == txtUser.Text && x.passWord == txtPass.Text)).FirstOrDefault();
            if(curr == null)
            {
                MessageBox.Show("Sai tên/mật khẩu");
                return;
            };
            DialogResult=DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
