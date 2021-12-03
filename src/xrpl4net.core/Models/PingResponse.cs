namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected from a {@link PingRequest}.
    /// </summary>
    class PingResponse : BaseResponse
    {
        public PingResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

