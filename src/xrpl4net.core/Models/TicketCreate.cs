namespace Xrpl4net.Core
{

    /// <summary>
    /// A TicketCreate transaction sets aside one or more sequence numbers as
    /// Tickets.
    /// </summary>
    class TicketCreate : BaseTransaction
    {
        /// <summary>
        /// How many Tickets to create. This must be a positive number and cannot
        /// cause the account to own more than 250 Tickets after executing this
        /// transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TicketCount", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        double TicketCount { get; set; }

    }
}

