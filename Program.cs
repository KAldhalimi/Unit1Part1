using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! please provide me with 3 numbers");
            string numberOne = Console.ReadLine();
            string numberTwo = Console.ReadLine();
            string numberThree = Console.ReadLine();
            double convertedNumberOne = double.Parse(numberOne);
            double convertedNumberTwo = double.Parse(numberTwo);
            double convertedNumberThree = double.Parse(numberThree);

            double total = convertedNumberOne + convertedNumberTwo + convertedNumberThree;
            double average = total / 3;

            double lowestNumber = convertedNumberOne;
            if (convertedNumberTwo < lowestNumber)
            {
                lowestNumber = convertedNumberTwo;
            }
            if (convertedNumberThree < lowestNumber)
            {
                lowestNumber = convertedNumberThree;
            }

            double highestnumber = convertedNumberOne;
            if (convertedNumberTwo > highestnumber)
            {
                highestnumber = convertedNumberTwo;
            }
            if(convertedNumberThree > highestnumber)
            {
                highestnumber = convertedNumberThree;
            }



            string totalDisplayUS = String.Format("{0:C}", total);
            string totalDisplayJapenese = string.Format(new CultureInfo("ja-JP"), "{0:C}", total);
            string totalDisplayThai = string.Format(new CultureInfo("th-TH"), "{0:C}", total);
            string totalDisplayswedish = string.Format(new CultureInfo("sv-SE"), "{0:C}", total);
            Console.Write("US: " + totalDisplayUS + "\nJapanese: " + totalDisplayJapenese + " \nThai: " + totalDisplayThai + " \nSwedish: " + totalDisplayswedish + " \nAverage: " + average + " \nLowest Number: " + lowestNumber + " \nMax Number: " + highestnumber);

            Console.ReadKey();
        }
    }
}
