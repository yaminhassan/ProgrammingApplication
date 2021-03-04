using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This Application is Designed to calculate the body mass index of individuals
    /// </summary>
    /// <author>
    /// Yamin Hassan
    /// </author>
    public class BMI
    {
        // The List of units determin the input must not be less than 1 and more than 2
        public string[] choices = new string[] { "Matric", "Imperial" };
        // The get and set method for Web application for Height in metres.
        public double HeightMetres { get; set; }
        // The get and set method for Web application for Height in Inches.
        public double HeightInches { get; set; }
        //The get and set method for Web application for Weight in Kilo grames.
        public double WeightKg { get; set;}
        //The get and set method for Web application for Weight in Kilo Poubds.
        public double WeightLbs { get; set; }
        // The get and set method for Result.
        public double Result { get; set; }
        public double HeightFeet { get;  set; }
        public double WeightStone { get; set; }
        public double HeightCentemetre { get;  set; }
        public double WeightGrams { get;  set; }

        // The Choice method let the console user choose from matric and imperial units.
        public void Choice()
        {            
            int unitChoice = ConsolHelper.SelectChoice("\t Body Mass Index\n\t\t By Yamin Hassan" +
                                                        "\n\tPlease use matric units to calculate your BMI", choices);
            ChooseUnits(Convert.ToInt32(unitChoice));
        }
        // The switch statement determin which method to use by user to calculate BMI
        public void ChooseUnits(int choose)
        {
            switch (choose)
            {
                case 1:
                    PrintMatricResults();
                    break;

                case 2:
                    PrintImperialConversion();
                    break;                
            }
        }
        /// <summary>
        /// The PrintMatricResults calculate the Matric units and display the result.
        /// </summary>

        private void PrintMatricResults()
        {
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("\t Body Mass Index\n\t By Yamin Hassan");
                Console.WriteLine("\n\tPlease use matric units to calculate your BMI" +
                                  "\n\t Please  Enter your height in Metres >");

                HeightMetres = ConsolHelper.GetInput();
                
                Console.WriteLine("\tPlease  Enter your height in Centimetres >");
                HeightCentemetre = ConsolHelper.GetInput();

                Console.WriteLine($"\tWell you are {HeightMetres} Metres and {HeightCentemetre} Centimetres  tall");
                

                Console.WriteLine("\tPlease enter your weigt in Kilograms >");
                WeightKg = ConsolHelper.GetInput();

                Console.WriteLine("\tPlease enter your weigt in Grams >");
                WeightGrams = ConsolHelper.GetInput();

                Console.WriteLine($"\tThanks for your weight. You weight: {WeightKg}KG and {WeightGrams}");

                double Result = Math.Round((WeightKg + (WeightGrams / 1000)) / Math.Pow((HeightMetres + (HeightCentemetre / 100)), 2), 1);
                Console.WriteLine(Result);
                ConsolHelper.BmiResult(Result);

               
                String lastcommand = Console.ReadLine().ToLower();

                if (lastcommand == "yes")
                {
                    finish = true;
                    Choice();
                }
                else
                {
                    finish = false;
                    break;                  
                }                
            }
        }
        // The PrintMatricResults calculate the Imperial units and display the result.
        public void PrintImperialConversion()
        {
            bool finish = false;
            while (!finish)
            {
                Console.WriteLine("\t Body Mass Index\n\t By Yamin Hassan");
                Console.WriteLine("\n\tPlease use matric units to calculate your BMI" +
                                  "\t Please  Enter your height in Feet >");

                HeightFeet = ConsolHelper.GetInput();
                Console.WriteLine("Please enter your height in Inches");

                HeightInches = ConsolHelper.GetInput();
                Console.WriteLine($"\tWell you are {HeightFeet} feet and {HeightInches} Centimetres  tall");

                Console.WriteLine("\n\tPlease enter your weigt in stones >");
                WeightStone = ConsolHelper.GetInput();

                Console.WriteLine("Please enter your weight in Pounds");
                WeightLbs = ConsolHelper.GetInput();

                Console.WriteLine($"\tThanks for your weight. You weight: {WeightStone} Stones and {WeightLbs} Lbs");

                double Result = Math.Round(((WeightLbs+ WeightStone*14) / Math.Pow((HeightInches + HeightFeet*12), 2)) * 703, 1);
                Console.WriteLine(Result);
                ConsolHelper.BmiResult(Result);


                String lastcommand = Console.ReadLine().ToLower();

                if (lastcommand == "yes")
                {
                    finish = true;
                    Choice();
                }
                else
                {                    
                    break;
                }
            }
        }
        public double GetResultMatric()
        {
            return Math.Round((WeightKg + (WeightGrams / 1000)) / Math.Pow((HeightMetres + (HeightCentemetre / 100)), 2), 1);
        }
        public double GetResultImperial()
        {            
          return Math.Round((((WeightLbs +( WeightStone * 14)) / Math.Pow((HeightInches + (HeightFeet * 12)), 2)) * 703), 1);
        }
        
    }
}
