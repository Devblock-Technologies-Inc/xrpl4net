using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models
{
    public abstract class BaseResponse
    {
        public string status { get; set; }

        public bool validated { get; set; }

        public string ledger_hash { get; set; }

        public uint ledger_index { get; set; }

        public List<Warning> warnings { get; set; } = new List<Warning>();
    }

    public class Warning
    {
        public int id { get; set; }

        public string message { get; set; }
    }
}
