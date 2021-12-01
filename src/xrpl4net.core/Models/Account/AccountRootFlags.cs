namespace Xrpl4net.Core.Models.Account
{
    enum AccountRootFlags
    {
        LsfPasswordSpent = 0x00010000,

        LsfRequireDestTag = 0x00020000,

        LsfRequireAuth = 0x00040000,

        LsfDisallowXRP = 0x00080000,

        LsfDisableMaster = 0x00100000,

        LsfNoFreeze = 0x00200000,

        LsfGlobalFreeze = 0x00400000,

        LsfDefaultRipple = 0x00800000,

        LsfDepositAuth = 0x01000000,
    }
}
