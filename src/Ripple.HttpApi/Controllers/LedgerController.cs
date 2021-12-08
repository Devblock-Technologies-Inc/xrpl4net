using Microsoft.AspNetCore.Mvc;
using Ripple.HttpApi.Factories;
using Ripple.HttpApi.Models.Ledger;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Controllers
{
    public class LedgerController : BaseController
    {
        #region Fields

        private readonly ILedgerModelFactory _ledgerModelFactory;

        #endregion

        #region Ctor

        public LedgerController(ILedgerModelFactory ledgerModelFactory)
        {
            _ledgerModelFactory = ledgerModelFactory;
        }

        #endregion

        #region Methods

        [HttpPost]
        public async Task<dynamic> GetLedgerAsync(LedgerRequest input)
        {
            var model = await _ledgerModelFactory.GetLedger(input);
            return model;
        }

        #endregion
    }
}
