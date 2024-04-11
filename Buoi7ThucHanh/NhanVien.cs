using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    public abstract class NhanVien
    {
        public string TenNhanVien { get; set; }
        public int IDNhanVien { get; set; }

        public NhanVien(string tenNhanVien, int idNhanVien)
        {
           TenNhanVien = tenNhanVien;
            IDNhanVien = idNhanVien;
        }

        // Phương thức abstract để tính lương, phải được implement trong các class con
        public abstract decimal CalculateSalary();
    }
}
