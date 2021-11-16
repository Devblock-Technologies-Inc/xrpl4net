namespace Xrpl4net.Core
{

    /// <summary>
    /// A utility for deriving a wallet composed of a keypair (publicKey/privateKey).
    /// A wallet can be derived from either a seed, mnemonic, or entropy (array of random numbers).
    /// It provides functionality to sign/verify transactions offline.
    /// </summary>
    class Wallet
    {
        public Wallet(string publicKey, string privateKey, WalletOptions opts) => throw new System.NotImplementedException();

        [Newtonsoft.Json.JsonProperty("classicAddress", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClassicAddress { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("privateKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrivateKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("publicKey", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublicKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("seed", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string? Seed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        [Newtonsoft.Json.JsonProperty("fromSecret", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        static public System.Func<string, DeriveWalletOptions, Wallet> FromSecret { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); } = Wallet.fromSeed;

        [Newtonsoft.Json.JsonProperty("address", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get => throw new System.NotImplementedException(); }

        /// <summary>
        ///  Decode a serialized transaction, remove the fields that are added during the signing process,
        ///  and verify that it matches the transaction prior to signing. This gives the user a sanity check
        ///  to ensure that what they try to encode matches the message that will be recieved by rippled.
        /// </summary>
        private void CheckTxSerialization(string serialized, Transaction tx) => throw new System.NotImplementedException();

        /// <summary>
        /// Gets an X-address in Testnet/Mainnet format.
        /// </summary>
        /// <returns>
        /// An X-address.
        /// 
        /// </returns>
        public string GetXAddress(TypedocConverter.GeneratedTypes.DoubleStringUnion tag, bool isTestnet) => throw new System.NotImplementedException();

        /// <summary>
        /// Signs a transaction offline.
        /// </summary>
        /// <returns>
        /// A signed transaction.
        /// </returns>
        public SignedTxBlobHash Sign(Transaction transaction, TypedocConverter.GeneratedTypes.StringBoolUnion multisign) => throw new System.NotImplementedException();

        /// <summary>
        /// Verifies a signed transaction offline.
        /// </summary>
        /// <returns>
        /// Returns true if a signedTransaction is valid.
        /// 
        /// </returns>
        public bool VerifyTransaction(string signedTransaction) => throw new System.NotImplementedException();

        /// <summary>
        /// Derive a Wallet from a seed.
        /// </summary>
        /// <returns>
        /// A Wallet derived from the seed.
        /// 
        /// </returns>
        static private Wallet DeriveWallet(string seed, DeriveWalletOptions opts) => throw new System.NotImplementedException();

        /// <summary>
        /// Derives a wallet from an entropy (array of random numbers).
        /// </summary>
        /// <returns>
        /// A Wallet derived from an entropy.
        /// 
        /// </returns>
        static public Wallet FromEntropy(TypedocConverter.GeneratedTypes.DoubleArrayByteArrayUnion entropy, DeriveWalletOptions opts) => throw new System.NotImplementedException();

        /// <summary>
        /// Derives a wallet from a mnemonic.
        /// </summary>
        /// <returns>
        /// A Wallet derived from a mnemonic.
        /// </returns>
        static public Wallet FromMnemonic(string mnemonic, FromMnemonicOptions opts) => throw new System.NotImplementedException();

        /// <summary>
        /// Derives a wallet from a seed.
        /// </summary>
        /// <returns>
        /// A Wallet derived from a seed.
        /// 
        /// </returns>
        static public Wallet FromSeed(string seed, DeriveWalletOptions opts) => throw new System.NotImplementedException();

        /// <summary>
        /// Generates a new Wallet using a generated seed.
        /// </summary>
        /// <returns>
        /// A new Wallet derived from a generated seed.
        /// 
        /// </returns>
        static public Wallet Generate(ECDSA algorithm) => throw new System.NotImplementedException();

    }
}

