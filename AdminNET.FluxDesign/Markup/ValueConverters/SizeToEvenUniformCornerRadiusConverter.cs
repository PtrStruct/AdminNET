using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace AdminNET.FluxDesign.Markup.ValueConverters
{
    public class SizeToEvenUniformCornerRadiusConverter
        : IMultiValueConverter
    {
        public static SizeToEvenUniformCornerRadiusConverter I { get; } 
            = new SizeToEvenUniformCornerRadiusConverter();


        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = System.Convert.ToDouble(values[0]);
            var actualHeight = System.Convert.ToDouble(values[1]);

            var smallest = actualHeight < actualWidth 
                ? actualHeight 
                : actualWidth;

            var radius = smallest / 2d;
            return new CornerRadius(radius, radius, radius, radius);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
