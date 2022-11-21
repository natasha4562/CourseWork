﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFaculties = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            this.toolStripMenuItemGrStudents});
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
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 49);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(250, 700);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 42);
            this.toolStripMenuItem1.Text = "Факультет 1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.itemsMenuStrip2_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 42);
            this.toolStripMenuItem2.Text = "Факультет 2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.itemsMenuStrip2_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 749);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFaculties;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuStudents;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuTeachers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrStudents;
    }
}

