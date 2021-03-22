using System.Collections.Generic;
using System;
namespace ContosoUniversity.Models    
{
    public enum Grade
    {
        A, B, C, D, F, NotAssigned
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int Mark { get; set; }
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public ICollection<Student> Student { get; set; }


        

        public Grade GradeCalculator ()
        {
           
            if(70<= Mark && Mark<=100)
            {
                Grade grade = Models.Grade.A;
                return grade;
            }
            else if(60 <= Mark && Mark <= 69)
            {
                Grade grade = Models.Grade.B;
                return grade;
            }
            else if (50 <= Mark && Mark <= 59)
            {
                Grade grade = Models.Grade.C;
                return grade;
            }
            else if (40 <= Mark && Mark <= 49)
            {
                Grade grade = Models.Grade.D;
                return grade;
            }
            else if (0 <= Mark && Mark <= 39)
            {
                Grade grade = Models.Grade.F;
                return grade;
            }
            return Models.Grade.NotAssigned;

        }

        public Student FindStudent(int number)
        {
            foreach(Student Students in Student)
                if(Students.ID==number)
                {
                    System.Console.WriteLine(Students);  
                }
            else
            {
                System.Console.WriteLine("Please use valid student id");
            }
            return null;
        }
        public void PrintAll()
        {
            foreach(Student Students in Student)
            {
                System.Console.WriteLine(Students); 
            }
            
        }
    }
}