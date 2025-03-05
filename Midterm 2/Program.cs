using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userInput = 0;
            string fromCurrency = "";
            string toCurrency = "";

            Console.Write("Insert money amount to convert: ");

            userInput = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("What currency is the money? Insert USD, EUR, or JPY.");

            fromCurrency = Console.ReadLine();
             fromCurrency.ToUpper();

            Console.WriteLine("What do you want to convert this to?");
            Console.WriteLine($"USD, EUR, Or JPY?");
            toCurrency = Console.ReadLine();
             toCurrency.ToUpper();


            if (fromCurrency == toCurrency)
            {
                Console.WriteLine("Already that currency!");
            }
            
            
            switch (fromCurrency)
            {
                case "USD":
                    ConvertToUSD(userInput, toCurrency); 
                    break;

                case "EUR":
                    ConvertToEUR(userInput, toCurrency);
                    break;
                case "JPY":
                    ConvertToJPY(userInput, toCurrency);
                    break;
                default:
                    Console.WriteLine("Not an option. Make sure to capitalize.");
                    break;
            }
            Console.ReadLine();

        }

        static void ConvertToUSD(double userInput, string toCurrency)
        {
            double result = 0;


            switch (toCurrency)
            {
                case "EUR":
                    Console.WriteLine("Converting USD to EUR");
                    result = userInput * 0.95;
                    Console.WriteLine($"{userInput} USD converted to EUR is {result}.");
                    result = 0;
                    break;

                case "JPY":
                    Console.WriteLine("Converting USD to JPY");
                    result = userInput * 25;
                    Console.WriteLine($"{userInput} USD converted to JPY is {result}.");
                    result = 0;
                    break;
            }
            
            
        }

        static void ConvertToEUR(double userInput, string toCurrency)
        {
            double result = 0;


            switch (toCurrency)
            {
                case "USD":
                    Console.WriteLine("Converting EUR to USD");
                    result = userInput * 1.95;
                    Console.WriteLine($"{userInput} EUR converted to USD is {result}.");
                    result = 0;
                    break;

                case "JPY":
                    Console.WriteLine("Converting EUR to JPY");
                    result = userInput * 26;
                    Console.WriteLine($"{userInput} EUR converted to JPY is {result}.");
                    result = 0;
                    break;
            }

        }

        static void ConvertToJPY(double userInput, string toCurrency)
        {

            double result = 0;


            switch (toCurrency)
            {
                case "USD":
                    Console.WriteLine("Converting JPY to USD");
                    result = userInput / 25;
                    Console.WriteLine($"{userInput} JPY converted to USD is {result}.");
                    result = 0;
                    break;

                case "EUR":
                    Console.WriteLine("Converting JPY to EUR");
                    result = userInput / 26;
                    Console.WriteLine($"{userInput} JPY converted to EUR is {result}.");
                    result = 0;
                    break;
            }

        }


    }
}
