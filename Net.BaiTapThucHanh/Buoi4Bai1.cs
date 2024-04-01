using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi4Bai1
    {
        List<QuanLySach> KhoSach = new List<QuanLySach>();
        public struct QuanLySach
        {
            public string TieuDeSach { get; set; }
            public string TacGiaSach { get; set; }
            public int NamSXSach { get; set; }

            public QuanLySach(string _tieudesach, string _tacgiasach, int _namsxsach)
            {
                TieuDeSach = _tieudesach;
                TacGiaSach = _tacgiasach;
                NamSXSach = _namsxsach;
            }
            public override string ToString()
            {
                return $"Tiêu đề sách: {TieuDeSach}, Tác giả: {TacGiaSach}, Năm xuất bản: {NamSXSach}";
            }
        }
        public void B4Bai1()
        {
            while (true)
            {
                Console.WriteLine("Bạn đang dự định làm gì ?");
                Console.WriteLine("1 : Xem Danh Sách Sách");
                Console.WriteLine("2 : Thêm Sách Mới");
                Console.WriteLine("3 : Tìm Kiếm Sách");
                Console.WriteLine("4 : Thoát Chương Trình!");
                int Menu = Convert.ToInt32(Console.ReadLine());

                switch (Menu)
                {
                    case 1:
                        XemSach();
                        break;
                    case 2:
                        ThemSach();
                        break;
                    case 3:
                        TimKiemSach();
                        break;
                    case 4:
                          return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }


        }
        
        public void ThemSach()
        {
            bool ktTacGia = false;
            do { 
            Console.WriteLine("Bạn hãy thêm tiêu đề của sách! ");
                string _tieudesach = Console.ReadLine();
                
            Console.WriteLine("Bạn hãy thêm Tên Tác Giả!");
                string _tacgiasach = Console.ReadLine();
            Console.WriteLine("Bạn hãy thêm năm xuất bản!");
                int _namsxsach = Convert.ToInt32(Console.ReadLine());   
                
                                              
                for (int i = 0; i <= _tacgiasach.Length-1; i++)
                {
                    Char kt = _tacgiasach[i];
                    if (kt >= '0' && kt <= '9') 
                    {
                        ktTacGia = true;
                        break;
                    }
                }
                if ( _namsxsach >DateTime.Now.Year)
                {
                    Console.WriteLine("Năm sản xuất bạn nhập không đúng! ");
                }
                else if (_tieudesach.Length <=0)
                {
                    Console.WriteLine("Vui lòng nhập tiêu đề sách ");
                }else if (_tieudesach.Length >= 100000000)
                {
                    Console.WriteLine("Tiêu đề sách bạn nhập quá dài! Hoặc không đúng!");
                }
                else if (_tacgiasach.Length <=0)
                {
                    Console.WriteLine("Vui lòng nhập tên tác giả!");
                }
                else if (_tacgiasach.Length >100000)
                {
                    Console.WriteLine("Tên Tác Giá Quá Dài! Vui long nhập lại");
                }
                else if (ktTacGia==true)
                {
                    Console.WriteLine("Tên tác giả không được chứa số!");
                }
                else
                {
                    KhoSach.Add(new QuanLySach(_tieudesach, _tacgiasach, _namsxsach));
                    Console.WriteLine("Sách đã được thêm thành công! ");
                    break;
                }


            } while (true);
        }
        public void XemSach()
        {
            if (KhoSach.Count > 0)
            {
                foreach (QuanLySach sach in KhoSach)
                {
                    Console.WriteLine(sach);
                }
            }else { Console.WriteLine("Trong kho sách của bạn chưa có sách! "); }
                 
        }
        public void TimKiemSach()
        {
            Console.WriteLine("Nhập tiêu đề sách cần tìm:");
            string tieuDeCanTim = Console.ReadLine();
            var ketQuaTimKiem = TimKiemSachTheoTieuDe(tieuDeCanTim);

            if (ketQuaTimKiem.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var sach in ketQuaTimKiem)
                {
                    Console.WriteLine(sach);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách với tiêu đề chính xác. Đang tìm gợi ý...");
                var goiYTimKiem = GoiYTimKiem(tieuDeCanTim);
                if (goiYTimKiem.Count > 0)
                {
                    Console.WriteLine("Có phải bạn đang tìm kiếm:");
                    foreach (var sach in goiYTimKiem)
                    {
                        Console.WriteLine(sach);
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy sách!");
                }
            }
        }

        private List<QuanLySach> TimKiemSachTheoTieuDe(string tieuDe)
        {
            List<QuanLySach> ketQuaChinhXac = new List<QuanLySach>();
            foreach (var sach in KhoSach)
            {
                if (String.Equals(sach.TieuDeSach, tieuDe, StringComparison.OrdinalIgnoreCase))
                {
                    ketQuaChinhXac.Add(sach);
                }
            }
            return ketQuaChinhXac;
        }

        private List<QuanLySach> GoiYTimKiem(string tieuDe)
        {
            List<QuanLySach> goiYTimKiem = new List<QuanLySach>();
            foreach (var sach in KhoSach)
            {
                if (sach.TieuDeSach.Contains(tieuDe))
                {
                    goiYTimKiem.Add(sach);
                }
            }
            return goiYTimKiem;
        }
    }
}
