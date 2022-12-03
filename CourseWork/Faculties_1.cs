using CourseWork.Controls;
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
using University.Functions;

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
                if (dean != null)
                {
                    labelFIO.Text = dean.Surname + " " + dean.FirstName + " " + dean.Patronymic;
                    pictureBox1.Image = Image.FromFile("D:\\7 семестр\\БД\\CourseWork\\Pictures\\" + dean.Picture);
                }
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

            DepOrSpec depOrSpec = new DepOrSpec(Parent, 2);
            depOrSpec.Location = new Point(250, 49);
            Parent.Controls.Add(depOrSpec);
            Parent.ChildElem = depOrSpec;
        }

        private void labelDepartments_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            DepOrSpec depOrSpec = new DepOrSpec(Parent, 1);
            depOrSpec.Location = new Point(250, 49);
            Parent.Controls.Add(depOrSpec);
            Parent.ChildElem = depOrSpec;
        }

        private void labelSubjects_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            SubjectsAll subjects = new SubjectsAll(Parent);
            subjects.Location = new Point(250, 49);
            Parent.Controls.Add(subjects);
            Parent.ChildElem = subjects;
        }
    }
}
