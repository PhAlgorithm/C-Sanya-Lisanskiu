using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
   class ChatClient
    {
        public string Name = "Uzer1";
        public string Password = "12345";

        public ChatClient() {

        }

        public void Connect() {

            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 8080);
            using (var stream = client.GetStream()) {
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);

                string NameChek;
                do
                {
                    Console.Write("Enter your NicName");
                    NameChek = Console.ReadLine();

                } while (Name == NameChek);
                
                string PassChek;
                do
                {
                    Console.Write("Enter your Password");
                    PassChek = Console.ReadLine();

                } while (Password == PassChek);
                Console.Clear();

                while (true) {
                    Console.Write($"{Name}: ");
                    Console.WriteLine(reader.ReadLine());
                    string input = Console.ReadLine();
                    writer.WriteLine(input);
                    writer.Flush();
                }
            }
        }
    }
}
