using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    // Định nghĩa class Product
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    // Định nghĩa interface IProduct
    public interface IProduct
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(int productId);
        List<Product> Search(string keyword);
    }
    public class XuLyProduct : IProduct
    {
        private List<Product> products = new List<Product>();
        public void Delete(int productId)
        {
            var sanpham =products.Find(x => x.ProductId == productId);
            if (sanpham != null)
            {
                products.Remove(sanpham);
                Console.WriteLine("Sản Phẩm Đã Xóa");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm!");
            }

        }
        private static int demProductId = 1;
        public void Insert(Product product)
        {
            products.Add(product);
            product.ProductId = demProductId++;
        }

        public List<Product> Search(string keyword)
        {
            return products.FindAll(d => d.ProductName.Contains(keyword));
            
        }

        public void Update(Product product)
        {
            var upProduct = products.Find(x => x.ProductId == product.ProductId);
            if(upProduct != null)
            {
                upProduct.ProductName = product.ProductName;
                upProduct.Price = product.Price;
            }
            else
            {
                Console.WriteLine("Không tìm thấy sản phẩm!");
            }
        }
        public void HienThi ()
        {
            Console.WriteLine("Danh Sách Sản Phẩm");
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Tên: {product.ProductName}, Giá: {product.Price}");
            }
        }
        

    }
   
    
    internal class B7Bai3
    {
        XuLyProduct xuLyProduc = new XuLyProduct();

        public void Menu()

        {
            
            while (true)
            {
                Console.WriteLine("Menu Bài 7!");
                Console.WriteLine("Chọn 1 - Thêm Sản Phẩm");
                Console.WriteLine("Chọn 2 - Xóa Sản Phẩm");
                Console.WriteLine("Chọn 3 - Cập Nhật Sản phẩm!");
                Console.WriteLine("Chọn 4 - Xóa Nhiều Sản Phẩm Cùng Lúc!");
                Console.WriteLine("Chọn 5 - Xem Danh Sách Sản Phẩm!");
                Console.WriteLine("Chọn 6 - Thoát Chương trình!");
                int menu;
                int slSP;
                if (int.TryParse(Console.ReadLine(),out menu)||menu>0) 
                { 
                    switch (menu)
                    {
                        case 1: // Thêm Sản Phẩm
                            Console.WriteLine("Bạn hãy nhập số lượng sản phẩm {n}");
                            if (int.TryParse(Console.ReadLine(), out slSP))
                            {
                                ThemSP(slSP);
                            }
                            else
                            {
                                Console.WriteLine("Bạn cần nhập số!");
                            }
                            break;
                            // end Thêm Sản Phẩm

                        case 2: // Xóa Sản Phẩm
                            XoaSP();
                            break;
                            // End Xóa Sản Phẩm
                        case 3: // Cập Nhật Sản Phẩm
                            CapNhatSP();
                            break;
                        // end Cập Nhật Sản Phẩm
                        case 4: // Xóa Nhiều Sản Phẩm Cùng Lúc
                            Console.Write("Nhập ID hoặc tên của sản phẩm cần xóa: ");
                            string nhapIDXoa = Console.ReadLine();
                            var timIDCanXoa = xuLyProduc.Search(nhapIDXoa);
                            foreach (var item in timIDCanXoa)
                            {
                                xuLyProduc.Delete(item.ProductId);
                            }
                            break;
                        //end Xóa Nhiều Sản Phẩm Cùng Lúc
                        case 5:xuLyProduc.HienThi();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }else { Console.WriteLine("Bạn vui lòng nhập số nguyên"); }
                
            }
        }
        public void ThemSP(int slSP)
        {
            
                for (int i = 0; i < slSP; i++)
                {
                    Console.WriteLine($"Thêm Sản Phẩm Số {i+1}");
                    Product sanPham = new Product();
                    Console.WriteLine("Thêm Tên Sản Phẩm");
                    sanPham.ProductName = Console.ReadLine();
                    Console.WriteLine("Thêm Giá Sản Phẩm!");
                    sanPham.Price = decimal.Parse(Console.ReadLine());
                    xuLyProduc.Insert(sanPham);
                }
            
        }
        public void XoaSP()
        {
            Console.WriteLine("Tìm id sản phẩm cần xóa");
            int nhapID;
            if (int.TryParse(Console.ReadLine(), out nhapID))
            {
                var timID = xuLyProduc.Search(nhapID.ToString());
                if (timID.Count == 0)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm!");
                }
                else if (timID.Count == 1)
                {
                    xuLyProduc.Delete(timID[0].ProductId);
                }
                else
                {
                    Console.WriteLine("Tìm thấy nhiều hơn 1 sản phẩm!");
                    foreach (var item in timID)
                    {
                        Console.WriteLine($"Id : {item.ProductId}, Tên Sản Phẩm : {item.ProductName}, Giá Sản Phẩm : {item.Price}");
                    }
                    Console.WriteLine("Nhập ID Sản Phẩm Để Xóa!");
                    int idcanxoa = int.Parse(Console.ReadLine());
                    xuLyProduc.Delete(idcanxoa);
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
            }
        }
        public void CapNhatSP()
        {
            Console.Write("Nhập ID của sản phẩm cần cập nhật: ");
            int idCapNhat;
            if (int.TryParse(Console.ReadLine(), out idCapNhat))
            {

                var timIDSanPham = xuLyProduc.Search(idCapNhat.ToString());
                if (timIDSanPham.Count == 0)
                {
                    Console.WriteLine("Không tìm thấy sản phẩm.");
                }
                else
                {
                    Console.Write("Nhập tên mới của sản phẩm: ");
                    string tenSanPhamMoi = Console.ReadLine();
                    Console.Write("Nhập giá mới của sản phẩm: ");
                    decimal giaSanPhamMoi = decimal.Parse(Console.ReadLine());
                    timIDSanPham[0].ProductName = tenSanPhamMoi;
                    timIDSanPham[0].Price = giaSanPhamMoi;
                    xuLyProduc.Update(timIDSanPham[0]);
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
            }
        }

     
    }
}
