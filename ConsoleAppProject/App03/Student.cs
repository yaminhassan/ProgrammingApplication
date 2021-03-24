using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This is a Stuent class it is a blue print of the studnt it has  Id, Name , Mark and Grade 
    /// of the student and also it can convert the given mark to grade.
    /// </summary>
	public class Student
    {
        /// <summary>
        /// Id of the student
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Name of the student
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Mark of the student
        /// </summary>
        public int Mark { get; set; }
        
        /// <summary>
        /// Grade of the student
        /// </summary>
        public string Grade { get; set; }      
           /// <summary>
           /// Constructor for web Application
           /// </summary>
        public Student( )
        {
            CalculateGrade(Mark);
        }
        /// <summary>
        /// Constructor for the Student object 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="mark"></param>
        public Student(int id, string name, int mark)
        {
            ID = id;
            Name = name;
            Mark = mark;
            CalculateGrade(mark);

        }
        /// <summary>
        /// The conversion method to convert the Mark to Grade.
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public String CalculateGrade(int mark)
        {
            if (mark >= 70 && Mark <= 100)
            {
                Grade = "A";
            }
            if (mark >= 60 && Mark <= 69)
            {
                Grade = "B";
            }
            if (mark >= 50 && Mark <= 59)
            {
                Grade = "C";
            }
            if (mark >= 40 && Mark <= 49)
            {
                Grade = "D";
            }
            if (mark < 39)
            {
                Grade = "F";
            }
            return Grade;
        }
        /// <summary>
        /// ToString Method to print the instance of the class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\tID: " + ID + " Name: " +Name + " Mark: " + Mark + " Grade:  " + Grade + "\n\n";
        }

    }
		
	

}