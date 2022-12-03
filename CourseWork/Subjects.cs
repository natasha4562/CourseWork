using CourseWork.ControlsAdd;
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
        private int elemForm;
        private List<int> listIdSubjects = new List<int>();
        public Subjects(Form1 f, int _num)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            dataGridViewSubjects.ContextMenuStrip = contextMenuStrip1;
            LoadSubject();
        }

        private void LoadSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    var ds = db.DistributionSubjects.Where(d => d.IdTeacher == Parent.IdTeacher).Select(d => d.IdSubject).ToList();
                    var sub = db.Subjects.Where(s => ds.Contains(s.Id)).OrderBy(s => s.Semester).ThenBy(s => s.Name).ToList();

                    for (int i = 0; i < sub.Count; i++)
                    {
                        var gs = db.DistributionSubjects.Where(d => d.IdSubject == sub[i].Id).FirstOrDefault();

                        dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                            db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                            db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name,
                            db.GroupStudents.Where(g => g.Id == gs.IdGroupStudents).FirstOrDefault().Number);
                        listIdSubjects.Add(gs.Id);
                    }
                }
                if(elemForm == 2)
                {

                    dataGridViewSubjects.Columns[dataGridViewSubjects.Columns.Count - 1].HeaderText = "Преподаватель";

                    var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                    var sub = db.Subjects.Where(s => ds.Contains(s.Id)).OrderBy(s => s.Semester).ThenBy(s => s.Name).ToList();

                    for (int i = 0; i < sub.Count; i++)
                    {
                        var te = db.DistributionSubjects.Where(d => d.IdSubject == sub[i].Id).FirstOrDefault();
                        var teach = db.Teachers.Where(t => t.Id == te.IdTeacher).FirstOrDefault();

                        dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                            db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                            db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name,
                            teach.Surname + " " + teach.FirstName + " " + teach.Patronymic);
                        listIdSubjects.Add(te.Id);
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

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            DistributionSubjectAdd subject = new DistributionSubjectAdd(Parent, elemForm);
            subject.Location = new Point(250, 49);
            Parent.Controls.Add(subject);
            Parent.ChildElem = subject;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = listIdSubjects[dataGridViewSubjects.CurrentCell.RowIndex];
                var sub = db.DistributionSubjects.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                DistributionSubjectAdd subject = new DistributionSubjectAdd(Parent, elemForm, sub);
                subject.Location = new Point(250, 49);
                Parent.Controls.Add(subject);
                Parent.ChildElem = subject;
            }
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить данную запись?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    int id = listIdSubjects[dataGridViewSubjects.CurrentCell.RowIndex];

                    db.DistributionSubjects.Remove(db.DistributionSubjects.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewSubjects.Rows.RemoveAt(listIdSubjects.IndexOf(id));
                    listIdSubjects.RemoveAt(listIdSubjects.IndexOf(id));
                }
            }
        }
    }
}
