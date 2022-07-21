using DcrDataSharp.Interfaces.Clients.Api;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class ExchangesApi : IExchangesApi
    {
        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public ExchangesApi(RestClient restClient)
        {
            this._restClient = restClient;
        }
    }
}