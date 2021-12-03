namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected from a {@link PathFindRequest}.
    /// </summary>
    class PathFindResponse : BaseResponse
    {
        public PathFindResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

