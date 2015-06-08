using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface INewsService
    {
        Task<IList<NewsList>> GetNewsAsync(int listId = 1, int count = 50, Interval interval = Interval.Popular);

        Task<IList<NewsList>> GetListsAsync(int listId = 0, bool showSources = true);
    }
}