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
            bool logInSuccess = false;
            while (!logInSuccess) {
                Console.Clear();
                Console.WriteLine("Please enter Nickname");
                string nickName = Console.ReadLine();
                Console.WriteLine("Please enter Password");
                string passWord = Console.ReadLine();
                SqlQueries sqlQueries = new SqlQueries();
               logInSuccess = sqlQueries.TestLogInInfo(nickName, passWord);
                if(!logInSuccess)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NickName or PassWord incorrect, Please try again");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }

            }
            Console.WriteLine("Success");
            OperateAccount operateAccount = new OperateAccount();
            operateAccount.Operate();
            Console.Read();
        }
    }
}
