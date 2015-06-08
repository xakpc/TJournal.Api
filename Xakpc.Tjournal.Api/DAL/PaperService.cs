using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    internal class PaperService : BaseService, IPaperService
    {
        public Task<IList<Paper>> GetPapersAsync(int count = 30, int offset = 0, SortPeriod period = SortPeriod.None)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("paper"), HttpMethod.Get);

            if (count != 30)
                request.AddQueryParameter("count", count);

            if (offset != 0)
                request.AddQueryParameter("offset", offset);

            if (period != SortPeriod.None)
                request.AddQueryParameter("period", period.ToString().ToLower());

            return ExecuteRequest<IList<Paper>>(request);
        }

        public Task<Paper> GetPaperInfoAsync(int paperId)
        {
            ValidateIntegerParam("paperId", paperId, 1, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("paper", "info"), HttpMethod.Get);

            request.AddQueryParameter("paperId", paperId);

            return ExecuteRequest<Paper>(request);
        }
    }
}