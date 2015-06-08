using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp.Portable;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api.DAL
{
    internal class ClubService : BaseService, IClubService
    {
        public Task<IList<ClubPaper>> GetClubPapersAsync(int count = 30, int offset = 0, ClubPaperCategory category = ClubPaperCategory.News,
            SortMode sortMode = SortMode.Recent, SortModeAdditional sortModeAdditional = SortModeAdditional.Day)
        {
            ValidateIntegerParam("count", count, 1, 50);
            ValidateIntegerParam("offset", offset, 0, int.MaxValue);

            var request = new RestRequest(FormRequestUrl("club"), HttpMethod.Get);

            if (count != 30)
                request.AddQueryParameter("count", count);
            
            if (offset != 0)
                request.AddQueryParameter("offset", offset);

            if (category != ClubPaperCategory.News)
                request.AddQueryParameter("category", category.ToString().ToLower());
            
            if (sortMode != SortMode.Recent)
                request.AddQueryParameter("sortMode", sortMode.ToString().ToLower());
            
            if ((sortMode == SortMode.Popular) && (sortModeAdditional != SortModeAdditional.Day))
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