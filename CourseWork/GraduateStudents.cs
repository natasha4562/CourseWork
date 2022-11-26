using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace CourseWork
{
    public partial class GraduateStudents : UserControl
    {
        public Form1 Parent { get; set; }
        public GraduateStudents(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadGrStudents();
        }

        void LoadGrStudents()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var teachs = db.GraduateSchools.Select(g => g.IdTeacherNavigation).ToList();

                for (int i = 0; i < teachs.Count; i++)
                {
                    dataGridViewTeachers.Rows.Add(teachs[i].Surname, teachs[i].FirstName, teachs[i].Patronymic, db.Posts.Where(p => p.Id == teachs[i].IdPost).FirstOrDefault().Name, teachs[i].Gender,
                        teachs[i].Birthdate.Value.ToString("dd.MM.yyyy"), teachs[i].AmountChildren, teachs[i].Salary);
                }
            }
        }
    }
}
