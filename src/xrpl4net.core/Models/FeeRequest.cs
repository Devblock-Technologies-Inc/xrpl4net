namespace Xrpl4net.Core
{

    /// <summary>
    /// The `fee` command reports the current state of the open-ledger requirements
    /// for the transaction cost. This requires the FeeEscalation amendment to be
    /// enabled. Expects a response in the form of a {@link FeeResponse}.
    /// </summary>
    class FeeRequest : BaseRequest
    {
    }
}

