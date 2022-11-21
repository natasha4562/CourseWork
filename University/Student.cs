using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Student
    {
        public Student()
        {
            GraduateWorks = new HashSet<GraduateWork>();
            MarkOfSubjects = new HashSet<MarkOfSubject>();
            Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public long? CreditBookNumber { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? AmountChildren { get; set; }
        public int? IdStudyForm { get; set; }
        public decimal? AmountScholarship { get; set; }
        public int? IdGroupStudents { get; set; }

        public virtual GroupStudent IdGroupStudentsNavigation { get; set; }
        public virtual StudyForm IdStudyFormNavigation { get; set; }
        public virtual ICollection<GraduateWork> GraduateWorks { get; set; }
        public virtual ICollection<MarkOfSubject> MarkOfSubjects { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
    }
}
