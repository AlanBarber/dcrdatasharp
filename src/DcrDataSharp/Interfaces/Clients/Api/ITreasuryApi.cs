using DcrDataSharp.Types;

namespace DcrDataSharp.Interfaces.Clients.Api
{
    /// <summary>
    /// Treasury API endpoints
    /// </summary>
    public interface ITreasuryApi
    {
        public Task<TreasuryBalance?> GetTreasuryBalanceAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}