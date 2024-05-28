using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class Context : DbContext
    {
        DbSet<User> Users {  get; set; }
        DbSet<Professor> Professors {  get; set; }
        DbSet<Student> Students {  get; set; }
        DbSet<Question> Questions {  get; set; }
        DbSet<Response> Responses {  get; set; }
        DbSet<Subject> Subjects {  get; set; }


        public Context(DbContextOptions<Context> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasDiscriminator(u => u.UserType);

            modelBuilder.Entity<Student>().HasData(CreateStudentDataSeed());

            modelBuilder.Entity<Professor>().HasData(CreateProfessorDataSeed());

            modelBuilder.Entity<Subject>().HasData(CreateSubjectDataSeed());

            modelBuilder.Entity<Question>().HasData(CreateQuestionDataSeed());

            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.NoAction;
            }
        }

        private Student[] CreateStudentDataSeed()
        {
            Student[] result;
                result = [
                new Student
            {
                LastName = "Bologna",
                Name = "Nicolas",
                Email = "nbologna31@gmail.com",
                Username = "nbologna_alumno",
                Password = "123456",
                UserType = "Estudiante",
                Id = 1
            },
                new Student
                {
                    LastName = "Perez",
                    Name = "Juan",
                    Email = "Jperez@gmail.com",
                    Username = "jperez",
                    Password = "123456",
                    UserType = "Estudiante",
                    Id = 2
                },
                new Student
                {
                    LastName = "Garcia",
                    Name = "Pedro",
                    Email = "pgarcia@gmail.com",
                    Username = "pgarcia",
                    Password = "123456",
                    UserType = "Estudiante",
                    Id = 3
                }];

            return result;
        }


        private Professor[] CreateProfessorDataSeed()
        {
            Professor[] result = Array.Empty<Professor>();

           result = [
            new Professor
            {
                LastName = "Bologna",
                Name = "Nicolas",
                Email = "nbologna31@gmail.com",
                Username = "nbologna_profesor",
                Password = "123456",
                UserType = "Profesor",
                Id = 4
            },
            new Professor
            {
                LastName = "Paez",
                Name = "Pablo",
                Email = "ppaez@gmail.com",
                Username = "ppaez",
                UserType = "Profesor",
                Password = "123456",
                Id = 5
            }];

            return result;
        }


        private Subject[] CreateSubjectDataSeed()
        {
            Subject[] result;
                result =
                [
                new Subject
                {
                    Id = 1,
                    Name = "Programación 3",
                    Quarter = "Tercer"
                },
                new Subject
                {
                    Id = 2,
                    Name = "Programación 4",
                    Quarter = "Tercer"
                }
                ];

            return result;
        }

        private object[] CreateStudentsSubjectsAttendeDataSeed()
        {
            object[] result;
                result = new[]
                {
                new { StudentsId = 1, SubjectsAttendedId = 1},
                new { StudentsId = 1, SubjectsAttendedId = 2},
            };
 

            return result;
        }

        private object[] CreateProfessorSubjectDataSeed()
        {
            object[] result;

                result = new[]
                {
                new { ProfessorsId = 4, SubjectsId = 1},
                new { ProfessorsId= 5, SubjectsId = 1},
                new { ProfessorsId = 4, SubjectsId = 2},
            };

            return result;
        }

        private object[] CreateQuestionDataSeed()
        {
            object[] result;

                result =
                [
                    new
                {
                    Id = 1,
                    Title = "Question Title 1 for testing",
                    Description = "Question Description 1 for testing",
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    LastModificationDate = DateTime.Now,
                    QuestionState = Domain.Enum.QuestionState.WaitingProfessorAnwser,
                    AssignedProfessorId = 5,
                    StudentId = 1,
                    SubjectId = 1
                }
                ,new
                {
                    Id = 2,
                    Title = "Question Title 2 for testing",
                    Description = "Question Description 2 for testing",
                    CreationDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    LastModificationDate = DateTime.Now,
                    QuestionState = Domain.Enum.QuestionState.WaitingProfessorAnwser,
                    AssignedProfessorId = 4,
                    StudentId = 1,
                    SubjectId = 1
                }
                ];

            return result;
        }
    }
}
