using System;
using System.Globalization;
using System.Windows.Data;

namespace ConverterDemo
{
    class Converter : IValueConverter
    {
        /// <summary>
        /// Converts the object to a string
        /// </summary>
        /// <param name="value">The object to convert</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">unused</param>
        /// <param name="culture">unused</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return value.ToString();
            }
            return Binding.DoNothing;
        }

        /// <summary>
        /// Convert the object to a decimal value.
        /// </summary>
        /// <param name="value">The object to convert</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">unused</param>
        /// <param name="culture">unused</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string data = value as string;
            if (data == null)
            {
                return value;
            }
            if (data.Equals(string.Empty))
            {
                return 0;
            }
            if (!string.IsNullOrEmpty(data))
            {
                decimal result;
                //Hold the value if ending with .
                if (data.EndsWith(".") || data.Equals("-0"))
                {
                    return Binding.DoNothing;
                }
                if (decimal.TryParse(data, out result))
                {
                    return result;
                }
            }
            return Binding.DoNothing;
        }

    }
}
