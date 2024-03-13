using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai3
    {
        public void B2bai3()
        //Đếm số lần xuất hiện của một ký tự trong chuỗi
        {
            Console.Write("Bạn hãy nhập một chuỗi bất kỳ :");
            string _nhapchuoi = Console.ReadLine();
            Console.Write("Nhập ký tự bất kỳ : ");
            char _kytu = Console.ReadKey().KeyChar;
            int _demso = 0;
            // Đếm số lần ký tự số lần xuất hiện trong chuỗi
            for (int i = 0;i<_nhapchuoi.Length;i++)
            {
                if (_nhapchuoi[i] == _kytu)
                {
                    _demso++;
                }
            }
            // Kiểm tra nếu số lần xuất hiện ký tự >0 thì xuất hiện. Ít hơn thì thông báo người dùng rằng ký tự hiện không có trong chuỗi.
            if (_demso > 0)
            {
                Console.WriteLine($" - Ký Tự {_kytu} Số Lần xuất hiện : " + _demso);
            }
            else
            {
                Console.WriteLine($"Ký tự {_kytu} bạn nhập không có trong chuối.");
                
            }
        }
    }
}
