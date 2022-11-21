
namespace CourseWork
{
    partial class Departments
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelDep2 = new System.Windows.Forms.Label();
            this.labelDep1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "КАФЕДРЫ";
            // 
            // labelDep2
            // 
            this.labelDep2.AutoSize = true;
            this.labelDep2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDep2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDep2.Location = new System.Drawing.Point(22, 139);
            this.labelDep2.Name = "labelDep2";
            this.labelDep2.Size = new System.Drawing.Size(160, 38);
            this.labelDep2.TabIndex = 18;
            this.labelDep2.Text = "Кафедра 2";
            this.labelDep2.Click += new System.EventHandler(this.labelDep_Click);
            this.labelDep2.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelDep2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // labelDep1
            // 
            this.labelDep1.AutoSize = true;
            this.labelDep1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDep1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelDep1.Location = new System.Drawing.Point(22, 90);
            this.labelDep1.Name = "labelDep1";
            this.labelDep1.Size = new System.Drawing.Size(160, 38);
            this.labelDep1.TabIndex = 17;
            this.labelDep1.Text = "Кафедра 1";
            this.labelDep1.Click += new System.EventHandler(this.labelDep_Click);
            this.labelDep1.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelDep1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDep2);
            this.Controls.Add(this.labelDep1);
            this.Controls.Add(this.label1);
            this.Name = "Departments";
            this.Size = new System.Drawing.Size(928, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDep2;
        private System.Windows.Forms.Label labelDep1;
    }
}
