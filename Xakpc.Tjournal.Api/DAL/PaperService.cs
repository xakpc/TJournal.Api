﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    internal class PaperService : BaseService, IPaperService
    {
        public Task<IList<Paper>> GetPapersAsync()
        {
            return ExecuteRequest<IList<Paper>>(new RestRequest(FormRequestUrl("paper"), HttpMethod.Get));
        }

        public Task<IList<Paper>> GetPapersAsync(int count)
        {
            ValidateIntegerParam("count", count, 1, 50);

            var request = new RestRequest(FormRequestUrl("paper"), HttpMethod.Get);

            request.AddQueryParameter("count", count);

            return ExecuteRequest<IList<Paper>>(request);
        }

        public Task<IList<Paper>> GetPapersAsync(int count, int offset)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("paper"), HttpMethod.Get);

            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);

            return ExecuteRequest<IList<Paper>>(request);
        }

        public Task<IList<Paper>> GetPapersAsync(int count, int offset, SortPeriod period)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("paper"), HttpMethod.Get);

            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);
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