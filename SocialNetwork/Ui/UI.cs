using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{ 
    class UI
    {   
        public static void MainMenu(string nickName)
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("-------------------------");
                Console.WriteLine("(1) View profile.");
                Console.WriteLine("(2) Edit profile.");
                Console.WriteLine("(3) Messages.");
                Console.WriteLine("(4) Search for user.");
                Console.WriteLine("(5) Logout.");
                Console.WriteLine();


                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        DisplayProfile(SqlQueries.GetUser(nickName));
                        break;
                    case '2':
                        EditProfileMenu();
                        break;

                    case '3':
                        
                        break;

                    case '4':
                        
                        break;

                    case '5':
                        LogInSystemControll lsc = new LogInSystemControll();
                        lsc.StartLogInSystem();
                        break;
                }
            }
        }

        public static void EditProfileMenu()
        {
            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("Edit Profile");
                Console.WriteLine("-------------------------");
                Console.WriteLine("(1) Change nickname.");
                Console.WriteLine("(2) Change city.");
                Console.WriteLine("(3) Change password.");
                Console.WriteLine("(4) Delete Account.");
                Console.WriteLine("(5) Exit to Main menu");
                Console.WriteLine();

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':

                        break;

                    case '2':

                        break;

                    case '3':
                        break;

                    case '4':
                        break;

                    case '5':
                    default:
                        continueMenu = false;
                        break;


                }
            }
        }

        public static void DisplayProfile(User user)
        {
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine($"Comment Id:{user.UserId}");
            Console.WriteLine($"Nickname: {user.UserNickName}");
            Console.WriteLine($"Age: {user.UserAge}");
            Console.WriteLine($"City: {user.UserCity}");
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine();
        }

        //public static void DisplayMessage()
        //{
        //    Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        //    Console.WriteLine($"Comment Id: {comment.Id}");
        //    Console.WriteLine($"Nickname: {comment.Author}");
        //    Console.WriteLine($"Age: {comment.Created}");
        //    Console.WriteLine($"City: {comment.CommentText}");
        //    Console.WriteLine($"Message: {comment.CommentText}");
        //    Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
        //    Console.WriteLine();
        //}
    }
}
