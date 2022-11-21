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
    public partial class TeachersInfo : UserControl
    {
        public Form1 Parent { get; set; }
        public TeachersInfo(Form1 f)
        {
            InitializeComponent();
            Parent = f;
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Departments departments = new Departments(Parent);
            departments.Location = new Point(250, 49);
            Parent.Controls.Add(departments);
            Parent.ChildElem = departments;
        }
    }
}
