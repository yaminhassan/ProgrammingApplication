using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace Applicatio02testing
{
    [TestClass]
    public class UnitTest1
    {
        
        public BMI bmi = new BMI();
        [TestMethod]

        public void MatricUnitTest()
        {
            //<18.5 minumim Under weight
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 193;
            bmi.WeightKg = 45;
            bmi.WeightGrams = 50;
            double expectedresult = 12.1;
            Assert.AreEqual(expectedresult, bmi.GetResultMatric());
            //18.5 maximun under weight
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 193;
            bmi.WeightKg = 68;
            bmi.WeightGrams = 20;
            double expectedresult1 = 18.3;
            Assert.AreEqual(expectedresult1, bmi.GetResultMatric());
            //Normal 18.5 to 24.9 Minmum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 155;
            bmi.WeightKg = 45;
            bmi.WeightGrams = 50;
            double expectedresult2 = 18.8;
            Assert.AreEqual(expectedresult2, bmi.GetResultMatric());
            //Normal 18.5 to 24.9 Maximum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 193;
            bmi.WeightKg = 90;
            bmi.WeightGrams = 90;
            double expectedresult3 = 24.2;
            Assert.AreEqual(expectedresult3, bmi.GetResultMatric());
            //Over weight 25 to 29.9 Minimum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 152;
            bmi.WeightKg = 59;
            bmi.WeightGrams = 10;
            double expectedresult4 = 25.5;
            Assert.AreEqual(expectedresult4, bmi.GetResultMatric());
            // Over weight 25 to 29.9 Maximum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 183;
            bmi.WeightKg = 97;
            bmi.WeightGrams = 70;
            double expectedresult5 = 29;
            Assert.AreEqual(expectedresult5, bmi.GetResultMatric());

            // Obese I 30 to 34.9 Minimum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 152;
            bmi.WeightKg = 70;
            bmi.WeightGrams = 50;
            double expectedresult6 = 30.3;
            Assert.AreEqual(expectedresult6, bmi.GetResultMatric());
            // Obese I 30 to 34.9 Maximum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 168;
            bmi.WeightKg = 97;
            bmi.WeightGrams = 70;
            double expectedresult7 = 34.4;
            Assert.AreEqual(expectedresult7, bmi.GetResultMatric());

            // Obese II 35 to 39.9 Minimum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 153;
            bmi.WeightKg = 81;
            bmi.WeightGrams = 80;
            double expectedresult8 = 34.6;
            Assert.AreEqual(expectedresult8, bmi.GetResultMatric());

            // Obese II 35 to 39.9 Maximum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 157;
            bmi.WeightKg = 97;
            bmi.WeightGrams = 70;
            double expectedresult9 = 39.4;
            Assert.AreEqual(expectedresult9, bmi.GetResultMatric());

            //Obese III 40 and over Minimum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 155;
            bmi.WeightKg = 97;
            bmi.WeightGrams = 70;
            double expectedresult10 = 40.4;
            Assert.AreEqual(expectedresult10, bmi.GetResultMatric());

            //Obese III 40 and over Maximum
            bmi.HeightMetres = 0;
            bmi.HeightCentemetre = 153;
            bmi.WeightKg = 97;
            bmi.WeightGrams = 70;
            double expectedresult11 = 41.5;
            Assert.AreEqual(expectedresult11, bmi.GetResultMatric());


        }
        [TestMethod]

        public void ImperialUnitTest()
        {
            // Under weight 18.5 and less Minimum
            bmi.HeightInches = 4;
            bmi.HeightFeet = 6;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 100;
            double expectedresult = 12.2;
            Assert.AreEqual(expectedresult, bmi.GetResultImperial());

            //Under Weight 18.5 and less Maximum
            bmi.HeightInches = 4;
            bmi.HeightFeet = 6;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 150;
            double expectedresult1 = 18.3;
            Assert.AreEqual(expectedresult1, bmi.GetResultImperial());

            // Normal 18.5 to 24.9 Minimum
            bmi.HeightInches = 1;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 100;
            double expectedresult2 = 18.9;
            Assert.AreEqual(expectedresult2, bmi.GetResultImperial());

            //Normal 18.5 to 24.9 Maximum
            bmi.HeightInches = 4;
            bmi.HeightFeet = 6;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 200;
            double expectedresult3 = 24.3;
            Assert.AreEqual(expectedresult3, bmi.GetResultImperial());

            // Over Weight 25 to 29.9 Minimum
            bmi.HeightInches = 0;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 130;
            double expectedresult4 = 25.4;
            Assert.AreEqual(expectedresult4, bmi.GetResultImperial());

            // Over weight 25 to 29.9 Maximum
            bmi.HeightInches = 0;
            bmi.HeightFeet = 6;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 215;
            double expectedresult5 = 29.2;
            Assert.AreEqual(expectedresult5, bmi.GetResultImperial());

            // Obese I 30 to 39.9 minimum
            bmi.HeightInches = 0;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 155;
            double expectedresult6 = 30.3;
            Assert.AreEqual(expectedresult6, bmi.GetResultImperial());

            // Obese I 30 to 34.9 Maximum

            bmi.HeightInches = 6;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 215;
            double expectedresult7 = 34.7;
            Assert.AreEqual(expectedresult7, bmi.GetResultImperial());

            //Obese II 35 to 39.9 Minimum
            bmi.HeightInches = 0;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 180;
            double expectedresult8 = 35.2;
            Assert.AreEqual(expectedresult8, bmi.GetResultImperial());

            // Obese II 35 to 39.9 Maximum
            bmi.HeightInches = 2;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 215;
            double expectedresult9 = 39.3;
            Assert.AreEqual(expectedresult9, bmi.GetResultImperial());

            // Obese III 40 and over Minimum

            bmi.HeightInches = 1;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 215;
            double expectedresult10 = 40.6;
            Assert.AreEqual(expectedresult10, bmi.GetResultImperial());

            // Obese III 40 and over Maximum

            bmi.HeightInches = 0;
            bmi.HeightFeet = 5;
            bmi.WeightStone = 0;
            bmi.WeightLbs = 215;
            double expectedresult11 = 42;
            Assert.AreEqual(expectedresult11, bmi.GetResultImperial());
        }
        }
}
