using System;

namespace Converter
{
    class DecToBinConverter
    {
        public static string Convert(string dec)
        {
            int dividend = Int32.Parse(dec);

            if (dividend == 0)
                return "0";
            string bin = String.Empty;
            while (dividend != 0)
            {
                int remainder = dividend % 2;

                if (remainder == 0)
                {
                    bin = '0' + bin;
                }

                if (remainder == 1)
                {
                    bin = '1' + bin;
                }

                dividend = dividend / 2;
            }
            return bin;
        }
    }
}
