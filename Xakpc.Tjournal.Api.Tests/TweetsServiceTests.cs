using System.Threading.Tasks;
using NUnit.Framework;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class TweetsServiceTests
    {
        [Test]
        public async Task GetTopTweets_Default_ReturnAtLeast30()
        {
            var api = ApiFactory.GetTweetService();

            var actual = await api.GetTopTweets();

            Assert.That(actual, Has.Count.AtLeast(30));
        }

        [Test]
        public async Task GetTopTweets_LimitCountTo5_Return5()
        {
            var api = ApiFactory.GetTweetService();

            var actual = await api.GetTopTweets(5);

            Assert.That(actual, Has.Count.EqualTo(5));
        }

        [Test]
        public async Task GetTopTweets_SetInterval_Return5()
        {
            var api = ApiFactory.GetTweetService();

            var actual = await api.GetTopTweets(listId:2);

            Assert.That(actual, Has.Count.EqualTo(5));
        }
    }
}