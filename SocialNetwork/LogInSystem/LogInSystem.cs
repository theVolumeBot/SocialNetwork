using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class LogInSystemControll
    {
 

        public void StartLogInSystem()
        {
            bool LogInSuccess = false;
            while (!LogInSuccess) {
                Console.Clear();
                Console.WriteLine("Please enter credentials");
                string entry = Console.ReadLine();
               
            }
            OperateAccount operateAccount = new OperateAccount();
            operateAccount.Operate();
            Console.Read();
        }
    }
}
