using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6ThucHanh
{
    internal class Buoi6Bai3
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public void Bai3()
        {
            // Ví dụ hoán đổi hai số nguyên
            int a = 5, b = 10;
            Console.WriteLine("Trước khi hoán đổi: a = {0}, b = {1}", a, b);
            Swap(ref a, ref b);
            Console.WriteLine("Sau khi hoán đổi: a = {0}, b = {1}", a, b);

            // Ví dụ hoán đổi hai chuỗi
            string s1 = "Hello", s2 = "World";
            Console.WriteLine("Trước khi hoán đổi: s1 = {0}, s2 = {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("Sau khi hoán đổi: s1 = {0}, s2 = {1}", s1, s2);

        }
    }
}
