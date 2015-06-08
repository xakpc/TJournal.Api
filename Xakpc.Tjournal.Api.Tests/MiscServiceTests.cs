using System.Threading.Tasks;
using NUnit.Framework;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class MiscServiceTests
    {
        [Test]
        public async Task RevealContentAsync_AnyUrl_ExpectedResult()
        {
            var api = ApiFactory.GetMiscService();

            var actual = await api.RevealContentAsync(@"https://tjournal.ru/p/yanavigator-vs-citiguide");

            Assert.That(actual.Title, Is.EqualTo("«Навигатор» против «Ситигида»"));
        }
    }
}