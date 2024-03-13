using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi1Bai2
        
    {
        public void B1Bai2()
        {
            // Tính tổng 2 số nhập từ bàn phím
            int so1;
            int so2;
            Console.WriteLine("Bạn hãy nhập 2 số Vào");
            Console.Write("Bạn hãy nhập số thứ 1 : ");
            bool ktso1 = int.TryParse(Console.ReadLine(), out so1);

            while (!ktso1 ||so1<=0||so1>=100000)
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
            Console.Write("Bạn hãy nhập số thứ 2 : ");
            bool ktso2 = int.TryParse(Console.ReadLine(), out so2);

            while (!ktso2 || so2 <= 0 || so2 >= 100000)
            {
                if (so2 < 0)
                {
                    Console.WriteLine("Số bạn nhập vào phải lớn hơn hoặc bằng 0");
                }
                else if (!ktso2)
                {
                    Console.WriteLine("Bạn phải nhập số vào");
                }
                else if (so2 > 100000)
                {
                    Console.WriteLine("Số Bạn nhập phải nhỏ hơn 100000");
                }
                ktso2 = int.TryParse(Console.ReadLine(), out so2);
            }
            int kqtong = so1 + so2;

            Console.WriteLine("Tổng 2 số bạn đã nhập = " +kqtong);
        }
    }
}
