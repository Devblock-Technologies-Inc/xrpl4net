using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models;
using Xrpl4net.Client.Models.Accounts;

namespace Xrpl4net.Tests.Client.Accounts
{
    [TestFixture]
    public class AccountMethodsTests : XrplClientTest
    {
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public async Task CanGetAccountChannels()
        {
            var accountChannelRequest = new AccountChannelsRequest
            {
                Params = new List<AccountChannelsRequestParams>
                {
                    new AccountChannelsRequestParams
                    {
                        account = "rN7n7otQDd6FczFgLdSqtcsAUxDkw6fzRH",
                        destination_account = "rf1BiGeXwwQoi8Z2ueFYTEXSwuJYfV2Jpn",
                        ledger_index= "validated"
                    }
                }.ToArray()
            };

            var response = await _xrplClient.AccountChannels(accountChannelRequest);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetAccountInfo()
        {
            var request = new AccountInfoRequest
            {
                Params = new List<AccountInfoRequestParams>
                {
                    new AccountInfoRequestParams
                    {
                        account = "rG1QQv2nh2gr7RCZ1P8YYcBUKCCN633jCn",
                        strict = true,
                        ledger_index = "current",
                        queue = true
                    }
                }.ToArray()
            };
            var response = await _xrplClient.AccountInfo(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetAccountObjects()
        {
            var request = new AccountObjectsRequest
            {
                Params = new List<AccountObjectsRequestParams>
                {
                    new AccountObjectsRequestParams
                    {
                        account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                        type = "state",
                        ledger_index = "validated",
                        deletion_blockers_only = true,
                        limit = 10
                    }
                }.ToArray()
            };
            var response = await _xrplClient.AccountObjects(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetAccountOffers()
        {
            var request = new AccountOffersRequest
            {
                Params = new List<AccountOffersRequestParams>
                {
                    new AccountOffersRequestParams
                    {
                        account = "rpP2JgiMyTF5jR5hLG3xHCPi1knBb1v9cM"
                    }
                }.ToArray()
            };
            var response = await _xrplClient.AccountOffers(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetAccountTX()
        {
            var request = new AccountTXRequest
            {
                Params = new List<AccountTXRequestParams>
                {
                    new AccountTXRequestParams
                    {
                        account = "rLNaPoKeeBjZe2qs6x52yVPZpZ8td4dc6w",
                        binary = false,
                        forward = false,
                        limit = 2 ,
                        ledger_index_max = -1,
                        ledger_index_min = -1
                    }
                }.ToArray()
            };
            var response = await _xrplClient.AccountTX(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetNorippleCheck()
        {
            var request = new NorippleCheckRequest
            {
                Params = new List<NorippleCheckRequestParams>
                {
                    new NorippleCheckRequestParams
                    {
                        account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                        ledger_index = "current",
                        limit = 2,
                        role = "gateway",
                        transactions = true
                    }
                }.ToArray()
            };
            var response = await _xrplClient.NorippleCheck(request);
            response.result.Should().NotBeNull();
        }
    }
}
