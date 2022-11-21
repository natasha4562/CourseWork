using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Speciality
    {
        public Speciality()
        {
            GroupStudents = new HashSet<GroupStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdDepartment { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual ICollection<GroupStudent> GroupStudents { get; set; }
    }
}
