using System;
using System.Collections.Generic;

namespace DontBugMe
{
    public class Account
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string AppIdentifier { get; set; }

        public List<Message> getMessages()
        {
            List<Message> messages = new List<Message>();
            return messages;
        }
    }

}
