using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup 
            int minLength = 8;
            string uppercase = "ABCDEFGHJIKLMNOPQRSTUWXYZ";
            string lowercase = "ABCDEFGHJIKLMNOPQRSTUWXYZ".ToLower();
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*-_+";

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();


            // Test 
            int score = 0; 

            if(password.Length >= 8)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++; 
            }
            if (Tools.Contains(password, digits))
            {
                score++; 
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }


            // Inform the user
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("The password is strong");
                    break;
                case 2:
                    Console.WriteLine("The password is medium");
                    break;
                case 1:
                    Console.WriteLine("The password is weak");
                    break;
                default:
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
            }


        }
    }
}
