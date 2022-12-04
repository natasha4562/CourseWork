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
    public partial class FacultyAdd : UserControl
    {
        public Form1 Parent { get; set; }
        private Faculty faculty;
        public FacultyAdd(Form1 f, Faculty _faculty = null)
        {
            InitializeComponent();
            Parent = f;
            faculty = _faculty;
            EditVersion();
        }

        private void EditVersion()
        {
            if (faculty != null)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    textBoxName.Text = faculty.Name;
                    
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
                if (faculty != null)
                {
                    EditFaculties();
                }
                else
                {
                    AddNewFaculties();
                }
                back();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void AddNewFaculties()
        {
            using (UniversityContext db = new UniversityContext())
            {
                Faculty faculty1 = new Faculty();
                faculty1.Name = textBoxName.Text;

                db.Faculties.Add(faculty1);
                db.SaveChanges();
            }
        }

        private void EditFaculties()
        {
            using (UniversityContext db = new UniversityContext())
            {
                faculty.Name = textBoxName.Text;
                
                db.Entry(faculty).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void back()
        {
            Parent.Controls.Remove(this);

            FacultiesAll faculties = new FacultiesAll(Parent);
            faculties.Location = new Point(250, 49);
            Parent.Controls.Add(faculties);
            Parent.ChildElem = faculties;
        }
    }
}