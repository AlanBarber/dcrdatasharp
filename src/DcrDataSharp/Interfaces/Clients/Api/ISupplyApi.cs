using DcrDataSharp.Types;

namespace DcrDataSharp.Interfaces.Clients.Api
{
    /// <summary>
    /// Coin Supply API Endpoints
    /// </summary>
    public interface ISupplyApi
    {
        /// <summary>
        /// Gets coin supply
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        public Task<CoinSupply?> GetCoinSupplyAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets coin supply circulating
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        public Task<long> GetCoinSupplyCirculatingAtomsAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets coin supply circulating as DCR
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        public Task<float> GetCoinSupplyCirculatingDcrAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}