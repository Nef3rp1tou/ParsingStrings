﻿using System;

namespace ParsingStrings
{
    public static class NumberParser
    {
        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the operation succeeded.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 32-bit signed integer value equivalent of the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseInteger(string str, out int result)
        {
            {
                result = 0;

                if (string.IsNullOrWhiteSpace(str))
                {
                    return false;
                }

                str = str.Trim();

                return int.TryParse(str, out result);
            }

        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 32-bit signed integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns zero. If an overflow error occurs returns minus one.</returns>
        public static int ParseInteger(string str)
        {
            int result = 0;
            try
            {
               result = int.Parse(str);
            }
            catch (OverflowException)
            {

                return -1;
            }
            catch (FormatException)
            {
                return 0;
            }

            return result;
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its 32-bit unsigned integer equivalent. A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 32-bit unsigned integer value that is equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedInteger(string str, out uint result)
        {
            result = 0;

            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            str = str.Trim();

            return uint.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string representing the number to convert.</param>
        /// <returns>A 32-bit unsigned integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns minimum value of unsigned int. If an overflow error occurs returns maximum value of unsigned int.</returns>
        public static uint ParseUnsignedInteger(string str)
        {
            uint result = 0;
            try
            {
                result = uint.Parse(str);
            }
            catch (OverflowException)
            {
                return uint.MaxValue;
            }
            catch (FormatException)
            {
                return uint.MinValue;
            }

            return result;
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its Byte equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <param name="result">When this method returns, contains the Byte value equivalent to the number contained in <see cref="str"/> if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseByte(string str, out byte result)
        {
            result = 0;

            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            str = str.Trim();

            return byte.TryParse(str, out result);
        }
        /// <summary>
        /// Converts the string representation of a number to its Byte equivalent.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <returns>A byte value that is equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns maximum value of byte. If an overflow error occurs returns minimum value of byte.</returns>
        public static byte ParseByte(string str)
        {
            byte result = 0;

            try
            {
                result = byte.Parse(str);
            }
            catch (FormatException)
            {
                return byte.MaxValue;
            }
            catch (OverflowException)
            {
                return byte.MinValue;
            }

            return result;
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its SByte equivalent, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="str">A string that contains a number to convert.</param>
        /// <param name="result">When this method returns, contains the 8-bit signed integer value that is equivalent to the number contained in <see cref="str"/> if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TrySignedByte(string str, out sbyte result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(str)) return false;
            str = str.Trim();
            return sbyte.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 8-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents a number to convert.</param>
        /// <returns>An 8-bit signed integer that is equivalent to the number contained in the <see cref="str"/> parameter. If a formatting error occurs returns maximum value of signed byte.</returns>
        public static sbyte ParseSignedByte(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            try
            {
                return sbyte.Parse(str.Trim());
            }
            catch (FormatException)
            {
                return sbyte.MaxValue;
            }
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 16-bit signed integer value equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseShort(string str, out short result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(str)) return false;
            str = str.Trim();
            return short.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 16-bit signed integer equivalent to the number contained in <see cref="str"/>. If an overflow error occurs returns maximum value of short.</returns>
        public static short ParseShort(string str)
        {
            try { return short.Parse(str); }
            catch (OverflowException) { return short.MaxValue; }
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 16-bit unsigned integer value that is equivalent to the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedShort(string str, out ushort result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(str)) return false;
            str = str.Trim();
            return ushort.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 16-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <returns>A 16-bit unsigned integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns zero. If an overflow error occurs returns maximum value of unsigned short.</returns>
        public static ushort ParseUnsignedShort(string str)
        {
            try { return ushort.Parse(str); }
            catch (FormatException) { return 0; }
            catch (OverflowException) { return ushort.MaxValue; }
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the 64-bit signed integer value equivalent of the number contained in <see cref="str"/>, if the conversion succeeded, or zero if the conversion failed. </param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseLong(string str, out long result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(str)) return false;
            str = str.Trim();
            return long.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="str">A string containing a number to convert.</param>
        /// <returns>A 64-bit signed integer equivalent to the number contained in <see cref="str"/>. If a formatting error occurs returns minimum value of long. If an overflow error occurs returns minus one.</returns>
        public static long ParseLong(string str)
        {
            try { return long.Parse(str); }
            catch (FormatException) { return long.MinValue; }
            catch (OverflowException) { return -1; }
        }

        /// <summary>
        /// Tries to convert the string representation of a number to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <param name="result">When this method returns, contains the 64-bit unsigned integer value that is equivalent to the number contained in <see cref=""/>, if the conversion succeeded, or zero if the conversion failed.</param>
        /// <returns>true if <see cref="str"/> was converted successfully; otherwise, false.</returns>
        public static bool TryParseUnsignedLong(string str, out ulong result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(str)) return false;
            str = str.Trim();
            return ulong.TryParse(str, out result);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit unsigned integer equivalent.
        /// </summary>
        /// <param name="str">A string that represents the number to convert.</param>
        /// <returns>A 64-bit unsigned integer equivalent to the number contained in <see cref="str"/>.</returns>
        public static ulong ParseUnsignedLong(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str)); 

            if (string.IsNullOrWhiteSpace(str))
                throw new FormatException(); 

            try
            {
                return ulong.Parse(str.Trim());
            }
            catch (FormatException)
            {
                throw; 
            }
            catch (OverflowException)
            {
                throw; 
            }
        }
    }
}
