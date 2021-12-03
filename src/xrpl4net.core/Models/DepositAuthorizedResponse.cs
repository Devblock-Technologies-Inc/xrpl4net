namespace Xrpl4net.Core
{

    /// <summary>
    /// Expected response from a {@link DepositAuthorizedRequest}.
    /// </summary>
    class DepositAuthorizedResponse : BaseResponse
    {
        public DepositAuthorizedResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

