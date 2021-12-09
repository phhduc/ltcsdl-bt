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

namespace btnhom.View
{
    public partial class ProductView : UserControl
    {
        private bool isAdmin;
        public ProductView(bool isAdmin)
        {
            this.isAdmin = isAdmin;
            lsHang=MatHangBL.GetAll();
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            LoadTree();
            LoadView(lsHang);
            if(isAdmin) contextMenuStrip1.Enabled = true;
        }
        private TreeNode MakeNode(LoaiHang x)
        {
            if (x==null) return null;
            TreeNode node = new TreeNode();
            node.Text = x.name;
            node.Tag = x;
            List<LoaiHang> lsCon = LoaiBL.GetLoaiHangCon(x.id);
            if (lsCon == null) return node;
            foreach(var i in lsCon)
            {
                if(i == null) continue;
                node.Nodes.Add(MakeNode(i));
            }
            return node;
        }
        private void LoadTree()
        {
            tvLoai.Nodes.Clear();
            tvLoai.Nodes.Add("Tất cả");
            List<LoaiHang> bigestLoai = LoaiBL.GetBigestLoaiHangs();
            foreach(var i in bigestLoai)
                tvLoai.Nodes[0].Nodes.Add(MakeNode(i));
            tvLoai.ExpandAll();
            tvLoai.SelectedNode = tvLoai.Nodes[0];
        }
        private List<Data.MatHang> lsHang;

        private void LoadView(List<Data.MatHang> dsHang)
        {
            lvHang.Items.Clear();
            foreach(var x in dsHang)
            {
                ListViewItem item = lvHang.Items.Add(x.id.ToString());
                item.SubItems.Add(x.name);
                item.SubItems.Add(x.SoLuongTon.ToString());
                item.SubItems.Add(x.GiaNhap.ToString());
                item.SubItems.Add(x.GiaBan.ToString());
                item.SubItems.Add(x.DoTuoi);
                item.SubItems.Add(x.XuatXu);
            }
        }

        private void tvLoai_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Tất cả")
            {
                lsHang = MatHangBL.GetAll();
                LoadView(MatHangBL.GetAll());
            }
            if (e.Node.Tag != null)
            {
                lsHang = (LoaiBL.GetAllMatHangOfLoaiHang(((LoaiHang)e.Node.Tag).id));
            }
            LoadView(lsHang);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string s = txtSearch.Text;
            
            var tmp = lsHang.FindAll(x => x.XuatXu.Contains(s) || x.name.Contains(s)).ToList();
            tmp.Sort((x, y) => x.DoTuoi.CompareTo(y.DoTuoi));
            LoadView(tmp);
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            var f = new MatHangView(isAdmin, null);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm mới thành công");
                MatHang x = f.currHang;
                lsHang = LoaiBL.GetAllMatHangOfLoaiHang(x.idLH!=null?x.idLH.Value:0);
                lsHang.Sort((xx, y) => xx.name.CompareTo(y.name));
                LoadView(lsHang);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvHang.SelectedItems.Count == 0) return;
            if (MatHangBL.Remove(int.Parse(lvHang.SelectedItems[0].Text)))
            {
                MessageBox.Show("Xóa thành công");
                lvHang.Items.Remove(lvHang.SelectedItems[0]);
            } else { MessageBox.Show("Lỗi"); }
        }

        private void lvHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvHang_DoubleClick(object sender, EventArgs e)
        {
            if (lvHang.SelectedItems.Count == 0) return;
            MatHang x = MatHangBL.FindById(int.Parse(lvHang.SelectedItems[0].Text));
            var f = new MatHangView(isAdmin, x);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("update");
                var a = f.currHang;
                lsHang = LoaiBL.GetAllMatHangOfLoaiHang(a.idLH.HasValue ? a.idLH.Value : 0);
                lsHang.Sort((b,c) => b.name.CompareTo(c.name));
                LoadView(lsHang);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new LoaiView(null);
            f.ShowDialog();
            if(f.DialogResult == DialogResult.OK){
                LoadTree();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvLoai.Nodes.Remove(tvLoai.SelectedNode);
        }

        private void tvLoai_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var f = new LoaiView((LoaiHang)e.Node.Tag);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                LoadTree();
            }
        }
    }
}
