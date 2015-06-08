using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class NewsServiceTests
    {
        [Test]
        public async Task GetNewsAsync_Default_Return50()
        {
            var api = ApiFactory.GetNewsService();

            var actual = await api.GetNewsAsync(1);

            Assert.That(actual, Has.Count.EqualTo(2));
            Assert.That(actual[0].News, Has.Count.EqualTo(50));
        }

        [Test]
        public async Task GetNewsAsync_Limit15_Return15Each()
        {
            var api = ApiFactory.GetNewsService();

            var actual = await api.GetNewsAsync(1, 15);

            Assert.That(actual, Has.Count.EqualTo(2));
            Assert.That(actual[0].News, Has.Count.EqualTo(15));
            Assert.That(actual[1].News, Has.Count.EqualTo(15));
        }

        [Test]
        public async Task GetListsAsync_Default_ReturnAll()
        {
            var api = ApiFactory.GetNewsService();

            var actual = await api.GetListsAsync(0);

            Assert.That(actual, Has.Count.EqualTo(5));
            Assert.That(actual[0].Sources, Has.Count.AtLeast(15));
            Assert.That(actual[1].Sources, Has.Count.AtLeast(15));
        }

        [Test]
        public async Task GetListsAsync_List1_ReturnOneList()
        {
            var api = ApiFactory.GetNewsService();

            var actual = await api.GetListsAsync(1);

            Assert.That(actual, Has.Count.EqualTo(1));
            Assert.That(actual[0].Sources, Has.Count.AtLeast(15));
        }
    }
}