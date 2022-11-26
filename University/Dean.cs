using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Dean
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? AmountChildren { get; set; }
        public decimal? Salary { get; set; }
        public int? IdFaculty { get; set; }
        public string Picture { get; set; }

        public virtual Faculty IdFacultyNavigation { get; set; }
    }
}
