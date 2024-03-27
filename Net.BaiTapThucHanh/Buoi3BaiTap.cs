using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi3BaiTap
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
            Console.WriteLine();
            TongCacSoNguyenTo(mang);
            Console.WriteLine() ;
            int tongChan = 0, tongLe = 0;
            TinhTongChanLeThamChieu(mang, ref tongChan, ref tongLe);
            Console.WriteLine($"Tổng số chẵn: {tongChan}, Tổng số lẻ: {tongLe}");
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
            Console.WriteLine("Các số Lẻ là :");
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
            Console.WriteLine("Sắp xếp giảm dần các phần tử đã nhập:");
            int doiCho;
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = i + 1; j < mang.Length; j++)
                {
                    if (mang[i] < mang[j])
                    {
                        doiCho = mang[i];
                        mang[i] = mang[j];
                        mang[j] = doiCho;
                    }
                }
            }

            // In mảng giảm dần
            Console.Write("Mảng sau khi sắp xếp giảm dần: ");
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(); 

            // In lại mảng theo thứ tự giảm dần sử dụng giá trị của mảng
            Console.Write("Mảng giảm dần : ");
            for (int i = mang.Length - 1; i >= 0; i--)
            {
                Console.Write(mang[i] + " "); // Sử dụng mang[i] để tham chiếu đến giá trị
            }
            Console.WriteLine(); // Xuống dòng
        }
        public void soArmstrong(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                int soTam = mang[i];
                int soChu = soTam.ToString().Length;
                int tong = 0;
                while (soTam > 0)
                {
                    int chuSo = soTam % 10;
                    tong += (int)Math.Pow(chuSo, soChu);
                    soTam /= 10;
                }

                if (tong == mang[i])
                {
                    Console.WriteLine(mang[i] + " - là số Armstrong");
                }
                else
                {
                    Console.WriteLine(mang[i] + " - Không phải số Armstrong");
                }
            }
        }
        public void TongCacSoNguyenTo(int[] mang)
        {
            int tongSoNguyen = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                int soNguyen = mang[i];
                if (soNguyen < 2) continue; // Số nguyên tố phải lớn hơn 1

                bool laSoNguyenTo = true;
                for (int j = 2; j * j <= soNguyen; j++)
                {
                    if (soNguyen % j == 0)
                    {
                        laSoNguyenTo = false;
                        break; // Dừng vòng lặp nếu tìm thấy ước số, đây không phải số nguyên tố
                    }
                }

                if (laSoNguyenTo)
                {
                    tongSoNguyen += soNguyen; // Chỉ cộng dồn khi là số nguyên tố
                }
            }
            Console.WriteLine("Tổng các số nguyên tố bằng " + tongSoNguyen);
        }
        public void TinhTongChanLeThamChieu(int[] mang, ref int tongChan, ref int tongLe)
        {
            tongChan = 0;
            tongLe = 0;
            foreach (int i in mang)
            {
                if (i % 2 == 0)
                {
                    tongChan += i;
                }
                else
                {
                    tongLe += i;
                }
            }
        }

    }
}
