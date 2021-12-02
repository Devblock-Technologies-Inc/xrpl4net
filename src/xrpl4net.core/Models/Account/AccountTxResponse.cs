namespace Xrpl4net.Core
{

    /// <summary>
    /// Expected response from an {@link AccountTxRequest}.
    /// </summary>
    class AccountTxResponse : BaseResponse
    {
        public AccountTxResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

