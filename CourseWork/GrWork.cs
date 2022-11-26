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
        public GrWork(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadGrWork();
        }

        private void LoadGrWork()
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
