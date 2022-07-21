namespace DcrDataSharp.Interfaces.Clients.Api
{
    /// <summary>
    /// EndPoint List API endpoints
    /// </summary>
    public interface IEndPointListApi
    {
        public Task<string[]?> GetEndPointsAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
