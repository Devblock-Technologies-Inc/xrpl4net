using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.Ledger;
using Xrpl4net.Client.Models.ServerInfo;

namespace Xrpl4net.Tests.Client
{
    [TestFixture]
    public class SendXRPTests : XrplClientTest
    {
        public override void SetUp()
        {
            base.SetUp();
        }

        [Test]
        public async Task SendXRP()
        {
            // Prepare transaction --------------------------------------------------------
            // Look up your Account Info
            var accountInfoRequest = new AccountInfoRequest
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

            var accountInfoResponse = await _xrplClient.AccountInfo(accountInfoRequest);
            var accountInfoResult = accountInfoResponse.result;
            var sequence = accountInfoResult.account_data.Sequence;

            // Request current fee information from rippled
            var feeResponse = await _xrplClient.Fee(new FeeRequest());
            var feeResult = feeResponse.result;
            var openLedgerFee = feeResult.drops.open_ledger_fee;

            // Get the latest validated ledger index
            var ledgerRequest = new LedgerRequest
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

            var ledgerResponse = await _xrplClient.Ledger(ledgerRequest);
            var ledgerResult = ledgerResponse.result;
            var validatedLedger = ledgerResult.ledger_index;

            // Construct a Payment


            // Sign transaction -----------------------------------------------------------

        }
    }
}
