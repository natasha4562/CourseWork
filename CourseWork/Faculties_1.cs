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
    public partial class Faculties_1 : UserControl
    {
        public Form1 Parent { get; set; }
        public Faculties_1(Form1 f)
        {
            InitializeComponent();
            Parent = f;

            LoadDean();
        }

        private void LoadDean()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var dean = db.Deans.Where(d => d.IdFaculty == Parent.IdFacult).FirstOrDefault();
                labelFIO.Text = dean.Surname + " " + dean.FirstName + " " + dean.Patronymic;
            }
        }

        private void labelChahgeColor_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Black;
        }

        private void labelChahgeColor_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = SystemColors.ControlDark;
        }

        private void labelTeachers_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Teachers teachers = new Teachers(Parent);
            teachers.Location = new Point(250, 49);
            Parent.Controls.Add(teachers);
            Parent.ChildElem = teachers;
        }

        private void labelSpecialties_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Specialties specialties = new Specialties(Parent);
            specialties.Location = new Point(250, 49);
            Parent.Controls.Add(specialties);
            Parent.ChildElem = specialties;
        }

        private void labelDepartments_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Departments departments = new Departments(Parent);
            departments.Location = new Point(250, 49);
            Parent.Controls.Add(departments);
            Parent.ChildElem = departments;
        }
    }
}
