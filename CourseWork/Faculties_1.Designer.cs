
namespace CourseWork
{
    partial class Faculties_1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faculties_1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelDepartments = new System.Windows.Forms.Label();
            this.labelSpecialties = new System.Windows.Forms.Label();
            this.labelTeachers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ДЕКАН ФАКУЛЬТЕТА";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(22, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFIO.Location = new System.Drawing.Point(314, 148);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(282, 91);
            this.labelFIO.TabIndex = 2;
            this.labelFIO.Text = "Фамилия Имя Отчество";
            // 
            // labelDepartments
            // 
            this.labelDepartments.AutoSize = true;
            this.labelDepartments.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDepartments.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDepartments.Location = new System.Drawing.Point(22, 456);
            this.labelDepartments.Name = "labelDepartments";
            this.labelDepartments.Size = new System.Drawing.Size(157, 38);
            this.labelDepartments.TabIndex = 3;
            this.labelDepartments.Text = "КАФЕДРЫ";
            this.labelDepartments.Click += new System.EventHandler(this.labelDepartments_Click);
            this.labelDepartments.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelDepartments.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // labelSpecialties
            // 
            this.labelSpecialties.AutoSize = true;
            this.labelSpecialties.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSpecialties.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSpecialties.Location = new System.Drawing.Point(22, 522);
            this.labelSpecialties.Name = "labelSpecialties";
            this.labelSpecialties.Size = new System.Drawing.Size(270, 38);
            this.labelSpecialties.TabIndex = 4;
            this.labelSpecialties.Text = "СПЕЦИАЛЬНОСТИ";
            this.labelSpecialties.Click += new System.EventHandler(this.labelSpecialties_Click);
            this.labelSpecialties.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelSpecialties.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTeachers.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelTeachers.Location = new System.Drawing.Point(22, 581);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(264, 38);
            this.labelTeachers.TabIndex = 5;
            this.labelTeachers.Text = "ПРЕПОДАВАТЕЛИ";
            this.labelTeachers.Click += new System.EventHandler(this.labelTeachers_Click);
            this.labelTeachers.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelTeachers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // Faculties_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.labelTeachers);
            this.Controls.Add(this.labelSpecialties);
            this.Controls.Add(this.labelDepartments);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Faculties_1";
            this.Size = new System.Drawing.Size(928, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelDepartments;
        private System.Windows.Forms.Label labelSpecialties;
        private System.Windows.Forms.Label labelTeachers;
    }
}
