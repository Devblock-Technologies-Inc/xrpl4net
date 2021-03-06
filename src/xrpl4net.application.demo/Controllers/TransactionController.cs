using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ripple.TxSigning;
using System.Collections.Generic;
using System.Threading.Tasks;
using xrpl4net.application.demo.Models;
using Xrpl4net.Client.Models.Accounts;
using Xrpl4net.Client.Models.ServerInfo;
using Xrpl4net.Client.Models.Transactions;

namespace xrpl4net.application.demo.Controllers
{
    public class TransactionController : BaseApiController
    {
        [HttpGet]
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
        public dynamic SignTransaction(PaymentModel input)
        {
            dynamic payment = new
            {
                Account = input.Account,
                Amount = input.Amount,
                Destination = input.Destination,
                Fee = input.Fee,
                Flags = input.Flags,
                Sequence = input.Sequence,
                TransactionType = "Payment"
            };
            SignedTx signedPayment = TxSigner.SignJson(JObject.Parse(JsonConvert.SerializeObject(payment)), input.Secret);
            return new
            {
                hash = signedPayment.Hash,
                txtBlob = signedPayment.TxBlob
            };
        }

        [HttpPost]
        public async Task<SubmitResult> Submit(PaymentModel input)
        {
            dynamic payment = new
            {
                Account = input.Account,
                Amount = input.Amount,
                Destination = input.Destination,
                Fee = input.Fee,
                Flags = input.Flags,
                Sequence = input.Sequence,
                TransactionType = "Payment"
            };
            SignedTx signedPayment = TxSigner.SignJson(JObject.Parse(JsonConvert.SerializeObject(payment)), input.Secret);
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
        public async Task<bool> CheckTransactionResult(string hash)
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

            var response = await _xrplClient.TXRequest(request);
            if (response.result == null || response.result.meta == null)
                return false;
            return response.result.validated;
        }

        [HttpGet]
        public async Task<TXResponse> GetTransactionResult(string hash)
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
