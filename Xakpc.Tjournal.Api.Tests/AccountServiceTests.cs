using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using Xakpc.Tjournal.Api.DAL;

namespace Xakpc.Tjournal.Api.Tests
{
    [TestFixture]
    public class AccountServiceTests
    {
        [Test]
        public async Task GetAccountInfoAsync_SendOne_ReturnChekalsky()
        {
            var api = ApiFactory.GetAccountService();

            const string expected = "Илья Чекальский";

            var actual = await api.GetAccountInfoAsync(1);

            Assert.That(actual.Name, Is.EqualTo(expected));            
        }

        [Test]
        public void GetAccountInfoAsync_SendZero_ReturnNull()
        {
            var api = ApiFactory.GetAccountService();
            Assert.Catch<ArgumentException>(async () => await api.GetAccountInfoAsync(0));            
        }

        [Test]
        public async Task GetAccountPostsAsync_SendOneWithoutBounds_ReturnAny()
        {
            var api = ApiFactory.GetAccountService();

            var actual = await api.GetAccountPostsAsync(1);

            Assert.That(actual, Has.Count.GreaterThan(0)); 
        }

        [Test]
        public async Task GetAccountPostsAsync_SendOneWithLimit15_Return15()
        {
            var api = ApiFactory.GetAccountService();

            var actual = await api.GetAccountPostsAsync(1, 15);

            Assert.That(actual, Has.Count.EqualTo(15));
        }

        [Test]
        public async Task GetAccountPostsAsync_SendOneWithLimit15Offset5_Return15()
        {
            var api = ApiFactory.GetAccountService();

            var actual = await api.GetAccountPostsAsync(1, 15, 5);

            Assert.That(actual, Has.Count.EqualTo(15));
        }
    }
}