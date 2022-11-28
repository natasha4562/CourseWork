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

                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Мин. возраст");
                        AddNewElement("textBox", "Мин. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        using (UniversityContext db = new UniversityContext())
                        {
                            var form = db.StudyForms.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Форма обуч.");
                            AddNewElement("comboBox", "Форма обуч.", form);
                        }

                        AddNewElement("label", "Мин. стипендия");
                        AddNewElement("textBox", "Мин. стипендия");

                        label1.Text = "Получить перечень и общее число студентов указанных групп либо указанного курса (курсов) " +
                            "факультета полностью, по половому признаку, году рождения, возрасту, признаку наличия детей, по " +
                            "признаку получения и размеру стипендии.";

                        break;
                    }
                case "GetCountStudentsInGroup":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        AddNewElement("label", "Пол");
                        AddNewElement("textBox", "Пол");

                        AddNewElement("label", "Дата рождения");
                        AddNewElement("datePicker", "Дата рождения");

                        AddNewElement("label", "Мин. возраст");
                        AddNewElement("textBox", "Мин. возраст");

                        AddNewElement("label", "Кол-во детей");
                        AddNewElement("textBox", "Кол-во детей");

                        using (UniversityContext db = new UniversityContext())
                        {
                            var form = db.StudyForms.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Форма обуч.");
                            AddNewElement("comboBox", "Форма обуч.", form);
                        }

                        AddNewElement("label", "Мин. стипендия");
                        AddNewElement("textBox", "Мин. стипендия");

                        label1.Text = "Получить перечень и общее число студентов указанных групп либо указанного курса (курсов) " +
                            "факультета полностью, по половому признаку, году рождения, возрасту, признаку наличия детей, по " +
                            "признаку получения и размеру стипендии.";
                        break;
                    }
                case "GetGraduateStudentsWithDissertation":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var departments = db.Departments.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Кафедра");
                            AddNewElement("comboBox", "Кафедра", departments);
                        }

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
                        using (UniversityContext db = new UniversityContext())
                        {
                            var departments = db.Departments.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Кафедра");
                            AddNewElement("comboBox", "Кафедра", departments);
                        }

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
                        using (UniversityContext db = new UniversityContext())
                        {
                            var departments = db.Departments.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Кафедра");
                            AddNewElement("comboBox", "Кафедра", departments);
                        }

                        label1.Text = "Получить перечень и общее число тем кандидатских и докторских диссертаций, защитивших " +
                            "сотрудниками указанной кафедры либо указанного факультета.";

                        break;
                    }
                case "GetDepartment":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить перечень кафедр, проводящих занятия в указанной группе либо на указанном курсе " +
                            "указанного факультета в указанном семестре, либо за указанный период.";

                        break;
                    }
                case "GetTeachersStudiesGroup":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        using (UniversityContext db = new UniversityContext())
                        {
                            var subjects = db.Subjects.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Дисциплина");
                            AddNewElement("comboBox", "Дисциплина", subjects);
                        }

                        label1.Text = "Получить список и общее число преподавателей, проводивших (проводящих) занятия по указанной " +
                            "дисциплине в указанной группе либо на указанном курсе указанного факультета.";

                        break;
                    }
                case "GetTeachersStudiesGroupInSem":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить перечень и общее число преподавателей проводивших (проводящих) лекционные, " +
                            "семинарские и другие виды занятий в указанной группе либо на указанном курсе указанного " +
                            "факультета в указанном семестре, либо за указанный период.";

                        break;
                    }
                case "GetStudentsPassExamWithMark":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var subjects = db.Subjects.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Дисциплина");
                            AddNewElement("comboBox", "Дисциплина", subjects);
                        }

                        AddNewElement("label", "Оценка");
                        AddNewElement("textBox", "Оценка");

                        label1.Text = "Получить список и общее число студентов указанных групп, сдавших зачет либо экзамен по указанной " +
                            "дисциплине с указанной оценкой.";

                        break;
                    }
                case "GetStudentsPassExamsGood":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        label1.Text = "Получить список и общее число студентов указанных групп или указанного курса указанного " +
                            "факультета, сдавших указанную сессию на отлично, без троек, без двоек.";

                        break;
                    }
                case "GetTeachersExam":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        using (UniversityContext db = new UniversityContext())
                        {
                            var subjects = db.Subjects.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Дисциплина");
                            AddNewElement("comboBox", "Дисциплина", subjects);
                        }

                        AddNewElement("label", "Семестр");
                        AddNewElement("textBox", "Семестр");

                        label1.Text = "Получить перечень преподавателей, принимающих (принимавших) экзамены в указанных группах, по " +
                            "указанным дисциплинам, в указанном семестре.";

                        break;
                    }
                case "GetStudentsWithMarkExam":
                    {
                        using(UniversityContext db = new UniversityContext())
                        {
                            var groups = db.GroupStudents.Select(x => x.Number).ToArray();
                            AddNewElement("label", "Группа");
                            AddNewElement("comboBox", "Группа", groups);
                        }

                        using (UniversityContext db = new UniversityContext())
                        {
                            var subjects = db.Subjects.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Дисциплина");
                            AddNewElement("comboBox", "Дисциплина", subjects);
                        }
                        
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
                        using (UniversityContext db = new UniversityContext())
                        {
                            var teachers = db.Teachers.Select(x => x.Surname + " " + x.FirstName + " " + x.Patronymic).ToArray();
                            AddNewElement("label", "Преподаватель");
                            AddNewElement("comboBox", "Преподаватель", teachers);
                        }
                        
                        label1.Text = "Получить список студентов и тем дипломных работ, выполняемых ими на указанной кафедре либо у " +
                            "указанного преподавателя.";

                        break;
                    }
                case "GetTeachersWithGrWork":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var departments = db.Departments.Select(x => x.Name).ToArray();
                            AddNewElement("label", "Кафедра");
                            AddNewElement("comboBox", "Кафедра", departments);
                        }

                        label1.Text = "Получить список руководителей дипломных работ с указанной кафедры, либо факультета полностью и " +
                            "раздельно по некоторым категориям преподавателей.";

                        break;
                    }
                case "GetTeachersWorkload":
                    {
                        using (UniversityContext db = new UniversityContext())
                        {
                            var type = db.TypeOccupations.Select(t => t.Name).ToArray();
                            AddNewElement("label", "Вид занятия");
                            AddNewElement("comboBox", "Вид занятия", type);
                        }
                        
                        label1.Text = "Получить нагрузку преподавателей (название дисциплины, количество часов), ее объем по отдельным " +
                            "видам занятий и общую нагрузку в указанном семестре для конкретного преподавателя либо для " +
                            "преподавателей указанной кафедры.";

                        break;
                    }
            }
        }
        DataGridView oldDataGridView = new DataGridView();
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
                            string comdoboxSelectedItem = (string)parameters[0];
                            int @GroupId = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;
                            string @StudentGender = (string)parameters[1];
                            DateTime @StudentYearOfBirthdate = Convert.ToDateTime(parameters[2]);
                            int @MinAge = Convert.ToInt32((string)parameters[3]);
                            int @AmountChildren = Convert.ToInt32((string)parameters[4]);
                            string comdoboxSelectedStudyForm = (string)parameters[5];
                            int @IdStudyForm = db.StudyForms.Where(x => x.Name == comdoboxSelectedStudyForm).FirstOrDefault().Id;
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
                            string comdoboxSelectedItem = (string)parameters[0];
                            int @GroupId = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;
                            string @StudentGender = (string)parameters[1];
                            DateTime @StudentYearOfBirthdate = Convert.ToDateTime(parameters[2]);
                            int @MinAge = Convert.ToInt32((string)parameters[3]);
                            int @AmountChildren = Convert.ToInt32((string)parameters[4]);
                            string comdoboxSelectedStudyForm = (string)parameters[5];
                            int @IdStudyForm = db.StudyForms.Where(x => x.Name == comdoboxSelectedStudyForm).FirstOrDefault().Id;
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
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Departments.Where(x => x.Name == comdoboxSelectedItem).FirstOrDefault().Id;
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
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Departments.Where(x => x.Name == comdoboxSelectedItem).FirstOrDefault().Id;
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
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Departments.Where(x => x.Name == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetDissertation(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetDepartment":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param2 = Convert.ToInt32((string)parameters[1]);

                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetDepartment(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersStudiesGroup":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            string comboboxSelectedSubjects = (string)parameters[1];

                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;
                            int param2 = db.Subjects.Where(s => s.Name == comboboxSelectedSubjects).FirstOrDefault().Id;

                            var a = db.GetTeachersStudiesGroup(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersStudiesGroupInSem":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param2 = Convert.ToInt32((string)parameters[1]);

                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetTeachersStudiesGroupInSem(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsPassExamWithMark":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Subjects.Where(s => s.Name == comdoboxSelectedItem).FirstOrDefault().Id;
                            int param2 = Convert.ToInt32((string)parameters[1]);

                            var a = db.GetStudentsPassExamWithMark(param1, param2);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsPassExamsGood":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetStudentsPassExamsGood(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersExam":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            string comboboxSelectedSubjects = (string)parameters[1];
                            int param3 = Convert.ToInt32((string)parameters[2]);

                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;
                            int param2 = db.Subjects.Where(s => s.Name == comboboxSelectedSubjects).FirstOrDefault().Id;

                            var a = db.GetTeachersExam(param1, param2, param3);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsWithMarkExam":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            string comboboxSelectedSubjects = (string)parameters[1];
                            int param3 = Convert.ToInt32((string)parameters[2]);
                            int param4 = Convert.ToInt32((string)parameters[3]);

                            
                            int param1 = db.GroupStudents.Where(x => x.Number == comdoboxSelectedItem).FirstOrDefault().Id;
                            int param2 = db.Subjects.Where(s => s.Name == comboboxSelectedSubjects).FirstOrDefault().Id;

                            var a = db.GetStudentsWithMarkExam(param1, param2, param3, param4);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetStudentsWithGrWorkInTeacher":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Teachers.Where(x => x.Surname + " " + x.FirstName + " " + x.Patronymic == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetStudentsWithGrWorkInTeacher(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersWithGrWork":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.Departments.Where(x => x.Name == comdoboxSelectedItem).FirstOrDefault().Id;

                            var a = db.GetTeachersWithGrWork(param1);
                            var list = a.ToList();

                            source.DataSource = list;
                            break;
                        }
                    case "GetTeachersWorkload":
                        {
                            string comdoboxSelectedItem = (string)parameters[0];
                            int param1 = db.TypeOccupations.Where(x => x.Name == comdoboxSelectedItem).FirstOrDefault().Id;

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
                this.Controls.Remove(oldDataGridView);
                oldDataGridView = dataGridView;
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

        public void AddNewElement(string element, string textInLabel, string[] valueForCombobox = null)
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
                case "comboBox":
                    {
                        currentElementInParametersArray++;
                        ComboBox textBox = new ComboBox();
                        textBox.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        textBox.Name = (currentElementInParametersArray - 1).ToString();
                        textBox.Size = new Size(150, 40);
                        textBox.Location = new Point(positionElements[0, currentElement - 1], positionElements[1, currentElement - 1]);
                        textBox.MaximumSize = new Size(243, 0);
                        textBox.AutoSize = true;
                        textBox.SelectedIndexChanged += UpdateFieldSelect;
                        textBox.Items.AddRange(valueForCombobox);
                        textBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                        textBox.SelectedIndex = 0;
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
        void UpdateFieldSelect(object? sender, EventArgs e)
        {
            var a = (ComboBox)sender;
            if(a.SelectedItem != null)
            {
                var value = a.SelectedItem.ToString();
                var index = Convert.ToInt32(a.Name);
                parameters[index] = value;
            }
        }
    }
}
