using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Subject
    {
        public Subject()
        {
            DistributionSubjects = new HashSet<DistributionSubject>();
            MarkOfSubjects = new HashSet<MarkOfSubject>();
            Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AmountHours { get; set; }
        public int? Course { get; set; }
        public int? Semester { get; set; }
        public int? IdTypeOccupation { get; set; }
        public int? IdFormControl { get; set; }

        public virtual FormControl IdFormControlNavigation { get; set; }
        public virtual TypeOccupation IdTypeOccupationNavigation { get; set; }
        public virtual ICollection<DistributionSubject> DistributionSubjects { get; set; }
        public virtual ICollection<MarkOfSubject> MarkOfSubjects { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
