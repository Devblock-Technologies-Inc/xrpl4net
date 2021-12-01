namespace Xrpl4net.Core
{
    class AccountRootFlagsInterface
    {
        bool? LsfPasswordSpent { get; set; }

        bool? LsfRequireDestTag { get; set; }

        bool? LsfRequireAuth { get; set; }

        bool? LsfDisallowXRP { get; set; }

        bool? LsfNoFreeze { get; set; }

        bool? LsfGlobalFreeze { get; set; }

        bool? LsfDefaultRipple { get; set; }

        bool? LsfDepositAuth { get; set; }
    }
}
