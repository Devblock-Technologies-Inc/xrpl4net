
namespace Xrpl4net.Core
{
    public class DisabledValidator
    {
        double FirstLedgerSequence { get; set; }

        string PublicKey { get; set; }
    }

    class NegativeUNL : BaseLedgerEntry
    {
        string LedgerEntryType => "NegativeUNL";

        string ValidatorToDisable { get; set; }

        string ValidatorToReEnable { get; set; }

        DisabledValidator[] DisabledValidators { get; set; }
    }
}
