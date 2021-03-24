using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This Application is Designed to calculate the Studnt's Grade Based on their given Marks
    /// </summary>
    /// <author>
    /// Yamin Hassan
    /// </author>
    
    public class StudentGrade
    {
        // List of the Students can take dynamic number of students
        public List<Student> Students = new List<Student>();
        public string[] Grd = new string[] { "A", "B", "C", "D", "F" };
        public string[] list = new string[] { "1", "2", "3", "4" };
        // The Main Method that start the program and print the welcome message and gives 
        //options to choose from
        public StudentGrade()
        {

        }
        public void MainMenu()
        {
            Console.WriteLine("\t\t This is Student Grading console application" +
                              "\n\t\t\t By: Yamin Hassan" +
                              "\n\t\t Please enter from one of the choices below " +
                              "\n\t\t 1: Add Student\n \t\t 2: PrintAll\n\t\t 3: Mean Maximum and Minimum Mark"+
                              "\n\t\t 4: Grade Profile ");
            int choice = ConsolHelper.GetInput1();
            if (choice >= 1 && choice <= list.Length)
            {
                Choice(choice);
            }
            else
            {
                Console.WriteLine("Please Enter from Choices below ");
                MainMenu();
            }
        }  
        //Method to choose from Various options like Add Students, Print all students,
        // Calculate Minimum, Maximum and median Mark.
        public void Choice(int choice)
        {
            switch (choice)
            {
                case 1:
                    AddStudents();
                    break;
                case 2:
                    PrintAll();
                    break;
                case 3:
                    MaxMinMeanResult();
                    break;
                case 4:
                    GrdesPercentage();
                    break;                    
            }
        }

       
        // Print all student sin the Array list 
        public void PrintAll()
        {
            int count = 1;
            foreach (Student s in Students)
            {
                Console.WriteLine($"\t{count++}:{s}");
            }
            MainMenu();
        }
        // Method calculate the over all percentage of the whole result.
        public void GrdesPercentage()
        {
            for (int i = 0; i < Grd.Length; i++)
            {
                double count = 0;
                foreach (Student s in Students)
                {                    
                    if (s != null && s.Grade.Contains(Grd[i]))
                    {
                        count++;                        
                    }
                }
                
                 Console.WriteLine($" {Grd[i]} Position Holders Percentage: {count/ Students.Count*100} % ");
               
            }
            MainMenu();
        }

        // Calculate the Mean Max and Minumum number in student Marks      
        public void MaxMinMeanResult()
        {
            int max = Students.Max(students => students.Mark);
            Console.WriteLine($"\t\tThe Maximum Mark is: {max} ");

            int min = Students.Min(students => students.Mark);
            Console.WriteLine($"\t\tThe Minimum Mark is: {min}");
             
            double totalMarks = Students.Sum(pkg => pkg.Mark);
            double arrylistSize = Students.Count;
            double averageMarks = totalMarks / arrylistSize;
            Console.WriteLine($"\t\tThe Mean Marks for all of the Students is {averageMarks}\n\n");

            MainMenu();
        } 
        /// <summary>
        /// Method is to find the student with its id if it returns true 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student FindStudentById(int id)
        {
            foreach(Student student in Students)
            {
                if(student.ID == id)
                {
                    return student;
                }
            }
            return null;
        }
        // The method to create the object    
        public void AddObject(Student student)
        {
            if (FindStudentById(student.ID) != null)
            {
                Console.WriteLine("\t\tPlease enter the unique id as This Id already exist");

            }
            else
            {
                Students.Add(student);
            }
        }
        // Main method to use to add the student 
        public void AddStudents()
        {
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("\t\t You can add Student details and Grade Here\n\t\t Please " +
                                      "follow the instructions");
                Console.WriteLine("\t\tPlease Enter Student Id");
                int id = Convert.ToInt32(ConsolHelper.GetInput());
                Console.WriteLine("\t\tPlease Enter Students's Full Name");
                string name = Console.ReadLine();
                Console.WriteLine("\t\t Please Enter The Final Mark of the Student");
                int mark = ConsolHelper.GetInput1();
                Student student = new Student(id, name, mark);
                AddObject(student);
                
                Console.WriteLine(student);

                Console.WriteLine("Please enter yes for main menu or press any key to exit");
                // continue or finish the program
                string lastcommand = Console.ReadLine().ToLower();
                if (lastcommand == "yes")
                {
                    finish = true;
                    MainMenu();
                }
                else
                {                         
                    break;
                }
            }
        }       
    }
}

