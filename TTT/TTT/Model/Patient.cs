﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT.Model
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
    }
}
