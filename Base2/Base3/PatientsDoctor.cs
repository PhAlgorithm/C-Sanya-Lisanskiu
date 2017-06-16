namespace Base3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PatientsDoctor
    {
        [Key]
        public int PatientsDoctorsID { get; set; }

        public int? DoctorID { get; set; }

        public int? PatientID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
