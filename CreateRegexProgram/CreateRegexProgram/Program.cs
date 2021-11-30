using System;
using System.Text.RegularExpressions;

namespace CreateRegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexPatterns checkpattern = new RegexPatterns();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("User Registration Validate using Regular Expression");
                Console.WriteLine("Choose Option to Execute the Regex Program: \n 1. Validate First Name, \n 2. Validate Last Name, \n 3. Email Check \n 4. Mobile Number \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        Console.WriteLine("For Check Validation Enter First Name");
                        string input = Console.ReadLine();
                        checkpattern.ValidateFirstName(input);
                        checkpattern.Validating(input);
                        break;

                    case 2:
                        Console.WriteLine("For Check Validation Enter Last Name");
                        string inputLastname = Console.ReadLine();
                        checkpattern.ValidateLastName(inputLastname);
                        checkpattern.Validating(inputLastname);
                        break;

                    case 3:
                        Console.WriteLine("For Check Validation Enter Email:");
                        string inputEmail = Console.ReadLine();
                        checkpattern.ValidateEmail(inputEmail);
                        checkpattern.Validating(inputEmail);
                        break;
                    case 4:
                        Console.WriteLine("For Check Validation Enter Mobile Number:");
                        string inputMoNo = Console.ReadLine();
                        checkpattern.ValidateMobileNo(inputMoNo);
                        checkpattern.Validating(inputMoNo);
                        break;
                    case 5:
                        flag = false;
                        break;


                }
            }
        }
    }
}
    

