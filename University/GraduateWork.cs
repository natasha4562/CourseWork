using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class GraduateWork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdStudent { get; set; }
        public int? IdTeacher { get; set; }

        public virtual Student IdStudentNavigation { get; set; }
        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
