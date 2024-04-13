using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            B7Bai1 bai1 = new B7Bai1();
            B7Bai2 bai2 = new B7Bai2();
            B7Bai3 bai3 = new B7Bai3();
            while (true)
            {

                Console.WriteLine("Bạn hãy chọn bài muốn chạy");
                Console.WriteLine("Chọn 1 - Bài 1");
                Console.WriteLine("Chọn 2 - Bài 2");
                Console.WriteLine("Chọn 3 - Bài 3");
                try
                {


                    int chonBai = Convert.ToInt32(Console.ReadLine());
                    switch (chonBai)
                    {
                        case 1: bai1.MainBai1(); break;
                        case 2: bai2.Main(); ; break;
                        case 3: bai3.Menu(); break;

                        default:
                            Console.WriteLine("bạn nhập không đúng!"); break;
                    }
                    
                }
                catch (FormatException)
                {

                    Console.WriteLine("Vui lòng nhập số vào!");
                }
            }
        }
    }
}
