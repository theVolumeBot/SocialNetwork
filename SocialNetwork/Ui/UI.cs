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
                        MessagesMenu(nickName);
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

        public static void MessagesMenu(string nickName)
        {
            bool continueMenu = true;

            SqlQueries.GetUser(nickName);
            User user = new User();
            MessageData.ListAllComments(user.UserId);

            while (continueMenu)
            {
                Console.WriteLine("Messages");
                Console.WriteLine("-------------------------");
                Console.WriteLine("(1) Read Message.");
                Console.WriteLine("(2) Send Message.");;
                Console.WriteLine("(3) Delete Messsage.");
                Console.WriteLine("(4) Exit to Main menu");
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
                    default:
                        continueMenu = false;
                        break;


                }
            }
        }


        public static void DisplayProfile(User user)
        {
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine($"User Id:{user.UserId}");
            Console.WriteLine($"Nickname: {user.UserNickName}");
            Console.WriteLine($"Age: {User.GetAge(user.BirthDate)}");
            Console.WriteLine($"City: {user.UserCity}");
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine();
        }

        public static void DisplayMessage(Message message)
        {
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine($"Message Id: {message.MessageId}");
            Console.WriteLine($"From: {message.FromUserId}");
            Console.WriteLine($"Titel: {message.MessageTitle}");
            Console.WriteLine($"Date: {message.DateForMessage}");
            Console.WriteLine($"Message: {message.MessageContent}");
            Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
            Console.WriteLine();
        }
    }
}
