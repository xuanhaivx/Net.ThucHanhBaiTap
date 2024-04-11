using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Net.BaiTapThucHanh.Buoi4Bai2;
using static Net.BaiTapThucHanh.Buoi4Bai3Nhom;

namespace Net.BaiTapThucHanh
{
    internal class CheckInput
    {
        public bool ContainsNumber(string input)
        {
            if (input.Any(char.IsDigit))
            {
                Console.WriteLine("Không được chứa chữ số!");
                return true;
            }
            else
                return false;
        }
        public bool CheckContainSpecialChar(string input)
        {
            Regex specialCharRegex = new Regex(@"[~`!@#$%^&*()+=|\\{}':;,.<>?/""-]");
            if (specialCharRegex.IsMatch(input))
            {
                Console.WriteLine("Không được chứa kí tự đặc biệt!");
                return true;
            }
            else
                return false;
        }
        public bool CheckIsNullOrWhiteSpace(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Không được để trống hay chỉ chứa khoảng trắng!");
                return true;
            }
            else
                return false;
        }
        public bool CheckDateTime(string input)
        {
            if (DateTime.TryParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                DateTime now = DateTime.Now;
                TimeSpan interval = now - date;
                if (interval.Days > 0)
                    return true;
                else
                {
                    Console.WriteLine("Ngày phát hành hóa đơn không được lớn hơn thời gian hiện tại!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Định dạng ngày không hợp lệ!");
                return false;
            }
        }
        public bool CheckMoney(string input, out double money)
        {
            if (Double.TryParse(input, out money))
            {
                if (money <= 0)
                {
                    Console.WriteLine("Số tiền không được bằng 0 hoặc là số âm!");
                    return false;
                }
                else
                    return true;
            }
            else
            {
                Console.WriteLine("Số tiền không được quá lớn, không được là kí tự, không để trống hay chứa khoảng trắng!");
                return false;
            }
        }
    }
    internal class Buoi4Bai3Nhom : CheckInput
    {
        List<QuanLyHoaDon> QlHoaDon = new List<QuanLyHoaDon>();
        public struct QuanLyHoaDon
        {
            public string MaHoaDon { get; set; } // Mã hóa Đơn
            public DateTime NgayPhatHanhHoaDon { get; set; } // Ngày phát hành hóa đơn
            public double TongTienHoaDon { get; set; } // Tổng tiền hóa đơn
            public double SoTienConNoHoaDon { get; set; } // Số Tiền Còn Nợ
            public bool TrangThaiNo { get; set; } //Trạng Thái Nợ
            public string TenKhachHang { get; set; } // Tên Khách Hàng Hóa Đơn

            public QuanLyHoaDon(string maHoaDon, DateTime ngayPhatHanhHoaDon, double tongTienHoaDon, double soTienConNoHoaDon, bool trangThaiNo, string tenKhachHang)
            {
                MaHoaDon = maHoaDon;
                NgayPhatHanhHoaDon = ngayPhatHanhHoaDon;
                TongTienHoaDon = tongTienHoaDon;
                SoTienConNoHoaDon = soTienConNoHoaDon;
                TrangThaiNo = trangThaiNo;
                TenKhachHang = tenKhachHang;
            }

