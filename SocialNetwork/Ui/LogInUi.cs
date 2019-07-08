using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class LogInUi
    {

        public static void DisplayLogIn()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("-------------------------");
            Console.WriteLine("(1) Log in.");
            Console.WriteLine("(2) Create Account");
            Console.WriteLine("(3) Forgot Password");
            Console.WriteLine();
            var key = Console.ReadKey();
            LogInSystemControll logInSystemControll = new LogInSystemControll();
            switch (key.KeyChar)
            {
                case '1':
                   
                    logInSystemControll.LogIn();
                    break;
                case '2':
                    logInSystemControll.CreateAccount();
                        break;
                default:
                    break;
            }
        }
    }
}
