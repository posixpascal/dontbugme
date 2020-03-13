using System;

namespace DontBugMe
{
    public class Message
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public int AccountId  { get; set; }

        public void MarkAsRead()
        {
            this.IsRead = true;
            return;
        }
    }
}
