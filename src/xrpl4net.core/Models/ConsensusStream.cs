namespace Xrpl4net.Core
{

    /// <summary>
    /// The consensus stream sends consensusPhase messages when the consensus
    /// process changes phase. The message contains the new phase of consensus the
    /// server is in.
    /// </summary>
    class ConsensusStream : BaseStream
    {
        /// <summary>
        /// The new consensus phase the server is in. Possible values are open,
        /// establish, and accepted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consensus", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        string Consensus { get; set; }

    }
}

