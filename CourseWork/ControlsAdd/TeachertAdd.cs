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
    public partial class TeachertAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private Teacher teacher;

        public TeachertAdd(Form1 f, Teacher _teach = null)
        {
            InitializeComponent();
            Parent = f;
            teacher = _teach;
            LoadComboboxPost();
            EditVersion();
        }

        private void LoadComboboxPost()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var list = db.Posts.Select(p => p.Name).ToList();

                for(int i = 0; i < list.Count; i++)
                {
                    comboBoxPost.Items.Add(list[i]);
                }
                comboBoxPost.SelectedIndex = 0;
                radioButtonMale.Checked = true;
            }
        }

        private void EditVersion()
        {
            if(teacher != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    textBoxSurname.Text = teacher.Surname;
                    textBoxFirstName.Text = teacher.FirstName;
                    textBoxPatronymic.Text = teacher.Patronymic;
                    if (teacher.Gender == "м") radioButtonMale.Checked = true;
                    else if (teacher.Gender == "ж") radioButtonFemale.Checked = true;
                    dateTimePickerBirthdate.Value = teacher.Birthdate.Value;
                    textBoxAmountChildren.Text = teacher.AmountChildren.ToString();
                    textBoxSalary.Text = teacher.Salary.ToString();
                    var elem = db.Posts.FirstOrDefault(s => s.Id == teacher.IdPost).Name;
                    comboBoxPost.SelectedIndex = comboBoxPost.Items.IndexOf(elem);

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
                if (teacher != null)
                {
                    EditTeacher();
                }
                else
                {
                    AddNewTeacher();
                }

                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
        }

        private void EditTeacher()
        {
            using (UniversityContext db = new UniversityContext())
            {
                teacher.Surname = textBoxSurname.Text;
                teacher.FirstName = textBoxFirstName.Text;
                teacher.Patronymic = textBoxPatronymic.Text;
                teacher.Gender = radioButtonMale.Checked == true ? radioButtonMale.Text : radioButtonFemale.Text;
                teacher.Birthdate = dateTimePickerBirthdate.Value;
                teacher.AmountChildren = int.Parse(textBoxAmountChildren.Text);
                teacher.Salary = decimal.Parse(textBoxSalary.Text);
                teacher.IdPost = db.Posts.Where(s => s.Name == comboBoxPost.Text).FirstOrDefault().Id;
                teacher.IdDepartment = Parent.IdDepartnemt;

                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void AddNewTeacher()
        {
            using (UniversityContext db = new UniversityContext())
            {
                Teacher teacher1 = new Teacher();
                teacher1.Surname = textBoxSurname.Text;
                teacher1.FirstName = textBoxFirstName.Text;
                teacher1.Patronymic = textBoxPatronymic.Text;
                teacher1.Gender = radioButtonMale.Checked == true ? radioButtonMale.Text : radioButtonFemale.Text;
                teacher1.Birthdate = dateTimePickerBirthdate.Value;
                teacher1.AmountChildren = int.Parse(textBoxAmountChildren.Text);
                teacher1.Salary = decimal.Parse(textBoxSalary.Text);
                teacher1.IdPost = db.Posts.Where(s => s.Name == comboBoxPost.Text).FirstOrDefault().Id;
                teacher1.IdDepartment = Parent.IdDepartnemt;

                db.Teachers.Add(teacher1);
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            TeachersInfo teachers = new TeachersInfo(Parent);
            teachers.Location = new Point(250, 49);
            Parent.Controls.Add(teachers);
            Parent.ChildElem = teachers;
        }
    }
}
