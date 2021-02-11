using System;

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


       /// <returns>Get input from the user such from , to and amount</returns> 
       
        
        // coversion method for the diffrent perimetres
        public double Conversion(int choice)
        {   
            
                switch (choice)
                {
                    case 1:
                        return METRE;
                    case 2:
                        return CM;
                    case 3:
                        return FEET;
                    case 4:
                        return INCH;
                    case 5:
                        return KM;
                    case 6:
                        return MILES;
                    case 7:
                        return YARD;
                    default:
                        return 1;
                }
                
           
        }
        // This method converts the input values to the output value.
        public void PrintResults()
        {
            while (true)
            {
                int firstChoice = ConsolHelper.SelectChoice("Pick 'From' the Unit in the List, you would like conversion", choices);
                int secondChoice = ConsolHelper.SelectChoice("Pick 'To' the Unit in the List, you would like conversion", choices);
                double amount = ConsolHelper.GetInput("Please select the amount\n");
                double result = (Conversion(firstChoice) / Conversion(secondChoice)) * amount;
                Console.WriteLine(result);


            }



            }
        }
               
}
