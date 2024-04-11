using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book FindBookByAuthor(string author)
        {
            return books.FirstOrDefault(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase) && !b.IsBorrowed);
        }

        public Book FindBookByISBN(string isbn)
        {
            return books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
        }
        public List<Book> FindBooksByTitle(string title)
        {
            return books.Where(b => b.Title.ToLower().Contains(title.ToLower()) && !b.IsBorrowed).ToList();
        }

        public bool BorrowBook(string isbn)
        {
            Book book = FindBookByISBN(isbn);
            if (book != null && !book.IsBorrowed)
            {
                book.Borrow();
                Console.WriteLine($"'{book.Title}' Đã Mượn");
                return true;
            }
            Console.WriteLine("Sách không có sẵn hoặc không tồn tại");
            return false;
        }

        public bool ReturnBook(string isbn)
        {
            Book book = books.FirstOrDefault(b => b.ISBN == isbn && b.IsBorrowed);
            if (book != null)
            {
                book.Return();
                Console.WriteLine($"'{book.Title}' Đã Trả");
                return true;
            }
            Console.WriteLine("Sách không được mượn hoặc không tồn tại");
            return false;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Danh Mục Sách :");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
