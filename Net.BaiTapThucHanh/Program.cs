using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Buoi1Bai1 kqB1Bai1= new Buoi1Bai1();
            //kqBai1.B1Bai2();

            //Buoi1Bai2 kqB1Bai2 = new Buoi1Bai2();
            //kqB1Bai2.B1Bai2();

            //Buoi1Bai3 kqB1Bai3 = new Buoi1Bai3();
            //kqB1Bai3.B1Bai3();

            //Buoi2Bai1 kqB2Bai1 = new Buoi2Bai1();
            //kqB2Bai1.B2Bai1();

            //Buoi2Bai2 kqB2Bai2 = new Buoi2Bai2();
            //kqB2Bai2.B2Bai2();

            Buoi2Bai3 kqB2Bai3 = new Buoi2Bai3();
            kqB2Bai3.B2bai3();

            Console.ReadKey();

        }
       
        
    }
}
