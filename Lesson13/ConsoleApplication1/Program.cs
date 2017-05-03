using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        const string Password = "123456";
        public delegate bool ValidatePassword(string password, string pattern);

        static void Main(string[] args)
        {
            ValidatePassword myDelegat = new ValidatePassword(VerifyPassword);
            myDelegat += Chek;
            var list = myDelegat.GetInvocationList();

           //var isValidPassword = valpas("safasf", Password);

           // myDelegat = Chek;

            Console.WriteLine($"Password is {myDelegat("546464", Password)}");
            //Console.WriteLine($"Password is {isValidPassword}");
            Console.WriteLine();  
        
        }

        public static bool VerifyPassword (string password, string pattern)
        {
            Console.WriteLine(nameof(VerifyPassword));
            return password == pattern;
        }

        public static bool Chek(string s1, string s2)
        {
            Console.WriteLine(nameof(Chek));
            Console.WriteLine($"{nameof(s1)} : {s1}; {nameof(s2)} : {s2};");
            return s1 == s2;

        }
    }
}
