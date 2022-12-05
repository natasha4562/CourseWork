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

namespace CourseWork.ControlsAdd
{
    public partial class GroupsAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private GroupStudent groupStudent;
        public GroupsAdd(Form1 f, GroupStudent _gs = null)
        {
            InitializeComponent();
            Parent = f;
            groupStudent = _gs;
            LoadCombobox();
            EditVersion();
        }

        private void LoadCombobox()
        {
            using (UniversityContext db = new UniversityContext())
            {
                comboBoxSemester.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });

                var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).Select(d => d.Id).ToList();
                var sp = db.Specialities.Where(s => dep.Contains(s.IdDepartment ?? 0)).ToList();

                for(int i = 0; i < sp.Count; i++)
                {
                    comboBoxSpeciality.Items.Add(sp[i].Name);
                }

                comboBoxSemester.SelectedIndex = 0;
                comboBoxSpeciality.SelectedIndex = 0;
            }
        }

        private void EditVersion()
        {
            if (groupStudent != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    textBoxName.Text = groupStudent.Number;
                    comboBoxSemester.SelectedIndex = comboBoxSemester.Items.IndexOf(groupStudent.Semester.ToString());
                    comboBoxSpeciality.SelectedIndex = comboBoxSpeciality.Items.IndexOf(db.Specialities.Where(s => s.Id == groupStudent.IdSpeciality).FirstOrDefault().Name);

                    label1.Text = "Редактирование";
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            back();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupStudent != null)
                {
                    EditGroups();
                }
                else
                {
                    AddNewGroups();
                }
                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void AddNewGroups()
        {
            using (UniversityContext db = new UniversityContext())
            {
                GroupStudent groupStudent1 = new GroupStudent();
                groupStudent1.Number = textBoxName.Text;
                int num = int.Parse(comboBoxSemester.Text);
                groupStudent1.Course = num / 2 + num % 2;
                groupStudent1.Semester = num;
                groupStudent1.IdSpeciality = db.Specialities.Where(s => s.Name == comboBoxSpeciality.Text).FirstOrDefault().Id;

                db.GroupStudents.Add(groupStudent1);
                db.SaveChanges();
            }
        }

        private void EditGroups()
        {
            using (UniversityContext db = new UniversityContext())
            {
                groupStudent.Number = textBoxName.Text;
                int num = int.Parse(comboBoxSemester.Text);
                //groupStudent.Course = num / 2 + num % 2;
                groupStudent.Semester = num;
                groupStudent.IdSpeciality = db.Specialities.Where(s => s.Name == comboBoxSpeciality.Text).FirstOrDefault().Id;

                db.Entry(groupStudent).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            GroupsSt groups = new GroupsSt(Parent);
            groups.Location = new Point(250, 49);
            Parent.Controls.Add(groups);
            Parent.ChildElem = groups;
        }
    }
}
