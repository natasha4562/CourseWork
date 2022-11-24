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
        public TeachersInfo(Form1 f)
        {
            InitializeComponent();
            Parent = f;
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
                    }
                    comboBoxTeachers.SelectedIndex = 0;
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
            }
        }
    }
}
