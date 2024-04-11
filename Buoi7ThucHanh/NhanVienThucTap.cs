using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class NhanVienThucTap:NhanVien
    {
        public decimal LuongThucTap { get; set; }

        public NhanVienThucTap(string tenNhanVien, int idNhanVien, decimal luongThucTap) : base(tenNhanVien, idNhanVien)
        {
            LuongThucTap = luongThucTap;
        }

        public override decimal CalculateSalary()
        {
            return LuongThucTap; // Lương của Nhân Viên Thực Tập có thể là một khoản trợ cấp cố định
        }
    }
}
