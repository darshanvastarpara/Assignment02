using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Assignment_02.Tests
{
    class Class1
    {
        choice dTest = new choice();

        [TestCase]
        public void ConvertCelciusToFahrenheitTest()
        {

            //double answer = ((cValue * 1.8) + 32);
            double result = dTest.ConvertCelciusToFahrenheit(10);
            //assert
            Assert.AreEqual(50, result);

            //test2
            result = dTest.ConvertCelciusToFahrenheit(20);
            Assert.AreEqual(68, result);

            //test3
            result = dTest.ConvertCelciusToFahrenheit(30);
            Assert.AreEqual(86, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTest()
        {
            double result = dTest.ConvertCelciusToKelvin(10);

            //assert
            Assert.AreEqual(283.14999999999998, result);

        }
        [Test]
        public void ConvertKelvinToFahrenheitTest()
        {
            double result = dTest.ConvertCelciusToFahrenheit(10);

            //assert
            Assert.AreEqual(50.0, result);
        }
        [Test]
        public void ConvertKelvinToCelciusTest()
        {
            double result = dTest.ConvertKelvinToFahrenheit(10);

            //assert
            Assert.AreEqual(-441.66999999999996, result);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTest()
        {
            double result = dTest.ConvertFahrenheitToKelvin(10);

            //assert
            Assert.AreEqual(273.14999999999998, result);
        }
        [Test]
        public void ConvertFahrenheitToCelciusTest()
        {
            double result = dTest.ConvertFahrenheitToCelcius(10);

            //assert
            Assert.AreEqual(-12.222222222222221, result);
        }

    }
}
