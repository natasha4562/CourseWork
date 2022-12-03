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
    public partial class SubjectsAll : UserControl
    {
        public Form1 Parent { get; set; }
        private List<int> listIdSubjects = new List<int>();
        public SubjectsAll(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            dataGridViewSubjects.ContextMenuStrip = contextMenuStrip1;
            LoadSubject();
        }

        private void LoadSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var sub = db.Subjects.OrderBy(s => s.Semester).ToList();

                for (int i = 0; i < sub.Count; i++)
                {
                    dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                        db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                        db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name);
                    listIdSubjects.Add(sub[i].Id);
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Faculties_1 faculties = new Faculties_1(Parent);
            faculties.Location = new Point(250, 49);
            Parent.Controls.Add(faculties);
            Parent.ChildElem = faculties;
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            SubjectAdd subject = new SubjectAdd(Parent);
            subject.Location = new Point(250, 49);
            Parent.Controls.Add(subject);
            Parent.ChildElem = subject;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = listIdSubjects[dataGridViewSubjects.CurrentCell.RowIndex];
                var sub = db.Subjects.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                SubjectAdd subject = new SubjectAdd(Parent, sub);
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

                    db.Subjects.Remove(db.Subjects.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewSubjects.Rows.RemoveAt(listIdSubjects.IndexOf(id));
                    listIdSubjects.RemoveAt(listIdSubjects.IndexOf(id));
                }
            }
        }
    }
}
