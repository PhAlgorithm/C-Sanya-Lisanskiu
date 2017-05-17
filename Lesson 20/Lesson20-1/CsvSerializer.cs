using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLinq
{
    public static class CsvSerializer
    {
        public static string Serialize(Book obj) {
            Type bookType = typeof(Book);
            var propertiesToSerialize = bookType.GetProperties().Where(p => p.GetCustomAttributes(typeof(NoCsvAttribute), true).Length == 0);

            StringBuilder newString = new StringBuilder();
            foreach (PropertyInfo prop in propertiesToSerialize) {
                newString.Append(prop.GetValue(obj)).Append(",");
            }

            return newString.Remove(newString.Length - 1, 1).ToString();
        }

        public static Book Deserialize(string str)
        {
            var array = str.Split(',');
            Type bookType = typeof(Book);
            
            return new Book
            {
                Author = array[0],
                Year = int.Parse(array[1]),
                Text = array[2]
            };
        }
    }
}
