using DcrDataSharp.Interfaces.Clients.Api;
using DcrDataSharp.Types;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class BlockApi : IBlockApi
    {
        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public BlockApi(RestClient restClient)
        {
            this._restClient = restClient;
        }


        public async Task<BlockDataBasic?> Get(long x, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestRequest($"/api/block/{x}");
            return await _restClient.GetAsync<BlockDataBasic>(request, cancellationToken);
        }
    }
}