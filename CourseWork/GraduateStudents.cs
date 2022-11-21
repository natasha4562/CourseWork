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
    public partial class GraduateStudents : UserControl
    {
        public Form1 Parent { get; set; }
        public GraduateStudents(Form1 f)
        {
            InitializeComponent();
            Parent = f;
        }
    }
}
