using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Functions
{
    [Keyless]
    public class TeacherSubject
    {
        public string Name { get; set; }
        public int AmountHours { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
    }
}
