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
    public partial class Groups : UserControl
    {
        public Form1 Parent { get; set; }
        public Groups(Form1 f)
        {
            InitializeComponent();
            Parent = f;

            using (UniversityContext db = new UniversityContext())
            {
                var groups = db.GroupStudents.Where(g => g.IdSpeciality == Parent.IdSpeciality).ToList();
                for (int i = 0; i < groups.Count; i++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
                    label.ForeColor = SystemColors.ControlDark;
                    label.Location = new Point(22, i * 38 + 90);
                    label.Name = groups[i].Id.ToString();
                    label.Size = new Size(250, 38);
                    label.Text = groups[i].Number;
                    label.Click += new System.EventHandler(this.labelGr_Click);
                    label.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
                    label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
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

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Specialties specialties = new Specialties(Parent);
            specialties.Location = new Point(250, 49);
            Parent.Controls.Add(specialties);
            Parent.ChildElem = specialties;
        }

        private void labelGr_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Students students = new Students(Parent);
            students.Location = new Point(250, 49);
            Parent.Controls.Add(students);
            Parent.ChildElem = students;
        }
    }
}
