using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class DistributionScience
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdScience { get; set; }
        public int? IdTeacher { get; set; }

        public virtual Science IdScienceNavigation { get; set; }
        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
