using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class TypeOccupation
    {
        public TypeOccupation()
        {
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
