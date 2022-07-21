using DcrDataSharp.Interfaces.Clients.Api;
using DcrDataSharp.Types;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    internal class StatusApi : IStatusApi
    {
        private const string statusEndpoint = "/api/status";
        private const string healthEndpoint = "/api/status/happy";

        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient">REST Client</param>
        public StatusApi(RestClient restClient)
        {
            this._restClient = restClient;
        }

        /// <inheritdoc />
        public async Task<APIStatus?> GetStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<APIStatus>(statusEndpoint, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<Health?> GetHealthAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await _restClient.GetJsonAsync<Health>(healthEndpoint, cancellationToken);
        }
    }
}
