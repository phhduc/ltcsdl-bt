namespace btnhom.View
{
    partial class ProductView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvLoai = new System.Windows.Forms.TreeView();
            this.lvHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvLoai);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 496);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại";
            // 
            // tvLoai
            // 
            this.tvLoai.ContextMenuStrip = this.contextMenuStrip1;
            this.tvLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvLoai.Location = new System.Drawing.Point(3, 21);
            this.tvLoai.Name = "tvLoai";
            this.tvLoai.Size = new System.Drawing.Size(181, 472);
            this.tvLoai.TabIndex = 0;
            this.tvLoai.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLoai_AfterSelect);
            this.tvLoai.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLoai_NodeMouseDoubleClick);
            // 
            // lvHang
            // 
            this.lvHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvHang.FullRowSelect = true;
            this.lvHang.GridLines = true;
            this.lvHang.HideSelection = false;
            this.lvHang.Location = new System.Drawing.Point(207, 56);
            this.lvHang.MultiSelect = false;
            this.lvHang.Name = "lvHang";
            this.lvHang.Size = new System.Drawing.Size(520, 451);
            this.lvHang.TabIndex = 2;
            this.lvHang.UseCompatibleStateImageBehavior = false;
            this.lvHang.View = System.Windows.Forms.View.Details;
            this.lvHang.SelectedIndexChanged += new System.EventHandler(this.lvHang_SelectedIndexChanged);
            this.lvHang.DoubleClick += new System.EventHandler(this.lvHang_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá nhập";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá bán";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Độ tuổi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Xuất xứ";
            this.columnHeader7.Width = 57;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(208, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "tìm kiếm...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(267, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtAdd
            // 
            this.txtAdd.CheckedState.Parent = this.txtAdd;
            this.txtAdd.CustomImages.Parent = this.txtAdd;
            this.txtAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdd.ForeColor = System.Drawing.Color.White;
            this.txtAdd.HoverState.Parent = this.txtAdd;
            this.txtAdd.Location = new System.Drawing.Point(692, 18);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ShadowDecoration.Parent = this.txtAdd;
            this.txtAdd.Size = new System.Drawing.Size(35, 32);
            this.txtAdd.TabIndex = 4;
            this.txtAdd.Text = "+";
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.CheckedState.Parent = this.btnDel;
            this.btnDel.CustomImages.Parent = this.btnDel;
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.Parent = this.btnDel;
            this.btnDel.Location = new System.Drawing.Point(651, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.ShadowDecoration.Parent = this.btnDel;
            this.btnDel.Size = new System.Drawing.Size(35, 32);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "-";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvHang);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(745, 531);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvLoai;
        private System.Windows.Forms.ListView lvHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button txtAdd;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
