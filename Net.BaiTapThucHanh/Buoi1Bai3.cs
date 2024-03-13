using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi1Bai3
    {
        public void B1Bai3()
        {
            // Tính Tổng Của các số chẵn nhỏ hơn được nhập từ bàn phím
            int so1;
                        Console.Write("Bạn hãy nhập một số bất kỳ  : ");
            bool ktso1 = int.TryParse(Console.ReadLine(), out so1);

            while (!ktso1 || so1 <= 0 || so1 >= 100000)
            {
                if (so1 < 0)
                {
                    Console.WriteLine("Số bạn nhập vào phải lớn hơn hoặc bằng 0");
                }
                else if (!ktso1)
                {
                    Console.WriteLine("Bạn phải nhập số vào");
                }
                else if (so1 > 100000)
                {
                    Console.WriteLine("Số Bạn nhập phải nhỏ hơn 100000");
                }
                ktso1 = int.TryParse(Console.ReadLine(), out so1);
            }
            int tong = 0;
            for (int i = 0; i <so1;i+=2)
            {
                tong += i;
            }
            Console.WriteLine("Tổng của các số chẵn nhỏ hơn được nhập từ bàn phím "+tong);
                 
        }
    }
}
