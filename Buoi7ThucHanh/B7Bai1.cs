using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class B7Bai1
    {
        public void MainBai1()
        {
            Library myLibrary = new Library();
            myLibrary.AddBook(new Book("Tên Sách Một", "Dương Thành", "123456789", 100000));
            myLibrary.AddBook(new Book("Tên Sách Hai", "Nguyễn Dương", "987654321", 200000));

            // xem chức năng mượn trả
            myLibrary.BorrowBook("123456789");
            myLibrary.ReturnBook("123456789");

            // hiển thị sách
            myLibrary.DisplayBooks();

        }
        
    }
}
