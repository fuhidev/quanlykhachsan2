namespace QuanLyKhachSan
{
    partial class frmChinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Phòng 1", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Phòng 2", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Phòng 3", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.pnTrai = new System.Windows.Forms.Panel();
            this.btnPhongDangGiaoDich = new System.Windows.Forms.Button();
            this.btnPhongDaThue = new System.Windows.Forms.Button();
            this.btnPhongConTrong = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.pnTren = new System.Windows.Forms.Panel();
            this.pnGiua = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tangSmall = new System.Windows.Forms.ImageList(this.components);
            this.tangLarge = new System.Windows.Forms.ImageList(this.components);
            this.btnTatCa = new System.Windows.Forms.Button();
            this.pnTrai.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnGiua.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTrai
            // 
            this.pnTrai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.pnTrai.Controls.Add(this.btnTatCa);
            this.pnTrai.Controls.Add(this.btnPhongDangGiaoDich);
            this.pnTrai.Controls.Add(this.btnPhongDaThue);
            this.pnTrai.Controls.Add(this.btnPhongConTrong);
            this.pnTrai.Controls.Add(this.panel1);
            this.pnTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTrai.Location = new System.Drawing.Point(0, 0);
            this.pnTrai.Name = "pnTrai";
            this.pnTrai.Size = new System.Drawing.Size(172, 427);
            this.pnTrai.TabIndex = 0;
            // 
            // btnPhongDangGiaoDich
            // 
            this.btnPhongDangGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongDangGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongDangGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongDangGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPhongDangGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnPhongDangGiaoDich.Location = new System.Drawing.Point(0, 140);
            this.btnPhongDangGiaoDich.Name = "btnPhongDangGiaoDich";
            this.btnPhongDangGiaoDich.Size = new System.Drawing.Size(172, 64);
            this.btnPhongDangGiaoDich.TabIndex = 3;
            this.btnPhongDangGiaoDich.Text = "Phòng đang giao dịch";
            this.btnPhongDangGiaoDich.UseVisualStyleBackColor = true;
            this.btnPhongDangGiaoDich.Click += new System.EventHandler(this.btnChonLoaiPhong_Click);
            // 
            // btnPhongDaThue
            // 
            this.btnPhongDaThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongDaThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongDaThue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongDaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPhongDaThue.ForeColor = System.Drawing.Color.White;
            this.btnPhongDaThue.Location = new System.Drawing.Point(0, 94);
            this.btnPhongDaThue.Name = "btnPhongDaThue";
            this.btnPhongDaThue.Size = new System.Drawing.Size(172, 46);
            this.btnPhongDaThue.TabIndex = 2;
            this.btnPhongDaThue.Text = "Phòng đã thuê";
            this.btnPhongDaThue.UseVisualStyleBackColor = true;
            this.btnPhongDaThue.Click += new System.EventHandler(this.btnChonLoaiPhong_Click);
            // 
            // btnPhongConTrong
            // 
            this.btnPhongConTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongConTrong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhongConTrong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPhongConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPhongConTrong.ForeColor = System.Drawing.Color.White;
            this.btnPhongConTrong.ImageIndex = 0;
            this.btnPhongConTrong.Location = new System.Drawing.Point(0, 48);
            this.btnPhongConTrong.Name = "btnPhongConTrong";
            this.btnPhongConTrong.Size = new System.Drawing.Size(172, 46);
            this.btnPhongConTrong.TabIndex = 1;
            this.btnPhongConTrong.Text = "Phòng còn trống";
            this.btnPhongConTrong.UseVisualStyleBackColor = true;
            this.btnPhongConTrong.Click += new System.EventHandler(this.btnChonLoaiPhong_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.lbNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 48);
            this.panel1.TabIndex = 0;
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.ForeColor = System.Drawing.Color.White;
            this.lbNhanVien.Location = new System.Drawing.Point(43, 14);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(83, 20);
            this.lbNhanVien.TabIndex = 0;
            this.lbNhanVien.Text = "Nhân Viên";
            // 
            // pnTren
            // 
            this.pnTren.BackColor = System.Drawing.Color.White;
            this.pnTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTren.Location = new System.Drawing.Point(172, 0);
            this.pnTren.Name = "pnTren";
            this.pnTren.Size = new System.Drawing.Size(546, 51);
            this.pnTren.TabIndex = 1;
            // 
            // pnGiua
            // 
            this.pnGiua.Controls.Add(this.listView);
            this.pnGiua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGiua.Location = new System.Drawing.Point(172, 51);
            this.pnGiua.Name = "pnGiua";
            this.pnGiua.Size = new System.Drawing.Size(546, 376);
            this.pnGiua.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.ContextMenuStrip = this.contextMenuStrip1;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView.LargeImageList = this.imageList1;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(546, 376);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtPhòngToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "conphong.png");
            this.imageList1.Images.SetKeyName(1, "dangthue.png");
            this.imageList1.Images.SetKeyName(2, "hetphong.png");
            // 
            // tangSmall
            // 
            this.tangSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tangSmall.ImageStream")));
            this.tangSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.tangSmall.Images.SetKeyName(0, "tang1.png");
            this.tangSmall.Images.SetKeyName(1, "tang2.png");
            this.tangSmall.Images.SetKeyName(2, "tang3.png");
            // 
            // tangLarge
            // 
            this.tangLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.tangLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.tangLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.White;
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTatCa.ForeColor = System.Drawing.Color.Black;
            this.btnTatCa.Location = new System.Drawing.Point(0, 204);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(172, 46);
            this.btnTatCa.TabIndex = 4;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnChonLoaiPhong_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 427);
            this.Controls.Add(this.pnGiua);
            this.Controls.Add(this.pnTren);
            this.Controls.Add(this.pnTrai);
            this.Name = "frmChinh";
            this.Text = "Quản lý khách sạn";
            this.pnTrai.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnGiua.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTrai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTren;
        private System.Windows.Forms.Panel pnGiua;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnPhongDangGiaoDich;
        private System.Windows.Forms.Button btnPhongDaThue;
        private System.Windows.Forms.Button btnPhongConTrong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.ImageList tangSmall;
        private System.Windows.Forms.ImageList tangLarge;
        private System.Windows.Forms.Button btnTatCa;
    }
}

