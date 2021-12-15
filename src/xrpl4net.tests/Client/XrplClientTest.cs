using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xrpl4net.Client;

namespace Xrpl4net.Tests.Client
{
    [TestFixture]
    public abstract class XrplClientTest : BaseXRPL4NetTest
    {
        protected XrplClient _xrplClient;

        [SetUp]
        public virtual void SetUp()
        {
            _xrplClient = new XrplClient("http://s1.ripple.com:51234/");
        }
    }
}
