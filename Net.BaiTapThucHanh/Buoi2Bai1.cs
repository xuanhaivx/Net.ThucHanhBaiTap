using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai1
    {
        public void B2Buoi1()
        {
            //In dãy số nguyên tố nhỏ hơn số được nhập vào từ bàn phím
            int _nhapso;
            Console.Write("Nhập một số bất kỳ :");
            bool _ktso = int.TryParse(Console.ReadLine(), out _nhapso);
            while (!_ktso || _nhapso <= 1 || _nhapso > 1000000)
            {
                if (!_ktso)
                {
                    Console.WriteLine("Bạn cần phải nhập số vào bàn phím");

                }
                else if (_nhapso > 1000000)
                {
                    Console.WriteLine("Số bạn nhập phải nhỏ hơn hoặc bằng 1000000.");
                }
                else if (_nhapso <= 1)
                {
                    Console.WriteLine("Số bạn nhập cần phải lớn hơn 1.");
                }
                _ktso = int.TryParse(Console.ReadLine(), out _nhapso);
            }


     
            for (int i = 2; i <=_nhapso; i++)
            {
                int _songuyen = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        _songuyen++;
                        break;
                    }
                }

                if (_songuyen == 0)
                {
                    Console.WriteLine("Số :" + i);
                }
            }
            Console.ReadKey();

        }
    }
}
