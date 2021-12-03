namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected by a {@link NoRippleCheckRequest}.
    /// </summary>
    class NoRippleCheckResponse : BaseResponse
    {
        public NoRippleCheckResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

