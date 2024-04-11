using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6ThucHanh
{
    internal class Mygeneric<T>
    {
        private List<T> items;

        public Mygeneric()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T GetItem(int index)
        {
            return items[index];
        }

        public T Find(Predicate<T> match)
        {
            return items.Find(match);
        }

        public void Display()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
