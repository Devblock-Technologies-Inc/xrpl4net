using Newtonsoft.Json;
using Ripple.HttpApi.Http;
using Ripple.HttpApi.Models.Ledger;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Factories
{
    public class LedgerModelFactory : ILedgerModelFactory
    {
        public async Task<dynamic> GetLedger(LedgerRequest input)
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpHelper.PostData(RippleHttpApiConsts.BASE_URL, request);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            return result;
        }
    }
}
