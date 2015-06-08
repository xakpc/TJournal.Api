using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    public class AccountService : BaseService, IAccountService
    {
        public Task<Model.AccountInfo> GetAccountInfoAsync(int userId)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("account", "info"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);

            return ExecuteRequest<Model.AccountInfo>(request);
        }

        public Task<IList<Model.Post>> GetAccountPostsAsync(int userId)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("account", "posts"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);

            return ExecuteRequest<IList<Post>>(request);
        }

        public Task<IList<Model.Post>> GetAccountPostsAsync(int userId, int count)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);
            ValidateIntegerParam("count", count, 1, 50);

            var request = new RestRequest(FormRequestUrl("account", "posts"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);
            request.AddQueryParameter("count", count);

            return ExecuteRequest<IList<Post>>(request);
        }

        public Task<IList<Model.Post>> GetAccountPostsAsync(int userId, int count, int offset)
        {
            ValidateIntegerParam("userId", userId, 1, int.MaxValue);
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("account", "posts"), HttpMethod.Get);

            request.AddQueryParameter("userId", userId);
            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);

            return ExecuteRequest<IList<Post>>(request);
        }
    }
}