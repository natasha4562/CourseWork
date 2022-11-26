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
    public partial class Students : UserControl
    {
        public Form1 Parent { get; set; }
        public Students(Form1 f)
        {
            InitializeComponent();
            Parent = f;

            using (UniversityContext db = new UniversityContext())
            {
                var students = db.Students.Where(s => s.IdGroupStudents == Parent.IdGroup).ToList();


                for (int i = 0; i < students.Count; i++)
                {
                    dataGridViewStudents.Rows.Add(students[i].Surname, students[i].FirstName, students[i].Patronymic, students[i].CreditBookNumber, students[i].Gender,
                        students[i].Birthdate.Value.ToString("dd.MM.yyyy"), students[i].AmountChildren, db.StudyForms.FirstOrDefault(s => s.Id == students[i].IdStudyForm).Name, students[i].AmountScholarship);
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Groups groups = new Groups(Parent);
            groups.Location = new Point(250, 49);
            Parent.Controls.Add(groups);
            Parent.ChildElem = groups;
        }

        private void buttonDisciplines_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Subjects subject = new Subjects(Parent, 0, 2);
            subject.Location = new Point(250, 49);
            Parent.Controls.Add(subject);
            Parent.ChildElem = subject;
        }

        private void buttonDiploma_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            GrWork grWork = new GrWork(Parent, 2);
            grWork.Location = new Point(250, 49);
            Parent.Controls.Add(grWork);
            Parent.ChildElem = grWork;
        }
    }
}
