using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi4Bai2
    {
        List<QuanLyHocSinh> listHocSinh = new List<QuanLyHocSinh>();
        public struct QuanLyHocSinh
        {
            public string TenHocSinh { get; set; }
            public int TuoiHocSinh { get; set; }
            public float DiemTrungBinh { get; set; }

            public QuanLyHocSinh(string _tenhocsinh, int _tuoihocsinh, float _diemtrungbinh)
            {
                TenHocSinh = _tenhocsinh;
                TuoiHocSinh = _tuoihocsinh;
                DiemTrungBinh = _diemtrungbinh;
            }
            public override string ToString()
            {
                return $"Tên Học Sinh: {TenHocSinh}, Tuổi Học Sinh: {TuoiHocSinh}, Điểm Trung Bình: {DiemTrungBinh}";
            }
        }
        public void B4Bai2()
        {
            while (true)
            {
                Console.WriteLine("Bạn đang dự định làm gì ?");
                Console.WriteLine("1 : Xem Danh Sách Học Sinh");
                Console.WriteLine("2 : Thêm Học Sinh Mới");
                Console.WriteLine("3 : Tìm Kiếm Học Sinh");
                Console.WriteLine("4 : Thoát Chương Trình!");
                int Menu = Convert.ToInt32(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                        XemHocSinh();
                        break;
                    case 2:
                        ThemHocSinh();
                        break;
                    case 3:
                        TimKiemHocSinh();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }


        }

        public void ThemHocSinh()
        {
            bool ktTenHocSinh = false;
            do
            {
                Console.WriteLine("Bạn hãy thêm Tên học Sinh! ");
                string _tenhocsinh = Console.ReadLine();

                Console.WriteLine("Thêm Tuổi Học Sinh");
                int _tuoihocsinh = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Thêm Điểm Trung Bình");
                float _diemtrungbinh;
                while (true)
                {
                    if (float.TryParse(Console.ReadLine(), out _diemtrungbinh))
                    {
                        break; // Thoát khỏi vòng lặp nếu nhập đúng
                    }
                    else
                    {
                        Console.WriteLine("Đây không phải là một số thực hợp lệ. Vui lòng nhập lại:");
                    }
                }

                for (int i = 0; i <= _tenhocsinh.Length - 1; i++)
                {
                    Char kt = _tenhocsinh[i];
                    if (kt >= '0' && kt <= '9')
                    {
                        ktTenHocSinh = true;
                        break;
                    }
                }
                if (_tuoihocsinh <5 || _tuoihocsinh>25)
                {
                    Console.WriteLine("Tuổi Bạn nhập không đúng ");
                }
                else if (_tenhocsinh.Length <= 0)
                {
                    Console.WriteLine("Vui lòng nhập tên học sinh ");
                }
                else if (_tenhocsinh.Length >= 10000)
                {
                    Console.WriteLine("Tên Quá Dài! Hãy Kiểm tra lại có thể bạn đã nhập tên không đúng!");
                }
                else if (_diemtrungbinh<0 ||_diemtrungbinh>10)
                {
                    Console.WriteLine("Điểm trung bình bạn nhập không đúng. Hãy Nhập Lại");
                }
                
                else if (ktTenHocSinh)
                {
                    Console.WriteLine("Tên Học Sinh Không Được Chứa Số!");
                }else
                {
                    listHocSinh.Add(new QuanLyHocSinh(_tenhocsinh, _tuoihocsinh, _diemtrungbinh));
                    Console.WriteLine("Học Sinh đã được thêm thành công! ");
                    break;
                }


            } while (true);
        }
        public void XemHocSinh()
        {
            if (listHocSinh.Count > 0)
            {
                foreach (QuanLyHocSinh xemhocsinh in listHocSinh)
                {
                    Console.WriteLine(xemhocsinh);
                }
            }
            else { Console.WriteLine("Trong lớp không có học sinh nào! "); }

        }
        public void TimKiemHocSinh()
        {
            Console.WriteLine("Nhập tên học sinh cần tìm:");
            string tenHocSinhCanTim = Console.ReadLine();
            var ketQuaTimHS = TimKiemHocSinhTheoTen(tenHocSinhCanTim);

            if (ketQuaTimHS.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var timhocsinh in ketQuaTimHS)
                {
                    Console.WriteLine(timhocsinh);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh với tên chính xác đề chính xác. Đang tìm gợi ý...");
                var goiYTimHS = GoiYTimKiem(tenHocSinhCanTim);
                if (goiYTimHS.Count > 0)
                {
                    Console.WriteLine("Có phải bạn đang tìm kiếm:");
                    foreach (var timhocsinh in goiYTimHS)
                    {
                        Console.WriteLine(timhocsinh);
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy học sinh!");
                }
            }
        }

        private List<QuanLyHocSinh> TimKiemHocSinhTheoTen(string TenHS)
        {
            List<QuanLyHocSinh> ketQuaChinhXac = new List<QuanLyHocSinh>();
            foreach (var timHocSinh in listHocSinh)
            {
                if (String.Equals(timHocSinh.TenHocSinh, TenHS, StringComparison.OrdinalIgnoreCase))
                {
                    ketQuaChinhXac.Add(timHocSinh);
                }
            }
            return ketQuaChinhXac;
        }

        private List<QuanLyHocSinh> GoiYTimKiem(string tenHS)
        {
            List<QuanLyHocSinh> goiYTimKiem = new List<QuanLyHocSinh>();
            foreach (var timHocSinh in listHocSinh)
            {
                if (timHocSinh.TenHocSinh.Contains(tenHS))
                {
                    goiYTimKiem.Add(timHocSinh);
                }
            }
            return goiYTimKiem;
        }
    }
}
