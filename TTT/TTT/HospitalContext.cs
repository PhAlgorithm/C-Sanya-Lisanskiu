using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTT.Model;

namespace TTT
{
    public class HospitalContext : DbContext
    {


        public HospitalContext() : base() { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Spetialisation> Spetialisations { get; set; }

    }
}
