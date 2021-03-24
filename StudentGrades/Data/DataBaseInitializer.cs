using ConsoleAppProject.App03;

using System;
using System.Linq;

namespace StudentGrades.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentData context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student(88,"Yamin Hassan", 58),
            new Student(87,"Yamin Hassan", 58),
            new Student(86,"Yamin Hassan", 58),
            new Student(82,"Yamin Hassan", 58),
            new Student(81,"Yamin Hassan", 58),
            new Student(83,"Yamin Hassan", 58),
            new Student(85,"Yamin Hassan", 58),

            };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}