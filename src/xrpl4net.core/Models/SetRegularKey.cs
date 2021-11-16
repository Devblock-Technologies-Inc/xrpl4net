namespace Xrpl4net.Core
{

    /// <summary>
    /// A SetRegularKey transaction assigns, changes, or removes the regular key
    /// pair associated with an account.
    /// </summary>
    class SetRegularKey : BaseTransaction
    {
        /// <summary>
        /// A base-58-encoded Address that indicates the regular key pair to be
        /// assigned to the account. If omitted, removes any existing regular key pair.
        /// from the account. Must not match the master key pair for the address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RegularKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string? RegularKey { get; set; }

    }
}

