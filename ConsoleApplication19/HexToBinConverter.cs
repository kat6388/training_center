namespace Converter
{
    class HexToBinConverter
    {
        public static string Convert(string hex)
        {
            string dec = HexToDecConverter.Convert(hex);
            string bin = DecToBinConverter.Convert(dec);
            return bin;
        }
    }
}
