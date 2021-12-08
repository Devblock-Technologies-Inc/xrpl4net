using Newtonsoft.Json;
using Ripple.HttpApi.Http;
using Ripple.HttpApi.Models.Accounts;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Factories
{
    public class AccountModelFactory : IAccountModelFactory
    {
        public async Task<dynamic> GetAccountChannels(AccountChannelsRequest input)
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpHelper.PostData(RippleHttpApiConsts.BASE_URL, request);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            return result;
        }

        public async Task<dynamic> GetAccountInfo(AccountInfoRequest input)
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpHelper.PostData(RippleHttpApiConsts.BASE_URL, request);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            return result;
        }

        public async Task<dynamic> GetGatewayBalance(GatewayBalanceRequest input)
        {
            var request = JsonConvert.SerializeObject(input);
            var response = await HttpHelper.PostData(RippleHttpApiConsts.BASE_URL, request);
            var result = JsonConvert.DeserializeObject<dynamic>(response);
            return result;
        }
    }
}
