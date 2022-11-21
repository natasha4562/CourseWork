using System;
using System.Collections.Generic;

#nullable disable

namespace University
{
    public partial class Dissertation
    {
        public Dissertation()
        {
            DistributionDissertations = new HashSet<DistributionDissertation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DistributionDissertation> DistributionDissertations { get; set; }
    }
}
