using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Assignment_02.Tests
{
    class ConversionTest
    {
       
        [Test]
        public void ConvertCelciusToFahrenheitTest01_WithInput10_Expect50()
        {
            Conversion convert = new Conversion(10);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(50, result);
        }

        public void ConvertCelciusToFahrenheitTest02_WithInput20_Expect68()
        {
            Conversion convert = new Conversion(20);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(68, result);
        }

        public void ConvertCelciusToFahrenheitTest03_WithInput35_Expect95()
        {
            Conversion convert = new Conversion(35);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(95, result);
        }

        public void ConvertCelConvertCelciusIntoKelvinTest04_WithInput27_Expect300()
        {
            Conversion convert = new Conversion(27);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(300.15, result);
        }

        public void ConvertCelConvertCelciusIntoKelvinTest05_WithInput54_Expect327()
        {
            Conversion convert = new Conversion(54);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(327.15, result);
        }

        public void ConvertCelConvertCelciusIntoKelvinTest06_WithInput65_Expect388()
        {
            Conversion convert = new Conversion(65);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(338.15, result);
        }

        public void ConvertKelvinIntoFahrenheitTest07_WithInput17_Expect429()
        {
            Conversion convert = new Conversion(17);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(-429.07, result);
        }

        public void ConvertKelvinIntoFahrenheitTest08_WithInput27_Expect411()
        {
            Conversion convert = new Conversion(27);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(-411.07, result);
        }

        public void ConvertKelvinIntoFahrenheitTest09_WithInput45_Expect378()
        {
            Conversion convert = new Conversion(45);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(-378.67, result);
        }

        public void ConvertKelvinIntoCelsiusTest10_WithInput05_Expect268()
        {
            Conversion convert = new Conversion(5);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(-268.15, result);
        }

        public void ConvertKelvinIntoCelsiusTest11_WithInput36_Expect237()
        {
            Conversion convert = new Conversion(36);
            double result = convert.ConvertCelciusIntoFahrenheit();
            //assert
            Assert.AreEqual(-237.15, result);
        }







        /* 
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
         }*/

    }
}
