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
    public partial class DepOrSpec : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        private List<int> listIdDepOrSpec = new List<int>();
        public DepOrSpec(Form1 f, int num)
        {
            InitializeComponent();
            Parent = f;
            elemForm = num;
            dataGridViewDepOrSpec.ContextMenuStrip = contextMenuStrip1;
            LoadInfo();
        }

        private void LoadInfo()
        {
            if(elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).ToList();
                    for (int i = 0; i < dep.Count; i++)
                    {
                        dataGridViewDepOrSpec.Rows.Add(dep[i].Name);
                        listIdDepOrSpec.Add(dep[i].Id);
                    }
                    labelName.Text = "КАФЕДРЫ";
                    dataGridViewDepOrSpec.Columns.RemoveAt(dataGridViewDepOrSpec.Columns.Count - 1);
                }
            }
            if(elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                    var specs = db.Specialities.Where(s => dep.Contains(s.IdDepartment ?? 0)).ToList();
                    for (int i = 0; i < specs.Count; i++)
                    {
                        var d = db.Departments.Where(d => d.Id == specs[i].IdDepartment).FirstOrDefault().Name;
                        dataGridViewDepOrSpec.Rows.Add(specs[i].Name, d);
                        listIdDepOrSpec.Add(specs[i].Id);
                    }
                    labelName.Text = "СПЕЦИАЛЬНОСТИ";
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Faculties_1 faculties_1 = new Faculties_1(Parent);
            faculties_1.Location = new Point(250, 49);
            Parent.Controls.Add(faculties_1);
            Parent.ChildElem = faculties_1;
        }

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            DepOrSpecAdd depOrSpec = new DepOrSpecAdd(Parent, elemForm);
            depOrSpec.Location = new Point(250, 49);
            Parent.Controls.Add(depOrSpec);
            Parent.ChildElem = depOrSpec;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    int id = listIdDepOrSpec[dataGridViewDepOrSpec.CurrentCell.RowIndex];
                    var sub = db.Departments.Where(s => s.Id == id).FirstOrDefault();
                    Parent.Controls.Remove(this);

                    DepOrSpecAdd depOrSpec = new DepOrSpecAdd(Parent, elemForm, sub);
                    depOrSpec.Location = new Point(250, 49);
                    Parent.Controls.Add(depOrSpec);
                    Parent.ChildElem = depOrSpec;
                }
                if(elemForm == 2)
                {
                    int id = listIdDepOrSpec[dataGridViewDepOrSpec.CurrentCell.RowIndex];
                    var sp = db.Specialities.Where(s => s.Id == id).FirstOrDefault();
                    Parent.Controls.Remove(this);

                    DepOrSpecAdd depOrSpec = new DepOrSpecAdd(Parent, elemForm, null, sp);
                    depOrSpec.Location = new Point(250, 49);
                    Parent.Controls.Add(depOrSpec);
                    Parent.ChildElem = depOrSpec;
                }
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
                    int id = listIdDepOrSpec[dataGridViewDepOrSpec.CurrentCell.RowIndex];

                    if(elemForm == 1)
                    {
                        db.Departments.Remove(db.Departments.Where(s => s.Id == id).FirstOrDefault());
                        db.SaveChanges();
                    }
                    if(elemForm == 2)
                    {
                        db.Specialities.Remove(db.Specialities.Where(s => s.Id == id).FirstOrDefault());
                        db.SaveChanges();
                    }

                    dataGridViewDepOrSpec.Rows.RemoveAt(listIdDepOrSpec.IndexOf(id));
                    listIdDepOrSpec.RemoveAt(listIdDepOrSpec.IndexOf(id));
                }
            }
        }
    }
}
