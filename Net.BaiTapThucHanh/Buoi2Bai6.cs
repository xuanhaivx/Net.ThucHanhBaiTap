using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai6
    {
        public void B2Bai6()
        {
            //Sử dụng do-while để kiểm tra mật khẩu được nhập từ bàn phím ( Mật khẩu phải từ 6-12 ký tự và có ký tự @) 

            string _nhapchuoi;
            int _demchuoi;

            do
            {
                Console.Write("Vui long nhập mật khẩu của bạn : ");
                _nhapchuoi = Console.ReadLine();
                
                _demchuoi =_nhapchuoi.Length;
                

                if (_demchuoi < 6 || _demchuoi > 12)
                {
                        Console.WriteLine("Bạn hãy nhập chuỗi từ 6-12 ký tự");

                }
                 else if (!_nhapchuoi.Contains("@"))
                 {
                        Console.WriteLine("Chuỗi bên trong cần phải có ký tự @");
                 }

                

            } while (_demchuoi < 6 || _demchuoi > 12|| !_nhapchuoi.Contains("@"));
            Console.WriteLine("Mất khẩu bạn nhập là : "+_nhapchuoi);

        }
    }
}
