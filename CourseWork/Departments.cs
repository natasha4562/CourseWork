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
    public partial class Departments : UserControl
    {
        public Form1 Parent { get; set; }
        public Departments(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadDepartments();
        }

        private void LoadDepartments()
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
                    label.Click += new EventHandler(this.labelDep_Click);
                    label.MouseLeave += new EventHandler(this.labelChahgeColor_MouseLeave);
                    label.MouseMove += new MouseEventHandler(this.labelChahgeColor_MouseMove);
                    this.Controls.Add(label);
                }
            }
        }

        private void labelChahgeColor_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Black;
        }

        private void labelChahgeColor_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = SystemColors.ControlDark;
        }

        private void labelDep_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            Parent.IdDepartnemt = int.Parse(label.Name);
            Parent.Controls.Remove(this);

            TeachersInfo teachers = new TeachersInfo(Parent);
            teachers.Location = new Point(250, 49);
            Parent.Controls.Add(teachers);
            Parent.ChildElem = teachers;
        }
    }
}
