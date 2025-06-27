using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    public class SanPham
    {
        private string ma;
        private string ten;
        private int namBaoHanh;
        private double gia;
        private int soLuong;
        private string danhMuc;
        public SanPham()
        {
            
        }

        public SanPham(string ma, string ten, int namBaoHanh, double gia, int soLuong, string danhMuc)
        {
            this.ma = ma;
            this.ten = ten;
            this.namBaoHanh = namBaoHanh;
            this.gia = gia;
            this.soLuong = soLuong;
            this.danhMuc = danhMuc;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamBaoHanh { get => namBaoHanh; set => namBaoHanh = value; }
        public double Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
    }
}
