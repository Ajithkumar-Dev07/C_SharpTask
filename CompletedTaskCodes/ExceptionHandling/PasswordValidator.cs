using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompletedTaskCodes.ExceptionHandling
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
            
        }
    }
    internal class PasswordValidator
    {
        public static void ValidatePassword(string password)
        {
            if (password.Length < 6)
                throw new InvalidPasswordException("Password must be contains at leat 6 characters");

            if(password.Contains(" "))
                throw new InvalidPasswordException("Password should not contains spaces");

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach(char ch in password)
            {
                if (char.IsUpper(ch))
                    hasUpperCase = true;

                else if (char.IsLower(ch))
                    hasLowerCase = true;
                else if (char.IsDigit(ch))
                    hasDigit = true;
                else
                    hasSpecial = true;
            }

            if (!hasUpperCase)
                throw new InvalidPasswordException("\nPassword must contain at least one uppercase character.");

            if(!hasLowerCase)
                throw new InvalidPasswordException("\nPassword must contain at least one lowercase character.");

            if(!hasDigit)
                throw new InvalidPasswordException("Password must contain at least one digit.");

            if(!hasSpecial)
                throw new InvalidPasswordException(
               "Password must contain at least one special character.");

            Console.WriteLine("Password is Valid..");
            Console.WriteLine("Registration completed successfully.");
        }
    }
    
    class CheckPassword
    {
        static void Main()
        {
            Console.Write("Enter the PASSWORD: ");
            string password = Console.ReadLine();

            try
            {
                PasswordValidator.ValidatePassword(password);
            }
            catch(InvalidPasswordException ex)
            {
                Console.WriteLine("Error occurs: "+ex.Message);
            }
            
        }
    }
}
