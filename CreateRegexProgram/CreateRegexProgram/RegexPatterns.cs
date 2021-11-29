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
            public void Validating(string input)
        {
            Regex regex = new Regex(pattern);
            Console.WriteLine("Validating the First Name");
            ValidateFirstName(input);
            Console.WriteLine("Validating the Last Name");
            ValidateLastName(input);
        }
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
        public void ValidateLastName(string inputLastname)
        {
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(inputLastname);
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
