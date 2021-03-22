using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using ConsoleAppProject;

using System;

namespace Applicatio03_Unit_Testing
    
{
    [TestClass]
    public class UnitTest1
    {
        
        public StudentGrade student = new StudentGrade();
        
        [TestMethod]
        public void GradeCalculationTest()
        {
            Student s = new Student(55, "Yamin", 90);
            s.CalculateGrade(s.Mark);            
            string expectedResult = "A";
            Assert.AreEqual(expectedResult, s.Grade); 
        }
        [TestMethod]

        public void DuplicateAddToList()
        {
            Student s = new Student(55, "Yamin", 90);
            student.AddObject(s);
            Student b = new Student(55, "Yamin", 90);
            student.AddObject(b);


            
            Assert.AreEqual(1, student.Students.Count);
        }
        [TestMethod]
        public void MenuChoice()
        {
            Student s = new Student(55, "Yamin", 90);
            student.AddObject(s);
            ConsolHelper.GetInput().
            



            Assert.AreEqual(, student.Students.Count);
        }


    }
}
