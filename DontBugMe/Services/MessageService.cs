using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontBugMe
{
    public class MessageService : IDataStore<Message>
    {
        List<Message> messages;

        public MessageService()
        {
            messages = new List<Message>();
            var _messages = new List<Message>
            {
            };
        }

        public async Task<bool> AddAsync(Message Message)
        {
            messages.Add(Message);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(Message Message)
        {
            var _Message = messages.Where((Message arg) => arg.Id == Message.Id).FirstOrDefault();
            messages.Remove(_Message);
            messages.Add(Message);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var _Message = messages.Where((Message arg) => arg.Id == id).FirstOrDefault();
            messages.Remove(_Message);

            return await Task.FromResult(true);
        }

        public async Task<Message> GetAsync(string id)
        {
            return await Task.FromResult(messages.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Message>> GetAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(messages);
        }
    }
}
