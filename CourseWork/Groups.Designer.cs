
namespace CourseWork
{
    partial class Groups
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
            this.labelGr2 = new System.Windows.Forms.Label();
            this.labelGr1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группы";
            // 
            // labelGr2
            // 
            this.labelGr2.AutoSize = true;
            this.labelGr2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGr2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGr2.Location = new System.Drawing.Point(22, 139);
            this.labelGr2.Name = "labelGr2";
            this.labelGr2.Size = new System.Drawing.Size(134, 38);
            this.labelGr2.TabIndex = 8;
            this.labelGr2.Text = "Группа 2";
            this.labelGr2.Click += new System.EventHandler(this.labelGr_Click);
            this.labelGr2.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelGr2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // labelGr1
            // 
            this.labelGr1.AutoSize = true;
            this.labelGr1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGr1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelGr1.Location = new System.Drawing.Point(22, 90);
            this.labelGr1.Name = "labelGr1";
            this.labelGr1.Size = new System.Drawing.Size(134, 38);
            this.labelGr1.TabIndex = 7;
            this.labelGr1.Text = "Группа 1";
            this.labelGr1.Click += new System.EventHandler(this.labelGr_Click);
            this.labelGr1.MouseLeave += new System.EventHandler(this.labelChahgeColor_MouseLeave);
            this.labelGr1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelChahgeColor_MouseMove);
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Font = new System.Drawing.Font("Calibri Light", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(793, 17);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(120, 50);
            this.button_Back.TabIndex = 15;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.labelGr2);
            this.Controls.Add(this.labelGr1);
            this.Controls.Add(this.label1);
            this.Name = "Groups";
            this.Size = new System.Drawing.Size(928, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGr2;
        private System.Windows.Forms.Label labelGr1;
        private System.Windows.Forms.Button button_Back;
    }
}
