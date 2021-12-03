namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected from an {@link ChannelVerifyRequest}.
    /// </summary>
    class ChannelVerifyResponse : BaseResponse
    {
        public ChannelVerifyResponse(string requestId, short apiVersion = 1, bool forwarded = false, string status = "success", string type = "response", string warning = "load") : base(requestId, apiVersion, forwarded, status, type, warning)
        {
        }
    }
}

