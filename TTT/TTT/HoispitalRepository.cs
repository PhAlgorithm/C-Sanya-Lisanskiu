using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTT.Model;

namespace TTT
{
    class HoispitalRepository
    {
        private HospitalContext context;
        public HoispitalRepository()
        {
            context = new HospitalContext();
        }

        public ICollection<Doctor> GetDoctor()
        {
            return context.Doctors.ToList();
        }
    }
}
