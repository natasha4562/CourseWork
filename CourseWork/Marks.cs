using Microsoft.EntityFrameworkCore;
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
    public partial class Marks : UserControl
    {
        public Form1 Parent { get; set; }
        private int Semester;
        public Marks(Form1 f)
        {
            InitializeComponent();
            Parent = f;
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            comboBoxSemester.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxSemester.SelectedIndex = 0;
            comboBoxType.Items.AddRange(new string[] { "Семестр", "Экзамен", "Зачет" });
            comboBoxType.SelectedIndex = 0;

            /*using (UniversityContext db = new UniversityContext())
            {
                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).Where(s => s.Semester == Semester).ToList(); ;

                for (int i = 0; i < sub.Count; i++)
                {
                    comboBoxSubjects.Items.Add(sub[i].Name);
                }
            }
            comboBoxSubjects.SelectedIndex = 0;*/
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            Students students = new Students(Parent);
            students.Location = new Point(250, 49);
            Parent.Controls.Add(students);
            Parent.ChildElem = students;
        }

        private void comboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            Semester = int.Parse(comboBoxSemester.SelectedItem.ToString());
            comboBoxSubjects.Items.Clear();
            using (UniversityContext db = new UniversityContext())
            {
                var ds = db.DistributionSubjects.Where(d => d.IdGroupStudents == Parent.IdGroup).Select(d => d.IdSubject).ToList();
                var sub = db.Subjects.Where(s => ds.Contains(s.Id)).Where(s => s.Semester == Semester).ToList(); ;

                for (int i = 0; i < sub.Count; i++)
                {
                    comboBoxSubjects.Items.Add(sub[i].Name);
                }
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
