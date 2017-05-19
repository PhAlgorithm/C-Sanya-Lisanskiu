using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    public class Book
    {
        public string NameBook;
        public int Year;
        public int AutorID;

        public override string ToString()
        {
            return NameBook + " - " + Year;
        }
    }

    public class Autor
    {
        public int AutorID;
        public string AutorName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Test 1    
            Book[] books =
            {
                new Book { NameBook= "Book1",     Year=1996,  AutorID=1},
                new Book { NameBook= "Book2",     Year=2000,  AutorID=2},
                new Book { NameBook= "Book3LINQ", Year=2004,  AutorID=1},
                new Book { NameBook= "Book3",     Year=2004,  AutorID=3},
                new Book { NameBook= "LINQBook4", Year=2011,  AutorID=4},
                new Book { NameBook= "Book5",     Year=2012,  AutorID=1},
                new Book { NameBook= "Book6",     Year=2001,  AutorID=2}
            };

            var selectetBook = from b in books
                               where b.NameBook.Contains("LINQ")
                               where DateTime.IsLeapYear(b.Year)
                               select b;
            foreach (var item in selectetBook)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('*', 20));
            #endregion

            #region Test 2

            Autor[] autor =
            {
                new Autor {AutorName="Autor1", AutorID=1 },
                new Autor {AutorName="Autor2", AutorID=2 },
                new Autor {AutorName="Autor3", AutorID=3 },
                new Autor {AutorName="Autor4", AutorID=4 },
                new Autor {AutorName="Autor5", AutorID=5 },
                new Autor {AutorName="Autor6", AutorID=6 }
            };

            var selectetAutorBooks = autor.GroupJoin(
                                     books,
                                     a => a.AutorID,
                                     b => b.AutorID,
                                     (a, b) => new {
                                         Name = a.AutorName,
                                         Books = b.Select(x => x.NameBook)
                                     });

            #endregion

            #region Test 3

            int[] arreyInt = { 14, 12, 23, 20, 33, 32, 63, 27, 36, 15, 75, 86, 23 };

            var digitAnaliz = arreyInt.Where(x => (x % 10).OrderBy().(x % 10-x).OrderBy()));


            #endregion
        }
    }
}
