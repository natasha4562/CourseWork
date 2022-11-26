using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using University.Functions;

#nullable disable

namespace University
{
    public partial class UniversityContext : DbContext
    {
        public UniversityContext()
        {
        }

        public UniversityContext(DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dean> Deans { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Dissertation> Dissertations { get; set; }
        public virtual DbSet<DistributionDissertation> DistributionDissertations { get; set; }
        public virtual DbSet<DistributionScience> DistributionSciences { get; set; }
        public virtual DbSet<DistributionSubject> DistributionSubjects { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FormControl> FormControls { get; set; }
        public virtual DbSet<GraduateSchool> GraduateSchools { get; set; }
        public virtual DbSet<GraduateWork> GraduateWorks { get; set; }
        public virtual DbSet<GroupStudent> GroupStudents { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<MarkOfSubject> MarkOfSubjects { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Science> Sciences { get; set; }
        public virtual DbSet<Speciality> Specialities { get; set; }
        public virtual DbSet<StatusOfExam> StatusOfExams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudyForm> StudyForms { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TypeOccupation> TypeOccupations { get; set; }

        public virtual DbSet<CountStudentsInGroup> GetCountsStudentsInGroup { get; set; }
        public virtual DbSet<CountGraduateStudentsWithDissertation> GetCountsGraduateStudentsWithDissertation { get; set; }

        #region function 


        public int GetCountStudentsInGroup(int GroupId, string StudentGender, DateTime StudentYearOfBirthdate,
            int MinAge, int AmountChildren, int IdStudyForm, int MinAmountScholarship)
        {
            return this.GetCountsStudentsInGroup.FromSqlInterpolated($"select * from dbo.GetCountStudentsInGroup ({GroupId}, {StudentGender}, {StudentYearOfBirthdate},{MinAge}, {AmountChildren}, {IdStudyForm}, {MinAmountScholarship}) as CountStudents").FirstOrDefault().CountStudents;
        }

        public int GetCountGraduateStudentsWithDissertation(int IdDepartment, string Gender, DateTime MinBirthdate,
            int MaxAge, int AmountChldren, int MinSalary)
        {
            return this.GetCountsGraduateStudentsWithDissertation.FromSqlInterpolated($"select * from dbo.GetCountGraduateStudentsWithDissertation ({IdDepartment}, {Gender}, {MinBirthdate},{MaxAge}, {AmountChldren}, {MinSalary}) as CountStudents").FirstOrDefault().CountTeachers;
        }

        public IQueryable<StudentsDto> GetStudentInGroup(int GroupId, string StudentGender, DateTime StudentYearOfBirthdate,
            int MinAge, int AmountChildren, int IdStudyForm, int MinAmountScholarship) => FromExpression(() => 
                    GetStudentInGroup(GroupId, StudentGender, StudentYearOfBirthdate,
                        MinAge, AmountChildren, IdStudyForm, MinAmountScholarship)); //1

        public IQueryable<StudentsDto> GetGraduateStudentsWithDissertation(int IdDepartment, string Gender, DateTime MinBirthdate,
            int  MaxAge, int AmountChldren, int MinSalary) => FromExpression(() =>
                    GetGraduateStudentsWithDissertation(IdDepartment, Gender, MinBirthdate, MaxAge, AmountChldren, MinSalary)); //2
                                                                                                                                
        //public int GetCountGraduateStudentsWithDissertation(int IdDepartment, string Gender, DateTime MinBirthdate,
        //    int  MaxAge, int AmountChldren, int MinSalary) => 
        //            GetCountGraduateStudentsWithDissertation(IdDepartment, Gender, MinBirthdate, MaxAge, AmountChldren, MinSalary); //2

        public IQueryable<DepartmentDto> GetDissertation(int IdDepartment) => FromExpression(() =>
                  GetDissertation(IdDepartment)); //3

        public IQueryable<DepartmentDto> GetDepartment(int IdGroupStudents, int semester) => FromExpression(() =>
                  GetDepartment(IdGroupStudents, semester)); //4

        public IQueryable<StudentsDto> GetTeachersStudiesGroup(int IdGroupStudents, int IdSubject) => FromExpression(() =>
                  GetTeachersStudiesGroup(IdGroupStudents, IdSubject)); //5

        public IQueryable<StudentsDto> GetTeachersStudiesGroupInSem(int IdGroupStudents, int IdSubject) => FromExpression(() =>
                  GetTeachersStudiesGroupInSem(IdGroupStudents, IdSubject)); //6

        public IQueryable<StudentsDto> GetStudentsPassExamWithMark(int IdSubject, int @IdMark) => FromExpression(() =>
                  GetStudentsPassExamWithMark(IdSubject, @IdMark)); //7

        public IQueryable<StudentsDto> GetStudentsPassExamsGood(int IdGroupStudents) => FromExpression(() =>
                  GetStudentsPassExamsGood(IdGroupStudents)); //8

        public IQueryable<StudentsDto> GetTeachersExam(int IdGroupStudents, int IdSubject, int Semester) => FromExpression(() =>
                  GetTeachersExam(IdGroupStudents, IdSubject, Semester)); //9

        public IQueryable<StudentsDto> GetStudentsWithMarkExam(int IdGroupStudents, int IdSubject, int Mark, int Semester) => FromExpression(() =>
                  GetStudentsWithMarkExam(IdGroupStudents, IdSubject, Mark, Semester)); //10

        public IQueryable<StudentsWithGrWork> GetStudentsWithGrWorkInTeacher(int IdTeacher) => FromExpression(() =>
                 GetStudentsWithGrWorkInTeacher(IdTeacher)); //11
                                                             
        public IQueryable<StudentsDto> GetTeachersWithGrWork(int IdTeacher) => FromExpression(() =>
                 GetTeachersWithGrWork(IdTeacher)); //12

        public IQueryable<TeacherSubject> GetTeachersWorkload(int age) => FromExpression(() => 
                GetTeachersWorkload(age)); // 13
        
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=University;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDbFunction(() => GetCountStudentsInGroup(default, default, default, default, default, default, default));//1

            modelBuilder.HasDbFunction(() => GetGraduateStudentsWithDissertation(default, default, default, default, default, default));
            //modelBuilder.HasDbFunction(() => GetCountGraduateStudentsWithDissertation(default, default, default, default, default, default));//2

            modelBuilder.HasDbFunction(() => GetDissertation(default));//3

            modelBuilder.HasDbFunction(() => GetDepartment(default, default));//4

            modelBuilder.HasDbFunction(() => GetTeachersStudiesGroup(default, default));//5

            modelBuilder.HasDbFunction(() => GetTeachersStudiesGroupInSem(default, default));//6

            modelBuilder.HasDbFunction(() => GetStudentsPassExamWithMark(default, default));//7

            modelBuilder.HasDbFunction(() => GetStudentsPassExamsGood(default));//8

            modelBuilder.HasDbFunction(() => GetTeachersExam(default, default, default));//9

            modelBuilder.HasDbFunction(() => GetStudentsWithMarkExam(default, default, default, default));//10

            modelBuilder.HasDbFunction(() => GetStudentsWithGrWorkInTeacher(default));//11

            modelBuilder.HasDbFunction(() => GetTeachersWithGrWork(default));//12

            modelBuilder.HasDbFunction(() => GetTeachersWorkload(default));//13

            modelBuilder.HasDbFunction(() => GetStudentInGroup(default, default, default, default, default, default, default));

            modelBuilder.Entity<Dean>(entity =>
            {
                entity.ToTable("Dean");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFacultyNavigation)
                    .WithMany(p => p.Deans)
                    .HasForeignKey(d => d.IdFaculty)
                    .HasConstraintName("FK__Dean__IdFaculty__123EB7A3");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFacultyNavigation)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.IdFaculty)
                    .HasConstraintName("FK__Departmen__IdFac__03F0984C");
            });

            modelBuilder.Entity<Dissertation>(entity =>
            {
                entity.ToTable("Dissertation");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistributionDissertation>(entity =>
            {
                entity.ToTable("DistributionDissertation");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDissertationNavigation)
                    .WithMany(p => p.DistributionDissertations)
                    .HasForeignKey(d => d.IdDissertation)
                    .HasConstraintName("FK__Distribut__IdDis__2EDAF651");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.DistributionDissertations)
                    .HasForeignKey(d => d.IdTeacher)
                    .HasConstraintName("FK__Distribut__IdTea__2FCF1A8A");
            });

            modelBuilder.Entity<DistributionScience>(entity =>
            {
                entity.ToTable("DistributionScience");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdScienceNavigation)
                    .WithMany(p => p.DistributionSciences)
                    .HasForeignKey(d => d.IdScience)
                    .HasConstraintName("FK__Distribut__IdSci__29221CFB");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.DistributionSciences)
                    .HasForeignKey(d => d.IdTeacher)
                    .HasConstraintName("FK__Distribut__IdTea__2A164134");
            });

            modelBuilder.Entity<DistributionSubject>(entity =>
            {
                entity.ToTable("DistributionSubject");

                entity.HasOne(d => d.IdGroupStudentsNavigation)
                    .WithMany(p => p.DistributionSubjects)
                    .HasForeignKey(d => d.IdGroupStudents)
                    .HasConstraintName("FK__Distribut__IdGro__245D67DE");

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.DistributionSubjects)
                    .HasForeignKey(d => d.IdSubject)
                    .HasConstraintName("FK__Distribut__IdSub__236943A5");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.DistributionSubjects)
                    .HasForeignKey(d => d.IdTeacher)
                    .HasConstraintName("FK__Distribut__IdTea__22751F6C");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.ToTable("Faculty");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormControl>(entity =>
            {
                entity.ToTable("FormControl");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GraduateSchool>(entity =>
            {
                entity.ToTable("GraduateSchool");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.GraduateSchools)
                    .HasForeignKey(d => d.IdTeacher)
                    .HasConstraintName("FK__GraduateS__IdTea__367C1819");
            });

            modelBuilder.Entity<GraduateWork>(entity =>
            {
                entity.ToTable("GraduateWork");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.GraduateWorks)
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK__GraduateW__IdStu__32AB8735");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.GraduateWorks)
                    .HasForeignKey(d => d.IdTeacher)
                    .HasConstraintName("FK__GraduateW__IdTea__339FAB6E");
            });

            modelBuilder.Entity<GroupStudent>(entity =>
            {
                entity.Property(e => e.Number)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSpecialityNavigation)
                    .WithMany(p => p.GroupStudents)
                    .HasForeignKey(d => d.IdSpeciality)
                    .HasConstraintName("FK__GroupStud__IdSpe__09A971A2");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.ToTable("Mark");

                entity.Property(e => e.DateReceiving).HasColumnType("date");

                entity.Property(e => e.Mark1).HasColumnName("Mark");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK__Mark__IdStudent__3C34F16F");

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.IdSubject)
                    .HasConstraintName("FK__Mark__IdSubject__3B40CD36");
            });

