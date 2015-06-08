using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface IClubService
    {
        Task<IList<ClubPaper>> GetClubPapersAsync(int count = 30, int offset = 0, ClubPaperCategory category = ClubPaperCategory.News, 
            SortMode sortMode = SortMode.Recent, SortModeAdditional sortModeAdditional = SortModeAdditional.Day);

        /// <summary>
        /// Конкретная запись
        /// </summary>
        /// <param name="paperId">ID записи</param>
        /// <returns>Конкретная запись</returns>
        Task<ClubPaper> GetClubPaperAsync(int paperId);
    }

    public enum ClubPaperCategory
    {
        News,
        Offtopic
    }

    public enum SortMode
    {
        All,
        Recent,
        Popular,
        Discuss,
        Unadmitted
    }

    public enum SortModeAdditional
    {
        Day,
        FourDays,
        All
    }
}