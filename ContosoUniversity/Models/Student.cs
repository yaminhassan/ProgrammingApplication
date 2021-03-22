using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Mark { get; set; }
        List<Student> Stulist = new List<Student>();
        //public DateTime EnrollmentDate { get; set; }
        //public Course Course { get; set; }

        //public ICollection<Enrollment> Enrollments { get; set; }
        
        public Student()
        {
        }

        public void MainMenu()
        {
            Console.WriteLine("\t\t This is Student Grade Application" +
                              " You can use options below \n\t\t 1: Add student" +
                              "\n\t\t 2: Display all students\n\t\t 3: Add Marks to exiting Students" +
                              "\n\t\t 4: Calculate Mean, Max and minimum Mark");
            Console.WriteLine("Please enter From one of the choices above");
            int choice = Convert.ToInt32(ConsoleHelper.GetInput());
            ChooseOptions(choice);
        }

        public void ChooseOptions(int choice)
        {
            switch(choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    PrintAll();
                    break;
                case 3:
                    AddMarks();
                    break;
                case 4:
                    CalculateMean();
                    break;
                case 5:
                    GradeProfile();
                    break;
            }
        }

        private void GradeProfile()
        {
            throw new NotImplementedException();
        }

        private void CalculateMean()
        {
            throw new NotImplementedException();
        }

        private void PrintAll()
        {
            throw new NotImplementedException();
        }

        public Student AddStudent()
        {
            Console.WriteLine("\t\t Plesae add the student");
            Console.WriteLine("\t\t Please enter student id and use the number ");
            int id = Convert.ToInt32(ConsoleHelper.GetInput());
            Console.WriteLine("Please enter Student First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("\t\t Please enter last name");
            string lastName = Console.ReadLine();
            Mark=Convert.ToInt32(ConsoleHelper.GetInput());
            Student newStudent = new Student();
            Stulist.Add(newStudent);
            return newStudent;
            

        }
        public void AddMarks()
        {
            Console.WriteLine("Please enter the Id of the student");
            int id = Convert.ToInt32(ConsoleHelper.GetInput());
            foreach (Student student in Stulist)
            
                if(ID==id)
                {
                    int marks = Convert.ToInt32(ConsoleHelper.GetInput());
                    Mark = marks;
                    Console.WriteLine(Mark);
                }
                else
                {
                    Console.WriteLine("Please enter valid id");
                    AddMarks();
                }
                    
        }
    }

    
}