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
    public partial class Teachers : UserControl
    {
        public Form1 Parent { get; set; }
        public Teachers(Form1 f)
        {
            InitializeComponent();
            Parent = f;
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
