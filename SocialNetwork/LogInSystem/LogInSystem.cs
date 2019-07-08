using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SocialNetwork
{
    class LogInSystemControll
    {


        public void StartLogInSystem()
        {

     

            LogInUi.DisplayLogIn();
          




        }

        public void LogIn()
        {
            string nickName = string.Empty;
            bool logInSuccess = false;
            while (!logInSuccess)
            {
                Console.WriteLine("Please enter Nickname");
                nickName = Console.ReadLine();
                Console.WriteLine("Please enter Password");
                string passWord = Console.ReadLine();
                SqlQueries sqlQueries = new SqlQueries();
                logInSuccess = sqlQueries.TestLogInInfo(nickName, passWord);
               
                if (!logInSuccess)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NickName or PassWord incorrect, Please try again");
                    Thread.Sleep(4000);
                    Console.ResetColor();
                } else
                {
                    Console.WriteLine("Success");
                    OperateAccount operateAccount = new OperateAccount();
                    operateAccount.Operate(nickName);
                }
               
            }
        }

        public void CreateAccount()
        {
            Console.WriteLine("Please enter a nickName between 3 and 50 characters");
            string nickName = Console.ReadLine();
          var user =  SqlQueries.GetUser(nickName);
            if(user == null)
            {
                Console.WriteLine("Password:");
                string password = Console.ReadLine();
                Console.WriteLine("Birth date ex 1989-01-01:");
                string birthDate = Console.ReadLine();
                Console.WriteLine("City");
                string city = Console.ReadLine();
                Console.WriteLine("Enter your secret recovery word");
                string secret = Console.ReadLine();
                SqlQueries.CreateUser(nickName, password, birthDate, city, secret);

            } else
            {
                Console.WriteLine("Name taken, PLease try something else!");
               
            }
          
        }
    }
}
