using DcrDataSharp.Interfaces.Clients.Api;
using DcrDataSharp.Types;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class TreasuryApi : ITreasuryApi
    {
        private const string treasuryBalanceEndpoint = "/api/treasury/balance";

        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public TreasuryApi(RestClient restClient)
        {
            this._restClient = restClient;
        }

        /// <inheritdoc />
        public async Task<TreasuryBalance?> GetTreasuryBalanceAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<TreasuryBalance>(treasuryBalanceEndpoint, cancellationToken);
        }
    }
}