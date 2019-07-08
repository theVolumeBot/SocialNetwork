using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    class Message
    {
        public int MessageId { get; }
        public int FromUserId { get; }
        public int ToUserId { get; }
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
    }
}
