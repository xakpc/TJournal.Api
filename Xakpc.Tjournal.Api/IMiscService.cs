using System.Threading.Tasks;
using Xakpc.Tjournal.Api.Model;

namespace Xakpc.Tjournal.Api
{
    public interface IMiscService
    {
        /// <summary>
        /// Отправка опечаток
        /// </summary>
        /// <param name="text">опечатка</param>
        /// <param name="url">адрес статьи</param>
        /// <returns></returns>
        Task PostMisprintsAsync(string text, string url);

        /// <summary>
        /// Определение статьи по URL
        /// </summary>
        /// <param name="url">адрес статьи</param>
        /// <returns></returns>
        Task<Paper> RevealContentAsync(string url);
    }
}