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
    public partial class Subjects : UserControl
    {
        public Form1 Parent { get; set; }
        public Subjects(Form1 f)
        {
            InitializeComponent();
            Parent = f;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            TeachersInfo teachersInfo = new TeachersInfo(Parent);
            teachersInfo.Location = new Point(250, 49);
            Parent.Controls.Add(teachersInfo);
            Parent.ChildElem = teachersInfo;
        }
    }
}
