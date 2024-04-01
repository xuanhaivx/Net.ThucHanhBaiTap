using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class BaiViDu

    {
        //viết hàm để sắp xếp dãy tăng dần
        public void ViDu()
        {
            var strSinhVien = new SinhVien();
            bool hopLe = false;
            do
            {
                Console.WriteLine("Bạn hãy nhập ID Sinh viên :");
                strSinhVien.IDSinhVien = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bạn hãy nhập Tên Sinh Viên :");
                strSinhVien.TenSinhVien = Console.ReadLine();
                Console.WriteLine("Bạn hãy nhập Giới Tính SinH Viên :");
                strSinhVien.GioiTinhSinhVien = Console.ReadLine();
                Console.WriteLine("Bạn hãy nhập Tuổi Sinh Viên :");
                strSinhVien.TuoiSinhVien = Convert.ToInt32(Console.ReadLine());
                if (strSinhVien.IDSinhVien <= 0)
                {
                    Console.WriteLine("Id Phải Là Số:");
                }
                else if (strSinhVien.TuoiSinhVien <= 0)
                {
                    Console.WriteLine("Tuổi SinH Viên Phải Là Số!");
                }
            } while (strSinhVien.IDSinhVien <= 0 || strSinhVien.TuoiSinhVien <= 0);




            Console.WriteLine(" ID SinH Viên Là : " + strSinhVien.IDSinhVien);
            Console.WriteLine(" Tên Sinh Viên : " + strSinhVien.TenSinhVien);
            Console.WriteLine(" Giới Tính SinH viên Là : " + strSinhVien.GioiTinhSinhVien);
            Console.WriteLine(" Tuổi Sinh Viên Là : " + strSinhVien.TuoiSinhVien);

        }
        public struct SinhVien
        {
            public int IDSinhVien { get; set; }
            public string TenSinhVien { get; set; }
            public String GioiTinhSinhVien { set; get; }
            public int TuoiSinhVien { set; get; }

            public SinhVien (int _idsinhvien,String _tensinhvien,String _gioitinhsinhvien, int _tuoisinhvien)
            {
                IDSinhVien = _idsinhvien;
                TenSinhVien = _tensinhvien;
                GioiTinhSinhVien = _gioitinhsinhvien;
                TuoiSinhVien= _tuoisinhvien;
            }
        }
        enum DonHang
        {
            DaDatHang = 1,
            GiaHang = 2
        }
    }
}
