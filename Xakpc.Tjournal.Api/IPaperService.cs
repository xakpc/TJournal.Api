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
        /// <returns></returns>
        Task<IList<Paper>> GetPapersAsync();

        /// <summary>
        /// Статьи редакции
        /// </summary>
        /// <param name="count">количество</param>
        /// <returns></returns>
        Task<IList<Paper>> GetPapersAsync(int count);

        /// <summary>
        /// Статьи редакции
        /// </summary>
        /// <param name="count">количество</param>
        /// <param name="offset">отступ от начала</param>
        /// <returns></returns>
        Task<IList<Paper>> GetPapersAsync(int count, int offset);

        /// <summary>
        /// Статьи редакции
        /// </summary>
        /// <param name="count">количество</param>
        /// <param name="offset">отступ от начала</param>
        /// <param name="period">сортировка по популярности за период</param>
        /// <returns>Статьи редакции</returns>
        Task<IList<Paper>> GetPapersAsync(int count, int offset, SortPeriod period);

        /// <summary>
        /// Информация о статье
        /// </summary>
        /// <param name="paperId">ID статьи</param>
        /// <returns>Информация о статье</returns>
        Task<Paper> GetPaperInfoAsync(int paperId);
    }

    public enum SortPeriod
    {
        Month,
        Week
    }
}