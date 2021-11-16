namespace Xrpl4net.Core
{

    /// <summary>
    /// Response expected from a {@link TxRequest}.
    /// </summary>
    class TxResponse : BaseResponse
    {
        /// <summary>
        /// If true, the server was able to search all of the specified ledger
        /// versions, and the transaction was in none of them. If false, the server did
        /// not have all of the specified ledger versions available, so it is not sure.
        /// If one of them might contain the transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("searched_all", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? SearchedAll { get; set; }

    }
}

