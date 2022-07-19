using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Good
{
    public class Library
    {
        private IList<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        //cares for the location of the book
        //we can easily change it that way, keep it in a matrix or somewhere else
        //the book should not care for that where it is placed
        public int FindBook(string title)
        {
            for (int ind = 0; ind < books.Count; ind++)
            {
                if (books.ElementAt(ind).Title == title)
                {
                    return ind;
                }
            }
            return -1;
        }



    }
}
