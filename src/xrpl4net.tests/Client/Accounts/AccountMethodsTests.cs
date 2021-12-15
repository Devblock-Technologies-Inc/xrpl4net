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

            var response = await _xrplClient.GetAccountChannels(accountChannelRequest);
            string result = JsonConvert.SerializeObject(response["result"]);
            var accountChannelResponse = JsonConvert.DeserializeObject<AccountChannelsResponse>(result);
            accountChannelResponse.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetAccountCurrencies()
        {
            var currenciesRequest = new AccountCurrenciesRequest
            {
                Params = new List<AccountCurrenciesRequestParams>
                {
                    new AccountCurrenciesRequestParams
                    {
                        account = "r9cZA1mLK5R5Am25ArfXFmqgNwjZgnfk59",
                        account_index = 0,
                        ledger_index = "validated",
                        strict = true
                    }
                }.ToArray()
            };
            var response = await _xrplClient.GetAccountCurrencies(currenciesRequest);
            string result = JsonConvert.SerializeObject(response["result"]);
            var accountCurrenciesResponse = JsonConvert.DeserializeObject<AccountCurrenciesResponse>(result);
            accountCurrenciesResponse.Should().NotBeNull();
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
            var response = await _xrplClient.GetAccountInfo(request);
            string json = JsonConvert.SerializeObject(response["result"]);
            var expectedResult = new AccountInfoResponse
            {
                account_data = new AccountData
                {
                    Account = "rG1QQv2nh2gr7RCZ1P8YYcBUKCCN633jCn",
                    Balance = "9977",
                    Flags = 1048576,
                    index = "92FA6A9FC8EA6018D5D16532D7795C91BFB0831355BDFDA177E86C8BF997985F",
                    LedgerEntryType = "AccountRoot",
                    RegularKey = "rhLkGGNZdjSpnHJw4XAFw1Jy7PD8TqxoET"
                },
                ledger_current_index = 68349087,
                status = "success",
                validated = false
            };
            var result = JsonConvert.DeserializeObject<AccountInfoResponse>(json);
            result.Should().NotBeNull();
        }
    }
}
