using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
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
            // Viết chương trình tính tuổi của mình. Nhập vào ngày sinh và in ra xem mình bao nhiêu ngày, bao nhiêu tuổi.
            //DateTime sinhNhat;
            //do
            //{
            //    Console.WriteLine("Bạn vui lòng nhập ngày tháng năm sinh của bạn!");
            //    Console.WriteLine("Nhập Ngày Sinh :");
            //    int nhapNgaySinh = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Nhập Tháng Sinh :");
            //    int nhapThangSinh = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Nhập Năm Sinh :");
            //    int nhapNamSinh = Convert.ToInt32(Console.ReadLine());

            //    string thoiGianNhap = $"{nhapNgaySinh}/{nhapThangSinh}/{nhapNamSinh}";
            //    if (DateTime.TryParseExact(thoiGianNhap, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out sinhNhat))
            //        {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ngày tháng bạn nhập vào không hợp lệ. Vui lòng nhập lại");
            //    }

            //} while (true);
            //TimeSpan tuoi = DateTime.Now - sinhNhat;

            //Console.WriteLine("Sinh Ra Được Bao Nhiêu Ngày : " + (int)Math.Round(tuoi.TotalDays));
            //Console.WriteLine("Sinh Ra Được Bao Nhiêu Ngày : " + (int)Math.Round(tuoi.TotalDays/365));

            /// nhập vào text xem user và pass có đúng với user name mình có sẵn không // admin/admin
            /// 
            string dangNhap = "admin";
            string matKhau = "admin";
            
                Console.WriteLine("Bạn hãy nhập vào tên đăng nhập và mật khẩu của mình");
                Console.WriteLine("Tên Đăng Nhập :");
                string nhapTen = Console.ReadLine();
                Console.WriteLine("Tên Mật Khẩu :");
                string nhapMatKhau = Console.ReadLine();
                int kqMatKhau = string.Compare(matKhau, nhapMatKhau);
                int kqTen = string.Compare(dangNhap,nhapTen);
                if (kqMatKhau !=0 ||kqTen !=0)
                {
                    Console.WriteLine("Đăng nhập thất bại");
                }
                else
                {
                    Console.WriteLine("Bạn đã đăng nhập thành công");
                }
          

        }
    }
}
