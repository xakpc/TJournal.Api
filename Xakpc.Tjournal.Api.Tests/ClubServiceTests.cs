using System.Threading.Tasks;
using NUnit.Framework;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class ClubServiceTests
    {
        [Test]
        public async Task GetClubPapersAsync_Default_ReturnAtLeast30()
        {
            var api = ApiFactory.GetClubService();

            var actual = await api.GetClubPapersAsync();

            Assert.That(actual, Has.Count.AtLeast(30));
        }

        [Test]
        public async Task GetClubPapersAsync_Limit15_ReturnAtLeast15()
        {
            var api = ApiFactory.GetClubService();

            var actual = await api.GetClubPapersAsync(15);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetClubPapersAsync_Limit15Offset5_ReturnAtLeast15()
        {
            var api = ApiFactory.GetClubService();

            var actual = await api.GetClubPapersAsync(15, 5);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetClubPapersAsync_Limit15Offset5WithCategory_ReturnAtLeast15()
        {
            var api = ApiFactory.GetClubService();

            var actual = await api.GetClubPapersAsync(15, 5, ClubPaperCategory.Offtopic);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetClubPapersAsync_Limit15Offset5WithSort_ReturnAtLeast15()
        {
            var api = ApiFactory.GetClubService();

            var actual = await api.GetClubPapersAsync(15, 5, ClubPaperCategory.News, SortMode.Discuss, SortModeAdditional.FourDays);

            Assert.That(actual, Has.Count.AtLeast(15));
        }


        [Test]
        public async Task GetClubPapersAsync_Get1234Paper_ReturnValidPaper()
        {
            var api = ApiFactory.GetClubService();

            const string expected = @"Xiaomi стал самым дорогим технологическим стартапом";

            var actual = await api.GetClubPaperAsync(1234);

            Assert.That(actual.Title, Is.EqualTo(expected));            
        }
    }
}