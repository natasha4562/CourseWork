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

namespace CourseWork.Controls
{
    public partial class MainControlForFunctions : UserControl
    {
        private Form1 _parent { get; set; }
        private Panel _panelMenu { get; set; }
        private Dictionary<string,string> Functions { get; set; }
        public MainControlForFunctions(Form1 parent, Panel panelMenu)
        {
            _parent = parent;
            _panelMenu = panelMenu;
            InitializeComponent();
            InitFunctions();
            LoadFunctions();
            //ElementsFunctions control = new ElementsFunctions("GetStudentInGroup");
            //control.Location = new Point(0, 0);
            //this.Controls.Add(control);

            //ControlForFunctions controlTable = new ControlForFunctions("GetStudentInGroup");
            //control.Location = new Point(0, 0);
            //this.Controls.Add(control);

        }

        private void InitFunctions()
        {
            Functions = new Dictionary<string, string>();
            Functions.Add("Запрос 1 (список)", "GetStudentInGroup");
            Functions.Add("Запрос 1 (количество)", "GetCountStudentsInGroup");
            Functions.Add("Запрос 2 (список)", "GetGraduateStudentsWithDissertation");
            Functions.Add("Запрос 2 (количество)", "GetCountGraduateStudentsWithDissertation");
            Functions.Add("Запрос 3", "GetDissertation");
            Functions.Add("Запрос 4", "GetDepartment");
            Functions.Add("Запрос 5", "GetTeachersStudiesGroup");
            Functions.Add("Запрос 6", "GetTeachersStudiesGroupInSem");
            Functions.Add("Запрос 7", "GetStudentsPassExamWithMark");
            Functions.Add("Запрос 8", "GetStudentsPassExamsGood");
            Functions.Add("Запрос 9", "GetTeachersExam");
            Functions.Add("Запрос 10", "GetStudentsWithMarkExam");
            Functions.Add("Запрос 11", "GetStudentsWithGrWorkInTeacher");
            Functions.Add("Запрос 12", "GetTeachersWithGrWork");
            Functions.Add("Запрос 13", "GetTeachersWorkload");
        }

        private void LoadFunctions()
        {
            _panelMenu.Controls.Clear();
            using (UniversityContext db = new UniversityContext())
            {
                _panelMenu.AutoScroll = false;
                _panelMenu.HorizontalScroll.Enabled = false;
                _panelMenu.HorizontalScroll.Visible = false;
                _panelMenu.HorizontalScroll.Maximum = 0;
                _panelMenu.AutoScroll = true;

                var functions = Functions.Select(x => x.Key).ToList();
                var height = 0;
                for (int i = 0; i < functions.Count; i++)
                {
                    Label label = new Label();
                    label.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    label.Name = functions[i];
                    label.Size = new Size(243, 42);
                    label.Location = new Point(0, height);
                    label.Text = functions[i];
                    label.MaximumSize = new Size(243, 0);
                    label.AutoSize = true;
                    label.Click += new EventHandler(label_Click);
                    //label.MouseLeave += new EventHandler(label_MouseLeave);
                    //label.MouseEnter += new EventHandler(label_MouseEnter);
                    _panelMenu.Controls.Add(label);
                    height += label.Height + 30;
                }
            }
        }
        
        private void label_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Label a = (Label)sender;
            string funcName = Functions.GetValueOrDefault(a.Text);
            ElementsFunctions control = new ElementsFunctions(funcName);
            control.Location = new Point(0, 0);
            this.Controls.Add(control);
        }
    }
}
