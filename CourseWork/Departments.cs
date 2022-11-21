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
    public partial class Departments : UserControl
    {
        public Form1 Parent { get; set; }
        public Departments(Form1 f)
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

        private void labelDep_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            TeachersInfo teachers = new TeachersInfo(Parent);
            teachers.Location = new Point(250, 49);
            Parent.Controls.Add(teachers);
            Parent.ChildElem = teachers;
        }
    }
}
