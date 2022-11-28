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
        private int elemForm;
        private GraduateWork graduateW;

        public GraduateWorkAdd(Form1 f, int _num, GraduateWork _g = null)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            graduateW = _g;
            EditVersion();
        }

        private void LoadComboboxStudents()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                    var sp = db.Specialities.Where(s => dep.Contains(s.IdDepartment ?? 0)).Select(d => d.Id).ToList();
                    var gr = db.GroupStudents.Where(g => sp.Contains(g.IdSpeciality ?? 0)).Select(d => d.Id).ToList();
                    var st = db.Students.Where(s => gr.Contains(s.IdGroupStudents ?? 0)).ToList();

                    for (int i = 0; i < st.Count; i++)
                    {
                        if (!db.GraduateWorks.Where(g => g.IdStudent == st[i].Id).Any())
                            comboBoxStudents.Items.Add(st[i].Surname + " " + st[i].FirstName + " " + st[i].Patronymic);
                    }
                }
                if(elemForm == 2)
                {
                    var st = db.Students.Where(s => s.IdGroupStudents == Parent.IdGroup).ToList();

                    for (int i = 0; i < st.Count; i++)
                    {
                        if (!db.GraduateWorks.Where(g => g.IdStudent == st[i].Id).Any())
                            comboBoxStudents.Items.Add(st[i].Surname + " " + st[i].FirstName + " " + st[i].Patronymic);
                    }
                }
                
                if (comboBoxStudents.Items.Count < 1)
                {
                    MessageBox.Show("У всех студентов есть дипломные работы!");
                    return;
                }

                comboBoxStudents.SelectedIndex = 0;
            }
        }

        private void LoadComboboxTeachers()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                    var teach = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault();

                    comboBoxTeachers.Items.Add(teach.Surname + " " + teach.FirstName + " " + teach.Patronymic);
                }
                if(elemForm == 2)
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                    var teach = db.Teachers.Where(t => dep.Contains(t.IdDepartment ?? 0)).ToList();

                    for (int i = 0; i < teach.Count; i++)
                    {
                        comboBoxTeachers.Items.Add(teach[i].Surname + " " + teach[i].FirstName + " " + teach[i].Patronymic);
                    }
                }
                
                if (comboBoxTeachers.Items.Count < 1)
                {
                    MessageBox.Show("На данном факультете нет преподавателей!");
                    return;
                }

                comboBoxTeachers.SelectedIndex = 0;
            }
        }

        private void EditVersion()
        {
            if(graduateW != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var student = db.Students.Where(s => s.Id == graduateW.IdStudent).FirstOrDefault();
                    var teacher = db.Teachers.Where(t => t.Id == graduateW.IdTeacher).FirstOrDefault();
                    comboBoxStudents.Items.Add(student.Surname + " " + student.FirstName + " " + student.Patronymic);
                    comboBoxTeachers.Items.Add(teacher.Surname + " " + teacher.FirstName + " " + teacher.Patronymic);
                    textBoxName.Text = graduateW.Name;

                    comboBoxStudents.SelectedIndex = 0;
                    comboBoxTeachers.SelectedIndex = 0;

                    label1.Text = "Редактирование";
                }
            }
            else
            {
                LoadComboboxStudents();
                LoadComboboxTeachers();
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
                if (graduateW != null)
                {
                    EditStudent();
                }
                else
                {
                    AddNewGrWork();
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
                graduateW.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                graduateW.IdTeacher = db.Teachers.Where(t => t.Surname + " " + t.FirstName + " " + t.Patronymic == comboBoxTeachers.Text).FirstOrDefault().Id;
                graduateW.Name = textBoxName.Text;

                db.Entry(graduateW).State = EntityState.Modified;
                db.SaveChanges();
            }
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

            back();
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            GrWork grWork = new GrWork(Parent, elemForm);
            grWork.Location = new Point(250, 49);
            Parent.Controls.Add(grWork);
            Parent.ChildElem = grWork;
        }
    }
}
