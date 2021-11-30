using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CreateRegexProgram
{
    public class RegexPatterns
    {
        string pattern = "^[A-Za-z]{2,}$";
        string patternEmail = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
        string patternMobile_Number = @"/^(\+\d{1,3}[- ]?)?\d{10}$/";
        public static string REGEX_PASSWORD1 = @"[a-z,A-Z,0-9]{8,}$";
        public void Validating(string input)
        {
            Regex regex = new Regex(REGEX_PASSWORD1);
            Console.WriteLine("Validating the Mobile Number");
            ValidateMobileNo(input);
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
        public void ValidateMobileNo(string inputMobileNo)
        {
            Regex regex = new Regex(patternMobile_Number);
            bool res = regex.IsMatch(inputMobileNo);
            if (res)
            {
                Console.WriteLine("Valid Mobile Number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
        }
        public void ValidatePassword(string inputPassword)
        {
            Regex regex = new Regex(REGEX_PASSWORD1);
            bool res = regex.IsMatch(inputPassword);
            if (res)
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
