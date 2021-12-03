namespace Xrpl4net.Core
{

    /// <summary>
    /// The expected response from an {@link AccountCurrenciesRequest}.
    /// </summary>
    class AccountCurrenciesResponse : BaseResponse
    {
        public AccountCurrenciesResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

