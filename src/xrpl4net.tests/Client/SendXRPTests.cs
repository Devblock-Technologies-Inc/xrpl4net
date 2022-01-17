using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Ripple.Signing;
using Ripple.TxSigning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.Faucet;
using Xrpl4net.Client.Models.KeyGeneration;
using Xrpl4net.Client.Models.Ledger;
using Xrpl4net.Client.Models.ServerInfo;
using Xrpl4net.Client.Models.Transactions;

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
            try
            {
                // Get Credentials --------------------------------------------------------
                var encodedSeed = "sEd7rBGm5kxzauRTAV2hbsNz7N45X91";
                var seed = Seed.FromBase58(encodedSeed);
                var pair = seed.KeyPair();
                // Get the Classic address
                var classicAddress = pair.Id();
                Console.WriteLine("Address: " + classicAddress);

                // Fund the account using the testnet Faucet
                var fundAccountRequest = new FundAccountRequest
                {
                    destination = classicAddress
                };
                var fundAccountResponse = await _faucetClient.FundAccount(fundAccountRequest);
                if(fundAccountResponse != null)
                {
                    Console.WriteLine("Funded the account using the Testnet faucet.");
                }

                // Prepare transaction --------------------------------------------------------
                // Look up your Account Info
                var accountInfoRequest = new AccountInfoRequest
                {
                    Params = new List<AccountInfoRequestParams>
                    {
                        new AccountInfoRequestParams
                        {
                            account = classicAddress,
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

                // Construct a Payment
                dynamic payment = new 
                {
                    Account = classicAddress,
                    Amount = 1000,
                    Destination = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh",
                    Fee = openLedgerFee,
                    Flags = 2147483648,
                    Sequence = sequence,
                    TransactionType = "Payment"
                };
                Console.WriteLine("Constructed Payment: " + JsonConvert.SerializeObject(payment));

                // Sign transaction -----------------------------------------------------------
                var signedPayment = TxSigner.SignJson(JObject.Parse(JsonConvert.SerializeObject(payment)), encodedSeed);
                // Submit transaction ---------------------------------------------------------
                var submitResponse = await _xrplClient.Submit(new SubmitRequest
                {
                    Params = new List<SubmitRequestParams>
                    {
                        new SubmitRequestParams
                        {
                            tx_blob = signedPayment.TxBlob
                        }
                    }.ToArray()
                });
                var submitResult = submitResponse.result;
                // Check transaction results
                Console.WriteLine("Explorer link: https://testnet.xrpl.org/transactions/" + submitResult.tx_json.hash);
                bool transactionValidated = false;

                if(submitResult.validated_ledger_index >= 0)
                {
                    transactionValidated = true;
                }
                Assert.IsTrue(transactionValidated);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
