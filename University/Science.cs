﻿using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Science
    {
        public Science()
        {
            DistributionSciences = new HashSet<DistributionScience>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DistributionScience> DistributionSciences { get; set; }
    }
}
