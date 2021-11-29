using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CreateRegexProgram
{
    public class RegexPatterns
    {
        string pattern = "^[A-Za-z]{2,}$";
        public void ValidateFirstName(string input)
        {
            Regex regex = new Regex(pattern);

            bool res = regex.IsMatch(input);
            if (res)
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
        public void Validating()
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("First Name Validating");
        }
    }
}
     