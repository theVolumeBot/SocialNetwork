using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class MessageData
    {
        public static void ListAllMessages(int Id)
        {
            List<Message> messages = MessageSQL.GetAllMessage(Id);

            foreach (var item in messages)
            {
                UI.DisplayMessage(item);
            }

            Console.WriteLine();
        }
    }
}
