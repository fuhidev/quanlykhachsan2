using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Server;

namespace QuanLyKhachSan.Model
{
    public class Phong
    {
        public const int PHONG_TRONG = 0;
        public const int DA_THUE = 1;
        public const int DANG_GIAO_DICH = 2;
        public String ID { get; set; }
        public String TenPhong { get; set; }
        public int LoaiPhong{ get; set; }
    }
}
