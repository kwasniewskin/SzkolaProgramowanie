using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SliderRGB
{
    class HexStringToColorComponent : IMultiValueConverter
    {
        private string[] intToHexTable =
            {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"};

        private Dictionary<string, byte> hexToIntDictionary = new Dictionary<string, byte>()
        {
            {"0", 0}, {"1", 1}, {"2", 2}, {"3", 3}, {"4", 4},
            {"5", 5}, {"6", 6}, {"7", 7}, {"8", 8}, {"9", 9},
            {"A", 10}, {"B", 11}, {"C", 12}, {"D", 13}, {"E", 14}, {"F", 15}
        };
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte red = System.Convert.ToByte((double)values[0]);
            byte green = System.Convert.ToByte((double)values[1]);
            byte blue = System.Convert.ToByte((double)values[2]);

            string redHex = intToHexTable[red / 16] + intToHexTable[red % 16];
            string greenHex = intToHexTable[green / 16] + intToHexTable[green % 16];
            string blueHex = intToHexTable[blue / 16] + intToHexTable[blue % 16];

            string wynik = redHex + greenHex + blueHex;
            return wynik.ToUpper();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            if (value == null)
                return new object[] { Binding.DoNothing, Binding.DoNothing, Binding.DoNothing };

            string hexStr = value.ToString().ToUpper();

            if (string.IsNullOrEmpty(hexStr.Trim()) || hexStr.Length != 6)
                return new object[] { Binding.DoNothing, Binding.DoNothing, Binding.DoNothing };

            double red = (byte)(hexToIntDictionary[hexStr[0].ToString()] * 16 + hexToIntDictionary[hexStr[1].ToString()]);
            double green = (byte)(hexToIntDictionary[hexStr[2].ToString()] * 16 + hexToIntDictionary[hexStr[3].ToString()]);
            double blue = (byte)(hexToIntDictionary[hexStr[4].ToString()] * 16 + hexToIntDictionary[hexStr[5].ToString()]);

            return new object[] { red, green, blue };
        }
    }
}
