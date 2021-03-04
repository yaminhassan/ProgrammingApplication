using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
   public static  class ConsolHelper
    {
        public static double GetInput(string message)
        {
            try
            {
                Console.WriteLine(message);
                return Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception)
            {

                Console.WriteLine("please type in a number");
                return GetInput(message);
        
             }
        
        }
        public static double GetInput()
        {
            try
            {
                
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("please type in a number");
                return GetInput();

            }

        }
        public static double GetInput(string message, double min, double max)
        {

            double number = GetInput(message);
            if(min <= number && number <= max)
            {
                return number;
            }
            else
            {
                return GetInput(message, min, max);
            }

        }
        public static int SelectChoice(string message, string[] list)
        {
            Console.WriteLine(message);
            DisplayChoices(list);
            return (int)GetInput("Plese enter your choice number", 1, list.Length);
        }

        public static double BmiResult(double number)
        {
            if (number < 18.5)
            {
                Console.WriteLine($"The BMI is: {Math.Round(number, 1)} \n You are Underweight");
            }
            else if (18.5 <= number && number <= 24.9)
            {
                Console.WriteLine($"The BMI is: {Math.Round(number, 1)} \n You are Normal weight");
            }
            else if (25 <= number && number <= 29.9)
            {
                Console.WriteLine($"The BMI is: {Math.Round(number, 1)} \n You are Over weight");
            }
            else if (30 <= number && number <= 34.9)
            {
                Console.WriteLine($"The BMI is: {Math.Round(number,1)} \n You are Obesity Class I");
            }
            else if (35 <= number && number <= 39.9)
            {
                Console.WriteLine($"The BMI is: {Math.Round(number, 1)} \n You are Obesity Class I");
            }
            else if (number >= 40)
            {
                Console.WriteLine($"\tThe BMI is: {Math.Round(number, 1)} \n You are Obesity Class III");
            }
            Console.WriteLine("\t If you are Black, Asian or other minority\n ethnic group, you have a higher risk" +
                                 "\n \tAdult 23 or more are at increased risk\n\t Adult 27 or more are at high risk");
            Console.WriteLine(" \tWould you like to another Conersion \n\t Yes \n\t No");
            return number;


        }

        
        public static void DisplayChoices(string[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"\t\t{i+1} {list[i]}");
            }
        }
    }
}
