using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class GraduateSchool
    {
        public int Id { get; set; }
        public int? IdTeacher { get; set; }

        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
