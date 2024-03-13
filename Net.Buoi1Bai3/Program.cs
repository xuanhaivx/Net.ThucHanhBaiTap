using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Buoi1Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Viết chương trình C# tính tổng các số chẵn nhỏ hơn số được nhập từ bàn phím
           
            int bt3Tong = 0;
            int number;
            bool bt3kiemtra;
            do
            {
                Console.Write("Bạn hãy nhập số bất kỳ :");
            string bt3So = Console.ReadLine();
            bt3kiemtra= int.TryParse(bt3So, out number);

                if{ 

                for (int i = 0; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                        bt3Tong += i;
                    }
                }
            }
            while (bt3Tong != 0);
            }
            else { Console.WriteLine("Lỗi Nhập Vào. Bạn Cần Nhập Số Vào!"); }
            Console.ReadKey();
        }
    }
}
