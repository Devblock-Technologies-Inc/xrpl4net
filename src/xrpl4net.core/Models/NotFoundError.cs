namespace Xrpl4net.Core
{

    /// <summary>
    /// Error thrown when xrpl.js cannot retrieve a transaction, ledger, account, etc.
    /// From rippled.
    /// </summary>
    class NotFoundError : XrplError
    {
        public NotFoundError(string message) => throw new System.NotImplementedException();

        [Newtonsoft.Json.JsonProperty("data", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object? Data { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("message", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Message { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("name", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("stack", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Stack { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("prepareStackTrace", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static System.Func<Error, CallSite[], object>? PrepareStackTrace { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("stackTraceLimit", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static double StackTraceLimit { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Console.log in node uses util.inspect on object, and util.inspect allows
        /// us to customize its output:
        /// https://nodejs.org/api/util.html#util_custom_inspect_function_on_objects.
        /// </summary>
        /// <returns>
        /// The String output of the Error.
        /// 
        /// </returns>
        public string Inspect() => throw new System.NotImplementedException();

        /// <summary>
        /// Converts the Error to a human-readable String form.
        /// </summary>
        /// <returns>
        /// The String output of the Error.
        /// 
        /// </returns>
        public string ToString() => throw new System.NotImplementedException();

        /// <summary>
        /// Create .stack property on a target object
        /// </summary>
        static void CaptureStackTrace(object targetObject, Function constructorOpt) => throw new System.NotImplementedException();

    }
}

