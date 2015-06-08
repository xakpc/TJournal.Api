using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface IClubService
    {
        Task<IList<ClubPaper>> GetClubPapersAsync();

        Task<IList<ClubPaper>> GetClubPapersAsync(int count);

        Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset);

        Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset, ClubPaperCategory category);

        Task<IList<ClubPaper>> GetClubPapersAsync(int count, int offset, ClubPaperCategory category, SortMode sortMode, SortModeAdditional sortModeAdditional);

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