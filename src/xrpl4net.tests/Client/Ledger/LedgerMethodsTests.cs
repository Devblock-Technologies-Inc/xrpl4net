using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models.Ledger;

namespace Xrpl4net.Tests.Client.Ledger
{
    [TestFixture]
    public class LedgerMethodsTests : XrplClientTest
    {
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public async Task CanGetLedger()
        {
            var request = new LedgerRequest
            {
                Params = new List<LedgerRequestParams>
                {
                    new LedgerRequestParams
                    {
                        accounts = false,
                        full = false,
                        ledger_index = "validated",
                        transactions = false,
                        expand = false,
                        owner_funds = false
                    }
                }.ToArray()
            };
            var response = await _xrplClient.Ledger(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetLedgerClosed()
        {
            var request = new LedgerClosedRequest
            {
                Params = new List<LedgerClosedRequestParams>().ToArray()
            };

            var response = await _xrplClient.LedgerClosed(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetLedgerEntryObjectByID()
        {
            var request = new LedgerEntryRequest
            {
                Params = new List<LedgerEntryRequestParams>
                {
                    new LedgerEntryRequestParams
                    {
                        index = "7DB0788C020F02780A673DC74757F23823FA3014C1866E72CC4CD8B226CD6EF4",
                        ledger_index = "validated"
                    }
                }.ToArray()
            };

            var response = await _xrplClient.LedgerEntryRequest(request);
            response.result.Should().NotBeNull();
        }

        [Test]
        public async Task CanGetLedgerCurrent()
        {
            var request = new LedgerCurrentRequest
            {
                Params = new List<LedgerCurrentRequestParams>().ToArray()
            };

            var response = await _xrplClient.LedgerCurrent(request);
            response.result.Should().NotBeNull();
        }
    }
}
