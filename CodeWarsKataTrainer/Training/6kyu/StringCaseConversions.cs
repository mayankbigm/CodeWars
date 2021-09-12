using System;
using System.Text;

namespace Training._6kyu
{
    public static class StringCaseConversions
    {
        /// <summary>
        /// Complete the method/function so that it converts dash/underscore delimited words into camel casing.
        /// The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).
        /// Examples
        /// "the-stealth-warrior" gets converted to "theStealthWarrior"
        /// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            Console.WriteLine(str);

            // best answer
            // return string.Concat(str.Split(new[] { '-', '_' }).Select(((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s)));


            var sb = new StringBuilder();

            var words = str.Split(new[] { '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in words)
            {
                string s1 = s;
                if (char.IsLower(s[0]) && !s.Equals(words[0]))
                {
                    s1 = char.ToUpper(s1[0]) + s1.Substring(1);
                }

                sb.Append(s1);
            }

            return sb.ToString();

            //var chars = str.ToCharArray();
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    if (chars[i].Equals('_') || chars[i].Equals('-'))
            //    {
            //        chars[i + 1] = char.ToUpper(chars[i + 1]);
            //    }
            //}

            //return string.Join(string.Empty, chars);
        }

        /// <summary>
        /// Complete the solution so that the function will break up camel casing, using a space between words.
        /// Example
        /// "camelCasing"  =>  "camel Casing"
        /// "identifier"   =>  "identifier"
        /// ""             =>  ""
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            var sb = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(' ').Append(c);
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();

            // best answer: https://www.codewars.com/kata/5208f99aee097e6552000148/solutions/csharp
        }
    }
}
