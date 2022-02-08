using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Conversion
    {
        private double conversionValue;
        public double ConversionValue { get => conversionValue; set => conversionValue = value; }
        public Conversion()
        {
            this.ConversionValue = 1;
        }

        public Conversion(double conversionvalue)
        {
            this.ConversionValue = conversionValue;
        }
        public double ConvertCelciusIntoFahrenheit()
        {
            return (this.conversionValue * 1.8) + 32;
        }
        public double ConvertCelciusIntoKelvin()
        {
            return this.conversionValue + 273.15;
        }
        public double ConvertKelvinIntoFahrenheit()
        {
            return (this.conversionValue * 1.8) - 241.15;
        }
        public double ConvertKelvinIntoCelsius()
        {
            return this.conversionValue - 273.15;
        }
        public double ConvertFahrenheitIntoKelvin()
        {
            return (this.conversionValue * 1.8) + 241.15;
        }
        public double ConvertFahrenheitIntoCelsius()
        {
            return ((this.conversionValue - 32) * 1.8);
        }
    }
}
