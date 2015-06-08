using System;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    public class MiscService : BaseService, IMiscService
    {
        public Task PostMisprintsAsync(string text, string url)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentException("Empty misprint text", text);

            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Empty misprint text", url);

            var request = new RestRequest(FormRequestUrl("misprints", "new"), HttpMethod.Post);

            request.AddParameter("text", text);
            request.AddParameter("url", url);

            return ExecuteRequest(request);

        }

        public async Task<Paper> RevealContentAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("Empty misprint text", url);

            var request = new RestRequest(FormRequestUrl("content", "reveal"), HttpMethod.Get);

            request.AddQueryParameter("url", url);

            return (await ExecuteRequest<PaperWrapper>(request).ConfigureAwait(false)).Data;
        }
    }
}