using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class DistributionSubject
    {
        public int Id { get; set; }
        public int? IdTeacher { get; set; }
        public int? IdSubject { get; set; }
        public int? IdGroupStudents { get; set; }

        public virtual GroupStudent IdGroupStudentsNavigation { get; set; }
        public virtual Subject IdSubjectNavigation { get; set; }
        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
