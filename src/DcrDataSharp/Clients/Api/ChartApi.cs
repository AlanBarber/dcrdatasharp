using DcrDataSharp.Interfaces.Clients.Api;
using RestSharp;

namespace DcrDataSharp.Clients.Api
{
    /// <inheritdoc />
    public class ChartApi : IChartApi
    {
        private readonly RestClient _restClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="restClient"></param>
        public ChartApi(RestClient restClient)
        {
            this._restClient = restClient;
        }
    }
}