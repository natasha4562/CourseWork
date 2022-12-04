
namespace CourseWork
{
    partial class DepOrSpec
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Back = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewDepOrSpec = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepOrSpec)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.button_Back.TabIndex = 16;
            this.button_Back.Text = "Назад";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(22, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(186, 45);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "labelName";
            // 
            // dataGridViewDepOrSpec
            // 
            this.dataGridViewDepOrSpec.AllowUserToAddRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDepOrSpec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDepOrSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepOrSpec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDepOrSpec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDepOrSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepOrSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Department});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDepOrSpec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDepOrSpec.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewDepOrSpec.Name = "dataGridViewDepOrSpec";
            this.dataGridViewDepOrSpec.RowHeadersWidth = 51;
            this.dataGridViewDepOrSpec.RowTemplate.Height = 29;
            this.dataGridViewDepOrSpec.Size = new System.Drawing.Size(928, 613);
            this.dataGridViewDepOrSpec.TabIndex = 17;
            // 
            // Title
            // 
            this.Title.HeaderText = "Наименование";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Кафедра";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAdd,
            this.toolStripMenuEdit,
            this.toolStripMenuDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            // 
            // toolStripMenuAdd
            // 
            this.toolStripMenuAdd.Name = "toolStripMenuAdd";
            this.toolStripMenuAdd.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuAdd.Text = "Добавить";
            this.toolStripMenuAdd.Click += new System.EventHandler(this.toolStripMenuAdd_Click);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuEdit.Text = "Редактировать";
            this.toolStripMenuEdit.Click += new System.EventHandler(this.toolStripMenuEdit_Click);
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(180, 24);
            this.toolStripMenuDelete.Text = "Удалить";
            this.toolStripMenuDelete.Click += new System.EventHandler(this.toolStripMenuDelete_Click);
            // 
            // DepOrSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDepOrSpec);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.labelName);
            this.Name = "DepOrSpec";
            this.Size = new System.Drawing.Size(928, 613);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepOrSpec)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewDepOrSpec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}
