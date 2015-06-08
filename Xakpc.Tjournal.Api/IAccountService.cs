using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface IAccountService
    {
        Task<AccountInfo> GetAccountInfoAsync(int userId);

        Task<IList<Post>> GetAccountPostsAsync(int userId);
        Task<IList<Post>> GetAccountPostsAsync(int userId, int count);
        Task<IList<Post>> GetAccountPostsAsync(int userId, int count, int offset);
    }
}