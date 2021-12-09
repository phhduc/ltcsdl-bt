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
    public partial class NhanVienView : UserControl
    {
        private List<NhanVien> ls;
        public NhanVienView()
        {
            ls = NhanVienBL.GetAll();
            InitializeComponent();
        }
        private void LoadView(List<NhanVien> ds)
        {
            lvNhanVien.Items.Clear();
            foreach (var nv in ds)
            {
                ListViewItem item = lvNhanVien.Items.Add(nv.id.ToString());
                item.SubItems.Add(nv.name);
                item.SubItems.Add(nv.userName);
                item.SubItems.Add(nv.Sdt.ToString());
                item.SubItems.Add(nv.DiaChi.ToString());
                item.SubItems.Add(nv.active ? "còn làm" : "đã nghỉ");
                item.SubItems.Add(nv.VaiTro ? "Admin" : "Nhân viên");
            }
        }
        private void NhanVienView_Load(object sender, EventArgs e)
        {
            LoadView(ls);
        }
    }
}
