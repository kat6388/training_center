using System;

namespace Converter
{
    class HexToDecConverter
    {
        public static string Convert(string hex)
        {
            string upper = hex.ToUpper();
            int dec = 0;
            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[i] >= ConstsCodesFromASCIITable.numbersCodeBegin && hex[i] <= ConstsCodesFromASCIITable.numbersCodeEnd)
                {
                    dec += (int)((hex[i] - ConstsCodesFromASCIITable.numbersCodeBegin) * (Math.Pow(16, (hex.Length - 1) - i)));
                }
                else
                {
                    dec += (int)(((upper[i] - ConstsCodesFromASCIITable.upperLettersCodeBegin) + 10) * (Math.Pow(16, (hex.Length - 1) - i)));
                }
            }
            return dec.ToString();
        }
    }
}
