using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Buoi1Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình C# tính tổng 2 số được nhập vào từ bàn phím
            Console.OutputEncoding = Encoding.UTF8;
            int bt2So1, bt2So2, bt2Sum;
            Console.WriteLine("Để tính tổng của 2 số bạn hãy nhâp vào màn hình :");
            Console.Write("- Nhập số đầu tiên :");
            bt2So1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("- Nhập số thứ 2 :");
            bt2So2 = Convert.ToInt32(Console.ReadLine());
            bt2Sum = bt2So1 + bt2So2;
            Console.WriteLine($"Bạn đã nhập {bt2So1} và {bt2So2} và tổng của nó sẽ là : {bt2Sum}");
            Console.ReadKey();
        }
    }
}
