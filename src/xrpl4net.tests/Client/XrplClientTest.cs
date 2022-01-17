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
        protected FaucetClient _faucetClient;

        [SetUp]
        public virtual void SetUp()
        {
            _xrplClient = new XrplClient("https://s.altnet.rippletest.net:51234/");
            _faucetClient = new FaucetClient("https://faucet.altnet.rippletest.net");
        }
    }
}
