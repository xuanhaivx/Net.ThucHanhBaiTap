using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6ThucHanh
{
    internal class Buoi6Bai2
    {
        public struct SinhVien
        {
            public int MaSv { get; set; }
            public string TenSV { get; set; }
            public DateTime NgaySinhSV { get; set; }
            public string QueQuanSV { get; set; }
            public SinhVien(int maSV, string tenSv, DateTime ngaySinhSV, string queQuanSv)
            {
                MaSv = maSV;
                TenSV = tenSv;
                NgaySinhSV = ngaySinhSV;
                QueQuanSV = queQuanSv;
            }

            public override string ToString()
            {
                return $"Mã Sinh Viên: {MaSv}\nTên Sinh Viên: {TenSV}\nNgày Sinh: {NgaySinhSV:d}\nQuê Quán: {QueQuanSV}";
            }
        }

        public class QuanLySinhVien
        {
            private Dictionary<int, SinhVien> sinhVienDictionary = new Dictionary<int, SinhVien>();

            public void AddItem(int maSV, SinhVien sinhVien)
            {
                if (!sinhVienDictionary.ContainsKey(maSV))
                {
                    sinhVienDictionary.Add(maSV, sinhVien);
                    Console.WriteLine("Sinh viên đã được thêm thành công.");
                }
                else
                {
                    Console.WriteLine("Sinh viên với mã này đã tồn tại.");
                }
            }

            public SinhVien? GetItem(int maSV)
            {
                if (sinhVienDictionary.TryGetValue(maSV, out SinhVien sinhVien))
                {
                    return sinhVien;
                }
                else
                {
                    Console.WriteLine("Không tìm thấy sinh viên.");
                    return null;
                }
            }
        }


        public void Bai2()
        {
            QuanLySinhVien quanLy = new QuanLySinhVien();

            // Thêm sinh viên vào danh sách
            quanLy.AddItem(1, new SinhVien(1, "Nguyen Van A", new DateTime(2000, 1, 1), "Ha Noi"));
            quanLy.AddItem(2, new SinhVien(2, "Tran Thi B", new DateTime(2001, 2, 2), "TP Ho Chi Minh"));

            // Truy xuất thông tin sinh viên
            var sv = quanLy.GetItem(1);
            if (sv != null)
            {
                Console.WriteLine(sv);
            }

            sv = quanLy.GetItem(2);
            if (sv != null)
            {
                Console.WriteLine(sv);
            }
                      

        }

       
    }
}
