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
    public partial class SubjectAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private Subject subject;

        public SubjectAdd(Form1 f, Subject _sub = null)
        {
            InitializeComponent();
            Parent = f;
            subject = _sub;
            LoadCombobox();
            EditVersion();
        }

        private void LoadCombobox()
        {
            using (UniversityContext db = new UniversityContext())
            {
                comboBoxSemester.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
                comboBoxSemester.SelectedIndex = 0;

                var list = db.TypeOccupations.Select(s => s.Name).ToList();
                for(int i = 0; i < list.Count; i++)
                {
                    comboBoxTypeOccupation.Items.Add(list[i]);
                }
                comboBoxTypeOccupation.SelectedIndex = 0;

                var list2 = db.FormControls.Select(f => f.Name).ToList();
                for (int i = 0; i < list2.Count; i++)
                {
                    comboBoxFormControl.Items.Add(list2[i]);
                }
                comboBoxFormControl.SelectedIndex = 0;
            }
        }

        private void EditVersion()
        {
            if(subject != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    textBoxName.Text = subject.Name;
                    textBoxAmountHours.Text = subject.AmountHours.ToString();
                    comboBoxSemester.SelectedIndex = comboBoxSemester.Items.IndexOf(subject.Semester.ToString());
                    var elem = db.TypeOccupations.Where(t => t.Id == subject.IdTypeOccupation).FirstOrDefault().Name;
                    comboBoxTypeOccupation.SelectedIndex = comboBoxTypeOccupation.Items.IndexOf(elem);
                    var elem2 = db.FormControls.Where(f => f.Id == subject.IdFormControl).FirstOrDefault().Name;
                    comboBoxFormControl.SelectedIndex = comboBoxFormControl.Items.IndexOf(elem2);

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
                if (subject != null)
                {
                    EditStudent();
                }
                else
                {
                    AddNewSubject();
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
                subject.Name = textBoxName.Text;
                subject.AmountHours = int.Parse(textBoxAmountHours.Text);
                int num = int.Parse(comboBoxSemester.Text);
                subject.Course = num / 2 + num % 2;
                subject.Semester = num;
                subject.IdTypeOccupation = db.TypeOccupations.Where(t => t.Name == comboBoxTypeOccupation.Text).FirstOrDefault().Id;
                subject.IdFormControl = db.FormControls.Where(f => f.Name == comboBoxFormControl.Text).FirstOrDefault().Id;

                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void AddNewSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                Subject subject1 = new Subject();
                subject1.Name = textBoxName.Text;
                subject1.AmountHours = int.Parse(textBoxAmountHours.Text);
                int num = int.Parse(comboBoxSemester.Text);
                subject1.Course = num / 2 + num % 2;
                subject1.Semester = num;
                subject1.IdTypeOccupation = db.TypeOccupations.Where(t => t.Name == comboBoxTypeOccupation.Text).FirstOrDefault().Id;
                subject1.IdFormControl = db.FormControls.Where(f => f.Name == comboBoxFormControl.Text).FirstOrDefault().Id;

                db.Subjects.Add(subject1);
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            SubjectsAll subjects = new SubjectsAll(Parent);
            subjects.Location = new Point(250, 49);
            Parent.Controls.Add(subjects);
            Parent.ChildElem = subjects;
        }
    }
}
