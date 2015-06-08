using System.Threading.Tasks;
using NUnit.Framework;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class PaperServiceTests
    {
        [Test]
        public async Task GetPapersAsync_Default_ReturnAtLeast30()
        {
            var api = ApiFactory.GetPaperService();

            var actual = await api.GetPapersAsync();

            Assert.That(actual, Has.Count.AtLeast(30));
        }

        [Test]
        public async Task GetPapersAsync_Limit15_ReturnAtLeast15()
        {
            var api = ApiFactory.GetPaperService();

            var actual = await api.GetPapersAsync(15);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetPapersAsync_Limit15Offset5_ReturnAtLeast15()
        {
            var api = ApiFactory.GetPaperService();

            var actual = await api.GetPapersAsync(15, 5);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetPapersAsync_Limit15Offset5WithSort_ReturnAtLeast15()
        {
            var api = ApiFactory.GetPaperService();

            var actual = await api.GetPapersAsync(15, 5, SortPeriod.Week);

            Assert.That(actual, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetPaperAsync_Get6666Paper_ReturnValidPaper()
        {
            var api = ApiFactory.GetPaperService();

            const string expected = @"Репортаж из соцсетей: «Чёрная пятница»";

            var actual = await api.GetPaperInfoAsync(6666);

            Assert.That(actual.Title, Is.EqualTo(expected));            
        }
    }
}