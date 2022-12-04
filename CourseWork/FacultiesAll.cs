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
    public partial class FacultiesAll : UserControl
    {
        public Form1 Parent { get; set; }
        private List<int> listIdFaculties = new List<int>();
        public FacultiesAll(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            dataGridViewFaculties.ContextMenuStrip = contextMenuStrip1;
            LoadFaculties();
        }

        private void LoadFaculties()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var faculties = db.Faculties.ToList();
                for(int i = 0; i < faculties.Count; i++)
                {
                    dataGridViewFaculties.Rows.Add(faculties[i].Name);
                    listIdFaculties.Add(faculties[i].Id);
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

            FacultyAdd faculty = new FacultyAdd(Parent);
            faculty.Location = new Point(250, 49);
            Parent.Controls.Add(faculty);
            Parent.ChildElem = faculty;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = listIdFaculties[dataGridViewFaculties.CurrentCell.RowIndex];
                var fa = db.Faculties.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                FacultyAdd faculty = new FacultyAdd(Parent, fa);
                faculty.Location = new Point(250, 49);
                Parent.Controls.Add(faculty);
                Parent.ChildElem = faculty;
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
                    int id = listIdFaculties[dataGridViewFaculties.CurrentCell.RowIndex];

                    db.Faculties.Remove(db.Faculties.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewFaculties.Rows.RemoveAt(listIdFaculties.IndexOf(id));
                    listIdFaculties.RemoveAt(listIdFaculties.IndexOf(id));
                }
            }
        }
    }
}
