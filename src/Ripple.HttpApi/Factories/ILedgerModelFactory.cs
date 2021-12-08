using Ripple.HttpApi.Models.Ledger;
using System.Threading.Tasks;

namespace Ripple.HttpApi.Factories
{
    public interface ILedgerModelFactory
    {
        Task<dynamic> GetLedger(LedgerRequest request);
    }
}
