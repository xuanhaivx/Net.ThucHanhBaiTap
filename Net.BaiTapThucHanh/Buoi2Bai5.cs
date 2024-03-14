using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.BaiTapThucHanh
{
    internal class Buoi2Bai5
    {
        public void B2Bai5()
        {
            //Sử dụng do-while để  Đoán số ngẫu nhiên ( nhập vào bàn phím 1 số bất kỳ và so sánh với số được sinh ra từ Class Random trong c#)
            // sử dụng do-while kiểm tra xem ký tự nhập vào hợp lệ hay không
            // sinh ra số random sử dụng điều kiện. Nếu người dùng nhập 1 số thì randon ra 1 số, nhập n số thì random ra n số. 
            // so sánh số vừa nhập với ô random.
            int _sonhap;
            bool _ktsonhap;
            do
            {
                Console.Write("Bạn hãy nhập một số bất kỳ :");
                string _input = Console.ReadLine();
                _ktsonhap = int.TryParse(_input,out _sonhap);
                if(!_ktsonhap ||_sonhap<0)
                {
                    Console.WriteLine("Giá trị bạn nhập không đúng. Vui Lòng nhập số từ 0 ->2147483647");
                }
                string _chuyenchuoi = _sonhap.ToString();
                int _sokytu = _chuyenchuoi.Length;
                int min, max;
                switch (_sokytu)
                {
                   case 1:min = 1; max = 9;break;
                   case 2: min = 10; max = 99; break;                                                                                  
                    default:min = (int)Math.Pow(10,_sokytu -1); max = (int)Math.Pow(10, _sokytu) - 1;break;
                        // sử dụng phép tính 10^n (10 mũ n): Ví dụ 10^4 = 10000
                }


                Random _random = new Random();
                int _songaunhien = _random.Next(min, max-1);
                if (_sonhap>_songaunhien)
                {
                    Console.WriteLine($"Số Bạn vừa nhập số {_sonhap} lớn hơn số random {_songaunhien}");
                }else if (_sonhap<_songaunhien)
                {
                    Console.WriteLine($"Số bạn vừa nhập số {_sonhap} nhỏ hơn số random {_songaunhien}");
                }
                else if(_sonhap==_songaunhien)
                {
                    Console.WriteLine($"Số Bạn nhập số {_sonhap} bằng với ô random {_songaunhien} ");
                }
            } while (!_ktsonhap || _sonhap < 0);
            
            
            

        }
    }
}
