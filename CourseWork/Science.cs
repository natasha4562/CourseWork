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
    public partial class Science : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        public Science(Form1 f, int _num)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            LoadDissertations();
        }

        private void LoadDissertations()
        {
            if(elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dis = db.DistributionSciences.Where(d => d.IdTeacher == Parent.IdTeacher).Include(d => d.IdScienceNavigation).ToList();

                    for (int i = 0; i < dis.Count; i++)
                    {
                        dataGridViewScience.Rows.Add(dis[i].Name, dis[i].IdScienceNavigation.Name);
                    }
                    label1.Text = "Наука";
                }
            }
            if(elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    var dis = db.DistributionDissertations.Where(d => d.IdTeacher == Parent.IdTeacher).Include(d => d.IdDissertationNavigation).ToList();

                    for (int i = 0; i < dis.Count; i++)
                    {
                        dataGridViewScience.Rows.Add(dis[i].Name, dis[i].IdDissertationNavigation.Name);
                    }
                    label1.Text = "Диссертации";
                }
            }
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
