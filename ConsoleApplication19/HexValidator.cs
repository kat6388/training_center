namespace Converter
{
    class HexValidator
    {
        public static bool IsHex(string str)
        {
            string upper = str.ToUpper();

            bool isHex = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (!(upper[i] >= ConstsCodesFromASCIITable.numbersCodeBegin && upper[i] <= ConstsCodesFromASCIITable.numbersCodeEnd) &&
                    !(upper[i] >= ConstsCodesFromASCIITable.upperLettersCodeBegin && upper[i] <= ConstsCodesFromASCIITable.upperLettersCodeEnd))
                {
                    isHex = false;
                    break;
                }
            }
            return isHex;
        }
    }
}
