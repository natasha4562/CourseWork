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
    public partial class StudentAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private Student student;

        public StudentAdd(Form1 f, Student st = null)
        {
            InitializeComponent();
            Parent = f;
            student = st;
            LoadComboboxFormStudy();
            EditVersion();
        }

        private void LoadComboboxFormStudy()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var list = db.StudyForms.Select(s => s.Name).ToList();

                for(int i = 0; i < list.Count; i++)
                {
                    comboBoxStudyForm.Items.Add(list[i]);
                }
                comboBoxStudyForm.SelectedIndex = 0;
                radioButtonMale.Checked = true;
            }
        }

        private void EditVersion()
        {
            if(student != null)
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
                    comboBoxStudyForm.SelectedIndex = comboBoxStudyForm.Items.IndexOf(elem);
                    textBoxAmountScholarship.Text = student.AmountScholarship.ToString();

                    label1.Text = "Редактирование";
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (student != null)
                {
                    EditStudent();
                }
                else
                {
                    AddNewStudent();
                }

                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
        }

        private void EditStudent()
        {
            using (UniversityContext db = new UniversityContext())
            {
                student.Surname = textBoxSurname.Text;
                student.FirstName = textBoxFirstName.Text;
                student.Patronymic = textBoxPatronymic.Text;
                student.CreditBookNumber = int.Parse(textBoxCreditBookNumber.Text);
                student.Gender = radioButtonMale.Checked == true ? radioButtonMale.Text : radioButtonFemale.Text;
                student.Birthdate = dateTimePickerBirthdate.Value;
                student.AmountChildren = int.Parse(textBoxAmountChildren.Text);
                student.IdStudyForm = db.StudyForms.Where(s => s.Name == comboBoxStudyForm.Text).FirstOrDefault().Id;
                student.AmountScholarship = decimal.Parse(textBoxAmountScholarship.Text);
                student.IdGroupStudents = Parent.IdGroup;

                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void AddNewStudent()
        {
            using (UniversityContext db = new UniversityContext())
            {
                Student student1 = new Student();
                student1.Surname = textBoxSurname.Text;
                student1.FirstName = textBoxFirstName.Text;
                student1.Patronymic = textBoxPatronymic.Text;
                student1.CreditBookNumber = int.Parse(textBoxCreditBookNumber.Text);
                student1.Gender = radioButtonMale.Checked == true ? radioButtonMale.Text : radioButtonFemale.Text;
                student1.Birthdate = dateTimePickerBirthdate.Value;
                student1.AmountChildren = int.Parse(textBoxAmountChildren.Text);
                student1.IdStudyForm = db.StudyForms.Where(s => s.Name == comboBoxStudyForm.Text).FirstOrDefault().Id;
                student1.AmountScholarship = decimal.Parse(textBoxAmountScholarship.Text);
                student1.IdGroupStudents = Parent.IdGroup;

                db.Students.Add(student1);
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            Students student1 = new Students(Parent);
            student1.Location = new Point(250, 49);
            Parent.Controls.Add(student1);
            Parent.ChildElem = student1;
        }
    }
}
