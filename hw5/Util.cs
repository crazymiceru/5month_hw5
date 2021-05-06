using System;
using System.Text.RegularExpressions;

namespace hw5
{
    internal static class Util
    {
        internal static string GetParamFromString(this string inputString,string param)
        {
            string outValueParam=null;
            var pattern = $"{param}.?:.?\"(.+?)\"";

            foreach (Match item in Regex.Matches(inputString, pattern, RegexOptions.IgnoreCase))
            {
                outValueParam = item.Groups[1].Value;
            }
            return outValueParam;
        }
    }
}
