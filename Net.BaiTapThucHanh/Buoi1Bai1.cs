using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi1Bai1
    {
        public void B1Bai1()
        {
            // viết code đưa ra màn hình
            int soX = 10;
            int soY = 5;
            soX = soY + 3;
            Console.WriteLine("Khi Y =5 Biểu Thức X = Y +3 là :" + soX);
            soX = 10;
            soX = soY - 2;
            Console.WriteLine("Khi Y =5 Biểu Thức X = Y -2  là :" + soX);
            soX = 10;
            soX = soY * 5;
            Console.WriteLine("Khi Y =5 Biểu Thức X = Y *5  là :" + soX);
            soX = 10;
            soX = soX/soY;
            Console.WriteLine("Khi Y =5 và X = 10 Biểu Thức X = X/ Y là :" + soX);
            soX = 10;
            soX = soX%soY;
            Console.WriteLine("Khi Y =5 Và X = 10 Biểu Thức X = X%Y là :" + soX);



        }
    }
}
