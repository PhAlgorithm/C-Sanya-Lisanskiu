using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT.Model
{
   public  class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SpetialiationId { get; set; }

        public Spetialisation Spetialisation { get; set; }

        public ICollection<Patient> Patients { get; set; }

    }
}
