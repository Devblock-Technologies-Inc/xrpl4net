namespace Xrpl4net.Core
{

    /// <summary>
    /// The response expected from a {@link LedgerClosedRequest}.
    /// </summary>
    class LedgerClosedResponse : BaseResponse
    {
        public LedgerClosedResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

