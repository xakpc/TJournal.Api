using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    /// <summary>
    /// Редакция
    /// </summary>
    public interface IPaperService
    {
        /// <summary>
        /// Статьи редакции
        /// </summary>
        /// <param name="count">количество</param>
        /// <param name="offset">отступ от начала</param>
        /// <param name="period">сортировка по популярности за период</param>
        /// <returns>Статьи редакции</returns>
        Task<IList<Paper>> GetPapersAsync(int count = 30, int offset = 0, SortPeriod period = SortPeriod.None);

        /// <summary>
        /// Информация о статье
        /// </summary>
        /// <param name="paperId">ID статьи</param>
        /// <returns>Информация о статье</returns>
        Task<Paper> GetPaperInfoAsync(int paperId);
    }

    public enum SortPeriod
    {
        None,
        Month,
        Week
    }
}