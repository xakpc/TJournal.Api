﻿using Xakpc.Tjournal.Api.DAL;

namespace Xakpc.Tjournal.Api
{
    public class ApiFactory
    {
        public static IAccountService GetAccountService()
        {
            return new AccountService();
        }

        public static IPaperService GetPaperService()
        {
            return new PaperService();
        }

        public static IClubService GetClubService()
        {
            return new ClubService();
        }

        public static ITweetService GetTweetService()
        {
            return new TweetService();
        }

        public static INewsService GetNewsService()
        {
            return new NewsService();
        }

        public static IMiscService GetMiscService()
        {
            return new MiscService();            
        }
    }
}