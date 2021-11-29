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
        string patternEmail = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        public void Validating(string input)
        {
            Regex regex = new Regex(patternEmail);
            Console.WriteLine("Validating the Email Addr.");
            ValidateEmail(input);
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
        public void ValidateEmail(string inputEmail)
        {
            Regex regex = new Regex(patternEmail);
            bool res = regex.IsMatch(inputEmail);
            if (res)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}