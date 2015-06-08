using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    public class NewsService : BaseService, INewsService
    {
        public Task<IList<NewsList>> GetNewsAsync(int listId = 1, int count = 50, Interval interval = Interval.Popular)
        {
            ValidateIntegerParam("listId", listId, 1, int.MaxValue);
            ValidateIntegerParam("count", count, 1, 50);

            if ((interval != Interval.Popular) && (interval != Interval.Fresh))
                throw new ArgumentException("Interval must be Fresh or Popular", "interval");

            var request = new RestRequest(FormRequestUrl("news"), HttpMethod.Get);

            if (listId != 1)
                request.AddQueryParameter("listId", listId);

            if (count != 50)
                request.AddQueryParameter("count", count);

            if (interval != Interval.Popular)
                request.AddQueryParameter("interval", interval);

            return ExecuteRequest<IList<NewsList>>(request);
        }

        public async Task<IList<NewsList>> GetListsAsync(int listId = 0, bool showSources = true)
        {
            ValidateIntegerParam("listId", listId, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("news", "lists"), HttpMethod.Get);

            if (listId != 0)
                request.AddQueryParameter("listId", listId);

            if (!showSources)
                request.AddQueryParameter("showSources", false);

            if (listId != 0)
                return new List<NewsList> { await ExecuteRequest<NewsList>(request).ConfigureAwait(false) };

            return await ExecuteRequest<IList<NewsList>>(request).ConfigureAwait(false);
        }
    }
}