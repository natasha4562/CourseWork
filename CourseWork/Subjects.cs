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
        public Subjects(Form1 f, int _id)
        {
            InitializeComponent();
            Parent = f;
            idTeacher = _id;
            LoadSubject();
        }

        private void LoadSubject()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var ds = db.DistributionSubjects.Where(d => d.IdTeacher == idTeacher).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).OrderBy(s => s.Name).ToList();

                for(int i = 0; i < sub.Count; i++)
                {
                    dataGridViewSubjects.Rows.Add(sub[i].Name, sub[i].AmountHours, sub[i].Course, sub[i].Semester,
                        db.TypeOccupations.Where(t => t.Id == sub[i].IdTypeOccupation).FirstOrDefault().Name,
                        db.FormControls.Where(f => f.Id == sub[i].IdFormControl).FirstOrDefault().Name);
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            TeachersInfo teachersInfo = new TeachersInfo(Parent);
            teachersInfo.Location = new Point(250, 49);
            Parent.Controls.Add(teachersInfo);
            Parent.ChildElem = teachersInfo;
        }
    }
}
