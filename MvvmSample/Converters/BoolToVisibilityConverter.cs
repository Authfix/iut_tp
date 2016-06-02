using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MvvmSample.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Convertit une valeur. 
        /// </summary>
        /// <returns>
        /// Une valeur convertie.Si la méthode retourne null, la valeur Null valide est utilisée.
        /// </returns>
        /// <param name="value">Valeur produite par la source de liaison.</param><param name="targetType">Type de la propriété de cible de liaison.</param><param name="parameter">Paramètre de convertisseur à utiliser.</param><param name="culture">Culture à utiliser dans le convertisseur.</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var booleanValue = (bool) value;

            if (booleanValue)
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }

        /// <summary>
        /// Convertit une valeur. 
        /// </summary>
        /// <returns>
        /// Une valeur convertie.Si la méthode retourne null, la valeur Null valide est utilisée.
        /// </returns>
        /// <param name="value">Valeur produite par la cible de liaison.</param><param name="targetType">Type dans lequel convertir.</param><param name="parameter">Paramètre de convertisseur à utiliser.</param><param name="culture">Culture à utiliser dans le convertisseur.</param>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = (Visibility) value;

            if (visibility == Visibility.Visible)
                return true;

            return false;
        }
    }
}
