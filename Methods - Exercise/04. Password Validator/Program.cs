using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool letterCount =  CharactersCountChecker(password);
            bool validLetters = CheckerForValidLetters(password);
            bool digitCountIsValid = DigitCheker(password);

            if (letterCount&&validLetters&&digitCountIsValid)
            {
                Console.WriteLine("Password is valid");
            }

            if (!letterCount)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!validLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!digitCountIsValid)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        
        }

        private static bool DigitCheker(string password)
        {
            bool isValid = false;
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counter++;
                }

                if (counter>=2)
                {
                    isValid=true;
                }
            }

            return isValid;
        }

        public static bool CheckerForValidLetters(string password)
        {
            bool isValid = false;
            password = password.ToLower();

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i]>=97 && password[i]<=122) || (password[i] >= 48 && password[i] <= 57))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        private static bool CharactersCountChecker(string password)
        {
            bool isValid =false;
            if (password.Length>=6 && password.Length<=10)
            {
                isValid=true;
            }

            return isValid;
        }
    }
}
