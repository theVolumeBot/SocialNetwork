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

        
            string nickName = string.Empty;

            LogInUi.DisplayLogIn();
          



            Console.WriteLine("Success");
            OperateAccount operateAccount = new OperateAccount();
            operateAccount.Operate(nickName);
            Console.Read();
        }

        public void LogIn()
        {
            bool logInSuccess = false;
            while (!logInSuccess)
            {
                Console.WriteLine("Please enter Nickname");
                string nickName = Console.ReadLine();
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
                    break;
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
                Console.WriteLine("FREE NAME");
            } else
            {
                Console.WriteLine("NAme taken");
            }
          
        }
    }
}
