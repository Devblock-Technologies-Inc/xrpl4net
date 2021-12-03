namespace Xrpl4net.Core
{

    /// <summary>
    /// The response expected from a {@link LedgerDataRequest}.
    /// </summary>
    class LedgerDataResponse : BaseResponse
    {
        public LedgerDataResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

