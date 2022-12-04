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
    public partial class GroupsSt : UserControl
    {
        public Form1 Parent { get; set; }
        private List<int> listIdGroups = new List<int>();
        public GroupsSt(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            dataGridViewGroups.ContextMenuStrip = contextMenuStrip1;
            LoadGroups();
        }

        private void LoadGroups()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var sp = db.Specialities.Where(s => dep.Contains(s.IdDepartment ?? 0)).Select(s => s.Id).ToList();
                var groups = db.GroupStudents.Where(g => sp.Contains(g.IdSpeciality ?? 0)).ToList();
                for(int i = 0; i < groups.Count; i++)
                {
                    var spec = db.Specialities.Where(s => s.Id == groups[i].IdSpeciality).FirstOrDefault().Name;
                    dataGridViewGroups.Rows.Add(groups[i].Number, groups[i].Course, groups[i].Semester, spec);
                    listIdGroups.Add(groups[i].Id);
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

            GroupsAdd groups = new GroupsAdd(Parent);
            groups.Location = new Point(250, 49);
            Parent.Controls.Add(groups);
            Parent.ChildElem = groups;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                int id = listIdGroups[dataGridViewGroups.CurrentCell.RowIndex];
                var gs = db.GroupStudents.Where(s => s.Id == id).FirstOrDefault();

                Parent.Controls.Remove(this);

                GroupsAdd groups = new GroupsAdd(Parent, gs);
                groups.Location = new Point(250, 49);
                Parent.Controls.Add(groups);
                Parent.ChildElem = groups;
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
                    int id = listIdGroups[dataGridViewGroups.CurrentCell.RowIndex];

                    db.GroupStudents.Remove(db.GroupStudents.Where(s => s.Id == id).FirstOrDefault());
                    db.SaveChanges();

                    dataGridViewGroups.Rows.RemoveAt(listIdGroups.IndexOf(id));
                    listIdGroups.RemoveAt(listIdGroups
                        .IndexOf(id));
                }
            }
        }
    }
}
