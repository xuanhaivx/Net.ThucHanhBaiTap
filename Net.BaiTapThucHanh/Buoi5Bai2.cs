using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Net.BaiTapThucHanh.Buoi5Bai2;

namespace Net.BaiTapThucHanh
{
    internal class Buoi5Bai2
    {
        List<Product> DanhSachSanPham = new List<Product>();
        public struct Product
        {
            public string ProductName { set; get; }
            public decimal ProductPrice { set; get; }
            public DateTime ExpiredDate { set; get; }
            public Product(string producName, decimal productPrice, DateTime expiredDate)
            {
                ProductName = producName;
                ProductPrice = productPrice;
                ExpiredDate = expiredDate;
            }
            public override string ToString()
            {
                return $"Tên Sản Phẩm : {ProductName}.\nGía Sản Phẩm : {ProductPrice}.\n Ngày Hết Hạn Sản Phẩm : {ExpiredDate}";
            }
        }
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("Nhấn 1 - Nhập Sản Phẩm");
                Console.WriteLine("Nhấn 2 - Xem Sản Phẩm Sắp Hết Hạn");
                Console.WriteLine("Nhấn 3 - Sản phẩm Có Có Hơn 10 Ký Tự");
                Console.WriteLine("Nhấn 3 -Thoát Chương Trình");
                try {
                    int nhan = Convert.ToInt32(Console.ReadLine());
                    switch (nhan)
                    {
                        case 1:
                            Console.WriteLine("Vui lòng nhập số lượng sản phẩm!");
                            try
                            {
                                int slSanPham = Convert.ToInt32(Console.ReadLine());
                                NhapSanPham(slSanPham);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Số lượng sản phẩm phải là số!");
                            }
                            
                            
                            break;
                        case 2: SanPhamHetHan();
                            break;
                        case 3: SPTenDai(); 
                            break;  
                        case 4: return;
                        default: Console.WriteLine("Bạn nhập không đúng!")  
                                ; break;
                    }
                }catch(FormatException) { Console.WriteLine("Vui lòng nhấn số!"); }
                
            }
        }
        public bool CheckLoiDuLieu(string productName,decimal productPrice,DateTime expiredDate)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                Console.WriteLine("Tên Sản Phẩm Không Được Để Trống! ");
                return false;
            }
           
            
            if (DateTime.Now < expiredDate)
            {
                Console.WriteLine("Bạn nhập ngày sản xuất ở Tương Lai. Hãy Kiểm Tra Lại ");
                return false;
            }
           
            if (productName.Length > 1000)
            {
                Console.WriteLine("Dữ liệu nhập quá dài. Vui lòng kiểm tra lại ");
                return false;
            }
            if (productName.StartsWith(" "))
            {
                Console.WriteLine("Không thể nhập khoảng trắng ở đầu tiên.");
                return false;
            }
            
            return true;
        }
        public void NhapSanPham(int slSanPham)
        {
            for (int i = 0; i < slSanPham; i++)
            {
                Console.WriteLine($"Nhập thông tin sản phẩm thứ {i + 1}");

                Console.Write("Tên sản phẩm: ");
                string productName = Console.ReadLine();

                Console.Write("Giá sản phẩm: ");
                decimal productPrice = decimal.Parse(Console.ReadLine());

                Console.Write("Ngày hết hạn (dd/mm/yyyy): ");
                DateTime expiredDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                if (CheckLoiDuLieu(productName,productPrice,expiredDate))
                {
                    DanhSachSanPham.Add(new Product(productName, productPrice, expiredDate));
                    Console.WriteLine("Sản Phẩm Được Thêm Thành Công");
                }
            }
        }
        public void SanPhamHetHan() 
        {
            // Kiểm tra xem sản phẩm nào sắp hết hạn. Ngày hết hạn còn ít hơn 30day
            // Ngày hết hạn = ExpiredDate - DateTime.Now
            var sapHetHan = DanhSachSanPham.Where(p => (p.ExpiredDate - DateTime.Now).TotalDays >=150);
            Console.WriteLine("\nSản phẩm sắp hết hạn (<= 30 ngày):");
            foreach (var sa in sapHetHan)
            {
                Console.WriteLine($"{sa.ProductName} - Hết hạn vào: {sa.ExpiredDate.ToShortDateString()}");
                Console.WriteLine("-------------");
            }
        }
        public void SPTenDai ()
        {
            var tenDai = DanhSachSanPham.Where(p => p.ProductName.Length > 10);
            Console.WriteLine("\nSản phẩm có tên dài hơn 10 ký tự:");
            foreach (var sa in tenDai)
            {
                Console.WriteLine($"{sa.ProductName} - Giá: {sa.ProductPrice}");
                Console.WriteLine("-------------");
            }
        }
    }
}
