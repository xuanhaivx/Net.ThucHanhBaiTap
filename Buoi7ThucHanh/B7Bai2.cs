using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buoi7ThucHanh
{
    internal class B7Bai2
    {   static List<NhanVien> nhanViens = new List<NhanVien>();
        public static void Main()
        {
            
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChương trình quản lý nhân viên:");
                Console.WriteLine("1. Nhập vào N nhân viên.");
                Console.WriteLine("2. Tính toán lương cho mỗi loại nhân viên.");
                Console.WriteLine("3. Thoát.");

                Console.Write("Nhập lựa chọn của bạn: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        NhapNhanVien();
                        break;
                    case 2:
                        TinhLuong();
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            }
        }
        static void NhapNhanVien()
        {
            Console.WriteLine("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nChọn loại nhân viên:");
                Console.WriteLine("1. Nhân viên toàn thời gian");
                Console.WriteLine("2. Nhân viên bán thời gian");
                Console.WriteLine("3. Nhân viên thực tập");
                Console.Write("Lựa chọn của bạn: ");
                int loaiNhanVien = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập tên: ");
                string tennv = Console.ReadLine();
                Console.Write("Nhập ID: ");
                int idnv = Convert.ToInt32(Console.ReadLine());

                switch (loaiNhanVien)
                {
                    case 1:
                        Console.Write("Nhập lương hàng tháng: ");
                        decimal luongThang = decimal.Parse(Console.ReadLine());
                        nhanViens.Add(new NhanVienToanThoiGian(tennv,idnv,luongThang));
                        break;
                    case 2:
                        Console.Write("Nhập tỉ lệ lương theo giờ: ");
                        decimal luongGio = decimal.Parse(Console.ReadLine());
                        Console.Write("Nhập số giờ làm việc: ");
                        int gioLV = int.Parse(Console.ReadLine());
                        nhanViens.Add(new NhanVienBanThoiGian(tennv, idnv, luongGio, gioLV));
                        break;
                    case 3:
                        Console.Write("Nhập khoản trợ cấp: ");
                        decimal luongTT = decimal.Parse(Console.ReadLine());
                        nhanViens.Add(new NhanVienThucTap(tennv, idnv, luongTT));
                        break;
                    default:
                        Console.WriteLine("Loại nhân viên không hợp lệ.");
                        i--; // Yêu cầu người dùng nhập lại nếu loại nhân viên không hợp lệ
                        break;
                }
            }
        }
        static void TinhLuong()
        {
            foreach (var nhanVien in nhanViens)
            {
                Console.WriteLine($"Nhân viên {nhanVien.TenNhanVien} (ID: {nhanVien.IDNhanVien}) có lương: {nhanVien.CalculateSalary()}");
            }
        }
    }
}
