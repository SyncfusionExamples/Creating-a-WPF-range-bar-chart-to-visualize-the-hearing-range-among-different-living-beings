using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace HearingRangeDemo
{
    public class ValueToRangeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string textValue && double.TryParse(textValue, out double position))
            {
                string text;
                if (position >= 1000 && position <= 180000)
                {
                    text = (position / 1000).ToString("N0");
                    text = $"{text}kHz";
                }
                else
                {
                    text = $"{position:N0}Hz";
                }
                return text;
            }

            return null; 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}