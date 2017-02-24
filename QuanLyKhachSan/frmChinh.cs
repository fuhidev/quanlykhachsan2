using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhachSan.Const;
using QuanLyKhachSan.Model;

namespace QuanLyKhachSan
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            KhoiTaoPhong();

            this.btnChonLoaiPhong_Click(btnTatCa,null);
        }

        private DataProvider provider = new DataProvider();
        private void KhoiTaoPhong()
        {
            
            //lay cai danh sach phong
            
           
            updateList(provider.DanhSachPhong);
            
        }

        private void updateList(IEnumerable<Phong> danhSach)
        {
            //xoa cai tao mac dinh ngoai kia
            listView.Items.Clear();
            foreach (var phong in danhSach)
            {
                //tao listviewItem de them vao listview
                var lvi = new ListViewItem
                {
                    Text = phong.TenPhong,
                    ImageIndex = phong.LoaiPhong,
                    Tag = phong
                };

                listView.Items.Add(lvi);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //kiem tra, tung loai phong se bat chuc nang tuong ung
            var index = listView.SelectedItems;
            if (index.Count == 0)
                return;
            var item = index[0].Tag as Phong;
            switch (item.LoaiPhong)
            {
                case Phong.DANG_GIAO_DICH:
                     contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = true;
                    break;
                case Phong.DA_THUE:
                    contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
                    break;
                case Phong.PHONG_TRONG:
                     contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                    break;
            }
        }

        private Button preClick;
        private Button currentClick;

        private void ChangeMouseClick()
        {
            if (preClick != null)
            {
                preClick.ForeColor = ColorConst.BUTTON_FORE_LEAVE;
                preClick.BackColor = ColorConst.BUTTON_BACKGROUND_LEAVE;
            }
            if (currentClick != null)
            {
                currentClick.ForeColor = ColorConst.BUTTON_FORE_CLICK;
                currentClick.BackColor = ColorConst.BUTTON_BACKGROUND_CLICK;
            }
        }

        private void btnChonLoaiPhong_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            

            this.preClick = this.currentClick;
            this.currentClick = sender as Button;
            IEnumerable<Phong> list = null;
            if (button.Equals(btnTatCa))
            {
                list = provider.DanhSachPhong;
            }
            else
            {
                int loai = -1;

                if (button.Equals(btnPhongConTrong))
                {
                    loai = Phong.PHONG_TRONG;
                }
                else if (button.Equals(btnPhongDaThue))
                {
                    loai = Phong.DA_THUE;
                }
                else if (button.Equals(btnPhongDangGiaoDich))
                {
                    loai = Phong.DANG_GIAO_DICH;
                }
                list = from p in provider.DanhSachPhong
                       where p.LoaiPhong == loai
                       select p;
            }
            if (list == null) return;
            this.updateList(list);
            this.ChangeMouseClick();
        }
    }
}
