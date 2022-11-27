using Microsoft.EntityFrameworkCore;
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

namespace CourseWork.ControlsAdd
{
    public partial class GraduateStudentAdd : UserControl
    {
        public Form1 Parent { get; set; }

        public GraduateStudentAdd(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadComboboxFormTeacher();
        }

        private void LoadComboboxFormTeacher()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var teach = db.Teachers.Where(t => dep.Contains(t.IdDepartment ?? 0)).Where(t => t.IdPost == 1 || t.IdPost == 2).ToList();
                                
                for(int i = 0; i < teach.Count; i++)
                {
                    if(!db.GraduateSchools.Where(g => g.IdTeacher == teach[i].Id).Any())
                        comboBoxTeachers.Items.Add(teach[i].Surname + " " + teach[i].FirstName + " " + teach[i].Patronymic);
                }

                if (comboBoxTeachers.Items.Count < 1)
                {
                    MessageBox.Show("На данном факультете нет преподавателей/ассистентов, которые не обучаются в аспирантуре!");
                    return;
                }

                comboBoxTeachers.SelectedIndex = 0;
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            GraduateStudents graduateStudents = new GraduateStudents(Parent);
            graduateStudents.Location = new Point(250, 49);
            Parent.Controls.Add(graduateStudents);
            Parent.ChildElem = graduateStudents;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxTeachers.Text == "")
            {
                MessageBox.Show("Выберите запись!");
                return;
            }
            using (UniversityContext db = new UniversityContext())
            {
                GraduateSchool graduateSchool = new GraduateSchool();
                var teach = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.Text).FirstOrDefault().Id;
                graduateSchool.IdTeacher = teach;

                db.GraduateSchools.Add(graduateSchool);
                db.SaveChanges();
            }
            back();
        }
    }
}
