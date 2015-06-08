using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    public class TweetService : BaseService, ITweetService
    {
        public Task<IList<Tweet>> GetTopTweets(int count = 30, int offset = 0, int listId = 1, Interval interval = Interval.Popular)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);
            ValidateIntegerParam("listId", listId, 1, 3);

            var request = new RestRequest(FormRequestUrl("tweets"), HttpMethod.Get);

            if (count != 30)
                request.AddQueryParameter("count", count);

            if (offset != 0)
                request.AddQueryParameter("offset", offset);

            if (listId != 1)
                request.AddQueryParameter("listId", listId);

            if (interval != Interval.Popular)
                request.AddQueryParameter("interval", interval);

            return ExecuteRequest<IList<Tweet>>(request);
        }
    }
}