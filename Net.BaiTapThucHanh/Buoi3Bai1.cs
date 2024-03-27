using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi3Bai1
    {
        public void B3Bai1()
        {
         
            int phanTuMang = 0; // khai báo số phần tử trong mảng
            bool soHople = false;// Giả định trường hợp cho vòng lặp
            while (!soHople) //
            {
                try
                {
                    Console.WriteLine("Bạn hãy nhập số phần tử trong mảng:");
                    phanTuMang = Convert.ToInt32(Console.ReadLine());
                    if (phanTuMang > 0)
                    {
                        soHople = true;
                    }
                    else
                    {
                        Console.WriteLine("Số bạn nhập phải là số lớn hơn 0.");
                    }
                }
                catch (FormatException ms)
                {
                    Console.WriteLine("Định dạng không đúng. Bạn hãy nhập số vào bàn phím." + ms.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi không xác định!" + e.Message);
                }
            }
            int[] mang = new int[phanTuMang]; // khai báo mảng
            for (int i = 0; i < phanTuMang; i++) // vòng lặp nhập các phần tử vào mảng
            {

                Console.WriteLine($"Bạn hãy nhập vào mảng phần tử {i + 1} ");
                bool nhapDung = false;
                while (!nhapDung)
                {
                    try
                    {
                        mang[i] = Convert.ToInt32(Console.ReadLine());
                        nhapDung = true;
                    }
                    catch (FormatException loiPhanTu)
                    {
                        Console.WriteLine("Bạn nhập không đúng. Vui Lòng nhập số vào mảng" + loiPhanTu.Message);
                    }

                }
            }
            Console.Write("Các số bạn vừa nhập vào mảng là :");

            foreach (int i in mang)
            {

                Console.Write(i + ", ");

            }
            Console.WriteLine();
            ChanLe(mang);
            Console.WriteLine();
            TangGiam(mang);
            Console.WriteLine();
            soArmstrong(mang);
        }
        public void ChanLe(int[] mang)
        {
            // Kiểm tra số đó là chẵn hay lẻ
            Console.WriteLine("Các số chẵn là :");
            foreach (int i in mang)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+", ");
                }
            }
            Console.WriteLine("Các số chẵn là :");
            foreach (int i in mang)
            {
                if ((i % 2) != 0) 
                { 
                    Console.Write(i + ", "); 
                }
            }    

        }
        public void TangGiam(int[] mang)
        {
            Console.WriteLine("Sắp xếp tăng dần các phần tử đã nhập :");
            int doiCho;
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i+1; j < mang.Length; j++)
                {
                    
                    if (mang[i] < mang[j])
                    {
                        doiCho = mang[i];
                        mang[i] = mang[j];
                        mang[j] = doiCho; 

                    }
                }
            }
                        
            foreach(int i in mang)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Mảng Giảm dần là :");
            for (int i = mang.Length-1; i >=0; i--)
            {
                Console.Write(i + " ");
            }
            
        }
        public void soArmstrong(int[] mang)
        {
            int tong = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                int soChu = mang[i].ToString().Length;
                tong += (int)Math.Pow(mang[i] % 10, soChu);
                if (tong==mang[i])
                {
                    Console.WriteLine(i+ " - là số Armstron");
                }
                else
                {
                    Console.WriteLine(i + " - Không phải số Armstron ");
                }
            }
        }

    }
}
