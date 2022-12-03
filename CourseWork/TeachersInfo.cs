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
    public partial class TeachersInfo : UserControl
    {
        public Form1 Parent { get; set; }
        private List<int> idTeachers = new List<int>();
        public TeachersInfo(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            this.ContextMenuStrip = contextMenuStrip1;
            LoadTeachets();
        }

        void LoadTeachets()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var teachers = db.Teachers.Where(t => t.IdDepartment == Parent.IdDepartnemt).OrderBy(t => t.Surname).ToList();

                if (teachers.Count > 0)
                {
                    for (int i = 0; i < teachers.Count; i++)
                    {
                        comboBoxTeachers.Items.Add(teachers[i].Surname + " " + teachers[i].FirstName + " " + teachers[i].Patronymic);
                        idTeachers.Add(teachers[i].Id);
                    }
                    comboBoxTeachers.SelectedIndex = idTeachers.IndexOf(Parent.IdTeacher);
                }
            }
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Departments departments = new Departments(Parent);
            departments.Location = new Point(250, 49);
            Parent.Controls.Add(departments);
            Parent.ChildElem = departments;
        }

        private void comboBoxTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                var teacherInfo = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.SelectedItem.ToString()).FirstOrDefault();


                labelSurname.Text = teacherInfo.Surname;
                labelFirstName.Text = teacherInfo.FirstName;
                labelPatronymic.Text = teacherInfo.Patronymic;
                labelPost.Text = db.Posts.Where(p => p.Id == teacherInfo.IdPost).Select(p => p.Name).FirstOrDefault();
                labelGender.Text = teacherInfo.Gender == "м" ? "мужской" : "женский";
                labelBirthdate.Text = teacherInfo.Birthdate.Value.ToString("dd.MM.yyyy");
                labelAmountChildren.Text = teacherInfo.AmountChildren.ToString();
                labelSalary.Text = teacherInfo.Salary.ToString();

                Parent.IdTeacher = teacherInfo.Id;
            }
        }

        private void buttonDisciplines_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Subjects subject = new Subjects(Parent, 1);
            subject.Location = new Point(250, 49);
            Parent.Controls.Add(subject);
            Parent.ChildElem = subject;
        }

        private void buttonDiploma_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            GrWork grWork = new GrWork(Parent, 1);
            grWork.Location = new Point(250, 49);
            Parent.Controls.Add(grWork);
            Parent.ChildElem = grWork;
        }

        private void buttonScience_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Sciences science = new Sciences(Parent, 1);
            science.Location = new Point(250, 49);
            Parent.Controls.Add(science);
            Parent.ChildElem = science;
        }

        private void buttonDissertation_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Sciences science = new Sciences(Parent, 2);
            science.Location = new Point(250, 49);
            Parent.Controls.Add(science);
            Parent.ChildElem = science;
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            TeachertAdd teachert = new TeachertAdd(Parent);
            teachert.Location = new Point(250, 49);
            Parent.Controls.Add(teachert);
            Parent.ChildElem = teachert;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = idTeachers[comboBoxTeachers.SelectedIndex];
                var teach = db.Teachers.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                TeachertAdd teachert = new TeachertAdd(Parent, teach);
                teachert.Location = new Point(250, 49);
                Parent.Controls.Add(teachert);
                Parent.ChildElem = teachert;
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
                    int id = idTeachers[comboBoxTeachers.SelectedIndex];

                    db.Teachers.Remove(db.Teachers.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    comboBoxTeachers.Items.RemoveAt(idTeachers.IndexOf(id));
                    idTeachers.RemoveAt(idTeachers.IndexOf(id));
                }
            }
        }
    }
}
