using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class GroupStudent
    {
        public GroupStudent()
        {
            DistributionSubjects = new HashSet<DistributionSubject>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public int? Course { get; set; }
        public int? Semester { get; set; }
        public int? IdSpeciality { get; set; }

        public virtual Speciality IdSpecialityNavigation { get; set; }
        public virtual ICollection<DistributionSubject> DistributionSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
