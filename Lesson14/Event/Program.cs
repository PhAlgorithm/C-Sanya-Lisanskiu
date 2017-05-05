using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       // [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var accaunt = new Account(100);
            accaunt.Added += ShoweMessage;
            accaunt.WithDrowed += ShoweMessage;

            accaunt.Put(200);
            accaunt.WithDrowe(100);
            accaunt.WithDrowe(500);


        }

        static void ShoweMessage(AccountEventArgs e)
        {
            Console.WriteLine($"Transaction: {e.Sum} dollars");
            Console.WriteLine(e.Message);
        }
    }
}
