using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballContext)
            {
                context.Teams.Add(new Team
                {
                    Coach = "Meww",
                    Name = "Apple",
                });

                context.SaveChanges();

                context.Players.Add(new Player
                {
                     Name = "Milevsky",
                     Position = "botton",
                     Age = 66,

                });

            }

        }
    }
}
