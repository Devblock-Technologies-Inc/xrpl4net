using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrpl4net.Client.Models
{
    public abstract class BaseRequest
    {
        public virtual string method { get; }
    }
}