            public override string ToString()
            {
                return $"Mã Hóa Đơn: {MaHoaDon}\nNgày Phát Hành Hóa Đơn: {NgayPhatHanhHoaDon:dd/MM/yyyy}\nTổng Tiền Hóa Đơn: {TongTienHoaDon}\nSố Tiền Còn Nợ: {SoTienConNoHoaDon}\nTrạng Thái Nợ: {(TrangThaiNo ? "Còn nợ" : "Không nợ")}\nTên Khách Hàng: {TenKhachHang}";

            }
        }
        public void B4Bai3()
        {
            // Viết menu chương trình 
            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhập danh sách hóa đơn");
                Console.WriteLine("2. Xóa nợ cho hóa đơn");
                Console.WriteLine("3. Xuất danh sách hóa đơn");
                Console.WriteLine("4. Hiển thị hóa đơn còn nợ theo mốc");
                Console.WriteLine("5. Xuất hóa đơn ra file text");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn một chức năng: ");

                string nhap = Console.ReadLine();
                int chon;
                if (!Int32.TryParse(nhap, out chon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, mời nhập lại!");
                }
                else
                {
                    switch (chon)
                    {
                        case 1:
                            Console.Write("Nhập số lượng hóa đơn: ");
                            int n = Convert.ToInt32(Console.ReadLine());
                            NhapDanhSachHoaDon(n);
                            break;
                        case 2:
                            XoaNoHoaDon();
                            break;
                        case 3:
                            Console.Write("Nhập mã hóa đơn (để trống nếu muốn xuất tất cả): ");
                            string maHD = Console.ReadLine();
                            Console.Write("Trạng thái nợ (1: Còn nợ, 0: Không nợ, Khác: Tất cả): ");
                            string trangThai = Console.ReadLine();
                            bool? ttNo = trangThai == "1" ? true : trangThai == "0" ? false : (bool?)null;
                            XuatDanhSachHoaDon(maHD, ttNo);
                            break;
                        case 4:
                            Console.Write("Nhập số ngày (30, 60, 90): ");
                            int ngay = Convert.ToInt32(Console.ReadLine());
                            HoaDonConNoTheoMoc(ngay);
                            break;
                        case 5:
                            XuatHoaDonRaText();
                            break;
                        case 0:
                            Console.WriteLine("Thoát chương trình...");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
            } while (true);
        }

        public void NhapDanhSachHoaDon(int n) // Tham số n. Số lượng hóa đơn cần nhập n
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin hóa đơn thứ " + (i + 1));
                bool valid;
                // Nhập mã hóa đơn
                string maHoaDon;
                do
                {
                    Console.Write("Mã Hóa Đơn:");
                    maHoaDon = Console.ReadLine();
                    if (CheckContainSpecialChar(maHoaDon) || CheckIsNullOrWhiteSpace(maHoaDon))
                        valid = false;
                    else valid = true;
                } while (!valid);

                // Nhập ngày phát hành
                DateTime ngayPhatHanhHoaDon = new DateTime();
                do
                {
                    Console.Write("Thêm Ngày Phát Hành (dd/MM/yyyy):");
                    string ngayHopLe = Console.ReadLine();
                    if (CheckDateTime(ngayHopLe))
                    {
                        ngayPhatHanhHoaDon = DateTime.ParseExact(ngayHopLe, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                        valid = true;
                    }
                    else
                        valid = false;
                } while (!valid);

                // Nhập tổng tiền thanh toán
                double tongTienHoaDon;
                string tongTien;
                do
                {
                    Console.Write("Tổng Tiền Thanh Toán:");
                    tongTien = Console.ReadLine();
                    if (CheckMoney(tongTien, out tongTienHoaDon))
                        valid = true;
                    else valid = false;
                } while (!valid);

                // Nhập số tiền còn nợ
                double soTienConNoHoaDon;
                string tienNo;
                do
                {
                    Console.Write("Số Tiền Còn Nợ Hóa Đơn:");
                    tienNo = Console.ReadLine();
                    if (CheckMoney(tienNo, out soTienConNoHoaDon))
                        valid = true;
                    else valid = false;
                } while (!valid);

                // Cập nhật trạng thái nợ
                bool trangThaiNo = soTienConNoHoaDon > 0;

                // Nhập tên khách hàng
                string tenKhachHang;
                do
                {
                    Console.Write("Tên Khách Hàng:");
                    tenKhachHang = Console.ReadLine();
                    if (CheckContainSpecialChar(tenKhachHang) || CheckIsNullOrWhiteSpace(tenKhachHang) || ContainsNumber(tenKhachHang))
                        valid = false;
                    else valid = true;
                } while (!valid);

                QlHoaDon.Add(new QuanLyHoaDon(maHoaDon, ngayPhatHanhHoaDon, tongTienHoaDon, soTienConNoHoaDon, trangThaiNo, tenKhachHang));
            }
        }

        public void XoaNoHoaDon()
        {
            Console.WriteLine("Nhập mã hóa đơn muốn xóa nợ:");
            string maHoaDonXoaNo = Console.ReadLine();
            int index = QlHoaDon.FindIndex(hd => string.Equals(hd.MaHoaDon, maHoaDonXoaNo, StringComparison.OrdinalIgnoreCase));
            // sử dụng phương  thức findIndex của danh sách qlHoaDon.
            // sử dụng biến tạm thời đầu vào hd để xác định xem vị trí đầu tiên
            // của danh sách mã hóa đơn có giống với maHoaDonXoaNo hay không
            // Nếu không sẽ trả về giá trị là index = -1
            if (index != -1) // Nếu tìm thấy hóa đơn trong danh sách
            {
                // Kiểm tra xem vị trí của hóa đơn. Nếu index không bằng -1 thì vị trí của hóa đơn sẽ là index.
                var themHD = QlHoaDon[index]; // lưu thông tin hóa đơn vào biến themHD .
                                              // Khi này biến themHD sẽ là bản sao của đối tượng QuanLyHoaDon
                                              // tại vị trí index trong danh sách
                themHD.SoTienConNoHoaDon = 0; // cập nhật số tiền nợ của hóa đơn là 0
                themHD.TrangThaiNo = false; // cập nhật trạng thái nợ
                QlHoaDon[index] = themHD; // Gán lại hóa đơn vào vị trí index trong danh sách.
                Console.WriteLine("Đã xóa nợ cho hóa đơn có mã: " + maHoaDonXoaNo); // đưa ra thông báo xóa hóa đơn.
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn với mã đã nhập.");
            }
        }
        public void XuatDanhSachHoaDon(string maHoaDon = "", bool? trangThaiNo = null) // biến bool? có thể chứa true, false và null.
                                                                                       // Bool được khởi tạo là null (Không chứa gì cả)
        {
            IEnumerable<QuanLyHoaDon> danhSach = QlHoaDon; // Khởi tạo biến danhSach kiểu IEnumerable<QuanLyHoaDon>
                                                           // tham chiếu toàn bộ danh sách hóa đơn trong QLHoaDon
                                                           // Giúp duyệt qua các phân tử danhSach một cách tuần tự


            if (!string.IsNullOrWhiteSpace(maHoaDon)) // Kiểm tra xem hóa đơn đã nhập phần tử hay chưa, hoặc nhập tất cả đều là trống.
            {
                danhSach = danhSach.Where(hd => hd.MaHoaDon.Equals(maHoaDon, StringComparison.OrdinalIgnoreCase)); // sử dụng where để lọc xem mã hóa đơn có khắp với
                                                                                                                   // maHoaDon (lọc cả chữ hoa và chữ thường) rồi gán vào danhSach
            }
            if (trangThaiNo.HasValue) // Kiểm tra trạng thái nợ không phải null. Nếu nếu có tiếp tục lọc theo trạng thái nợ
                                      // trangThaiNo.Hasvalue == Null thì trương trình sẽ không chạy chỗ này
            {
                danhSach = danhSach.Where(hd => hd.TrangThaiNo == trangThaiNo.Value); //sử dụng phương thức where lọc các giá trị trạng thái nợ.
                                                                                      // tạo truy vấn mà những hóa đơn hd khớp với giá trị trạng thái nợ
                                                                                      // Trạng thái nợ phù hợp sẽ được gán vào danhSach phù hợp trạng thái.                                                                                     //trạng thái nợ.
            }

            foreach (var hd in danhSach)
            {
                Console.WriteLine(hd.ToString());
                Console.WriteLine("-------------");
            }
        }
        public void HoaDonConNoTheoMoc(int ngay) // truyền tham số ngay kiểu int để biểu thị số ngày hóa đơn còn nợ.
        {
            var danhSachConNo = QlHoaDon.Where(hd => (DateTime.Now - hd.NgayPhatHanhHoaDon).Days >= ngay && hd.TrangThaiNo == true);
            // sử dụng where để lọc hóa đơn còn nợ và ngày được tính bằng ngày hiện tại trừ đi ngày phát hành hóa đơn
            // Nếu ngày phát hành hóa đơn phải lớn hơn hoặc bằng ngày nhập vào.. 

            Console.WriteLine($"Danh sách hóa đơn còn nợ qua {ngay} ngày:");
            foreach (var hd in danhSachConNo)  // Duyệt qua mỗi hóa đơn trong danh sách còn nợ
                                               // chuyển các thông tin hóa đơn còn nợ thành chuỗi và in ra màn hình.
            {
                Console.WriteLine(hd.ToString());
            }
        }

        public void XuatHoaDonRaText()
        {
            string filePath = @"D:\HoaDonKhongConNo.txt"; // Khai báo biến đường dẫn file sẽ in vào. Nếu file có thì sẽ được ghi đè lên.
            var danhSachKhongNo = QlHoaDon.Where(hd => hd.TrangThaiNo == false); // lọc các danh sách không còn nợ trong danh sách QLhoaDon
                                                                                 // Sau đó lưu trữ vào trong danhSachKhongNo

            using (StreamWriter sw = new StreamWriter(filePath)) // Tạo đối tượng stream... để ghi đè lên file với được dẫn được khai báo (filePath)
                                                                 // Duyệt qua danhSachKhongNo rồi ghi lên file.

            {
                foreach (var hd in danhSachKhongNo)
                {
                    sw.WriteLine(hd.ToString());
                    sw.WriteLine("-----------------------");
                }
            }

            Console.WriteLine("Đã xuất hóa đơn không còn nợ ra file text.");
        }
    }


}
