
namespace CourseWork
{
    partial class TeachersInfo
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
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonDisciplines = new System.Windows.Forms.Button();
            this.buttonDiploma = new System.Windows.Forms.Button();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.labelAmountChildren = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "ПРЕПОДАВАТЕЛИ";
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
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeachers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.IntegralHeight = false;
            this.comboBoxTeachers.Location = new System.Drawing.Point(22, 161);
            this.comboBoxTeachers.MaxDropDownItems = 4;
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(375, 39);
            this.comboBoxTeachers.TabIndex = 16;
            this.comboBoxTeachers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeachers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выбор преподавателя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(414, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фамилия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(414, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Имя:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(414, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Отчество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(414, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Должность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(414, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "Пол:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(414, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "Дата рождения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(414, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Количество детей:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(414, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Заработная плата:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(414, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(271, 31);
            this.label11.TabIndex = 26;
            this.label11.Text = "Научная деятельность:";
            // 
            // buttonDisciplines
            // 
            this.buttonDisciplines.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDisciplines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisciplines.Font = new System.Drawing.Font("Calibri Light", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonDisciplines.ForeColor = System.Drawing.Color.White;
            this.buttonDisciplines.Location = new System.Drawing.Point(424, 630);
            this.buttonDisciplines.Name = "buttonDisciplines";
            this.buttonDisciplines.Size = new System.Drawing.Size(409, 50);
            this.buttonDisciplines.TabIndex = 27;
            this.buttonDisciplines.Text = "Преподаваемые дисциплины";
            this.buttonDisciplines.UseVisualStyleBackColor = false;
            this.buttonDisciplines.Click += new System.EventHandler(this.buttonDisciplines_Click);
            // 
            // buttonDiploma
            // 
            this.buttonDiploma.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonDiploma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiploma.Font = new System.Drawing.Font("Calibri Light", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonDiploma.ForeColor = System.Drawing.Color.White;
            this.buttonDiploma.Location = new System.Drawing.Point(94, 630);
            this.buttonDiploma.Name = "buttonDiploma";
            this.buttonDiploma.Size = new System.Drawing.Size(296, 50);
            this.buttonDiploma.TabIndex = 28;
            this.buttonDiploma.Text = "Дипломные работы";
            this.buttonDiploma.UseVisualStyleBackColor = false;
            this.buttonDiploma.Click += new System.EventHandler(this.buttonDiploma_Click);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(544, 96);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(161, 31);
            this.labelSurname.TabIndex = 29;
            this.labelSurname.Text = "labelSurname";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(489, 140);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(176, 31);
            this.labelFirstName.TabIndex = 30;
            this.labelFirstName.Text = "labelFirstName";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPatronymic.Location = new System.Drawing.Point(538, 181);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(188, 31);
            this.labelPatronymic.TabIndex = 31;
            this.labelPatronymic.Text = "labelPatronymic";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPost.Location = new System.Drawing.Point(568, 221);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(112, 31);
            this.labelPost.TabIndex = 32;
            this.labelPost.Text = "labelPost";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(489, 266);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(143, 31);
            this.labelGender.TabIndex = 33;
            this.labelGender.Text = "labelGender";
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBirthdate.Location = new System.Drawing.Point(613, 307);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(168, 31);
            this.labelBirthdate.TabIndex = 34;
            this.labelBirthdate.Text = "labelBirthdate";
            // 
            // labelAmountChildren
            // 
            this.labelAmountChildren.AutoSize = true;
            this.labelAmountChildren.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmountChildren.Location = new System.Drawing.Point(639, 349);
            this.labelAmountChildren.Name = "labelAmountChildren";
            this.labelAmountChildren.Size = new System.Drawing.Size(245, 31);
            this.labelAmountChildren.TabIndex = 35;
            this.labelAmountChildren.Text = "labelAmountChildren";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSalary.Location = new System.Drawing.Point(634, 393);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(132, 31);
            this.labelSalary.TabIndex = 36;
            this.labelSalary.Text = "labelSalary";
            // 
            // TeachersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelAmountChildren);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.buttonDiploma);
            this.Controls.Add(this.buttonDisciplines);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label1);
            this.Name = "TeachersInfo";
            this.Size = new System.Drawing.Size(928, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDisciplines;
        private System.Windows.Forms.Button buttonDiploma;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.Label labelAmountChildren;
        private System.Windows.Forms.Label labelSalary;
    }
}
