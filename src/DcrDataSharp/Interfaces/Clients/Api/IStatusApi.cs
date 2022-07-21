using DcrDataSharp.Types;

namespace DcrDataSharp.Interfaces.Clients.Api
{
    /// <summary>
    /// DcrData Status API endpoints
    /// </summary>
    public interface IStatusApi
    {
        /// <summary>
        /// Gets status
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<APIStatus?> GetStatusAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets health
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns></returns>
        Task<Health?> GetHealthAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
