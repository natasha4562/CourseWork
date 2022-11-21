
namespace CourseWork
{
    partial class Specialties
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
            this.labelSp2 = new System.Windows.Forms.Label();
            this.labelSp1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "СПЕЦИАЛЬНОСТИ";
            // 
            // labelSp2
            // 
            this.labelSp2.AutoSize = true;
            this.labelSp2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSp2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSp2.Location = new System.Drawing.Point(22, 139);
            this.labelSp2.Name = "labelSp2";
            this.labelSp2.Size = new System.Drawing.Size(250, 38);
            this.labelSp2.TabIndex = 6;
            this.labelSp2.Text = "Специальность 2";
            this.labelSp2.Click += new System.EventHandler(this.labelSp_Click);
            this.labelSp2.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelSp2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // labelSp1
            // 
            this.labelSp1.AutoSize = true;
            this.labelSp1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSp1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelSp1.Location = new System.Drawing.Point(22, 90);
            this.labelSp1.Name = "labelSp1";
            this.labelSp1.Size = new System.Drawing.Size(250, 38);
            this.labelSp1.TabIndex = 5;
            this.labelSp1.Text = "Специальность 1";
            this.labelSp1.Click += new System.EventHandler(this.labelSp_Click);
            this.labelSp1.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelSp1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // Specialties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSp2);
            this.Controls.Add(this.labelSp1);
            this.Controls.Add(this.label1);
            this.Name = "Specialties";
            this.Size = new System.Drawing.Size(928, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSp2;
        private System.Windows.Forms.Label labelSp1;
    }
}
