﻿
namespace CourseWork
{
    partial class Science
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
            this.button_Back = new System.Windows.Forms.Button();
            this.dataGridViewScience = new System.Windows.Forms.DataGridView();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScience)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "НАУЧНАЯ ДЕЯТЕЛЬНОСТЬ";
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
            this.button_Back.TabIndex = 18;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // dataGridViewScience
            // 
            this.dataGridViewScience.AllowUserToAddRows = false;
            this.dataGridViewScience.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScience.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewScience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScience.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Имя,
            this.Type});
            this.dataGridViewScience.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewScience.Name = "dataGridViewScience";
            this.dataGridViewScience.RowHeadersWidth = 51;
            this.dataGridViewScience.RowTemplate.Height = 29;
            this.dataGridViewScience.Size = new System.Drawing.Size(928, 613);
            this.dataGridViewScience.TabIndex = 19;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Наименование";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Science
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewScience);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label1);
            this.Name = "Science";
            this.Size = new System.Drawing.Size(928, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridView dataGridViewScience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}
