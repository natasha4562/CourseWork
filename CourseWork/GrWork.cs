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

namespace CourseWork
{
    public partial class GrWork : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        public GrWork(Form1 f, int _num)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            LoadGrWork();
        }

        private void LoadGrWork()
        {
            if(elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var grworks = db.GraduateWorks.Where(g => g.IdTeacher == Parent.IdTeacher).ToList();
                    var teach = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault();
                    for (int i = 0; i < grworks.Count; i++)
                    {
                        var st = db.Students.Where(s => s.Id == grworks[i].IdStudent).FirstOrDefault();

                        dataGridViewGrWork.Rows.Add(st.Surname + " " + st.FirstName + " " + st.Patronymic, teach.Surname + " " + teach.FirstName + " " + teach.Patronymic, grworks[i].Name);
                    }
                }
            }
            if(elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var grworks = db.GraduateWorks.Include(g => g.IdStudentNavigation).Include(g => g.IdTeacherNavigation)
                        .Where(g => g.IdStudentNavigation.IdGroupStudents == Parent.IdGroup).ToList();
                    for (int i = 0; i < grworks.Count; i++)
                    {
                        dataGridViewGrWork.Rows.Add(grworks[i].IdStudentNavigation.Surname + " " + grworks[i].IdStudentNavigation.FirstName + " " + grworks[i].IdStudentNavigation.Patronymic,
                            grworks[i].IdTeacherNavigation.Surname + " " + grworks[i].IdTeacherNavigation.FirstName + " " + grworks[i].IdTeacherNavigation.Patronymic, grworks[i].Name);
                    }
                }
            }                       
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            if(elemForm == 1)
            {
                Parent.Controls.Remove(this);

                TeachersInfo teachersInfo = new TeachersInfo(Parent);
                teachersInfo.Location = new Point(250, 49);
                Parent.Controls.Add(teachersInfo);
                Parent.ChildElem = teachersInfo;
            }
            if(elemForm == 2)
            {
                Parent.Controls.Remove(this);

                Students students = new Students(Parent);
                students.Location = new Point(250, 49);
                Parent.Controls.Add(students);
                Parent.ChildElem = students;
            }
        }
    }
}
