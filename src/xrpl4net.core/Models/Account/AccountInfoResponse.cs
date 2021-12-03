namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected from an {@link AccountInfoRequest}.
    /// </summary>
    class AccountInfoResponse : BaseResponse
    {
        public AccountInfoResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

