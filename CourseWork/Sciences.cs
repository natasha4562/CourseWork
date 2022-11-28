using CourseWork.ControlsAdd;
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
    public partial class Sciences : UserControl
    {
        public Form1 Parent { get; set; }
        private int elemForm;
        private List<int> listIdScience = new List<int>();
        public Sciences(Form1 f, int _num)
        {
            InitializeComponent();
            Parent = f;
            elemForm = _num;
            dataGridViewScience.ContextMenuStrip = contextMenuStrip1;
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
                        listIdScience.Add(dis[i].Id);
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
                        listIdScience.Add(dis[i].Id);
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

        private void toolStripMenuAdd_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);

            DissertationAdd dissertation = new DissertationAdd(Parent, elemForm);
            dissertation.Location = new Point(250, 49);
            Parent.Controls.Add(dissertation);
            Parent.ChildElem = dissertation;
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            if (elemForm == 1)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    int id = listIdScience[dataGridViewScience.CurrentCell.RowIndex];
                    var ds = db.DistributionSciences.Where(s => s.Id == id).FirstOrDefault();
                    Parent.Controls.Remove(this);

                    DissertationAdd dissertation = new DissertationAdd(Parent, elemForm, ds, null);
                    dissertation.Location = new Point(250, 49);
                    Parent.Controls.Add(dissertation);
                    Parent.ChildElem = dissertation;
                }
            }
            if (elemForm == 2)
            {
                using (UniversityContext db = new UniversityContext())
                {
                    int id = listIdScience[dataGridViewScience.CurrentCell.RowIndex];
                    var dd = db.DistributionDissertations.Where(s => s.Id == id).FirstOrDefault();
                    Parent.Controls.Remove(this);

                    DissertationAdd dissertation = new DissertationAdd(Parent, elemForm, null, dd);
                    dissertation.Location = new Point(250, 49);
                    Parent.Controls.Add(dissertation);
                    Parent.ChildElem = dissertation;
                }
            }
        }

        private void toolStripMenuDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить данную запись?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                if (elemForm == 1)
                {
                    using (UniversityContext db = new UniversityContext())
                    {
                        int id = listIdScience[dataGridViewScience.CurrentCell.RowIndex];

                        db.DistributionSciences.Remove(db.DistributionSciences.Where(s => s.Id == id).FirstOrDefault());
                        db.SaveChanges();

                        dataGridViewScience.Rows.RemoveAt(listIdScience.IndexOf(id));
                        listIdScience.RemoveAt(listIdScience.IndexOf(id));
                    }
                }
                if (elemForm == 2)
                {
                    using (UniversityContext db = new UniversityContext())
                    {
                        int id = listIdScience[dataGridViewScience.CurrentCell.RowIndex];

                        db.DistributionDissertations.Remove(db.DistributionDissertations.Where(s => s.Id == id).FirstOrDefault());
                        db.SaveChanges();

                        dataGridViewScience.Rows.RemoveAt(listIdScience.IndexOf(id));
                        listIdScience.RemoveAt(listIdScience.IndexOf(id));
                    }
                }
            }
        }
    }
}
