using ConsoleAppProject.App01;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App01Testing
{
    [TestClass]
    public class UnitTest1
    {
        public DistanceConverter converter = new DistanceConverter();
        
        [TestMethod]
        public void MetreToKilometre()
        {
            converter.FirstChoice = DistanceUnits.Metres;

            converter.SecondChoice = DistanceUnits.Kilometres;

            converter.Amount = 200;
            double expectedResult = 0.2;
            Assert.AreEqual(expectedResult, converter.GetResult());

        }
        // Meter to Mile
        [TestMethod]

        public void MeterToMile()
        {

        }

       
       
    }
}
