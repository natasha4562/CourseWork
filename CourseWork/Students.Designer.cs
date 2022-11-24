
namespace CourseWork
{
    partial class Students
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditBookNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountChildren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudyForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountScholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.buttonDisciplines = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.Firstname,
            this.Middlename,
            this.CreditBookNumber,
            this.Gender,
            this.DateOfBirth,
            this.AmountChildren,
            this.StudyForm,
            this.AmountScholarship});
            this.dataGridViewStudents.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 29;
            this.dataGridViewStudents.Size = new System.Drawing.Size(928, 536);
            this.dataGridViewStudents.TabIndex = 16;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Имя";
            this.Firstname.MinimumWidth = 6;
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Middlename
            // 
            this.Middlename.HeaderText = "Отчество";
            this.Middlename.MinimumWidth = 6;
            this.Middlename.Name = "Middlename";
            this.Middlename.ReadOnly = true;
            // 
            // CreditBookNumber
            // 
            this.CreditBookNumber.HeaderText = "Номер зач. книги";
            this.CreditBookNumber.MinimumWidth = 6;
            this.CreditBookNumber.Name = "CreditBookNumber";
            this.CreditBookNumber.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Пол";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Дата рождения";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // AmountChildren
            // 
            this.AmountChildren.HeaderText = "Количество детей";
            this.AmountChildren.MinimumWidth = 6;
            this.AmountChildren.Name = "AmountChildren";
            this.AmountChildren.ReadOnly = true;
            // 
            // StudyForm
            // 
            this.StudyForm.HeaderText = "Форма обучения";
            this.StudyForm.MinimumWidth = 6;
            this.StudyForm.Name = "StudyForm";
            this.StudyForm.ReadOnly = true;
            // 
            // AmountScholarship
            // 
            this.AmountScholarship.HeaderText = "Размер стипендии";
            this.AmountScholarship.MinimumWidth = 6;
            this.AmountScholarship.Name = "AmountScholarship";
            this.AmountScholarship.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "СТУДЕНТЫ";
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
            this.button_Back.TabIndex = 17;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // buttonGrade
            // 
            this.buttonGrade.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrade.Font = new System.Drawing.Font("Calibri Light", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonGrade.ForeColor = System.Drawing.Color.White;
            this.buttonGrade.Location = new System.Drawing.Point(200, 638);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(216, 50);
            this.buttonGrade.TabIndex = 18;
            this.buttonGrade.Text = "Успеваемость";
            this.buttonGrade.UseVisualStyleBackColor = false;
            // 
            // buttonDisciplines
            // 
            this.buttonDisciplines.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDisciplines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisciplines.Font = new System.Drawing.Font("Calibri Light", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonDisciplines.ForeColor = System.Drawing.Color.White;
            this.buttonDisciplines.Location = new System.Drawing.Point(439, 638);
            this.buttonDisciplines.Name = "buttonDisciplines";
            this.buttonDisciplines.Size = new System.Drawing.Size(334, 50);
            this.buttonDisciplines.TabIndex = 19;
            this.buttonDisciplines.Text = "Изучаемые дисциплины";
            this.buttonDisciplines.UseVisualStyleBackColor = false;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDisciplines);
            this.Controls.Add(this.buttonGrade);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Back);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(928, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditBookNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountChildren;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudyForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountScholarship;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Button buttonDisciplines;
    }
}
