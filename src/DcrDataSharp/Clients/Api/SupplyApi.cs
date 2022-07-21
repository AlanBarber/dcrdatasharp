using DcrDataSharp.Interfaces.Clients.Api;
using DcrDataSharp.Types;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class SupplyApi : ISupplyApi
    {
        private const string coinSupplyEndpoint = "/api/supply";
        private const string coinSupplyCirculatingAtomsEndpoint = "/api/supply/circulating?dcr=false";
        private const string coinSupplyCirculatingDcrEndpoint = "/api/supply/circulating?dcr=true";


        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public SupplyApi(RestClient restClient)
        {
            this._restClient = restClient;
        }

        /// <inheritdoc />
        public async Task<CoinSupply?> GetCoinSupplyAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<CoinSupply>(coinSupplyEndpoint, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<long> GetCoinSupplyCirculatingAtomsAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<long>(coinSupplyCirculatingAtomsEndpoint, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<float> GetCoinSupplyCirculatingDcrAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<float>(coinSupplyCirculatingDcrEndpoint, cancellationToken);
        }
    }
}