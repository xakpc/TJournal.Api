using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface ITweetService
    {
        Task<IList<Tweet>> GetTopTweets(int count = 30, int offset = 0, int listId = 1, Interval interval = Interval.Popular);
    }

    public enum Interval
    {
        Fresh,
        Popular,
        Week,
        Month
    }
}