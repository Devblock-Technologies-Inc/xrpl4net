using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{

	public enum LedgerType
	{
		Indexed,
		Hash,
		Shortcut
	}

	public enum LedgerIndexShortcut
	{
		Validated,
		Closed,
		Current
	}

	public class LedgerIndex
	{
		public LedgerIndex(LedgerType ledgerType, object ledgerIndex)
		{
			LedgerType = ledgerType;
			switch (ledgerType)
			{
				case LedgerType.Indexed:
					Sequence = (uint)ledgerIndex;
					break;
				case LedgerType.Hash:
					LedgerHash = ledgerIndex.ToString();
					break;
				case LedgerType.Shortcut:
					LedgerIndexShortcut = (LedgerIndexShortcut)ledgerIndex;
					break;
				default: break;
			}
		}

		public LedgerType LedgerType { get; }
		public uint? Sequence { get; }
		public string? LedgerHash { get; }
		public LedgerIndexShortcut? LedgerIndexShortcut { get; }

	}
}
