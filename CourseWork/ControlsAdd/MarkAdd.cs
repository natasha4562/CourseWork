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
    public partial class MarkAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private Mark mark;
        private MarkOfSubject markOfSubject;
        public MarkAdd(Form1 f, Mark _m = null, MarkOfSubject _ms = null)
        {
            InitializeComponent();
            Parent = f;
            mark = _m;
            markOfSubject = _ms;
            LoadCombobox();
            EditVersion();
        }

        private void EditVersion()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(mark != null)
                {
                    var st = db.Students.Where(s => s.Id == mark.IdStudent).FirstOrDefault();
                    comboBoxStudents.SelectedIndex = comboBoxStudents.Items.IndexOf(st.Surname + " " + st.FirstName + " " + st.Patronymic);
                    comboBoxSubjects.SelectedIndex = comboBoxSubjects.Items.IndexOf(db.Subjects.Where(s => s.Id == mark.IdSubject).FirstOrDefault().Name);
                    comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf("Семестр");
                    comboBoxMarks.SelectedIndex = comboBoxMarks.Items.IndexOf(mark.Mark1.ToString());
                    dateTimePicker1.Value = mark.DateReceiving.Value;

                    label1.Text = "Редактирование";
                }

                if (markOfSubject != null)
                {
                    var st = db.Students.Where(s => s.Id == markOfSubject.IdStudent).FirstOrDefault();
                    comboBoxStudents.SelectedIndex = comboBoxStudents.Items.IndexOf(st.Surname + " " + st.FirstName + " " + st.Patronymic);
                    comboBoxSubjects.SelectedIndex = comboBoxSubjects.Items.IndexOf(db.Subjects.Where(s => s.Id == markOfSubject.IdSubject).FirstOrDefault().Name);
                    var isExam = markOfSubject.IsExam == true ? "Экзамен" : "Зачет";
                    comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(isExam);
                    comboBoxMarks.SelectedIndex = comboBoxMarks.Items.IndexOf(markOfSubject.Mark.ToString());
                    dateTimePicker1.Value = markOfSubject.DateReceiving.Value;
                    comboBoxStatus.SelectedIndex = comboBoxStatus.Items.IndexOf(db.StatusOfExams.Where(s => s.Id == markOfSubject.IdStatusOfExam).FirstOrDefault().Status);

                    label1.Text = "Редактирование";
                }
            }
        }

        private void LoadCombobox()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var students = db.Students.Where(s => s.IdGroupStudents == Parent.IdGroup).ToList();
                for(int i = 0; i < students.Count; i++)
                {
                    comboBoxStudents.Items.Add(students[i].Surname + " " + students[i].FirstName + " " + students[i].Patronymic);
                }

                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var subjects = db.Subjects.Where(s => ds.Contains(s.Id)).ToList();
                for (int i = 0; i < subjects.Count; i++)
                {
                    comboBoxSubjects.Items.Add(subjects[i].Name);
                }

                comboBoxType.Items.AddRange(new string[] { "Семестр", "Экзамен", "Зачет" });
                comboBoxMarks.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

                comboBoxStudents.SelectedIndex = 0;
                comboBoxSubjects.SelectedIndex = 0;
                comboBoxType.SelectedIndex = 0;
                comboBoxMarks.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (mark != null)
                {
                    EditMark();
                }
                else if (markOfSubject != null)
                {
                    EditMarkOfSubject();
                }
                else
                {
                    AddNewMark();
                }
                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void AddNewMark()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(comboBoxType.Text == "Семестр")
                {
                    Mark mark1 = new Mark();
                    mark1.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                    mark1.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                    mark1.Mark1 = int.Parse(comboBoxMarks.Text);
                    mark1.DateReceiving = dateTimePicker1.Value;

                    db.Marks.Add(mark1);
                    db.SaveChanges();
                }
                else
                {
                    MarkOfSubject mark1 = new MarkOfSubject();
                    mark1.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                    mark1.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                    mark1.Mark = int.Parse(comboBoxMarks.Text);
                    mark1.DateReceiving = dateTimePicker1.Value;
                    mark1.IsExam = comboBoxMarks.Text == "Экзамен" ? true : false;
                    mark1.IdStatusOfExam = db.StatusOfExams.Where(s => s.Status == comboBoxStatus.Text).FirstOrDefault().Id;

                    db.MarkOfSubjects.Add(mark1);
                    db.SaveChanges();
                }
            }
        }

        private void EditMarkOfSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                markOfSubject.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                markOfSubject.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                markOfSubject.Mark = int.Parse(comboBoxMarks.Text);
                markOfSubject.DateReceiving = dateTimePicker1.Value;
                markOfSubject.IsExam = comboBoxMarks.Text == "Экзамен" ? true : false;
                markOfSubject.IdStatusOfExam = db.StatusOfExams.Where(s => s.Status == comboBoxStatus.Text).FirstOrDefault().Id;

                db.Entry(markOfSubject).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void EditMark()
        {
            using (UniversityContext db = new UniversityContext())
            {
                mark.IdStudent = db.Students.Where(s => s.Surname + " " + s.FirstName + " " + s.Patronymic == comboBoxStudents.Text).FirstOrDefault().Id;
                mark.IdSubject = db.Subjects.Where(s => s.Name == comboBoxSubjects.Text).FirstOrDefault().Id;
                mark.Mark1 = int.Parse(comboBoxMarks.Text);
                mark.DateReceiving = dateTimePicker1.Value;

                db.Entry(mark).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            Marks marks = new Marks(Parent);
            marks.Location = new Point(250, 49);
            Parent.Controls.Add(marks);
            Parent.ChildElem = marks;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.Text == "Семестр")
            {
                comboBoxStatus.Items.Clear();
            }
            else
            {
                if (comboBoxStatus.Text != "") return;
                using (UniversityContext db = new UniversityContext())
                {
                    var status = db.StatusOfExams.ToList();
                    for (int i = 0; i < status.Count; i++)
                    {
                        comboBoxStatus.Items.Add(status[i].Status);
                    }

                    comboBoxStatus.SelectedIndex = 0;
                }
            }
        }
    }
}
