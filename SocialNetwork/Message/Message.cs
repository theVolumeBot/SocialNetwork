using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class Message
    {
        public int MessageId { get; set; }
        public int FromUserId { get; set; }
        public int ToUserId { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public DateTime DateForMessage { get;  set; }

        public Message(int messageId, int fromUser, int toUser, string title, string content)
        {
            MessageId = messageId;
            FromUserId = fromUser;
            ToUserId = toUser;
            MessageTitle = title;
            MessageContent = content;
            DateTime dateNow = DateTime.Now;
            DateForMessage = dateNow; 
        }

        public Message()
        {

        }
    }
}
