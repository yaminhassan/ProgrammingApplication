using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App01UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public DistanceConverter converter = new DistanceConverter();

        [TestMethod]
        public void MileToFeet()
        {
            // 1 Mile to Feet
            converter.FirstChoice = DistanceUnits.Miles;

            converter.SecondChoice = DistanceUnits.Feet;

            converter.Amount = 1;
            double expectedResult = 5280;
            Assert.AreEqual(expectedResult, converter.GetResult());
            
            // 2 Miles to feet
            converter.FirstChoice = DistanceUnits.Miles;

            converter.SecondChoice = DistanceUnits.Feet;

            converter.Amount = 2;
            double expectedResult1 = 10560;
            Assert.AreEqual(expectedResult1, converter.GetResult());
        }
        [TestMethod]
        //Feets conversion to Miles
        public void FeettoMile()
        {
            // 5280Feet to Miles
            converter.FirstChoice = DistanceUnits.Feet;

            converter.SecondChoice = DistanceUnits.Miles;

            converter.Amount = 5280;
            double expectedResult = 1;
            Assert.AreEqual(expectedResult, converter.GetResult());

            //10560 Feet to Miles
            converter.FirstChoice = DistanceUnits.Feet;

            converter.SecondChoice = DistanceUnits.Miles;

            converter.Amount = 10560;
            double expectedResult1 = 2;
            Assert.AreEqual(expectedResult1, converter.GetResult());
        }

        [TestMethod]
        
        // Miles to Metres
        public void MileToMetres()
        {
            // 1 mile to Metres
            converter.FirstChoice = DistanceUnits.Miles;

            converter.SecondChoice = DistanceUnits.Metres;

            converter.Amount = 1;
            double expectedResult = 1609.34;
            Assert.AreEqual(expectedResult, converter.GetResult());
            
            // 2 Miles to Metres
            converter.FirstChoice = DistanceUnits.Miles;
            converter.SecondChoice = DistanceUnits.Metres;
            converter.Amount = 2;
            double expectedResult1 = 3218.69;

            Assert.AreEqual(expectedResult1, converter.GetResult());

        }
        [TestMethod]
        // Meter to Mile
        public void MeterToMile()
        {
            //1609.24 Metres To Mile
            converter.FirstChoice = DistanceUnits.Metres;

            converter.SecondChoice = DistanceUnits.Miles;

            converter.Amount = 1609.34;
            double expectedResult = 1;
            Assert.AreEqual(expectedResult, converter.GetResult());

            // 3218.69 Metres To Miles
            converter.FirstChoice = DistanceUnits.Metres;

            converter.SecondChoice = DistanceUnits.Miles;

            converter.Amount = 3218.69;
            double expectedResult1 = 2;
            Assert.AreEqual(expectedResult1, converter.GetResult());


        }
        [TestMethod]
        public void MetreToFeet()
        {
            //1 Metre To feet
            converter.FirstChoice = DistanceUnits.Metres;

            converter.SecondChoice = DistanceUnits.Feet;

            converter.Amount = 1;
            double expectedResult = 3.28;
            Assert.AreEqual(expectedResult, converter.GetResult());

            //2 Metre to feet
            converter.FirstChoice = DistanceUnits.Metres;

            converter.SecondChoice = DistanceUnits.Feet;

            converter.Amount = 2;
            double expectedResult1 = 6.56;
            Assert.AreEqual(expectedResult1, converter.GetResult());
        }

        [TestMethod]
        public void FeetToMetres()
        {
            // 3.28 Feet to metres
            converter.FirstChoice = DistanceUnits.Feet;

            converter.SecondChoice = DistanceUnits.Metres;

            converter.Amount = 3.28;
            double expectedResult = 1;
            Assert.AreEqual(expectedResult, converter.GetResult());

            // 6.56 Feet to metres
            converter.FirstChoice = DistanceUnits.Feet;

            converter.SecondChoice = DistanceUnits.Metres;

            converter.Amount = 6.56;
            double expectedResult2 = 2;
            Assert.AreEqual(expectedResult2, converter.GetResult());
        }
        

        
    }
}
