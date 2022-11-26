using Microsoft.EntityFrameworkCore;

namespace University.Functions
{
    [Keyless]
    public class CountStudentsInGroup
    {
        public int CountStudents { get; set; }
    }
}
