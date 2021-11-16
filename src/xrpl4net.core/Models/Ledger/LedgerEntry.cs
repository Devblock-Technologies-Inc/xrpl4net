namespace Xrpl4net.Core
{

    /// <summary>
    /// LedgerEntry type definitions are exported in their own namespace to prevent
    /// collisions of the DepositPreauth SLE and Transaction. LedgerEntries are used
    /// by the client less often, and in most scenarios, like when parsing a
    /// response, the client won't need to import the type. If it is required to use
    /// a Ledger Entry, import `LedgerEntry`, and access individual ledger entry
    /// types on the `LedgerEntry` namespace.
    /// </summary>
    enum LedgerEntry
    {
    }
}

