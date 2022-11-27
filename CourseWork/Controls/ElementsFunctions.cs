using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace CourseWork.Controls
{
    public partial class ElementsFunctions : UserControl
    {
        public object[] parameters = new object[7];
        int[,] positionElements =
        {
            { 10, 10, 170, 170, 330, 330, 490, 490, 650, 650, 810, 810, 10, 10 },
            { 10, 40, 10, 40, 10, 40, 10,  40,  10,  40,  10,  40, 90, 120  }
        };
        private int currentElement = 0;
        private int currentElementInParametersArray = 0;
        private string FunctionName = "";
        public ElementsFunctions(string functionName)
        {
            InitializeComponent();
            InitElements(functionName);
            FunctionName = functionName;
            Button button = new Button();
            button.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button.Text = "Выбрать";
            button.Size = new Size(150, 40);
            button.Location = new Point(790 , 90);
            button.MaximumSize = new Size(243, 50);
            button.AutoSize = true;
            button.Click += ReturnData;
            this.Controls.Add(button);
        }

        public void InitElements(string functionName)
        {
            this.Controls.Clear();
            this.Controls.Add(label1);
            switch (functionName)
            {
                case "GetStudentInGroup":
                    {
                        
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Мин. возраст");
                        AddNewElement("textBox", "Мин. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        AddNewElement("label", "ID ф. обуч.");
                        AddNewElement("textBox", "ID ф. обуч.");

                        AddNewElement("label", "Мин. стипендия");
                        AddNewElement("textBox", "Мин. стипендия");

                        label1.Text = "Получить перечень и общее число студентов указанных групп либо указанного курса (курсов) " +
                            "факультета полностью, по половому признаку, году рождения, возрасту, признаку наличия детей, по " +
                            "признаку получения и размеру стипендии.";

                        break;
                    }
                case "GetCountStudentsInGroup":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Мин. возраст");
                        AddNewElement("textBox", "Мин. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        AddNewElement("label", "ID ф. обуч.");
                        AddNewElement("textBox", "ID ф. обуч.");

                        AddNewElement("label", "Мин. стипендия");
                        AddNewElement("textBox", "Мин. стипендия");

                        label1.Text = "Получить перечень и общее число студентов указанных групп либо указанного курса (курсов) " +
                            "факультета полностью, по половому признаку, году рождения, возрасту, признаку наличия детей, по " +
                            "признаку получения и размеру стипендии.";
                        break;
                    }
                case "GetGraduateStudentsWithDissertation":
                    {
                        AddNewElement("label", "ID кафедры");
                        AddNewElement("textBox", "ID кафедры");

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Макс. возраст");
                        AddNewElement("textBox", "Макс. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        AddNewElement("label", "Мин. ЗП");
                        AddNewElement("textBox", "Мин. ЗП");

                        label1.Text = "Получить список и общее число преподавателей указанных кафедр либо указанного факультета " +
                            "полностью, либо указанных категорий(ассистенты, доценты, профессора и т.д.) по половому признаку, " +
                            "году рождения, возрасту, признаку наличия и количеству детей, размеру заработной платы, " +
                            "являющихся аспирантами, защитивших кандидатские, докторские диссертации в указанный период.";

                        break;
                    }
                case "GetCountGraduateStudentsWithDissertation":
                    {
                        AddNewElement("label", "ID кафедры");
                        AddNewElement("textBox", "ID кафедры");

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Макс. возраст");
                        AddNewElement("textBox", "Макс. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        AddNewElement("label", "Мин. ЗП");
                        AddNewElement("textBox", "Мин. ЗП");

                        label1.Text = "Получить список и общее число преподавателей указанных кафедр либо указанного факультета " +
                            "полностью, либо указанных категорий(ассистенты, доценты, профессора и т.д.) по половому признаку, " +
                            "году рождения, возрасту, признаку наличия и количеству детей, размеру заработной платы, " +
                            "являющихся аспирантами, защитивших кандидатские, докторские диссертации в указанный период.";

                        break;
                    }
                case "GetDissertation":
                    {
                        AddNewElement("label", "ID кафедры");
                        AddNewElement("textBox", "ID кафедры");

                        label1.Text = "Получить перечень и общее число тем кандидатских и докторских диссертаций, защитивших " +
                            "сотрудниками указанной кафедры либо указанного факультета.";

                        break;
                    }
                case "GetDepartment":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить перечень кафедр, проводящих занятия в указанной группе либо на указанном курсе " +
                            "указанного факультета в указанном семестре, либо за указанный период.";

                        break;
                    }
                case "GetTeachersStudiesGroup":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "ID дисциплины");
                        AddNewElement("textBox", "ID дисциплины");

                        label1.Text = "Получить список и общее число преподавателей, проводивших (проводящих) занятия по указанной " +
                            "дисциплине в указанной группе либо на указанном курсе указанного факультета.";

                        break;
                    }
                case "GetTeachersStudiesGroupInSem":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "ID дисциплины");
                        AddNewElement("textBox", "ID дисциплины");

                        label1.Text = "Получить перечень и общее число преподавателей проводивших (проводящих) лекционные, " +
                            "семинарские и другие виды занятий в указанной группе либо на указанном курсе указанного " +
                            "факультета в указанном семестре, либо за указанный период.";

                        break;
                    }
                case "GetStudentsPassExamWithMark":
                    {
                        AddNewElement("label", "ID дисциплины");
                        AddNewElement("textBox", "ID дисциплины");

                        AddNewElement("label", "ID оценки");
                        AddNewElement("textBox", "ID оценки");

                        label1.Text = "Получить список и общее число студентов указанных групп, сдавших зачет либо экзамен по указанной " +
                            "дисциплине с указанной оценкой.";

                        break;
                    }
                case "GetStudentsPassExamsGood":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        label1.Text = "Получить список и общее число студентов указанных групп или указанного курса указанного " +
                            "факультета, сдавших указанную сессию на отлично, без троек, без двоек.";

                        break;
                    }
                case "GetTeachersExam":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "ID дисциплины");
                        AddNewElement("textBox", "ID дисциплины");

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить перечень преподавателей, принимающих (принимавших) экзамены в указанных группах, по " +
                            "указанным дисциплинам, в указанном семестре.";

                        break;
                    }
                case "GetStudentsWithMarkExam":
                    {
                        AddNewElement("label", "ID группы");
                        AddNewElement("textBox", "ID группы");

                        AddNewElement("label", "ID дисциплины");
                        AddNewElement("textBox", "ID дисциплины");

                        AddNewElement("label", "Оценка");
                        AddNewElement("textBox", "Оценка");

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить список студентов указанных групп, либо которым заданный преподаватель поставил " +
                            "некоторую оценку за экзамен по определенным дисциплинам, в указанных семестрах, за некоторый " +
                            "период.";

                        break;
                    }
                case "GetStudentsWithGrWorkInTeacher":
                    {
                        AddNewElement("label", "ID преподавателя");
                        AddNewElement("textBox", "ID преподавателя");

                        label1.Text = "Получить список студентов и тем дипломных работ, выполняемых ими на указанной кафедре либо у " +
                            "указанного преподавателя.";

                        break;
                    }
                case "GetTeachersWithGrWork":
                    {
                        AddNewElement("label", "ID кафедры");
                        AddNewElement("textBox", "ID кафедры");

                        label1.Text = "Получить список руководителей дипломных работ с указанной кафедры, либо факультета полностью и " +
                            "раздельно по некоторым категориям преподавателей.";

                        break;
                    }
                case "GetTeachersWorkload":
                    {
                        AddNewElement("label", "ID вида занятия");
                        AddNewElement("textBox", "ID вида занятия");

                        label1.Text = "Получить нагрузку преподавателей (название дисциплины, количество часов), ее объем по отдельным " +
                            "видам занятий и общую нагрузку в указанном семестре для конкретного преподавателя либо для " +
                            "преподавателей указанной кафедры.";

                        break;
                    }
            }
        }
        
        public void ReturnData(object? sender, EventArgs e)
        {
            using(UniversityContext db = new UniversityContext())
            {
                ControlForFunctions controlForFunctions = new ControlForFunctions();
                DataGridView dataGridView = new DataGridView();
                var source = new BindingSource();
                switch (FunctionName)
                {
                    case "GetStudentInGroup":
                        {
                            int @GroupId = Convert.ToInt32((string)parameters[0]);
                            string @StudentGender = (string)parameters[1];
                            DateTime @StudentYearOfBirthdate = Convert.ToDateTime(parameters[2]);
                            int @MinAge = Convert.ToInt32((string)parameters[3]);
                            int @AmountChildren = Convert.ToInt32((string)parameters[4]);
                            int @IdStudyForm = Convert.ToInt32((string)parameters[5]);
                            int @MinAmountScholarship = Convert.ToInt32((string)parameters[6]);

                            var a = db.GetStudentInGroup(@GroupId, @StudentGender, @StudentYearOfBirthdate.Date, 
                                @MinAge, @AmountChildren, @IdStudyForm, @MinAmountScholarship);
                            var list = a.ToList();

                            source.DataSource = list;
                            
                            this.Controls.Add(dataGridView);
                            break;
                        }
                    case "GetCountStudentsInGroup":
                        {
                            int @GroupId = Convert.ToInt32((string)parameters[0]);
                            string @StudentGender = (string)parameters[1];
                            DateTime @StudentYearOfBirthdate = Convert.ToDateTime(parameters[2]);
                            int @MinAge = Convert.ToInt32((string)parameters[3]);
                            int @AmountChildren = Convert.ToInt32((string)parameters[4]);
                            int @IdStudyForm = Convert.ToInt32((string)parameters[5]);
                            int @MinAmountScholarship = Convert.ToInt32((string)parameters[6]);

                            var a = db.GetCountStudentsInGroup(@GroupId, @StudentGender, @StudentYearOfBirthdate,
                                @MinAge, @AmountChildren, @IdStudyForm, @MinAmountScholarship);
                            dataGridView.Columns.Add("CountStudents", "Count");
                            dataGridView.Rows.Add(1);

                            
                            dataGridView.Rows[0].Cells[0].Value = a.ToString();
                            source = (BindingSource)dataGridView.DataSource;
                            break;
                        }
                    case "GetGraduateStudentsWithDissertation":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            string param2 = (string)parameters[1];
                            DateTime param3 = Convert.ToDateTime(parameters[2]);
                            int param4 = Convert.ToInt32((string)parameters[3]);
                            int param5 = Convert.ToInt32((string)parameters[4]);
                            int param6 = Convert.ToInt32((string)parameters[5]);

                            var a = db.GetGraduateStudentsWithDissertation(param1, param2, param3,
                                param4, param5, param6);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetCountGraduateStudentsWithDissertation":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            string param2 = (string)parameters[1];
                            DateTime param3 = Convert.ToDateTime(parameters[2]);
                            int param4 = Convert.ToInt32((string)parameters[3]);
                            int param5 = Convert.ToInt32((string)parameters[4]);
                            int param6 = Convert.ToInt32((string)parameters[5]);

                            var a = db.GetCountGraduateStudentsWithDissertation(param1, param2, param3,
                                param4, param5, param6);
                            dataGridView.Columns.Add("CountStudents", "Count");
                            dataGridView.Rows.Add(1);


                            dataGridView.Rows[0].Cells[0].Value = a.ToString();
                            source = (BindingSource)dataGridView.DataSource;
                            break;
                        }
                    case "GetDissertation":
                        {
                            int IdDepartment = Convert.ToInt32((string)parameters[0]);
                            var a = db.GetDissertation(IdDepartment);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetDepartment":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            var a = db.GetDepartment(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersStudiesGroup":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            var a = db.GetTeachersStudiesGroup(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersStudiesGroupInSem":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            var a = db.GetTeachersStudiesGroupInSem(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsPassExamWithMark":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            var a = db.GetStudentsPassExamWithMark(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsPassExamsGood":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            var a = db.GetStudentsPassExamsGood(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersExam":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            int param3 = Convert.ToInt32((string)parameters[2]);
                            var a = db.GetTeachersExam(param1, param2, param3);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsWithMarkExam":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            int param2 = Convert.ToInt32((string)parameters[1]);
                            int param3 = Convert.ToInt32((string)parameters[2]);
                            int param4 = Convert.ToInt32((string)parameters[3]);
                            var a = db.GetStudentsWithMarkExam(param1, param2, param3, param4);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsWithGrWorkInTeacher":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            var a = db.GetStudentsWithGrWorkInTeacher(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersWithGrWork":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            var a = db.GetTeachersWithGrWork(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersWorkload":
                        {
                            int param1 = Convert.ToInt32((string)parameters[0]);
                            var a = db.GetTeachersWorkload(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                }
                dataGridView.DataSource = source;
                dataGridView.Location = new Point(10, 180);
                dataGridView.Size = new Size(900, 300);
                dataGridView.RowHeadersVisible = false;
                dataGridView.BackgroundColor = Color.White;
                dataGridView.AllowUserToAddRows = false;
                this.Controls.Add(dataGridView);
                for(var i = 0; i < dataGridView.ColumnCount; i++)
                {
                    if(dataGridView.ColumnCount != 0)
                    {
                        dataGridView.Columns[i].Width = dataGridView.Width / dataGridView.ColumnCount;
                    }
                }
            }
        }

        public void AddNewElement(string element, string textInLabel)
        {
            currentElement++;
            switch (element)
            {
                case "label":
                    {
                        Label label = new Label();
                        label.Font = new Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        label.Name = textInLabel;
                        label.Size = new Size(150, 42);
                        label.Location = new Point(positionElements[0, currentElement-1], positionElements[1, currentElement-1]);
                        label.Text = textInLabel;
                        label.MaximumSize = new Size(243, 0);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                        break;
                    }
                case "textBox":
                    {
                        currentElementInParametersArray++;
                        TextBox textBox = new TextBox();
                        textBox.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        textBox.Name = (currentElementInParametersArray - 1).ToString();
                        textBox.Size = new Size(150, 40);
                        textBox.Location = new Point(positionElements[0, currentElement-1], positionElements[1, currentElement-1]);
                        //textBox.Text = textInLabel;
                        textBox.MaximumSize = new Size(243, 0);
                        textBox.AutoSize = true;
                        textBox.TextChanged += UpdateField;
                        this.Controls.Add(textBox);
                        break;
                    }
                case "datePicker":
                    {
                        currentElementInParametersArray++;
                        DateTimePicker textBox = new DateTimePicker();
                        textBox.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        textBox.Name = (currentElementInParametersArray - 1).ToString();
                        textBox.Size = new Size(150, 40);
                        textBox.Location = new Point(positionElements[0, currentElement - 1], positionElements[1, currentElement - 1]);
                        textBox.MaximumSize = new Size(243, 0);
                        textBox.AutoSize = true;
                        textBox.ValueChanged += UpdateFieldDatePicker;
                        this.Controls.Add(textBox);
                        break;
                    }
            }
        }
        void UpdateField(object? sender, EventArgs e)
        {
            var a = (Control)sender;
            var index = Convert.ToInt32(a.Name);
            parameters[index] = a.Text;
        }
        void UpdateFieldDatePicker(object? sender, EventArgs e)
        {
            var a = (DateTimePicker)sender;
            var index = Convert.ToInt32(a.Name);
            parameters[index] = a.Value;
        }
    }
}
