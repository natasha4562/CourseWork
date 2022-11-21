using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class StatusOfExam
    {
        public StatusOfExam()
        {
            MarkOfSubjects = new HashSet<MarkOfSubject>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<MarkOfSubject> MarkOfSubjects { get; set; }
    }
}
