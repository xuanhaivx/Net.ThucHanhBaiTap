using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class NhanVienToanThoiGian :NhanVien
    {
        public decimal LuongThang { get; set; }

        public NhanVienToanThoiGian(string tenNhanVien, int idNhanVien, decimal luongThang) : base(tenNhanVien, idNhanVien)
        {
            LuongThang = luongThang;
        }

        public override decimal CalculateSalary()
        {
            return LuongThang;
        }
    }
}
