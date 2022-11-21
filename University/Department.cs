using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Department
    {
        public Department()
        {
            Specialities = new HashSet<Speciality>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdFaculty { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; }
        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
