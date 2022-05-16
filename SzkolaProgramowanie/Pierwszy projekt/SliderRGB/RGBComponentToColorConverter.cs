using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace SliderRGB
{
    class RGBComponentToColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length != 3)
                return Binding.DoNothing;

            byte red = System.Convert.ToByte((double)values[0]);
            byte green = System.Convert.ToByte((double)values[1]);
            byte blue = System.Convert.ToByte((double)values[2]);

            Color color = Color.FromRgb(red, green, blue);
            return new SolidColorBrush(color);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            /*SolidColorBrush s = value as SolidColorBrush;
            byte red = s.Color.R;
            byte green = s.Color.G;
            byte blue = s.Color.B;
            object[] wynik = new object[3];
            wynik[0] = red;
            wynik[1] = green;
            wynik[2] = blue;
            return wynik;*/
            throw new NotImplementedException();
        }
    }
}
