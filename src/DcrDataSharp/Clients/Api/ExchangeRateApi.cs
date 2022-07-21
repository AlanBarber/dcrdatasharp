using DcrDataSharp.Interfaces.Clients.Api;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class ExchangeRateApi : IExchangeRateApi
    {
        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public ExchangeRateApi(RestClient restClient)
        {
            this._restClient = restClient;
        }
    }
}