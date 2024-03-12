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
            int bt3So;
            int bt3Tong = 0;
            Console.Write("Bạn hãy nhập số bất kỳ :");
            bt3So = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < bt3So; i++)
            {
                if (i % 2 == 0)
                {
                    bt3Tong += i;
                }
            }

            Console.WriteLine($"Tổng các số chẵn nhỏ hơn số đã nhập :{bt3Tong}");

            Console.ReadKey();
        }
    }
}
