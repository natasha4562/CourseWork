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
    public partial class Marks : UserControl
    {
        public Form1 Parent { get; set; }
        private int Semester;
        public Marks(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            comboBoxSemester.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxSemester.SelectedIndex = 0;
            comboBoxType.Items.AddRange(new string[] { "Семестр", "Экзамен", "Зачет" });
            comboBoxType.SelectedIndex = 0;

            /*using (UniversityContext db = new UniversityContext())
            {
                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).Where(s => s.Semester == Semester).ToList(); ;

                for (int i = 0; i < sub.Count; i++)
                {
                    comboBoxSubjects.Items.Add(sub[i].Name);
                }
            }
            comboBoxSubjects.SelectedIndex = 0;*/
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Students students = new Students(Parent);
            students.Location = new Point(250, 49);
            Parent.Controls.Add(students);
            Parent.ChildElem = students;
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewMarks.Rows.Clear();
            ReturnData();
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewMarks.Rows.Clear();
            Semester = int.Parse(comboBoxSemester.SelectedItem.ToString());
            comboBoxSubjects.Items.Clear();
            using (UniversityContext db = new UniversityContext())
            {
                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).Where(s => s.Semester == Semester).ToList(); ;

                for (int i = 0; i < sub.Count; i++)
                {
                    comboBoxSubjects.Items.Add(sub[i].Name);
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewMarks.Rows.Clear();
            ReturnData();
        }

        private void ReturnData()
        {
            Semester = int.Parse(comboBoxSemester.SelectedItem.ToString());
            if (comboBoxSubjects.SelectedItem == null || comboBoxType.SelectedIndex == null)
                return;
            var subject = comboBoxSubjects.SelectedItem.ToString();
            var comboBoxTypeIndex = comboBoxType.SelectedIndex;
            using (UniversityContext db = new UniversityContext())
            {
                dataGridViewMarks.Rows.Clear();
                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).Where(s => s.Semester == Semester && s.Name == subject).FirstOrDefault();
                List<Mark> marks = new List<Mark>();
                List<MarkOfSubject> marks1 = new List<MarkOfSubject>();
                if (sub != null)
                {
                    switch (comboBoxTypeIndex)
                    {
                        case 0:
                            {
                                marks = db.Marks.Where(d => d.IdSubject == sub.Id).Include(m => m.IdStudentNavigation).ToList();
                                for(var i = 0; i< marks.Count; i++)
                                {
                                    dataGridViewMarks.Rows.Add(marks[i].IdStudentNavigation.FirstName + " " +
                                        marks[i].IdStudentNavigation.Surname + " " + marks[i].IdStudentNavigation.Patronymic,
                                        marks[i].Mark1,
                                        marks[i].DateReceiving.Value.ToString("dd.MM.yyyy"),
                                        " "

                                        );

                                }
                                break;
                            }
                        case 1:
                            {
                                marks1 = db.MarkOfSubjects.Include(m => m.IdStatusOfExamNavigation).Where(d => d.IdSubject == sub.Id && (d.IsExam ?? false)).Include(m => m.IdStudentNavigation).ToList();
                                for (var i = 0; i < marks1.Count; i++)
                                {
                                    dataGridViewMarks.Rows.Add(marks1[i].IdStudentNavigation.FirstName + " " +
                                        marks1[i].IdStudentNavigation.Surname + " " + marks1[i].IdStudentNavigation.Patronymic,
                                        marks1[i].Mark,
                                        marks1[i].DateReceiving.Value.ToString("dd.MM.yyyy"),
                                        marks1[i].IdStatusOfExamNavigation.Status

                                        );
                                }
                                break;
                            }
                        case 2:
                            {
                                marks1 = db.MarkOfSubjects.Include(m => m.IdStatusOfExamNavigation).Where(d => d.IdSubject == sub.Id && !(d.IsExam ?? false)).Include(m => m.IdStudentNavigation).ToList();
                                for (var i = 0; i < marks1.Count; i++)
                                {
                                    dataGridViewMarks.Rows.Add(marks1[i].IdStudentNavigation.FirstName + " " +
                                        marks1[i].IdStudentNavigation.Surname + " " + marks1[i].IdStudentNavigation.Patronymic,
                                        marks1[i].Mark,
                                        marks1[i].DateReceiving.Value.ToString("dd.MM.yyyy"),
                                        marks1[i].IdStatusOfExamNavigation.Status

                                        );
                                }
                                break;
                            }
                    }
                    

                }
            }
        }
    }
}
