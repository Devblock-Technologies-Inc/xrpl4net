using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ripple.TxSigning;
using System.Collections.Generic;
using System.Threading.Tasks;
using xrpl4net.httpApi.client.Models;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.ServerInfo;
using Xrpl4net.Client.Models.Transactions;

namespace xrpl4net.httpApi.client.Controllers
{
    public class TransactionController : BaseApiController
    {
        [HttpGet]
        [Route("construct-payment")]
        public async Task<PaymentModel> PrepareTransaction(string classicAddress, long amount) 
        {
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

            var feeResponse = await _xrplClient.Fee(new FeeRequest());
            var feeResult = feeResponse.result;
            var openLedgerFee = feeResult.drops.open_ledger_fee;

            var payment = new PaymentModel
            {
                Account = classicAddress,
                Amount = amount,
                Destination = "rHb9CJAWyB4rj91VRWn96DkukG4bwdtyTh",
                Fee = openLedgerFee,
                Flags = 2147483648,
                Sequence = sequence,
                TransactionType = "Payment"
            };

            return payment;
        }

        [HttpPost]
        [Route("sign")]
        public dynamic SignTransaction(PaymentModel input)
        {
            SignedTx signedPayment = TxSigner.SignJson(JObject.Parse(JsonConvert.SerializeObject(input)), Secret);
            return new
            {
                hash = signedPayment.Hash,
                txtBlob = signedPayment.TxBlob
            };
        }

        [HttpPost]
        [Route("submit")]
        public async Task<SubmitResult> Submit(PaymentModel input)
        {
            SignedTx signedPayment = TxSigner.SignJson(JObject.Parse(JsonConvert.SerializeObject(input)), Secret);
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

            return submitResponse.result;
        }

        [HttpGet]
        [Route("check")]
        public async Task<TXResponse> TransactionResult(string hash)
        {
            var request = new TXRequest
            {
                Params = new List<TXRequestParams>
                {
                    new TXRequestParams
                    {
                        transaction = hash
                    }
                }.ToArray()
            };

            return await _xrplClient.TXRequest(request);
        }
    }
}
