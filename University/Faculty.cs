using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Faculty
    {
        public Faculty()
        {
            Deans = new HashSet<Dean>();
            Departments = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Dean> Deans { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
