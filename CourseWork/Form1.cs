using CourseWork.Controls;
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
    public partial class Form1 : Form
    {
        public UserControl ChildElem;
        public int itemMenu1, IdFacult, IdSpeciality, IdGroup, IdDepartnemt, IdTeacher;
        public Form1()
        {
            InitializeComponent();
            InitializeId();

            Faculties_1 faculties_1 = new Faculties_1(this);
            faculties_1.Location = new Point(250, 49);
            this.Controls.Add(faculties_1);
            ChildElem = faculties_1;
            
            LoadFaculties();
        }

        private void InitializeId()
        {
            using(UniversityContext db = new UniversityContext())
            {
                itemMenu1 = 1;
                IdFacult = db.Faculties.First().Id;
                IdSpeciality = db.Specialities.First().Id;
                IdGroup = db.GroupStudents.First().Id;
                IdDepartnemt = db.Departments.First().Id;
                IdTeacher = db.Teachers.First().Id;
            }
        }

        private void LoadFaculties()
        {
            using (UniversityContext db = new UniversityContext())
            {
                var facults = db.Faculties.ToList();
                var height = 0;
                for(int i = 0; i < facults.Count; i++)
                {
                    Label label = new Label();
                    label.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    label.Name = facults[i].Id.ToString();
                    label.Size = new Size(243, 42);
                    label.Location = new Point(0, height);
                    label.Text = facults[i].Name;
                    label.MaximumSize = new Size(243, 0);
                    label.AutoSize = true;
                    label.Click += new EventHandler(label_Click);
                    label.MouseLeave += new EventHandler(label_MouseLeave);
                    label.MouseEnter += new EventHandler(label_MouseEnter);
                    panelMenuF.Controls.Add(label);
                    height += label.Height + 30;
                }
            }
        }

        private void itemsMenu1GrStudents_Click(object sender, EventArgs e)
        {
            InitializeId();
            Type myType = ChildElem.GetType();
            if (myType.Name != nameof(GraduateStudents))
            {
                this.Controls.Remove(ChildElem);

                GraduateStudents graduateStudents = new GraduateStudents(this);
                graduateStudents.Location = new Point(250, 49);
                this.Controls.Add(graduateStudents);
                ChildElem = graduateStudents;
                itemMenu1 = 4;
            }
        }

        private void itemsMenu1Department_Click(object sender, EventArgs e)
        {
            InitializeId();
            Type myType = ChildElem.GetType();
            if (myType.Name != nameof(Departments))
            {
                this.Controls.Remove(ChildElem);

                Departments departments = new Departments(this);
                departments.Location = new Point(250, 49);
                this.Controls.Add(departments);
                ChildElem = departments;
                itemMenu1 = 3;
            }
        }

        private void itemsMenu1Students_Click(object sender, EventArgs e)
        {
            InitializeId();
            Type myType = ChildElem.GetType();
            if (myType.Name != nameof(Specialties))
            {
                this.Controls.Remove(ChildElem);

                Specialties specialties = new Specialties(this);
                specialties.Location = new Point(250, 49);
                this.Controls.Add(specialties);
                ChildElem = specialties;
                itemMenu1 = 2;
            }
        }

        private void itemsMenu1Faculties_Click(object sender, EventArgs e)
        {
            InitializeId();
            Type myType = ChildElem.GetType();

            if (myType.Name != nameof(Faculties_1))
            {
                this.Controls.Remove(ChildElem);

                Faculties_1 faculties_1 = new Faculties_1(this);
                faculties_1.Location = new Point(250, 49);
                this.Controls.Add(faculties_1);
                ChildElem = faculties_1;
                itemMenu1 = 1;
                IdFacult = 1;
            }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            IdFacult = int.Parse(label.Name);

            Type myType = ChildElem.GetType();

            if(itemMenu1 == 1)
            {
                this.Controls.Remove(ChildElem);

                Faculties_1 faculties_1 = new Faculties_1(this);
                faculties_1.Location = new Point(250, 49);
                this.Controls.Add(faculties_1);
                ChildElem = faculties_1;
            }

            if (itemMenu1 == 2)
            {
                this.Controls.Remove(ChildElem);

                Specialties specialties = new Specialties(this);
                specialties.Location = new Point(250, 49);
                this.Controls.Add(specialties);
                ChildElem = specialties;
            }

            if (itemMenu1 == 3)
            {
                this.Controls.Remove(ChildElem);

                Departments departments = new Departments(this);
                departments.Location = new Point(250, 49);
                this.Controls.Add(departments);
                ChildElem = departments;
            }

            if (itemMenu1 == 4)
            {
                this.Controls.Remove(ChildElem);

                GraduateStudents graduateStudents = new GraduateStudents(this);
                graduateStudents.Location = new Point(250, 49);
                this.Controls.Add(graduateStudents);
                ChildElem = graduateStudents;
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Underline);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.Font = new Font(label.Font, FontStyle.Regular);
        }

        private void toolStripMenuItemQueries_Click(object sender, EventArgs e)
        {
            Type myType = ChildElem.GetType();

            if (myType.Name != nameof(MainControlForFunctions))
            {
                this.Controls.Remove(ChildElem);

                MainControlForFunctions faculties_1 = new MainControlForFunctions(this, this.panelMenuF);
                faculties_1.Location = new Point(250, 49);
                this.Controls.Add(faculties_1);
                ChildElem = faculties_1;
                itemMenu1 = 1;
                IdFacult = 1;
            }
        }
    }
}
