using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class ConsoleHelper
    {
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
}
