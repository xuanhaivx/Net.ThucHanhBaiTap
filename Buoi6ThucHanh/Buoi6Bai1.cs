using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6ThucHanh
{

    public class Buoi6Bai1
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

        public void MenuBai1()
        {
            Mygeneric<SinhVien> QLSinhVien = new Mygeneric<SinhVien>();

            // Thêm sinh viên vào danh sách
            QLSinhVien.Add(new SinhVien(2345234, "Khánh", new DateTime(1999, 12, 12), "Khánh Hòa"));
            QLSinhVien.Add(new SinhVien(63456354, "Tuấn", new DateTime(1999, 12, 12), "Hà Nội"));

            // Hiển thị danh sách sinh viên
            Console.WriteLine("Danh sách sinh viên:");
            QLSinhVien.Display();

            // Tìm kiếm sinh viên có mã là 2345234
            Console.WriteLine("\nSinh viên có mã 2345234:");
            var timSV = QLSinhVien.Find(s => s.MaSv == 2345234);
            if (timSV.MaSv !=0)
            {
                Console.WriteLine(timSV);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên có mã 2345234.");
            }

            // Xóa sinh viên
            QLSinhVien.Remove(new SinhVien(2345234, "Khánh", new DateTime(1999, 12, 12), "Khánh Hòa"));
            Console.WriteLine("\nDanh sách sinh viên sau khi xóa:");
            QLSinhVien.Display();
        }


    }   
}
