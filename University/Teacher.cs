using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Teacher
    {
        public Teacher()
        {
            DistributionDissertations = new HashSet<DistributionDissertation>();
            DistributionSciences = new HashSet<DistributionScience>();
            DistributionSubjects = new HashSet<DistributionSubject>();
            GraduateSchools = new HashSet<GraduateSchool>();
            GraduateWorks = new HashSet<GraduateWork>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? AmountChildren { get; set; }
        public decimal? Salary { get; set; }
        public int? IdDepartment { get; set; }
        public int? IdPost { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual Post IdPostNavigation { get; set; }
        public virtual ICollection<DistributionDissertation> DistributionDissertations { get; set; }
        public virtual ICollection<DistributionScience> DistributionSciences { get; set; }
        public virtual ICollection<DistributionSubject> DistributionSubjects { get; set; }
        public virtual ICollection<GraduateSchool> GraduateSchools { get; set; }
        public virtual ICollection<GraduateWork> GraduateWorks { get; set; }
    }
}
