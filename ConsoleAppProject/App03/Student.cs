using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App03
{
	public class Student
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public string Grade { get; set; }
        public int Percentage { get; set; }


        public Student(int id, string name, int mark)
        {
            Id = id;
            Name = name;
            Mark = mark;

        }
        public void CalculateGrade(int mark)
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

        }
        public override string ToString()
        {
            return "\tID: " + Id + " Name: " +Name + " Mark: " + Mark + " Grade:  " + Grade+ "\n\n";
        }

    }
		
	

}