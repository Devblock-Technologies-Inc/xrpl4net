using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Core
{
	public class Warning
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public Dictionary<string, object> Details { get; } = new Dictionary<string, object>();

	}
}
