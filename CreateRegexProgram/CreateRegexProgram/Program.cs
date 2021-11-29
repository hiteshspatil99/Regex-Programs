using System;
using System.Text.RegularExpressions;

namespace CreateRegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Option to Execute the Regex Program: \n 1. Validate First Name, \n 2. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User Registration Validate using Regular Expression");

                        RegexPatterns checkpattern = new RegexPatterns();
                        Console.WriteLine("For Check Validation Enter First Name");
                        string input = Console.ReadLine();
                        checkpattern.ValidateFirstName(input);
                        checkpattern.Validating();
                        break;

                    case 2:
                        flag = false;
                        break;


                }
            }
        }
    }
}
    

