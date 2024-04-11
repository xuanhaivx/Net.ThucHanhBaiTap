using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi5Bai1
    {
        List<QuanLyNhanVien> QLNhanVien = new List<QuanLyNhanVien>();
        public struct QuanLyNhanVien
        {
            public string MaNhanVien { get; set; }
            public string HoNhanVien { get; set; }
            public string TenNhanhVien { get; set; }
            public DateTime NgaySinhNhanVien { get; set; }
            public DateTime NgayVaoLam { get; set; }
            public QuanLyNhanVien(string maNhanVien, string hoNhanVien, string tenNhanVien, DateTime ngaySinhNhanVien, DateTime ngayVaoLam)
            {
                MaNhanVien = maNhanVien;
                HoNhanVien = hoNhanVien;
                TenNhanhVien = tenNhanVien;
                NgaySinhNhanVien = ngaySinhNhanVien;
                NgayVaoLam = ngayVaoLam;
            }
            public override string ToString()
            {
                return $"Mã Nhân Viên : {MaNhanVien}\n Họ Tên Nhân Viên :{HoNhanVien} {TenNhanhVien}\n Ngày Sinh Nhân Viên :{NgaySinhNhanVien}\n Ngày Vào Làm : {NgayVaoLam}";
            }


        }
        public void MenuB5B1()
        {
            while (true)
            {
                Console.WriteLine("\nMenu!");
                Console.WriteLine("Nhập 1 - Nhập Danh Sách Nhân Viên");
                Console.WriteLine("Nhập 2 - Xem danh sách nhân viên đã nhập!");
                Console.WriteLine("Nhập 3 - Sắp xếp Danh Sách Nhân Viên Theo Ngày!");
                Console.WriteLine("Nhâp 4 - Xem nhân Viên Làm Việc Trên 5 Năm!");
                Console.WriteLine("Nhập 5 - Thoát Chương Trình");
                try
                {
                    int chon = Convert.ToInt32(Console.ReadLine());

                    switch (chon)
                    {
                        case 1:
                            Console.WriteLine("Số lượng nhân viên bạn muốn nhập");
                            int slNhanVien = Convert.ToInt32(Console.ReadLine());
                            NhapNhanVien(slNhanVien);
                            break;

                        case 2:
                            HienThiNhanVien();
                            break;
                        case 3:
                            Console.WriteLine("Sắp Xếp Nhân Viên Theo Ngày Sinh : 1- Tăng, 2- Giảm");
                            
                            int thuTu = Convert.ToInt32(Console.ReadLine());
                            SapXepNhanVien(thuTu);
                            
                            break;
                        case 4:
                            NhanVien5nam();
                            break;
                        case 5:
                            Console.WriteLine("Thoát chương trình...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Số bạn nhập không đúng");
                            break;
                    }
                }
                catch (FormatException) { Console.WriteLine("Vui lòng nhập số vào!"); }
            }

        }
        public bool CheckLoiDuLieu(string maNhanhVien, string hoNhanVien, string tenNhanVien, DateTime ngaySinhNhanVien, DateTime ngayVaoLam)
        {
            if (string.IsNullOrWhiteSpace(hoNhanVien))
            {
                Console.WriteLine("Họ Nhân Viên Không Được Để Trống! ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(tenNhanVien))
            {
                Console.WriteLine("Tên Nhân Viên Không Được Để Trống! ");
                return false;
            }
            if (string.IsNullOrWhiteSpace(maNhanhVien))
            {
                Console.WriteLine("Mã Nhân Viên Không Được Để Trống! ");
                return false;
            }
            if (DateTime.Now < ngaySinhNhanVien)
            {
                Console.WriteLine("Bạn đã nhập ngày sinh nhân viên ở Tương Tại. Vui Lòng nhập lại ");
                return false;
            }
            if (DateTime.Now < ngayVaoLam)
            {
                Console.WriteLine("Bạn đã nhập ngày Vào Làm nhân viên ở Tương Tại. Vui Lòng nhập lại ");
                return false;
            }

            if (tenNhanVien.Length > 1000 || maNhanhVien.Length > 1000 || hoNhanVien.Length > 1000)
            {
                Console.WriteLine("Dữ liệu nhập quá dài. Vui lòng kiểm tra lại ");
                return false;
            }
            if (maNhanhVien.StartsWith(" ") || tenNhanVien.StartsWith(" ") || hoNhanVien.StartsWith(" "))
            {
                Console.WriteLine("Không thể nhập khoảng trắng ở đầu tiên.");
                return false;
            }

            if (!Regex.IsMatch(maNhanhVien, "^^[\\p{L}\\p{N}\\s]+$"))
            {
                Console.WriteLine("Mã nhân viên chỉ có thể chứa chữ cái và số ");
                return false;
            }
            if (!Regex.IsMatch(hoNhanVien, "^[\\p{L}\\s]+$"))
            {
                Console.WriteLine("Họ nhân viên chỉ có thể chứ chữ cái ");
                return false;
            }
            if (!Regex.IsMatch(tenNhanVien, "^[\\p{L}\\s]+$"))
            {
                Console.WriteLine("Tên nhân viên chỉ có thể chứ chữ cái");
                return false;
            }
            if (ngaySinhNhanVien.AddYears(18) > ngayVaoLam)
            {
                Console.WriteLine("Nhân viên vào làm chưa đủ 18 tuổi. Vui lòng kiểm tra lại");
                return false;
            }


            return true;
        }
        public void NhapNhanVien(int slNhanVien)
        {
            for (int i = 0; i < slNhanVien; i++)
            {
                Console.WriteLine("Nhập Mã Nhân viên");
                string maNhanVien = Console.ReadLine();
                Console.WriteLine("Nhập Họ Nhân viên");
                string hoNhanVien = Console.ReadLine();
                Console.WriteLine("Nhập Tên Nhân viên");
                string tenNhanVien = Console.ReadLine();
                DateTime ngaySinhNhanVien;
                DateTime ngayVaoLam;
                bool checkNgaySinh;
                bool checkNgayVaolam;
                do
                {
                    Console.WriteLine("Nhập Ngày Sinh Nhân Viên (Ngày/ Tháng/ năm)");
                    checkNgaySinh = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ngaySinhNhanVien);
                    if (!checkNgaySinh)
                    {
                        Console.WriteLine("ngày Sinh Nhân Viên Bị Lỗi. Vui Lòng Nhập Lại");
                    }
                } while (!checkNgaySinh);
                do
                {
                    Console.WriteLine("Nhập Ngày Vào Làm (Ngày/ Tháng/ năm)");
                    checkNgayVaolam = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ngayVaoLam);
                    if (!checkNgayVaolam)
                    {
                        Console.WriteLine("ngày Sinh Nhân Viên Bị Lỗi. Vui Lòng Nhập Lại");
                    }
                } while (!checkNgayVaolam);
                if (CheckLoiDuLieu(maNhanVien, hoNhanVien, tenNhanVien, ngaySinhNhanVien, ngayVaoLam))
                {
                    QLNhanVien.Add(new QuanLyNhanVien(maNhanVien, hoNhanVien, tenNhanVien, ngaySinhNhanVien, ngayVaoLam));
                    Console.WriteLine($"Nhân Viên Thứ {i + 1} thêm vào thành công! ");
                }
            }
        }
        public void HienThiNhanVien()
        {
            foreach (var nv in QLNhanVien)
            {
                Console.WriteLine($"Mã Nhân Viên : {nv.MaNhanVien}.\n Tên Nhân Viên : {nv.HoNhanVien} {nv.TenNhanhVien}." +
                    $"\n Ngày Sinh Nhân Viên : {nv.NgaySinhNhanVien.ToString("dd/MM/yyyy")}.\n Ngày Vào Làm : {nv.NgayVaoLam.ToString("dd/MM/yyyy")}");
                Console.WriteLine("-------------");
            }
        }
        public void SapXepNhanVien(int thuTu)
        {
            if (thuTu == 1) { 
            var xepNgayTang = QLNhanVien.OrderBy(d => d.NgaySinhNhanVien).ToList();
            foreach (var d in xepNgayTang)
            {
                Console.WriteLine(d.ToString());
            }
            }else if (thuTu==2) {
                var xepNgayTang = QLNhanVien.OrderByDescending(d => d.NgaySinhNhanVien).ToList();
                foreach (var d in xepNgayTang)
                {
                    Console.WriteLine(d.ToString());
                }

            }
            else
            {
                Console.WriteLine("bạn chọn không đúng");
            }
        }
        public void NhanVien5nam()
        {
            // Lấy ngày hiện tại
            DateTime now = DateTime.Now;

            // Lọc ra những nhân viên có số năm làm việc từ ngày vào làm đến hiện tại lớn hơn hoặc bằng 5
            var nhanVien5Nam = QLNhanVien.Where(nv => (now - nv.NgayVaoLam).TotalDays / 365 >= 5).ToList();

            // Kiểm tra xem có nhân viên nào thoả mãn điều kiện không
            if (nhanVien5Nam.Count > 0)
            {
                Console.WriteLine("Danh sách nhân viên làm việc hơn 5 năm:");
                foreach (var nv in nhanVien5Nam)
                {
                    Console.WriteLine(nv.ToString());
                    Console.WriteLine("-------------");
                }
            }
            else
            {
                Console.WriteLine("Không có nhân viên nào làm việc hơn 5 năm.");
            }
        }
    }
}
