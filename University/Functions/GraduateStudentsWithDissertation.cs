using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Functions
{
    [Keyless]
    public class GraduateStudentsWithDissertation
    {
        public int IdDepartment { get; set; }
        public string Gender { get; set; }
        public DateTime MinBirthdate { get; set; }
        public int MaxAge { get; set; }
        public int AmountChildren { get; set; }
        public int MinSalary { get; set; }
    }
}
