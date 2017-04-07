using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User : ILibreryUser
    {

        List<Book> books = new List<Book>();

        public void AddBook(string autor, string title)
        {
            books.Add(new Book(autor, title));

        }
        public void RemoveBook(string autor, string title)
        {
            books.RemoveAt(index);

        }

        public void BookInfo()
        {
            //
        }

        public void BooksCount()
        {
            books.Count<Book>();
        }
    }
}
