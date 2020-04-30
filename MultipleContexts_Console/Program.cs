using MultipleContexts_Student;
using MultipleContexts_Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleContexts_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.tutorialspoint.com/entity_framework/entity_framework_multiple_dbcontext.htm

            using (var context = new MyStudentContext())
            {

                //// Create and save a new Students
                Console.WriteLine("Adding new students");

                var student = new Student
                {
                    FirstMidName = "Alain",
                    LastName = "Bomer",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 24
                };

                context.Students.Add(student);

                var student1 = new Student
                {
                    FirstMidName = "Mark",
                    LastName = "Upston",
                    EnrollmentDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 30
                };

                context.Students.Add(student1);
                context.SaveChanges();

                // Display all Students from the database
                var students = (from s in context.Students
                                orderby s.FirstMidName
                                select s).ToList<Student>();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var stdnt in students)
                {
                    string name = stdnt.FirstMidName + " " + stdnt.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", stdnt.ID, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

            using (var context = new MyTeacherContext())
            {

                //// Create and save a new Teachers
                Console.WriteLine("Adding new teachers");

                var student = new Teacher
                {
                    FirstMidName = "Alain",
                    LastName = "Bomer",
                    HireDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 24
                };

                context.Teachers.Add(student);

                var student1 = new Teacher
                {
                    FirstMidName = "Mark",
                    LastName = "Upston",
                    HireDate = DateTime.Parse(DateTime.Today.ToString())
                    //Age = 30
                };

                context.Teachers.Add(student1);
                context.SaveChanges();

                // Display all Teachers from the database
                var teachers = (from t in context.Teachers
                                orderby t.FirstMidName
                                select t).ToList<Teacher>();

                Console.WriteLine("Retrieve all teachers from the database:");

                foreach (var teacher in teachers)
                {
                    string name = teacher.FirstMidName + " " + teacher.LastName;
                    Console.WriteLine("ID: {0}, Name: {1}", teacher.ID, name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

        }
    }
}
