namespace Xrpl4net.Core
{

    /// <summary>
    /// Retrieve information about the public ledger. Expects a response in the form
    /// of a {@link LedgerResponse}.
    /// </summary>
    class LedgerRequest : BaseRequest
    {
        /// <summary>
        /// Admin required. If true, return information on accounts in the ledger.
        /// Ignored if you did not specify a ledger version. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accounts", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Accounts { get; set; }

        /// <summary>
        /// If true, and transactions and expand are both also true, return
        /// transaction information in binary format (hexadecimal string) instead of
        /// JSON format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("binary", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Binary { get; set; }

        /// <summary>
        /// Provide full JSON-formatted information for transaction/account
        /// information instead of only hashes. Defaults to false. Ignored unless you
        /// request transactions, accounts, or both.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expand", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Expand { get; set; }

        /// <summary>
        /// Admin required If true, return full information on the entire ledger.
        /// Ignored if you did not specify a ledger version. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("full", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Full { get; set; }

        /// <summary>
        /// A 20-byte hex string for the ledger version to use.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_hash", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? LedgerHash { get; set; }

        /// <summary>
        /// The ledger index of the ledger to use, or a shortcut string to choose a
        /// ledger automatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ledger_index", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        LedgerIndex? LedgerIndex { get; set; }

        /// <summary>
        /// If true, include owner_funds field in the metadata of OfferCreate
        /// transactions in the response. Defaults to false. Ignored unless
        /// transactions are included and expand is true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("owner_funds", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? OwnerFunds { get; set; }

        /// <summary>
        /// If true, and the command is requesting the current ledger, includes an
        /// array of queued transactions in the results.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("queue", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Queue { get; set; }

        /// <summary>
        /// If true, return information on transactions in the specified ledger
        /// version. Defaults to false. Ignored if you did not specify a ledger
        /// version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactions", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        bool? Transactions { get; set; }

    }
}

