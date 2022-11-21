using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class MarkOfSubject
    {
        public int Id { get; set; }
        public int? Mark { get; set; }
        public DateTime? DateReceiving { get; set; }
        public bool? IsExam { get; set; }
        public int? IdStatusOfExam { get; set; }
        public int? IdSubject { get; set; }
        public int? IdStudent { get; set; }

        public virtual StatusOfExam IdStatusOfExamNavigation { get; set; }
        public virtual Student IdStudentNavigation { get; set; }
        public virtual Subject IdSubjectNavigation { get; set; }
    }
}
