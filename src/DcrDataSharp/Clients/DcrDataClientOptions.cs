namespace DcrDataSharp.Clients
{
    /// <summary>
    /// Options for the DcrData client
    /// </summary>
    public class DcrDataClientOptions
    {
        /// <summary>
        /// Default options for the client
        /// </summary>
        public static DcrDataClientOptions Default { get; set; } = new DcrDataClientOptions();

        public string BaseUrl { get; set; } = @"https://dcrdata.decred.org/";
    }
}
