using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu
{
    public class SanPhamService
    {
        List<SanPham> lstSanPham;
        public SanPhamService()
        {
            lstSanPham = new List<SanPham>()
            {
                new SanPham("1", "x", 1, 1, 1,"s"),
                new SanPham("2", "x", 1, 1, 1,"s"),
                new SanPham("3", "x", 1, 1, 1,"s"),
            };
        }
        public bool AddSanPham(SanPham sanPham)
        {
            if (Validate(sanPham.Ma))
            {
                lstSanPham.Add(sanPham);
                return true;
            }
            return false;
        }
        public bool Validate(string maSanPham)
        {
            if (string.IsNullOrEmpty(maSanPham))
            {
                return false;
            }
            else if (lstSanPham.FirstOrDefault(x => x.Ma == maSanPham) != null)
            {
                return false;
            }
            return true;
        }
        public bool Delete(string maSanPham)
        {
            SanPham? sanPhamRemove = lstSanPham.FirstOrDefault(x => x.Ma == maSanPham);
            if (sanPhamRemove == null)
            {
                return false;
            }
            lstSanPham.Remove(sanPhamRemove);
            return true;
        }
    }
}
