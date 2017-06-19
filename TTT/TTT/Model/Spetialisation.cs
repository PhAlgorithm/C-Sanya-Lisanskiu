using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT.Model
{
    public class Spetialisation
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
