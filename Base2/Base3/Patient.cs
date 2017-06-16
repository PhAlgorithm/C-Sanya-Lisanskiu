namespace Base3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            PatientsDoctors = new HashSet<PatientsDoctor>();
        }

        public int PatientID { get; set; }

        [Required]
        [StringLength(30)]
        public string PatientName { get; set; }

        public int? PatientAge { get; set; }

        public int? StatusID { get; set; }

        public int? TaxCode { get; set; }

        public int? DoctorID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Status Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientsDoctor> PatientsDoctors { get; set; }
    }
}
