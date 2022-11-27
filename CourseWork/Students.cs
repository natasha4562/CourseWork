using CourseWork.ControlsAdd;
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
        private List<int> listIdStudents = new List<int>();
        public Students(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            dataGridViewStudents.ContextMenuStrip = contextMenuStrip1;

            using (UniversityContext db = new UniversityContext())
            {
                var students = db.Students.Where(s => s.IdGroupStudents == Parent.IdGroup).ToList();


                for (int i = 0; i < students.Count; i++)
                {
                    dataGridViewStudents.Rows.Add(students[i].Surname, students[i].FirstName, students[i].Patronymic, students[i].CreditBookNumber, students[i].Gender,
                        students[i].Birthdate.Value.ToString("dd.MM.yyyy"), students[i].AmountChildren, db.StudyForms.FirstOrDefault(s => s.Id == students[i].IdStudyForm).Name, students[i].AmountScholarship);
                    listIdStudents.Add(students[i].Id);
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

        private void buttonGrade_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Marks mark = new Marks(Parent);
            mark.Location = new Point(250, 49);
            Parent.Controls.Add(mark);
            Parent.ChildElem = mark;
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            StudentAdd student = new StudentAdd(Parent);
            student.Location = new Point(250, 49);
            Parent.Controls.Add(student);
            Parent.ChildElem = student;            
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = listIdStudents[dataGridViewStudents.CurrentCell.RowIndex];
                var st = db.Students.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                StudentAdd student = new StudentAdd(Parent, st);
                student.Location = new Point(250, 49);
                Parent.Controls.Add(student);
                Parent.ChildElem = student;
            }
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить данную запись?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    int id = listIdStudents[dataGridViewStudents.CurrentCell.RowIndex];

                    db.Students.Remove(db.Students.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewStudents.Rows.RemoveAt(listIdStudents.IndexOf(id));
                    listIdStudents.RemoveAt(listIdStudents.IndexOf(id));
                }
            }
        }
    }
}
