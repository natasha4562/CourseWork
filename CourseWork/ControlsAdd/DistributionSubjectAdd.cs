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
    public partial class DistributionSubjectAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        private DistributionSubject distributionSubject;
        public DistributionSubjectAdd(Form1 f, int _num, DistributionSubject _ds = null)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            distributionSubject = _ds;
            LoadCombobox();
            EditVersion();
        }

        private void LoadCombobox()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var list = db.Subjects.Select(s => s.Name).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    comboBoxSubjects.Items.Add(list[i]);
                }

                if (elemForm == 1)
                {
                    var list2 = db.Teachers.Where(t => t.Id == Parent.IdTeacher).Select(t => t.Surname + " " + t.FirstName + " " + t.Patronymic).FirstOrDefault();
                    comboBoxTeachers.Items.Add(list2);

                    var list3 = db.GroupStudents.Select(s => s.Number).ToList();
                    for (int i = 0; i < list3.Count; i++)
                    {
                        comboBoxGroups.Items.Add(list3[i]);
                    }
                }
                if (elemForm == 2)
                {
                    var list2 = db.Teachers.Select(t => t.Surname + " " + t.FirstName + " " + t.Patronymic).ToList();
                    for (int i = 0; i < list2.Count; i++)
                    {
                        comboBoxTeachers.Items.Add(list2[i]);
                    }
                    var list3 = db.GroupStudents.Where(g => g.Id == Parent.IdGroup).Select(g => g.Number).FirstOrDefault();
                    comboBoxGroups.Items.Add(list3);
                }

                comboBoxSubjects.SelectedIndex = 0;
                comboBoxTeachers.SelectedIndex = 0;
                comboBoxGroups.SelectedIndex = 0;
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            Subjects subjects = new Subjects(Parent, elemForm);
            subjects.Location = new Point(250, 49);
            Parent.Controls.Add(subjects);
            Parent.ChildElem = subjects;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (distributionSubject != null)
                {
                    EditDistributionSubject();
                }
                else
                {
                    AddNewDistributionSubject();
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }            
            back();
        }

        private void EditVersion()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if (distributionSubject != null)
                {
                    var elem = db.Subjects.Where(s => s.Id == distributionSubject.IdSubject).FirstOrDefault().Name;
                    comboBoxSubjects.SelectedIndex = comboBoxSubjects.Items.IndexOf(elem);
                    var elem2 = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault();
                    comboBoxTeachers.SelectedIndex = comboBoxTeachers.Items.IndexOf(elem2.Surname + " " + elem2.FirstName + " " + elem2.Patronymic);
                    var elem3 = db.GroupStudents.Where(g => g.Id == distributionSubject.IdGroupStudents).FirstOrDefault().Number;
                    comboBoxGroups.SelectedIndex = comboBoxGroups.Items.IndexOf(elem3);

                    label1.Text = "Редактирование";
                }
            }
        }

        private void AddNewDistributionSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                DistributionSubject distributionSubject1 = new DistributionSubject();
                distributionSubject1.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                distributionSubject1.IdTeacher = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.Text).FirstOrDefault().Id;
                distributionSubject1.IdGroupStudents = db.GroupStudents.Where(g => g.Number == comboBoxGroups.Text).FirstOrDefault().Id;

                db.DistributionSubjects.Add(distributionSubject1);
                db.SaveChanges();
            }
        }

        private void EditDistributionSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                distributionSubject.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                distributionSubject.IdTeacher = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.Text).FirstOrDefault().Id;
                distributionSubject.IdGroupStudents = db.GroupStudents.Where(g => g.Number == comboBoxGroups.Text).FirstOrDefault().Id;

                db.Entry(distributionSubject).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
