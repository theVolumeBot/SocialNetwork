using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.User
{
    class User
    {

        public int UserId { get; }
        public string UserNickName { get; set; }
        public string UserPassword { get; set; }
        public int UserAge { get; set; }
        public string UserCity { get; set; }
    }
}
