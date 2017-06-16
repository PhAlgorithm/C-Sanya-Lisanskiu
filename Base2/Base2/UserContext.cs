using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Base2
{
    public class UserContext: DbContext
    {
   // private string  _connectionsString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public UserContext()
        {
            
        }
        public DbSet<User> Users { get; set; }

    }
}
