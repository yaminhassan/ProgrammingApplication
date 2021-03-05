using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject
{
   public static  class ConsolHelper
    {
        /// <summary>
        /// The GetInput method take a perametre string and take in put and through exception if it is not a double number
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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
        /// <summary>
        /// the Getinput method catch the exception if it can't handle
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// The GetInput take three perametres
        /// </summary>
        /// <param name="message"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The Bmi result display the result according to the result
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

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
        /// <summary>
        /// The list list item details
        /// </summary>
        /// <param name="list"></param>
        
        public static void DisplayChoices(string[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"\t\t{i+1} {list[i]}");
            }
        }
    }
}
