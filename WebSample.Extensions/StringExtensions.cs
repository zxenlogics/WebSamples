using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string target)
        {
            if (target == null)
            {
                return true;
            }

            return string.IsNullOrEmpty(target.Trim());
        }

        public static string RemoveHyphens(this string target)
        {
            return target.Replace("-", string.Empty);
        }

        public static string RemoveWhiteSpaces(this string target)
        {
            return target.Replace(" ", string.Empty);
        }

        public static string RemoveHyphensAndWhiteSpaces(this string target)
        {
            return target.Replace("-", string.Empty).Replace(" ", string.Empty);
        }

        public static bool IsNumber(this string target)
        {
            int number;
            bool result = int.TryParse(target, out number);
            return result;
        }

        public static bool IsPhoneNumber(this string target)
        {
            if (target.IsNullOrWhiteSpace())
            {
                return false;
            }

            string modifiedTarget = target.RemoveHyphens().Replace(" ", string.Empty).Trim();

            Func<string, bool>[] rules =
                {
                    r => r.Length == 10,
                    r => r.Substring(0,3).IsNumber(),
                    r => r.Substring(3,4).IsNumber(),
                    r => r.Substring(6, 4).IsNumber(),
                };

            return rules.All(rule => rule(modifiedTarget) == true);
        }
    }
}
