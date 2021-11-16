namespace Xrpl4net.Core
{

    /// <summary>
    /// Client for interacting with rippled servers.
    /// </summary>
    class Client : EventEmitter
    {
        public Client(string server, ClientOptions options) => throw new System.NotImplementedException();

        [Newtonsoft.Json.JsonProperty("autofill", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<T, double, System.Threading.Tasks.Task<T>> Autofill { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = autofill;

        [Newtonsoft.Json.JsonProperty("connection", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Connection Connection { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Factor to multiply estimated fee by to provide a cushion in case the
        /// required fee rises during submission of a transaction. Defaults to 1.2.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feeCushion", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double FeeCushion { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("fundWallet", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<Wallet, System.Threading.Tasks.Task<WalletWithStartingBalance>> FundWallet { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = fundWallet;

        [Newtonsoft.Json.JsonProperty("getBalances", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<string, GetBalancesOptions, System.Threading.Tasks.Task<Balance[]>> GetBalances { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = getBalances;

        [Newtonsoft.Json.JsonProperty("getLedgerIndex", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Action GetLedgerIndex { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = getLedgerIndex;

        [Newtonsoft.Json.JsonProperty("getOrderbook", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<TakerAmount, TakerAmount, OrderbookOptions, System.Threading.Tasks.Task<Orderbook>> GetOrderbook { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = getOrderbook;

        [Newtonsoft.Json.JsonProperty("getXrpBalance", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<string, GetXrpBalanceOptions, System.Threading.Tasks.Task<string>> GetXrpBalance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = getXrpBalance;

        /// <summary>
        /// Maximum transaction cost to allow, in decimal XRP. Must be a string-encoded
        /// number. Defaults to '2'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxFeeXRP", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaxFeeXRP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("prepareTransaction", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<T, double, System.Threading.Tasks.Task<T>> PrepareTransaction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = autofill;

        [Newtonsoft.Json.JsonProperty("submit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<TypedocConverter.GeneratedTypes.TransactionStringUnion, SubmitOptions, System.Threading.Tasks.Task<SubmitResponse>> Submit { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = submit;

        [Newtonsoft.Json.JsonProperty("submitAndWait", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Func<TypedocConverter.GeneratedTypes.TransactionStringUnion, SubmitOptions, System.Threading.Tasks.Task<TxResponse>> SubmitAndWait { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = submitAndWait;

        [Newtonsoft.Json.JsonProperty("captureRejectionSymbol", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static object CaptureRejectionSymbol { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets or gets the default captureRejection value for all emitters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("captureRejections", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static bool CaptureRejections { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("defaultMaxListeners", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static double DefaultMaxListeners { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// This symbol shall be used to install a listener for only monitoring `'error'`
        /// events. Listeners installed using this symbol are called before the regular
        /// `'error'` listeners are called./// Installing a listener using this symbol does not change the behavior once an
        /// `'error'` event is emitted, therefore the process will still crash if no
        /// regular `'error'` listener is installed.
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorMonitor", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static object ErrorMonitor { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("url", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get => throw new System.NotImplementedException(); }

        /// <summary>
        /// Alias for `emitter.on(eventName, listener)`.
        /// </summary>
        public Client AddListener(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Tells the Client instance to connect to its rippled server.
        /// </summary>
        /// <returns>
        /// A promise that resolves with a void value when a connection is established.
        /// </returns>
        public System.Threading.Tasks.Task Connect() => throw new System.NotImplementedException();

        /// <summary>
        /// Tells the Client instance to disconnect from it's rippled server.
        /// </summary>
        /// <returns>
        /// A promise that resolves with a void value when a connection is destroyed.
        /// </returns>
        public System.Threading.Tasks.Task Disconnect() => throw new System.NotImplementedException();

        /// <summary>
        /// Synchronously calls each of the listeners registered for the event named`eventName`, in the order they were registered, passing the supplied arguments
        /// to each./// Returns `true` if the event had listeners, `false` otherwise.
        /// 
        /// ```js
        /// const EventEmitter = require('events');
        /// const myEmitter = new EventEmitter();
        /// 
        /// // First listener
        /// myEmitter.on('event', function firstListener() {
        ///   console.log('Helloooo! first listener');
        /// });
        /// // Second listener
        /// myEmitter.on('event', function secondListener(arg1, arg2) {
        ///   console.log(`event with parameters ${arg1}, ${arg2} in second listener`);
        /// });
        /// // Third listener
        /// myEmitter.on('event', function thirdListener(...args) {
        ///   const parameters = args.join(', ');
        ///   console.log(`event with parameters ${parameters} in third listener`);
        /// });
        /// 
        /// console.log(myEmitter.listeners('event'));
        /// 
        /// myEmitter.emit('event', 1, 2, 3, 4, 5);
        /// 
        /// // Prints:
        /// // [
        /// //   [Function: firstListener],
        /// //   [Function: secondListener],
        /// //   [Function: thirdListener]
        /// // ]
        /// // Helloooo! first listener
        /// // event with parameters 1, 2 in second listener
        /// // event with parameters 1, 2, 3, 4, 5 in third listener
        /// ```
        /// </summary>
        public bool Emit(string eventName, object[] args) => throw new System.NotImplementedException();

        /// <summary>
        /// Returns an array listing the events for which the emitter has registered
        /// listeners. The values in the array are strings or `Symbol`s./// ```js
        /// const EventEmitter = require('events');
        /// const myEE = new EventEmitter();
        /// myEE.on('foo', () =&gt; {});
        /// myEE.on('bar', () =&gt; {});
        /// 
        /// const sym = Symbol('symbol');
        /// myEE.on(sym, () =&gt; {});
        /// 
        /// console.log(myEE.eventNames());
        /// // Prints: [ 'foo', 'bar', Symbol(symbol) ]
        /// ```
        /// </summary>
        public string[] EventNames() => throw new System.NotImplementedException();

        /// <summary>
        /// Returns the current max listener value for the `EventEmitter` which is either
        /// set by `emitter.setMaxListeners(n)` or defaults to {@link defaultMaxListeners}.
        /// </summary>
        public double GetMaxListeners() => throw new System.NotImplementedException();

        /// <summary>
        /// Checks if the Client instance is connected to its rippled server.
        /// </summary>
        /// <returns>
        /// Whether the client instance is connected.
        /// </returns>
        public bool IsConnected() => throw new System.NotImplementedException();

        /// <summary>
        /// Returns the number of listeners listening to the event named `eventName`.
        /// </summary>
        public double ListenerCount(string eventName) => throw new System.NotImplementedException();

        /// <summary>
        /// Returns a copy of the array of listeners for the event named `eventName`./// ```js
        /// server.on('connection', (stream) =&gt; {
        ///   console.log('someone connected!');
        /// });
        /// console.log(util.inspect(server.listeners('connection')));
        /// // Prints: [ [Function] ]
        /// ```
        /// </summary>
        public Function[] Listeners(string eventName) => throw new System.NotImplementedException();

        /// <summary>
        /// Alias for `emitter.removeListener()`.
        /// </summary>
        public Client Off(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<double> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<LedgerStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<ValidationStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<TransactionStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<PeerStatusStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<ConsensusStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<PathFindStream> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Event handler for subscription streams.
        /// </summary>
        /// <returns>
        /// This, because it inherits from EventEmitter.
        /// 
        /// </returns>
        public Client On(string @event, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Adds a **one-time**`listener` function for the event named `eventName`. The
        /// next time `eventName` is triggered, this listener is removed and then invoked./// ```js
        /// server.once('connection', (stream) =&gt; {
        ///   console.log('Ah, we have our first user!');
        /// });
        /// ```
        /// 
        /// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// 
        /// By default, event listeners are invoked in the order they are added. The`emitter.prependOnceListener()` method can be used as an alternative to add the
        /// event listener to the beginning of the listeners array.
        /// 
        /// ```js
        /// const myEE = new EventEmitter();
        /// myEE.once('foo', () =&gt; console.log('a'));
        /// myEE.prependOnceListener('foo', () =&gt; console.log('b'));
        /// myEE.emit('foo');
        /// // Prints:
        /// //   b
        /// //   a
        /// ```
        /// </summary>
        public Client Once(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Adds the `listener` function to the _beginning_ of the listeners array for the
        /// event named `eventName`. No checks are made to see if the `listener` has
        /// already been added. Multiple calls passing the same combination of `eventName`and `listener` will result in the `listener` being added, and called, multiple
        /// times./// ```js
        /// server.prependListener('connection', (stream) =&gt; {
        ///   console.log('someone connected!');
        /// });
        /// ```
        /// 
        /// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// </summary>
        public Client PrependListener(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Adds a **one-time**`listener` function for the event named `eventName` to the_beginning_ of the listeners array. The next time `eventName` is triggered, this
        /// listener is removed, and then invoked./// ```js
        /// server.prependOnceListener('connection', (stream) =&gt; {
        ///   console.log('Ah, we have our first user!');
        /// });
        /// ```
        /// 
        /// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// </summary>
        public Client PrependOnceListener(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Returns a copy of the array of listeners for the event named `eventName`,
        /// including any wrappers (such as those created by `.once()`)./// ```js
        /// const emitter = new EventEmitter();
        /// emitter.once('log', () =&gt; console.log('log once'));
        /// 
        /// // Returns a new Array with a function `onceWrapper` which has a property
        /// // `listener` which contains the original listener bound above
        /// const listeners = emitter.rawListeners('log');
        /// const logFnWrapper = listeners[0];
        /// 
        /// // Logs "log once" to the console and does not unbind the `once` event
        /// logFnWrapper.listener();
        /// 
        /// // Logs "log once" to the console and removes the listener
        /// logFnWrapper();
        /// 
        /// emitter.on('log', () =&gt; console.log('log persistently'));
        /// // Will return a new Array with a single function bound by `.on()` above
        /// const newListeners = emitter.rawListeners('log');
        /// 
        /// // Logs "log persistently" twice
        /// newListeners[0]();
        /// emitter.emit('log');
        /// ```
        /// </summary>
        public Function[] RawListeners(string eventName) => throw new System.NotImplementedException();

        /// <summary>
        /// Removes all listeners, or those of the specified `eventName`./// It is bad practice to remove listeners added elsewhere in the code,
        /// particularly when the `EventEmitter` instance was created by some other
        /// component or module (e.g. sockets or file streams).
        /// 
        /// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// </summary>
        public Client RemoveAllListeners(string @event) => throw new System.NotImplementedException();

        /// <summary>
        /// Removes the specified `listener` from the listener array for the event named`eventName`./// ```js
        /// const callback = (stream) =&gt; {
        ///   console.log('someone connected!');
        /// };
        /// server.on('connection', callback);
        /// // ...
        /// server.removeListener('connection', callback);
        /// ```
        /// 
        /// `removeListener()` will remove, at most, one instance of a listener from the
        /// listener array. If any single listener has been added multiple times to the
        /// listener array for the specified `eventName`, then `removeListener()` must be
        /// called multiple times to remove each instance.
        /// 
        /// Once an event is emitted, all listeners attached to it at the
        /// time of emitting are called in order. This implies that any`removeListener()` or `removeAllListeners()` calls _after_ emitting and_before_ the last listener finishes execution will
        /// not remove them from`emit()` in progress. Subsequent events behave as expected.
        /// 
        /// ```js
        /// const myEmitter = new MyEmitter();
        /// 
        /// const callbackA = () =&gt; {
        ///   console.log('A');
        ///   myEmitter.removeListener('event', callbackB);
        /// };
        /// 
        /// const callbackB = () =&gt; {
        ///   console.log('B');
        /// };
        /// 
        /// myEmitter.on('event', callbackA);
        /// 
        /// myEmitter.on('event', callbackB);
        /// 
        /// // callbackA removes listener callbackB but it will still be called.
        /// // Internal listener array at time of emit [callbackA, callbackB]
        /// myEmitter.emit('event');
        /// // Prints:
        /// //   A
        /// //   B
        /// 
        /// // callbackB is now removed.
        /// // Internal listener array [callbackA]
        /// myEmitter.emit('event');
        /// // Prints:
        /// //   A
        /// ```
        /// 
        /// Because listeners are managed using an internal array, calling this will
        /// change the position indices of any listener registered _after_ the listener
        /// being removed. This will not impact the order in which listeners are called,
        /// but it means that any copies of the listener array as returned by
        /// the `emitter.listeners()` method will need to be recreated.
        /// 
        /// When a single function has been added as a handler multiple times for a single
        /// event (as in the example below), `removeListener()` will remove the most
        /// recently added instance. In the example the `once('ping')`listener is removed:
        /// 
        /// ```js
        /// const ee = new EventEmitter();
        /// 
        /// function pong() {
        ///   console.log('pong');
        /// }
        /// 
        /// ee.on('ping', pong);
        /// ee.once('ping', pong);
        /// ee.removeListener('ping', pong);
        /// 
        /// ee.emit('ping');
        /// ee.emit('ping');
        /// ```
        /// 
        /// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// </summary>
        public Client RemoveListener(string eventName, System.Action<object[]> listener) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountChannelsResponse> Request(AccountChannelsRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountCurrenciesResponse> Request(AccountCurrenciesRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountInfoResponse> Request(AccountInfoRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountLinesResponse> Request(AccountLinesRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountObjectsResponse> Request(AccountObjectsRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountOffersResponse> Request(AccountOffersRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<AccountTxResponse> Request(AccountTxRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<BookOffersResponse> Request(BookOffersRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<ChannelVerifyResponse> Request(ChannelVerifyRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<DepositAuthorizedResponse> Request(DepositAuthorizedRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<FeeResponse> Request(FeeRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<GatewayBalancesResponse> Request(GatewayBalancesRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerResponse> Request(LedgerRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerClosedResponse> Request(LedgerClosedRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerCurrentResponse> Request(LedgerCurrentRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerDataResponse> Request(LedgerDataRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerEntryResponse> Request(LedgerEntryRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<ManifestResponse> Request(ManifestRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<NoRippleCheckResponse> Request(NoRippleCheckRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<PathFindResponse> Request(PathFindRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<PingResponse> Request(PingRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<RandomResponse> Request(RandomRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<RipplePathFindResponse> Request(RipplePathFindRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<ServerInfoResponse> Request(ServerInfoRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<ServerStateResponse> Request(ServerStateRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<SubmitResponse> Request(SubmitRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<SubmitMultisignedResponse> Request(SubmitMultisignedRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<SubscribeResponse> Request(SubscribeRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<UnsubscribeResponse> Request(UnsubscribeRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<TransactionEntryResponse> Request(TransactionEntryRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<TxResponse> Request(TxRequest r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes a request to the client with the given command and
        /// additional request body parameters.
        /// </summary>
        /// <returns>
        /// The response from the server.
        /// </returns>
        public System.Threading.Tasks.Task<T> Request<R, T>(R r) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<AccountChannelsResponse[]> RequestAll(AccountChannelsRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<AccountLinesResponse[]> RequestAll(AccountLinesRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<AccountObjectsResponse[]> RequestAll(AccountObjectsRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<AccountOffersResponse[]> RequestAll(AccountOffersRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<AccountTxResponse[]> RequestAll(AccountTxRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<BookOffersResponse[]> RequestAll(BookOffersRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Makes multiple paged requests to the client to return a given number of
        /// resources. Multiple paged requests will be made until the `limit`
        /// number of resources is reached (if no `limit` is provided, a single request
        /// will be made)./// If the command is unknown, an additional `collect` property is required to
        /// know which response key contains the array of resources.
        /// 
        /// NOTE: This command is used by existing methods and is not recommended for
        /// general use. Instead, use rippled's built-in pagination and make multiple
        /// requests as needed.
        /// 
        /// </summary>
        /// <returns>
        /// The array of all responses.
        /// </returns>
        public System.Threading.Tasks.Task<LedgerDataResponse[]> RequestAll(LedgerDataRequest req) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<AccountChannelsResponse> RequestNextPage(AccountChannelsRequest req, AccountChannelsResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<AccountLinesResponse> RequestNextPage(AccountLinesRequest req, AccountLinesResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<AccountObjectsResponse> RequestNextPage(AccountObjectsRequest req, AccountObjectsResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<AccountOffersResponse> RequestNextPage(AccountOffersRequest req, AccountOffersResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<AccountTxResponse> RequestNextPage(AccountTxRequest req, AccountTxResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// Requests the next page of data.
        /// </summary>
        /// <returns>
        /// The response with the next page of data.
        /// 
        /// </returns>
        public System.Threading.Tasks.Task<LedgerDataResponse> RequestNextPage(LedgerDataRequest req, LedgerDataResponse resp) => throw new System.NotImplementedException();

        /// <summary>
        /// By default `EventEmitter`s will print a warning if more than `10` listeners are
        /// added for a particular event. This is a useful default that helps finding
        /// memory leaks. The `emitter.setMaxListeners()` method allows the limit to be
        /// modified for this specific `EventEmitter` instance. The value can be set to`Infinity` (or `0`) to indicate an unlimited number of listeners./// Returns a reference to the `EventEmitter`, so that calls can be chained.
        /// </summary>
        public Client SetMaxListeners(double n) => throw new System.NotImplementedException();

        /// <summary>
        /// Returns a copy of the array of listeners for the event named `eventName`./// For `EventEmitter`s this behaves exactly the same as calling `.listeners` on
        /// the emitter.
        /// 
        /// For `EventTarget`s this is the only way to get the event listeners for the
        /// event target. This is useful for debugging and diagnostic purposes.
        /// 
        /// ```js
        /// const { getEventListeners, EventEmitter } = require('events');
        /// 
        /// {
        ///   const ee = new EventEmitter();
        ///   const listener = () =&gt; console.log('Events are fun');
        ///   ee.on('foo', listener);
        ///   getEventListeners(ee, 'foo'); // [listener]
        /// }
        /// {
        ///   const et = new EventTarget();
        ///   const listener = () =&gt; console.log('Events are fun');
        ///   et.addEventListener('foo', listener);
        ///   getEventListeners(et, 'foo'); // [listener]
        /// }
        /// ```
        /// </summary>
        static Function[] GetEventListeners(TypedocConverter.GeneratedTypes.DOMEventTargetEventEmitterUnion emitter, string name) => throw new System.NotImplementedException();

        /// <summary>
        /// A class method that returns the number of listeners for the given `eventName`registered on the given `emitter`./// ```js
        /// const { EventEmitter, listenerCount } = require('events');
        /// const myEmitter = new EventEmitter();
        /// myEmitter.on('event', () =&gt; {});
        /// myEmitter.on('event', () =&gt; {});
        /// console.log(listenerCount(myEmitter, 'event'));
        /// // Prints: 2
        /// ```
        /// </summary>
        static double ListenerCount(EventEmitter emitter, string eventName) => throw new System.NotImplementedException();

        /// <summary>
        /// ```js
        /// const { on, EventEmitter } = require('events');/// (async () =&gt; {
        ///   const ee = new EventEmitter();
        /// 
        ///   // Emit later on
        ///   process.nextTick(() =&gt; {
        ///     ee.emit('foo', 'bar');
        ///     ee.emit('foo', 42);
        ///   });
        /// 
        ///   for await (const event of on(ee, 'foo')) {
        ///     // The execution of this inner block is synchronous and it
        ///     // processes one event at a time (even with await). Do not use
        ///     // if concurrent execution is required.
        ///     console.log(event); // prints ['bar'] [42]
        ///   }
        ///   // Unreachable here
        /// })();
        /// ```
        /// 
        /// Returns an `AsyncIterator` that iterates `eventName` events. It will throw
        /// if the `EventEmitter` emits `'error'`. It removes all listeners when
        /// exiting the loop. The `value` returned by each iteration is an array
        /// composed of the emitted event arguments.
        /// 
        /// An `AbortSignal` can be used to cancel waiting on events:
        /// 
        /// ```js
        /// const { on, EventEmitter } = require('events');
        /// const ac = new AbortController();
        /// 
        /// (async () =&gt; {
        ///   const ee = new EventEmitter();
        /// 
        ///   // Emit later on
        ///   process.nextTick(() =&gt; {
        ///     ee.emit('foo', 'bar');
        ///     ee.emit('foo', 42);
        ///   });
        /// 
        ///   for await (const event of on(ee, 'foo', { signal: ac.signal })) {
        ///     // The execution of this inner block is synchronous and it
        ///     // processes one event at a time (even with await). Do not use
        ///     // if concurrent execution is required.
        ///     console.log(event); // prints ['bar'] [42]
        ///   }
        ///   // Unreachable here
        /// })();
        /// 
        /// process.nextTick(() =&gt; ac.abort());
        /// ```
        /// </summary>
        /// <returns>
        /// that iterates `eventName` events emitted by the `emitter`
        /// 
        /// </returns>
        static AsyncIterableIterator<object> On(EventEmitter emitter, string eventName, StaticEventEmitterOptions options) => throw new System.NotImplementedException();

        /// <summary>
        /// Creates a `Promise` that is fulfilled when the `EventEmitter` emits the given
        /// event or that is rejected if the `EventEmitter` emits `'error'` while waiting.
        /// The `Promise` will resolve with an array of all the arguments emitted to the
        /// given event./// This method is intentionally generic and works with the web platform [EventTarget](https://dom.spec.whatwg.org/#interface-eventtarget) interface, which has no special`'error'` event
        /// semantics and does not listen to the `'error'` event.
        /// 
        /// ```js
        /// const { once, EventEmitter } = require('events');
        /// 
        /// async function run() {
        ///   const ee = new EventEmitter();
        /// 
        ///   process.nextTick(() =&gt; {
        ///     ee.emit('myevent', 42);
        ///   });
        /// 
        ///   const [value] = await once(ee, 'myevent');
        ///   console.log(value);
        /// 
        ///   const err = new Error('kaboom');
        ///   process.nextTick(() =&gt; {
        ///     ee.emit('error', err);
        ///   });
        /// 
        ///   try {
        ///     await once(ee, 'myevent');
        ///   } catch (err) {
        ///     console.log('error happened', err);
        ///   }
        /// }
        /// 
        /// run();
        /// ```
        /// 
        /// The special handling of the `'error'` event is only used when `events.once()`is used to wait for another event. If `events.once()` is used to wait for the
        /// '`error'` event itself, then it is treated as any other kind of event without
        /// special handling:
        /// 
        /// ```js
        /// const { EventEmitter, once } = require('events');
        /// 
        /// const ee = new EventEmitter();
        /// 
        /// once(ee, 'error')
        ///   .then(([err]) =&gt; console.log('ok', err.message))
        ///   .catch((err) =&gt; console.log('error', err.message));
        /// 
        /// ee.emit('error', new Error('boom'));
        /// 
        /// // Prints: ok boom
        /// ```
        /// 
        /// An `AbortSignal` can be used to cancel waiting for the event:
        /// 
        /// ```js
        /// const { EventEmitter, once } = require('events');
        /// 
        /// const ee = new EventEmitter();
        /// const ac = new AbortController();
        /// 
        /// async function foo(emitter, event, signal) {
        ///   try {
        ///     await once(emitter, event, { signal });
        ///     console.log('event emitted!');
        ///   } catch (error) {
        ///     if (error.name === 'AbortError') {
        ///       console.error('Waiting for the event was canceled!');
        ///     } else {
        ///       console.error('There was an error', error.message);
        ///     }
        ///   }
        /// }
        /// 
        /// foo(ee, 'foo', ac.signal);
        /// ac.abort(); // Abort waiting for the event
        /// ee.emit('foo'); // Prints: Waiting for the event was canceled!
        /// ```
        /// </summary>
        static System.Threading.Tasks.Task<object[]> Once(NodeEventTarget emitter, string eventName, StaticEventEmitterOptions options) => throw new System.NotImplementedException();

        static System.Threading.Tasks.Task<object[]> Once(DOMEventTarget emitter, string eventName, StaticEventEmitterOptions options) => throw new System.NotImplementedException();

    }
}

