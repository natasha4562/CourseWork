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
        private int numForm;
        public DepOrSpec(Form1 f, int num)
        {
            InitializeComponent();
            Parent = f;
            numForm = num;

            LoadInfo();
        }

        private void LoadInfo()
        {
            if(numForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).ToList();
                    for (int i = 0; i < dep.Count; i++)
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
                        label.ForeColor = SystemColors.ControlDark;
                        label.Location = new Point(22, i * 38 + 90);
                        label.Name = dep[i].Id.ToString();
                        label.Size = new Size(250, 38);
                        label.Text = dep[i].Name;
                        this.Controls.Add(label);
                    }
                    labelName.Text = "КАФЕДРЫ";
                }
            }
            if(numForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                    var specs = db.Specialities.Where(s => dep.Contains(s.IdDepartment ?? 0)).ToList();
                    for (int i = 0; i < specs.Count; i++)
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
                        label.ForeColor = SystemColors.ControlDark;
                        label.Location = new Point(22, i * 38 + 90);
                        label.Name = specs[i].Id.ToString();
                        label.Size = new Size(250, 38);
                        label.Text = specs[i].Name;
                        this.Controls.Add(label);
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
    }
}
