using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai4
    {
        public void B2bai4()
        {
            //sử dụng do-while để Tính giai thừa của một số
            // Giai thừa là n!=1x2x3x4x...xn Nếu n=0 thì 0! =1
            //Lúc đầu e để giới hạn là 65. Nhưng xem đi xem lại hình như kết quả không đúng.
            //Số 20 thì ra giai thừa đúng. Còn số lớn hơn 65 kết quả về 0. Nên e giới hạn nhập từ 0 đến 20

            byte _sogiaithua;
            bool _sokiemtra;

            do
            {
                Console.Write("Bạn hãy nhập một số tính giai thừa bất kỳ!");
                string _input = Console.ReadLine();
                _sokiemtra = byte.TryParse(_input, out _sogiaithua); // chuyển giá trị nhập thành int
                if (!_sokiemtra||_sogiaithua>20)
                {
                    Console.WriteLine("Giá trị bạn nhập không đúng. Vui Lòng nhập số dương từ 0 ->20");

                }
            } while (!_sokiemtra||_sogiaithua > 20); /* Nếu _sokiemtra khác với _sokiemtra được chuyển 
                                                                                  * và _sogiathua lớn hơn 20*/

            ulong _giaithua = 1; // tính tích số. Nếu để là 0 thì giai thừa sai. Ra kết quả là 0.

            byte i = _sogiaithua; // Để tính lùi lại cho tới số 1.

            if (_sogiaithua == 0)
            {
                Console.WriteLine("Số Giai Thừa Của 0 Là 1"); // Giải thừa đặc biệt giai thừa của 0 sẽ là 1. 0!=1
            }
            else
            {
                do
                {
                    _giaithua *= i;
                    i--;

                } while (i > 0);
                

            }
            Console.WriteLine($"Số Giai Thừa Của {_sogiaithua} Là {_giaithua}");

        }

    }
    
}
