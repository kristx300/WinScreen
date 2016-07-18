using System.Linq;

namespace WinScreen.Core
{
    public static class StringExtension
    {
        /// <summary>
        /// Get last part of string
        /// </summary>
        /// <param name="str">Path</param>
        /// <returns>File name . file type</returns>
        public static string GetLastPart(this string str)
        {
            return str.Split('\\').LastOrDefault();
        }

        /// <summary>
        /// Get last part of URL
        /// </summary>
        /// <param name="str">Url path</param>
        /// <returns>File name . file type</returns>
        public static string GetLastPartLink(this string str)
        {
            return str.Split('/').LastOrDefault();
        }

        /// <summary>
        /// Contains array
        /// </summary>
        /// <param name="str">String search</param>
        /// <param name="values">Needed values</param>
        /// <returns>True if contains. False if not contains</returns>
        public static bool Contains(this string str, char[] values)
        {
            for (int i = 0; i < values.Length; i++)
                if (str.Contains(values[i]))
                    return true;

            return false;
        }

        /// <summary>
        /// Get last part of dot symbol
        /// </summary>
        /// <param name="str">String search</param>
        /// <returns>Last part of dot</returns>
        public static string GetDotPart(this string str)
        {
            return str.Split('.').LastOrDefault();
        }
    }
}