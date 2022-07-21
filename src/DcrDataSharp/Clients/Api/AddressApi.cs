using DcrDataSharp.Interfaces.Clients.Api;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class AddressApi : IAddressApi
    {
        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public AddressApi(RestClient restClient)
        {
            this._restClient = restClient;
        }
    }
}