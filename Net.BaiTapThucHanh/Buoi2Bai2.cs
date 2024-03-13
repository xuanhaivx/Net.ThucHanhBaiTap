using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai2
    {
        public void B2Bai2()
        {
            Console.Write("Bạn hãy Nhập Vào Một Chuỗi Bất Kỳ :");
            string _nhapchuoi = Console.ReadLine();
            string tenchuoi = "";
            
            for (int i = _nhapchuoi.Length -1; i >=0 ; i--)
            {
                tenchuoi += _nhapchuoi[i];
            }
            Console.WriteLine("Chuỗi mới dành cho bạn :"+tenchuoi);
        }
    }
}
