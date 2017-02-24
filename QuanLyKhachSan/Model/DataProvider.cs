using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhachSan.Model
{
    public class DataProvider
    {
        public List<Phong> DanhSachPhong { get; set; }

        public DataProvider()
        {
            DanhSachPhong = LayDanhSachPhong().ToList();
        }
        private IEnumerable<Phong> LayDanhSachPhong()
        {
            for (int i = 0; i < 10; i++)
            {
                var phong = new Phong
                {
                    ID=i+"",TenPhong = "Phòng "+i,LoaiPhong = i%3
                };
                yield return phong;
            }
        }
    }
}
