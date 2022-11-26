
namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFaculties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemQueries = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenuF = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFaculties,
            this.toolStripMenuStudents,
            this.toolStripMenuTeachers,
            this.toolStripMenuItemGrStudents,
            this.toolStripMenuItemQueries});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuFaculties
            // 
            this.toolStripMenuFaculties.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuFaculties.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripMenuFaculties.Name = "toolStripMenuFaculties";
            this.toolStripMenuFaculties.Size = new System.Drawing.Size(191, 45);
            this.toolStripMenuFaculties.Text = "Факультеты";
            this.toolStripMenuFaculties.Click += new System.EventHandler(this.itemsMenu1Faculties_Click);
            // 
            // toolStripMenuStudents
            // 
            this.toolStripMenuStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuStudents.Name = "toolStripMenuStudents";
            this.toolStripMenuStudents.Size = new System.Drawing.Size(175, 45);
            this.toolStripMenuStudents.Text = "Студентам";
            this.toolStripMenuStudents.Click += new System.EventHandler(this.itemsMenu1Students_Click);
            // 
            // toolStripMenuTeachers
            // 
            this.toolStripMenuTeachers.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuTeachers.Name = "toolStripMenuTeachers";
            this.toolStripMenuTeachers.Size = new System.Drawing.Size(264, 45);
            this.toolStripMenuTeachers.Text = "Преподавателям";
            this.toolStripMenuTeachers.Click += new System.EventHandler(this.itemsMenu1Department_Click);
            // 
            // toolStripMenuItemGrStudents
            // 
            this.toolStripMenuItemGrStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemGrStudents.Name = "toolStripMenuItemGrStudents";
            this.toolStripMenuItemGrStudents.Size = new System.Drawing.Size(197, 45);
            this.toolStripMenuItemGrStudents.Text = "Аспирантам";
            this.toolStripMenuItemGrStudents.Click += new System.EventHandler(this.itemsMenu1GrStudents_Click);
            // 
            // toolStripMenuItemQueries
            // 
            this.toolStripMenuItemQueries.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItemQueries.Name = "toolStripMenuItemQueries";
            this.toolStripMenuItemQueries.Size = new System.Drawing.Size(151, 45);
            this.toolStripMenuItemQueries.Text = "Запросы";
            this.toolStripMenuItemQueries.Click += new System.EventHandler(this.toolStripMenuItemQueries_Click);
            // 
            // panelMenuF
            // 
            this.panelMenuF.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenuF.Location = new System.Drawing.Point(0, 49);
            this.panelMenuF.Name = "panelMenuF";
            this.panelMenuF.Size = new System.Drawing.Size(250, 700);
            this.panelMenuF.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 749);
            this.Controls.Add(this.panelMenuF);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFaculties;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStudents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTeachers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrStudents;
        private System.Windows.Forms.Panel panelMenuF;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemQueries;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

