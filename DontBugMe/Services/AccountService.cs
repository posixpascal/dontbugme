using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DontBugMe
{
    public class AccountService
    {
        readonly List<Account> accounts;

        public AccountService()
        {
            accounts = new List<Account>();
            var _accounts = new List<Account>
            {
                new Account { Id = 1, EmailAddress = "pascal@raszyk.de", Password="test1234"},
                new Account { Id = 2, EmailAddress = "j.löhr@live.de", Password="test1234"},
            };
        }

        public async Task<bool> AddAccountAsync(Account account)
        {
            accounts.Add(account);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAccountAsync(Account account)
        {
            var _account = accounts.Where((Account arg) => arg.Id == account.Id).FirstOrDefault();
            accounts.Remove(_account);
            accounts.Add(account);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAccountAsync(string id)
        {
            var _account = accounts.Where((Account arg) => arg.Id == id).FirstOrDefault();
            accounts.Remove(_account);

            return await Task.FromResult(true);
        }

        public async Task<Account> GetAccountAsync(string id)
        {
            return await Task.FromResult(accounts.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Account>> GetAccountsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(accounts);
        }
    }
}
