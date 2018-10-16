using System;
using System.Globalization;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number:");
            CultureInfo culture = CultureInfo.CurrentCulture;
            string number = Console.ReadLine();
            string numberUpper= number.ToUpper(culture);

            // Console.WriteLine(DecToBinConverter.Convert("75"));
            if (HexValidator.IsHex(number))
            {
                Console.WriteLine("Original number:" + " " + numberUpper);
                Console.WriteLine(HexToBinConverter.Convert(number));
                Console.WriteLine(HexToDecConverter.Convert(number));
            }
            else
            {
                Console.WriteLine("Not hex");
            }
        }
    }
}
