using System.Collections.Generic;
using System.Threading.Tasks;

namespace DontBugMe
{
    public interface IDataStore<T>
    {
        Task<bool> AddAsync(T account);
        Task<bool> UpdateAsync(T account);
        Task<bool> DeleteAsync(string id);
        Task<T> GetAsync(string id);
        Task<IEnumerable<T>> GetAsync(bool forceRefresh = false);
    }
}
