using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    internal class ClubService : BaseService, IClubService
    {
        public Task<IList<ClubPaper>> GetClubPapersAsync()
        {
            return ExecuteRequest<IList<ClubPaper>>(new RestRequest(FormRequestUrl("club"), HttpMethod.Get));
        }

        public Task<IList<ClubPaper>> GetClubPapersAsync(int count)
        {
            ValidateIntegerParam("count", count, 1, 50);

            var request = new RestRequest(FormRequestUrl("club"), HttpMethod.Get);

            request.AddQueryParameter("count", count);

            return ExecuteRequest<IList<ClubPaper>>(request);
        }

        public Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("club"), HttpMethod.Get);

            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);

            return ExecuteRequest<IList<ClubPaper>>(request);
        }

        public Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset, ClubPaperCategory category)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("club"), HttpMethod.Get);

            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);
            request.AddQueryParameter("category", category.ToString().ToLower());

            return ExecuteRequest<IList<ClubPaper>>(request);
        }

        public Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset, ClubPaperCategory category, SortMode sortMode,
            SortModeAdditional sortModeAdditional)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("club"), HttpMethod.Get);

            request.AddQueryParameter("count", count);
            request.AddQueryParameter("offset", offset);
            request.AddQueryParameter("category", category.ToString().ToLower());
            request.AddQueryParameter("sortMode", sortMode.ToString().ToLower());
            if (sortMode == SortMode.Popular)
                request.AddQueryParameter("sortModeAdditional", sortModeAdditional.ToString().ToLower().Replace("four", "4"));

            return ExecuteRequest<IList<ClubPaper>>(request);
        }

        public Task<ClubPaper> GetClubPaperAsync(int paperId)
        {
            ValidateIntegerParam("paperId", paperId, 1, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("club","item"), HttpMethod.Get);

            request.AddQueryParameter("paperId", paperId);

            return ExecuteRequest<ClubPaper>(request);
        }
    }
}