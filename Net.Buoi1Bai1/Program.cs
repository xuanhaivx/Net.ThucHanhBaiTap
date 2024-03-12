using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Buoi1Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //viết code đưa ra màn hình kết quả

            int bt1X;
            int bt1Y = 5;

            Console.WriteLine("Giá trị X  Giá Trị Y  Biểu Thức  Kết Quả");
            Console.WriteLine($"{bt1X = 10}         {bt1Y}          x=y+3      {bt1X = bt1Y + 3}");
            Console.WriteLine($"{bt1X = 10}         {bt1Y}          x=y-2      {bt1X = bt1Y - 2}");
            Console.WriteLine($"{bt1X = 10}         {bt1Y}          x=y*5      {bt1X = bt1Y * 5}");
            Console.WriteLine($"{bt1X = 10}         {bt1Y}          x=x/y      {bt1X = bt1X / bt1Y}");
            Console.WriteLine($"{bt1X = 10}         {bt1Y}          x=x%y      {bt1X = bt1X % bt1Y}");
            Console.ReadKey();
        }
    }
}
