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
    public partial class GraduateStudents : UserControl
    {
        public Form1 Parent { get; set; }
        private List<int> listIdGrStudents = new List<int>();
        public GraduateStudents(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            dataGridViewTeachers.ContextMenuStrip = contextMenuStrip1;
            LoadGrStudents();
        }

        void LoadGrStudents()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var d = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var teachs = db.GraduateSchools.Select(g => g.IdTeacherNavigation).Where(g => d.Contains(g.IdDepartment ?? 0)).ToList();

                for (int i = 0; i < teachs.Count; i++)
                {
                    dataGridViewTeachers.Rows.Add(teachs[i].Surname, teachs[i].FirstName, teachs[i].Patronymic, db.Posts.Where(p => p.Id == teachs[i].IdPost).FirstOrDefault().Name, teachs[i].Gender,
                        teachs[i].Birthdate.Value.ToString("dd.MM.yyyy"), teachs[i].AmountChildren, teachs[i].Salary);
                    listIdGrStudents.Add(teachs[i].Id);
                }
            }
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            GraduateStudentAdd graduateStudents = new GraduateStudentAdd(Parent);
            graduateStudents.Location = new Point(250, 49);
            Parent.Controls.Add(graduateStudents);
            Parent.ChildElem = graduateStudents;
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
                    int id = listIdGrStudents[dataGridViewTeachers.CurrentCell.RowIndex];

                    db.GraduateSchools.Remove(db.GraduateSchools.Where(g => g.IdTeacher == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewTeachers.Rows.RemoveAt(listIdGrStudents.IndexOf(id));
                    listIdGrStudents.RemoveAt(listIdGrStudents.IndexOf(id));
                }
            }
        }
    }
}
