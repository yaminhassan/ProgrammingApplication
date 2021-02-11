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

        public static void DisplayChoices(string[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"\t\t{i+1} {list[i]}");
            }
        }
    }
}
