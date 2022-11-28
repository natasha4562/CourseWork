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
    public partial class Subjects : UserControl
    {
        public Form1 Parent { get; set; }
        private int idTeacher;
        private int elemForm;
        public Subjects(Form1 f, int _id, int _num)
        {
            InitializeComponent();
            Parent = f;
            idTeacher = _id;
            elemForm = _num;
            LoadSubject();
        }

        private void LoadSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    var ds = db.DistributionSubjects.Where(d => d.IdTeacher == idTeacher).Select(d => d.IdSubject).ToList();
                    var sub = db.Subjects.Where(s => ds.Contains(s.Id)).OrderBy(s => s.Semester).ThenBy(s => s.Name).ToList();

                    for (int i = 0; i < sub.Count; i++)
                    {
                        var gs = db.DistributionSubjects.Where(d => d.IdSubject == sub[i].Id).FirstOrDefault().IdGroupStudents;

                        dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                            db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                            db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name,
                            db.GroupStudents.Where(g => g.Id == gs).FirstOrDefault().Number);
                    }
                }
                if(elemForm == 2)
                {

                    dataGridViewSubjects.Columns[dataGridViewSubjects.Columns.Count - 1].HeaderText = "Преподаватель";

                    var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                    var sub = db.Subjects.Where(s => ds.Contains(s.Id)).OrderBy(s => s.Semester).ThenBy(s => s.Name).ToList();

                    for (int i = 0; i < sub.Count; i++)
                    {
                        var idTeach = db.DistributionSubjects.Where(d => d.IdSubject == sub[i].Id).FirstOrDefault().IdTeacher;
                        var teach = db.Teachers.Where(t => t.Id == idTeach).FirstOrDefault();

                        dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                            db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                            db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name,
                            teach.Surname + " " + teach.FirstName + " " + teach.Patronymic);
                    }
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            if(elemForm == 1)
            {
                TeachersInfo teachersInfo = new TeachersInfo(Parent);
                teachersInfo.Location = new Point(250, 49);
                Parent.Controls.Add(teachersInfo);
                Parent.ChildElem = teachersInfo;
            }
            if(elemForm == 2)
            {
                Students students = new Students(Parent);
                students.Location = new Point(250, 49);
                Parent.Controls.Add(students);
                Parent.ChildElem = students;
            }
        }
    }
}
