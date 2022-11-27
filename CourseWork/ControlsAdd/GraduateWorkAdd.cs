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
    public partial class GraduateWorkAdd : UserControl
    {
        public Form1 Parent { get; set; }

        public GraduateWorkAdd(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadComboboxStudents();
            LoadComboboxTeachers();
            EditVersion();
        }

        private void LoadComboboxStudents()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var st = db.Students.Where(s => s.IdGroupStudents == Parent.IdGroup).ToList();

                for(int i = 0; i < st.Count; i++)
                {
                    if(!db.GraduateWorks.Where(g => g.IdStudent == st[i].Id).Any())
                        comboBoxStudents.Items.Add(st[i].Surname + " " + st[i].FirstName + " " + st[i].Patronymic);
                }

                if (comboBoxStudents.Items.Count < 1)
                {
                    MessageBox.Show("У всех студентов данной группы есть дипломные работы!");
                    return;
                }

                comboBoxStudents.SelectedIndex = 0;
            }
        }

        private void LoadComboboxTeachers()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var teach = db.Teachers.Where(t => dep.Contains(t.IdDepartment ?? 0)).ToList();

                for (int i = 0; i < teach.Count; i++)
                {
                    comboBoxTeachers.Items.Add(teach[i].Surname + " " + teach[i].FirstName + " " + teach[i].Patronymic);
                }

                if (comboBoxStudents.Items.Count < 1)
                {
                    MessageBox.Show("На данном факультете нет преподавателей!");
                    return;
                }

                comboBoxStudents.SelectedIndex = 0;
            }
        }

        private void EditVersion()
        {
            /*if(student != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    textBoxSurname.Text = student.Surname;
                    textBoxFirstName.Text = student.FirstName;
                    textBoxPatronymic.Text = student.Patronymic;
                    textBoxCreditBookNumber.Text = student.CreditBookNumber.ToString();
                    if (student.Gender == "м") radioButtonMale.Checked = true;
                    else if (student.Gender == "ж") radioButtonFemale.Checked = true;
                    dateTimePickerBirthdate.Value = student.Birthdate.Value;
                    textBoxAmountChildren.Text = student.AmountChildren.ToString();
                    var elem = db.StudyForms.FirstOrDefault(s => s.Id == student.IdStudyForm).Name;
                    comboBoxTeachers.SelectedIndex = comboBoxTeachers.Items.IndexOf(elem);
                    textBoxName.Text = student.AmountScholarship.ToString();

                    label1.Text = "Редактирование";
                }
            }*/
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (student != null)
                {
                    EditStudent();
                }
                else
                {*/
                    AddNewGrWork();
               /* }

                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }*/
           
        }

        private void EditStudent()
        {
            /*using (UniversityContext db = new UniversityContext())
            {
                student.Surname = textBoxSurname.Text;
                student.FirstName = textBoxFirstName.Text;
                student.Patronymic = textBoxPatronymic.Text;
                student.CreditBookNumber = int.Parse(textBoxCreditBookNumber.Text);
                student.Gender = radioButtonMale.Checked == true ? radioButtonMale.Text : radioButtonFemale.Text;
                student.Birthdate = dateTimePickerBirthdate.Value;
                student.AmountChildren = int.Parse(textBoxAmountChildren.Text);
                student.IdStudyForm = db.StudyForms.Where(s => s.Name == comboBoxTeachers.Text).FirstOrDefault().Id;
                student.AmountScholarship = decimal.Parse(textBoxName.Text);
                student.IdGroupStudents = Parent.IdGroup;

                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }*/
        }

        private void AddNewGrWork()
        {
            using (UniversityContext db = new UniversityContext())
            {
                GraduateWork graduateWork = new GraduateWork();
                graduateWork.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                graduateWork.IdTeacher = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.Text).FirstOrDefault().Id;
                graduateWork.Name = textBoxName.Text;

                db.GraduateWorks.Add(graduateWork);
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            GrWork grWork = new GrWork(Parent, 1);
            grWork.Location = new Point(250, 49);
            Parent.Controls.Add(grWork);
            Parent.ChildElem = grWork;
        }
    }
}
