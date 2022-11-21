using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Groups : UserControl
    {
        public Form1 Parent { get; set; }
        public Groups(Form1 f)
        {
            InitializeComponent();
            Parent = f;
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
