using DcrDataSharp.Interfaces.Clients.Api;
using RestSharp;

namespace DcrDataSharp.Clients.Api;

/// <inheritdoc />
public class EndPointApi : IEndPointListApi
{
    private const string endPointListEndpoint = "/api/list";

    private readonly RestClient _restClient;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="restClient"></param>
    public EndPointApi(RestClient restClient)
    {
        this._restClient = restClient;
    }

    /// <inheritdoc />
    public async Task<string[]?> GetEndPointsAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        return await _restClient.GetJsonAsync<string[]>(endPointListEndpoint, cancellationToken);
    }
}