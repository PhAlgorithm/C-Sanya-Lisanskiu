using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Base2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var userContext = new UserContext())
            {
                //var user1 = new User
                //{
                //    Name = "Sqdfn",
                //    Age = 58
                //};
                //var user2 = new User
                //{
                //    Name = "Dergg",
                //    Age = 96
                //};

                //userContext.Users.Add(user1);
                //userContext.Users.Add(user2);

                //userContext.SaveChanges();



                //var users = userContext.Users;

                ////var user1 = users.FirstOrDefault();
                ////user1.Age = 1500;
                ////foreach (var user in users)
                ////{
                ////    Console.WriteLine(user);
                ////}

                //var tom = users.FirstOrDefault(x => x.Name == "Dergg");
                //userContext.Users.Remove(tom);

                //userContext.SaveChanges();
                // var users = userContext.Users;

               //
            }


        }
    }
}
