using System.Globalization;

namespace ListItMaui.Libraries;

public class ConverterToTextColor : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        string text = $"{value}";
        if (!string.IsNullOrEmpty(text))
        {
            if (text == "Mercado")
            {
                return "#443F3F";
            }
            else if (text == "Eletronicos")
            {
                return "#FFFFFF";
            }
            else if (text == "Oficina")
            {
                return "#443F3F";
            }
            else if (text == "Farmácia")
            {
                return "#443F3F";
            }
        }
        return string.Empty;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return string.Empty;
    }
}