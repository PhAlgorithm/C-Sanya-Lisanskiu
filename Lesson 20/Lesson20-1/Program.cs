using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using System.Diagnostics;

namespace ReflectionLinq
{
    class Program
    {
        static void Main(string[] args) {
            Book first = new Book() { Author = "user1", Year = 1553, Text = "asdfgsdgdfg" };

            string serializedBook = CsvSerializer.Serialize(first);

            Book deserializedBook = CsvSerializer.Deserialize(serializedBook);

            Type bookType = typeof(Book);

            foreach (var prop in bookType.GetProperties()) {
                Console.WriteLine(prop.Name);
                if (prop.GetCustomAttribute<NoCsvAttribute>() != null) {
                    Console.WriteLine("NoCsvAttribute");
                }
            }

        }
    }
}
