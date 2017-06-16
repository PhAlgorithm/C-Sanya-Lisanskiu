using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootballContext : DbContext 
    {
        public DbSet<Team> Teams { get; set; }
        {    

        }
    }
}
