using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class NhanVienBanThoiGian :NhanVien
    {
        public decimal LuongBanThoiGian { get; set; }
        public int GioLamViec { get; set; }

        public NhanVienBanThoiGian(string tenNhanVien, int idNhanVien, decimal luongBanThoiGian, int gioLamViec) : base(tenNhanVien, idNhanVien)
        {
            LuongBanThoiGian = luongBanThoiGian;
            GioLamViec = gioLamViec;
        }

        public override decimal CalculateSalary()
        {
            return LuongBanThoiGian * GioLamViec;
        }
    }
}
