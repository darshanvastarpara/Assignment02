using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;

            int a;
            double choice;
            do
            {
                string responseSecond = string.Empty;
                Console.WriteLine("\n Select Any option from below:");
                Console.WriteLine("Press - 1.Convert Celcius to Fahrenheit");
                Console.WriteLine("Press - 2.Convert Celcius to Kelvin");
                Console.WriteLine("Press - 3.Convert Fahrenheit to Kelvin");
                Console.WriteLine("Press - 4.Convert Fahrenheeit to Celcius");
                Console.WriteLine("Press - 5.Convert Kelvin to Fahrenheit");
                Console.WriteLine("Press - 6.Convert Kelvin to Celcius");
                Console.WriteLine("Press - 7.Eait");

                userChoice = string.Empty;


                do
                {
                    Console.Write("select option  from 1 to 7: ");
                    userChoice = Console.ReadLine();
                } while (!int.TryParse(userChoice, out a) || (a < 1) || (a > 7));



                double convertedValue;
                switch (a)
                {

                    case 1:
                        Console.WriteLine("Enter Celcius Value to convert into Fahrenheit");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c1 = new Conversion(choice);
                        convertedValue = c1.ConvertCelciusIntoFahrenheit();
                        Console.WriteLine(convertedValue + " Fahrenheit");
                        break;

                    case 2:
                        Console.WriteLine("Enter Celcius Value to convert into Kelvin");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c2 = new Conversion(choice);
                        convertedValue = c2.ConvertCelciusIntoKelvin();
                        Console.WriteLine(convertedValue + " Kelvin");
                        break;

                    case 3:
                        Console.WriteLine("Enter Fahrenheeit Value to convert into Kelvin");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c3 = new Conversion(choice);
                        convertedValue = c3.ConvertFahrenheitIntoKelvin();
                        Console.WriteLine(convertedValue + " Kelvin");
                        break;

                    case 4:
                        Console.WriteLine("Enter Fahrenheit Value to convert into Celcius");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c4 = new Conversion(choice);
                        convertedValue = c4.ConvertFahrenheitIntoCelsius();
                        Console.WriteLine(convertedValue + " Celcius");
                        break;

                    case 5:
                        Console.WriteLine("Enter Kelvin Value to convert into Fahrenheit");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c5 = new Conversion(choice);
                        convertedValue = c5.ConvertKelvinIntoFahrenheit();
                        Console.WriteLine(convertedValue + " Fahrenheit");
                        break;

                    case 6:
                        Console.WriteLine("Enter Kelvin Value to convert into Celcius");
                        choice = double.Parse(Console.ReadLine());
                        Conversion c6 = new Conversion(choice);
                        convertedValue = c6.ConvertKelvinIntoCelsius();
                        Console.WriteLine(convertedValue + " Celsius");
                        break;

                    case 7:
                        Console.WriteLine("\n\n Please Wait...");
                        break;

                    default:

                        Console.WriteLine("Please nter a proper choice.");
                        break;

                }

            } while (a != 7);


            Console.ReadKey();
        }
    }
}
