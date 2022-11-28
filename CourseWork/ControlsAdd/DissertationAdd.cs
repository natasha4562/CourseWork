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
    public partial class DissertationAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        private DistributionScience distributionScience;
        private DistributionDissertation distributionDissertation;
        
        public DissertationAdd(Form1 f, int _num, DistributionScience _s = null, DistributionDissertation _d = null)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            distributionScience = _s;
            distributionDissertation = _d;
            LoadComboboxDissertation();
            EditVersion();
        }

        private void LoadComboboxDissertation()
        {
            using (UniversityContext db = new UniversityContext())
            {
                if (elemForm == 1)
                {
                    var list = db.Sciences.Select(s => s.Name).ToList();

                    for (int i = 0; i < list.Count; i++)
                    {
                        comboBoxDissertation.Items.Add(list[i]);
                    }
                }
                if (elemForm == 2)
                {
                    var list = db.Dissertations.Select(s => s.Name).ToList();

                    for (int i = 0; i < list.Count; i++)
                    {
                        comboBoxDissertation.Items.Add(list[i]);
                    }
                }
                
                comboBoxDissertation.SelectedIndex = 0;
            }
        }

        private void EditVersion()
        {
            if (elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    if (distributionScience != null)
                    {
                        var elem = db.Sciences.FirstOrDefault(d => d.Id == distributionScience.IdScience).Name;
                        comboBoxDissertation.SelectedIndex = comboBoxDissertation.Items.IndexOf(elem);
                        textBoxName.Text = distributionScience.Name;

                        label1.Text = "Редактирование";
                    }
                }
            }
            if (elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    if (distributionDissertation != null)
                    {
                        var elem = db.Dissertations.FirstOrDefault(d => d.Id == distributionDissertation.IdDissertation).Name;
                        comboBoxDissertation.SelectedIndex = comboBoxDissertation.Items.IndexOf(elem);
                        textBoxName.Text = distributionDissertation.Name;

                        label1.Text = "Редактирование";
                    }
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
                if (elemForm == 1)
                {
                    if (distributionScience != null)
                    {
                        EditStudent();
                    }
                    else
                    {
                        AddNewStudent();
                    }
                }
                if (elemForm == 2)
                {
                    if (distributionDissertation != null)
                    {
                        EditStudent();
                    }
                    else
                    {
                        AddNewStudent();
                    }
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            back();
        }

        private void EditStudent()
        {
            if (elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    distributionScience.IdScience = db.Sciences.Where(d => d.Name == comboBoxDissertation.Text).FirstOrDefault().Id;
                    distributionScience.IdTeacher = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault().Id;
                    distributionScience.Name = textBoxName.Text;

                    db.Entry(distributionScience).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            if (elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    distributionDissertation.IdDissertation = db.Dissertations.Where(d => d.Name == comboBoxDissertation.Text).FirstOrDefault().Id;
                    distributionDissertation.IdTeacher = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault().Id;
                    distributionDissertation.Name = textBoxName.Text;

                    db.Entry(distributionDissertation).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void AddNewStudent()
        {
            if (elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    DistributionScience science = new DistributionScience();
                    science.IdScience = db.Sciences.Where(d => d.Name == comboBoxDissertation.Text).FirstOrDefault().Id;
                    science.IdTeacher = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault().Id;
                    science.Name = textBoxName.Text;

                    db.DistributionSciences.Add(science);
                    db.SaveChanges();
                }
            }
            if (elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    DistributionDissertation dissertation = new DistributionDissertation();
                    dissertation.IdDissertation = db.Dissertations.Where(d => d.Name == comboBoxDissertation.Text).FirstOrDefault().Id;
                    dissertation.IdTeacher = db.Teachers.Where(t => t.Id == Parent.IdTeacher).FirstOrDefault().Id;
                    dissertation.Name = textBoxName.Text;

                    db.DistributionDissertations.Add(dissertation);
                    db.SaveChanges();
                }
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            Sciences sciences = new Sciences(Parent, elemForm);
            sciences.Location = new Point(250, 49);
            Parent.Controls.Add(sciences);
            Parent.ChildElem = sciences;
        }
    }
}
