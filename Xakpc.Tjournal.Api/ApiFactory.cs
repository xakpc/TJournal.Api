using Xakpc.Tjournal.Api.DAL;

namespace Xakpc.Tjournal.Api
{
    public class ApiFactory
    {
        public static IAccountService GetAccountService()
        {
            return new AccountService();
        }
    }
}