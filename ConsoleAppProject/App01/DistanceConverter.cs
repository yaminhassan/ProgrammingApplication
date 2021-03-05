using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppProject.App01
{
    /// <Units conversion class>
    /// This is Distance Converter class it holds the methods to convert the units
    /// This Class runs the operations to convert the units to another one.
    /// <author>
    /// Yamin Hassan
    /// </author>
    public class DistanceConverter
    {
        private string[] choices = new string[] { "METRE","CM", "FEET", "INCH","KM", "MILES", "YARD" };
        private  const double CM = 10;            // mm in one cm 
        private  const double METRE = 1000;       // mm in one metre
        private  const double KM = 1000000;       // mm in one kilometre
        private  const double INCH = 25.4;        // mm in one inch
        private  const double YARD = 914.4;       // mm in one yard
        private  const double  MILES = 1609344;  // mm in one mile
        private  const double FEET = 304.8;       //mm in one feet
        private const string Yes = "yes";
        // First choice to choose from 
        public DistanceUnits FirstChoice { get; set; }
        // The second choice the unit need to convert to
        public DistanceUnits SecondChoice { get; set; }
        // the result of the alculation 
        public double Result { get; set;}
        // The amount need to convert into the unit
        public double Amount { get; set; }
        // the list of double units with the key element
        public Dictionary<DistanceUnits, double> dictionary = new Dictionary<DistanceUnits, double>();
        /// <summary>
        /// The values of the units added and  inatialized with the key 
        /// </summary>
        public DistanceConverter()
        {
            dictionary.Add(DistanceUnits.Metres, METRE);
            dictionary.Add(DistanceUnits.Centimetres, CM);
            dictionary.Add(DistanceUnits.Feet, FEET);
            dictionary.Add(DistanceUnits.Inch, INCH);
            dictionary.Add(DistanceUnits.Kilometres, KM);
            dictionary.Add(DistanceUnits.Miles, MILES);
            dictionary.Add(DistanceUnits.Yard, YARD);
        }
        /// <summary>
        /// This method converts the input values to the output value
        /// </summary>
        public void PrintResults()
        {           
            while (true)
            {
                 FirstChoice = dictionary.ElementAt(ConsolHelper.SelectChoice("\tPick 'From' the Unit in the List, you would like conversion", choices)-1).Key;
                SecondChoice = dictionary.ElementAt(ConsolHelper.SelectChoice("\tPick 'To' the Unit in the List, you would like conversion", choices)-1).Key;
                Amount = ConsolHelper.GetInput("\tPlease select the amount\n");

                Console.WriteLine("The Result is:");
                Console.WriteLine(GetResult());
                Console.WriteLine("\tWould you like to another Conersion \n Yes \n No");
                String lastcommand = Console.ReadLine().ToLower();
                 if(lastcommand == Yes)
                {
                    continue;
                }
                
                break;
            }

        }
        /// <summary>
        /// Get result method takes choices and display result
        /// </summary>
        /// <returns></returns>
        public double GetResult()
        {
            return Math.Round((dictionary[FirstChoice] / dictionary[SecondChoice]*Amount), 2);
        }
        
        }
               
}