            modelBuilder.Entity<MarkOfSubject>(entity =>
            {
                entity.ToTable("MarkOfSubject");

                entity.Property(e => e.DateReceiving).HasColumnType("date");

                entity.HasOne(d => d.IdStatusOfExamNavigation)
                    .WithMany(p => p.MarkOfSubjects)
                    .HasForeignKey(d => d.IdStatusOfExam)
                    .HasConstraintName("FK__MarkOfSub__IdSta__43D61337");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.MarkOfSubjects)
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK__MarkOfSub__IdStu__45BE5BA9");

                entity.HasOne(d => d.IdSubjectNavigation)
                    .WithMany(p => p.MarkOfSubjects)
                    .HasForeignKey(d => d.IdSubject)
                    .HasConstraintName("FK__MarkOfSub__IdSub__44CA3770");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Science>(entity =>
            {
                entity.ToTable("Science");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.ToTable("Speciality");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Specialities)
                    .HasForeignKey(d => d.IdDepartment)
                    .HasConstraintName("FK__Specialit__IdDep__06CD04F7");
            });

            modelBuilder.Entity<StatusOfExam>(entity =>
            {
                entity.ToTable("StatusOfExam");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.AmountScholarship).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGroupStudentsNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdGroupStudents)
                    .HasConstraintName("FK__Student__IdGroup__0F624AF8");

                entity.HasOne(d => d.IdStudyFormNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdStudyForm)
                    .HasConstraintName("FK__Student__IdStudy__0E6E26BF");
            });

            modelBuilder.Entity<StudyForm>(entity =>
            {
                entity.ToTable("StudyForm");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFormControlNavigation)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.IdFormControl)
                    .HasConstraintName("FK__Subject__IdFormC__1F98B2C1");

                entity.HasOne(d => d.IdTypeOccupationNavigation)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.IdTypeOccupation)
                    .HasConstraintName("FK__Subject__IdTypeO__1EA48E88");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Surname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.IdDepartment)
                    .HasConstraintName("FK__Teacher__IdDepar__17036CC0");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK__Teacher__IdPost__17F790F9");
            });

            modelBuilder.Entity<TypeOccupation>(entity =>
            {
                entity.ToTable("TypeOccupation");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
