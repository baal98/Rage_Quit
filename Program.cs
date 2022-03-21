using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Regex regex = new Regex(@"(?'chars'[^\d]+)(?'digits'\d+)");

            MatchCollection matches = regex.Matches(command);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string chars = match.Groups["chars"].Value.ToString().ToUpper();
                int digits = int.Parse(match.Groups["digits"].Value);
                for (int i = 0; i < digits; i++)
                {
                    sb.Append(chars);
                }
            }
            char[] charsToCheck = sb.ToString().ToCharArray();
            List<char> listChars = new List<char>();

            foreach (char c in charsToCheck)
            {
                if (!listChars.Contains(c))
                {
                    listChars.Add(c);
                }
            }
            int counter = listChars.Count;

            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine(sb);
        }

    }
}