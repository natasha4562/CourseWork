using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Mark
    {
        public int Id { get; set; }
        public int? Mark1 { get; set; }
        public DateTime? DateReceiving { get; set; }
        public int? IdSubject { get; set; }
        public int? IdStudent { get; set; }

        public virtual Student IdStudentNavigation { get; set; }
        public virtual Subject IdSubjectNavigation { get; set; }
    }
}
