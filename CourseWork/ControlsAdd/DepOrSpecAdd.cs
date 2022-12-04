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
    public partial class DepOrSpecAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        private Department department;
        private Speciality speciality;

        public DepOrSpecAdd(Form1 f, int _num, Department _d = null, Speciality _sp = null)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            department = _d;
            speciality = _sp;
            EditForm();
            EditVersion();
        }

        private void EditVersion()
        {
            if(elemForm == 1)
            {
                if (department != null)
                {
                    using (UniversityContext db = new UniversityContext())
                    {
                        textBoxName.Text = department.Name;

                        label1.Text = "Редактирование";
                    }
                }
            }
            if(elemForm == 2)
            {
                if (speciality != null)
                {
                    using (UniversityContext db = new UniversityContext())
                    {
                        textBoxName.Text = speciality.Name;
                        var elem = db.Departments.Where(d => d.Id == speciality.IdDepartment).FirstOrDefault().Name;
                        comboBoxDepartments.SelectedIndex = comboBoxDepartments.Items.IndexOf(elem);

                        label1.Text = "Редактирование";
                    }
                }
            }
        }

        private void EditForm()
        {
            if(elemForm == 1)
            {
                this.Controls.Remove(label10);
                this.Controls.Remove(comboBoxDepartments);
            }
            if(elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dep = db.Departments.Where(d => d.IdFaculty == Parent.IdFacult).ToList();
                    for(int i = 0; i < dep.Count; i++)
                    {
                        comboBoxDepartments.Items.Add(dep[i].Name);
                    }
                    comboBoxDepartments.SelectedIndex = 0;
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
                if(elemForm == 1)
                {
                    if (department != null)
                    {
                        EditDepOrSpec();
                    }
                    else
                    {
                        AddNewDepOrSpec();
                    }
                }
                if(elemForm == 2)
                {
                    if (speciality != null)
                    {
                        EditDepOrSpec();
                    }
                    else
                    {
                        AddNewDepOrSpec();
                    }
                }
                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void EditDepOrSpec()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if (elemForm == 1)
                {
                    department.Name = textBoxName.Text;
                    department.IdFaculty = Parent.IdFacult;

                    db.Entry(department).State = EntityState.Modified;
                    db.SaveChanges();
                }
                if (elemForm == 2)
                {
                    speciality.Name = textBoxName.Text;
                    speciality.IdDepartment = db.Departments.Where(d => d.Name == comboBoxDepartments.Text).FirstOrDefault().Id;

                    db.Entry(speciality).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void AddNewDepOrSpec()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if(elemForm == 1)
                {
                    Department department1 = new Department();
                    department1.Name = textBoxName.Text;
                    department1.IdFaculty = Parent.IdFacult;

                    db.Departments.Add(department1);
                    db.SaveChanges();
                }
                if(elemForm == 2)
                {
                    Speciality speciality1 = new Speciality();
                    speciality1.Name = textBoxName.Text;
                    speciality1.IdDepartment = db.Departments.Where(d => d.Name == comboBoxDepartments.Text).FirstOrDefault().Id;

                    db.Specialities.Add(speciality1);
                    db.SaveChanges();
                }
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            DepOrSpec depOrSpec = new DepOrSpec(Parent, elemForm);
            depOrSpec.Location = new Point(250, 49);
            Parent.Controls.Add(depOrSpec);
            Parent.ChildElem = depOrSpec;
        }
    }
}
