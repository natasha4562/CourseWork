using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class DistributionDissertation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdDissertation { get; set; }
        public int? IdTeacher { get; set; }

        public virtual Dissertation IdDissertationNavigation { get; set; }
        public virtual Teacher IdTeacherNavigation { get; set; }
    }
}
