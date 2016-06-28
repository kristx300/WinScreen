using System.Linq;

namespace WinScreen.Core
{
    public static class StringExtension
    {
        public static string GetLastPart(this string str)
        {
            return str.Split('\\').LastOrDefault();
        }

        public static string GetLastPartLink(this string str)
        {
            return str.Split('/').LastOrDefault();
        }

        public static bool Contains(this string str, char[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (str.Contains(values[i]))
                    return true;
            }
            return false;
        }

        public static string GetDotPart(this string str)
        {
            return str.Split('.').LastOrDefault();
        }
    }
}