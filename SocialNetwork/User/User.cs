using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork
{
    public class User
    {
        public int UserId { get; set; }
        public string UserNickName { get; set; }
        public string UserPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserCity { get; set; }
    }
}
