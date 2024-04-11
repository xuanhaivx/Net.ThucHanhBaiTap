using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi7ThucHanh
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public double Price { get; private set; }
        public bool IsBorrowed { get; private set; }

        public Book(string title, string author, string isbn, double price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Price = price;
            IsBorrowed = false;
        }

        public void Borrow()
        {
            IsBorrowed = true;
        }

        public void Return()
        {
            IsBorrowed = false;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Price: {Price}, Borrowed: {IsBorrowed}";
        }
    }
}
