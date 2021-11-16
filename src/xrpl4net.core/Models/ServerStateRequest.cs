namespace Xrpl4net.Core
{

    /// <summary>
    /// The `server_state` command asks the server for various machine-readable
    /// information about the rippled server's current state. The response is almost
    /// the same as the server_info method, but uses units that are easier to process
    /// instead of easier to read.
    /// </summary>
    class ServerStateRequest : BaseRequest
    {
    }
}

