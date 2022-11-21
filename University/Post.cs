using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Post
    {
        public Post()
        {
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
