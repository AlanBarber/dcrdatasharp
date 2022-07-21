using DcrDataSharp.Interfaces.Clients.Api;

namespace DcrDataSharp.Interfaces.Clients
{
    /// <summary>
    /// Client for accessing the DcrData REST API
    /// </summary>
    public interface IDcrDataClient
    {
        /// <summary>
        /// Address API endpoints
        /// </summary>
        public IAddressApi Address { get; set; }

        /// <summary>
        /// Agenda API endpoints
        /// </summary>
        public IAgendaApi Agenda { get; set; }

        /// <summary>
        /// Block API endpoints
        /// </summary>
        public IBlockApi Block { get; set; }

        /// <summary>
        /// Chart API endpoints
        /// </summary>
        public IChartApi Chart { get; set; }

        /// <summary>
        /// Exchange Rate API endpoints
        /// </summary>
        public IExchangeRateApi ExchangeRate { get; set; }

        /// <summary>
        /// Exchanges API endpoints
        /// </summary>
        public IExchangesApi Exchanges { get; set; }

        /// <summary>
        /// MemPool API endpoints
        /// </summary>
        public IMemPoolApi MemPool { get; set; }

        /// <summary>
        /// Proposal API endpoints
        /// </summary>
        public IProposalApi Proposal { get; set; }

        /// <summary>
        /// Stake API endpoints
        /// </summary>
        public IStakeApi Stake { get; set; }

        /// <summary>
        /// Status API endpoints
        /// </summary>
        public IStatusApi Status { get; set; }

        /// <summary>
        /// Supply API endpoints
        /// </summary>
        public ISupplyApi Supply { get; set; }

        /// <summary>
        /// TicketPool API endpoints
        /// </summary>
        public ITicketPoolApi TicketPool { get; set; }

        /// <summary>
        /// Transaction API endpoints
        /// </summary>
        public ITransactionApi Transaction { get; set; }

        /// <summary>
        /// Treasury API endpoints
        /// </summary>
        public ITreasuryApi Treasury { get; set; }
    }
}
