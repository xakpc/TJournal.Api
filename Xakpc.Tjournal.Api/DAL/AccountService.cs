using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    internal class AccountService : BaseService, IAccountService
    {
        public Task<Model.AccountInfo> GetAccountInfoAsync(int userId)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("account", "info"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);

            return ExecuteRequest<Model.AccountInfo>(request);
        }

        public Task<IList<Model.Post>> GetAccountPostsAsync(int userId, int count = 30, int offset = 0)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("account", "posts"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);
            
            if (count != 30)
                request.AddQueryParameter("count", count);
            
            if (offset != 0)
                request.AddQueryParameter("offset", offset);

            return ExecuteRequest<IList<Post>>(request);
        }
    }
}