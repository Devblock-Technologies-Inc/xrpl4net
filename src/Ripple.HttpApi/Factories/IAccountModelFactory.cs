using Ripple.HttpApi.Models.Accounts;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Factories
{
    public interface IAccountModelFactory
    {
        Task<dynamic> GetAccountChannels(AccountChannelsRequest request);

        Task<dynamic> GetAccountInfo(AccountInfoRequest request);

        Task<dynamic> GetGatewayBalance(GatewayBalanceRequest request);
    }
}
