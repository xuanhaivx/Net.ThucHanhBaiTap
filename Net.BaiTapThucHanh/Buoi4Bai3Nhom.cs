using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Net.BaiTapThucHanh.Buoi4Bai2;

namespace Net.BaiTapThucHanh
{
    internal class Buoi4Bai3Nhom
    {
        List<QuanLyHoaDon> QlHoaDon = new List<QuanLyHoaDon>();
        public struct QuanLyHoaDon
        {
            public string MaHoaDon { get; set; }
            public DateTime NgayPhatHanhHoaDon { get; set; }
            public double TongTienHoaDon { get; set; }
            public double SoTienConNoHoaDon { get; set; }
            public bool TrangThaiNo { get; set; }
            public string TenKhachHang { get; set; }

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
        public bool KiemTraLoi(string maHoaDon, double tongTienHoaDon, double soTienConNoHoaDon, string tenKhachHang)
        {
            if (maHoaDon.Length < 1)
            {
                Console.WriteLine("Vui lòng nhập hóa đơn!");
                return false;
            }
            if (tenKhachHang.Length < 1)
            {
                Console.WriteLine("Vui lòng nhập Tên Khách Hàng!");
                return false;
            }
            if (tenKhachHang.Any(char.IsDigit))
            {
                Console.WriteLine("Tên Nhập Không Được Phép Có Số !");
                return false;
            }
            if (tongTienHoaDon < 0)
            {
                Console.WriteLine("Vui lòng nhập lại hoa");
                return false;
            }
            if (soTienConNoHoaDon < 0)
            {
                Console.WriteLine("Số tiền còn nợ hóa đơn không thể là số âm");
                return false;
            }
            return true;
        }
        public void NhapDanhSachHoaDon(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin hóa đơn thứ " + (i + 1));
                Console.WriteLine("Mã Hóa Đơn:");
                string maHoaDon = Console.ReadLine();

                Console.WriteLine("Thêm Ngày Phát Hành (dd/MM/yyyy):");
                DateTime ngayPhatHanhHoaDon;
                bool ngayHopLe;
                do
                {
                    ngayHopLe = DateTime.TryParse(Console.ReadLine(), out ngayPhatHanhHoaDon);
                    if (!ngayHopLe || ngayPhatHanhHoaDon > DateTime.Today)
                    {
                        Console.WriteLine("Ngày nhập không hợp lệ hoặc lớn hơn ngày hiện tại, vui lòng nhập lại:");
                    }
                } while (!ngayHopLe || ngayPhatHanhHoaDon > DateTime.Today);
                Console.WriteLine("Tổng Tiền Thanh Toán:");
                double tongTienHoaDon = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Số Tiền Còn Nợ Hóa Đơn:");
                double soTienConNoHoaDon = Convert.ToDouble(Console.ReadLine());

                bool trangThaiNo = soTienConNoHoaDon > 0;

                Console.WriteLine("Tên Khách Hàng:");
                string tenKhachHang = Console.ReadLine();

                if (KiemTraLoi(maHoaDon, tongTienHoaDon, soTienConNoHoaDon, tenKhachHang))
                {
                    QlHoaDon.Add(new QuanLyHoaDon(maHoaDon, ngayPhatHanhHoaDon, tongTienHoaDon, soTienConNoHoaDon, trangThaiNo, tenKhachHang));
                    Console.WriteLine("Hóa đơn đã được thêm thành công!");
                }
                else
                {
                    Console.WriteLine("Có lỗi khi thêm hóa đơn, vui lòng thử lại.");
                }
            }
        }

        public void XoaNoHoaDon()
        {
            Console.WriteLine("Nhập mã hóa đơn muốn xóa nợ:");
            string maHoaDonXoaNo = Console.ReadLine();
            int index = QlHoaDon.FindIndex(hd => string.Equals(hd.MaHoaDon, maHoaDonXoaNo, StringComparison.OrdinalIgnoreCase));

            if (index != -1) // Nếu tìm thấy hóa đơn trong danh sách
            {
                var themHD = QlHoaDon[index];
                themHD.SoTienConNoHoaDon = 0;
                themHD.TrangThaiNo = false;
                QlHoaDon[index] = themHD;
                Console.WriteLine("Đã xóa nợ cho hóa đơn có mã: " + maHoaDonXoaNo);
            }
            else
            {
                Console.WriteLine("Không tìm thấy hóa đơn với mã đã nhập.");
            }
        }

    }
}
