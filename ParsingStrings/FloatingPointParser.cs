using System;
using System.Globalization;
using System.Numerics;

namespace ParsingStrings
{
    public static class FloatingPointParser
    {
        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string representing a number to convert.</param>
        /// <param name="result">When this method returns, contains single-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseFloat(string str, out float result)
        {
            if (string.IsNullOrEmpty(str))
            {
                result = 0;
                return false;
            }

            bool isParsed = float.TryParse(str.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out result);
            return isParsed;
        }

        /// <summary>
        /// Converts the string representation of a number to its single-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A single-precision floating-point number equivalent to the numeric str or symbol specified in <paramref name="str"/>.  If a formatting error occurs returns NaN. </returns>
        public static float ParseFloat(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (float.TryParse(str.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
            {
                return result;
            }

            return float.NaN;

        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string representing a number to convert.</param>
        /// <param name="result">When this method returns, contains double-precision floating-point number equivalent to the numeric value or symbol contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseDouble(string str, out double result)
        {
            if (string.IsNullOrEmpty(str))
            {
                result = 0;
                return false;
            }

            bool isParsed = double.TryParse(str.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out result);
            return isParsed;
        }

        /// <summary>
        /// Converts the string representation of a number to its double-precision floating-point number equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A double-precision floating-point number equivalent to the numeric str or symbol specified in <paramref name="str"/>. If a formatting error occurs returns Epsilon.</returns>
        public static double ParseDouble(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (double.TryParse(str.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }

            return double.Epsilon;
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        /// <param name="str">The string representation of the number to convert.</param>
        /// <param name="result">When this method returns, contains the Decimal number that is equivalent to the numeric value contained in <paramref name="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <paramref name="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseDecimal(string str, out decimal result)
        {
            if (string.IsNullOrEmpty(str))
            {
                result = 0;
                return false;
            }

            bool isParsed = decimal.TryParse(str.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out result);
            return isParsed;
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        /// <param name="str">The string representation of the number to convert.</param>
        /// <returns>The equivalent to the number contained in <paramref name="str"/>.</returns>
        public static decimal ParseDecimal(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            str = str.Trim();

            if (BigInteger.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out BigInteger bigValue))
            {
                if (bigValue > (BigInteger)decimal.MaxValue || bigValue < (BigInteger)decimal.MinValue)
                {
                    return -2.2m; 
                }
            }

            if (decimal.TryParse(str, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal result))
            {
                return result;
            }

            return -1.1m; 
        }




    }
}
