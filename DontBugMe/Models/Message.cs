using System;

namespace DontBugMe
{
    public class Message
    {
        public string Type { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool Read { get; set; }
        public int AccountId  { get; set; }

    }

}
