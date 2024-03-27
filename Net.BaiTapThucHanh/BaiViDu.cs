using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class BaiViDu

    {
        //viết hàm để sắp xếp dãy tăng dần
        public void xepMang()
        {
            int[] nhapMang = {4,7,2,763,1,24,};
            Console.WriteLine("Mảng nhập sau khi xử lý");
            xuLyMang(ref nhapMang);
            foreach (int sox in nhapMang)
            {
                Console.WriteLine(sox);
            }
        }
        public void xuLyMang(ref int[] array)

        {
            int doicho;
           for (int j = 0; j < array.Length; j++) {
                for (int i = 0; i < array.Length; i++)
                {

                    if (array[i] > array[i + 1])
                    {

                        doicho = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = doicho;
                    }
                }   }
        }
    }
}
