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
    public partial class Teachers : UserControl
    {
        public Form1 Parent { get; set; }
        public Teachers(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadTeachets();
        }

        void LoadTeachets()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var d = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var teachers = db.Teachers.OrderBy(t => t.Surname).Where(t => d.Contains(t.IdDepartment ?? 0)).ToList();

                if (teachers.Count > 0)
                {
                    for (int i = 0; i < teachers.Count; i++)
                    {
                        dataGridViewTeachers.Rows.Add(teachers[i].Surname, teachers[i].FirstName, teachers[i].Patronymic, 
                            db.Posts.Where(p => p.Id == teachers[i].IdPost).FirstOrDefault().Name,
                            db.Departments.Where(d => d.Id == teachers[i].IdDepartment).FirstOrDefault().Name);
                    }
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Faculties_1 faculties_1 = new Faculties_1(Parent);
            faculties_1.Location = new Point(250, 49);
            Parent.Controls.Add(faculties_1);
            Parent.ChildElem = faculties_1;
        }
    }
}
