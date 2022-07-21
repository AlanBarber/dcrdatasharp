using DcrDataSharp.Clients.Api;
using DcrDataSharp.Interfaces.Clients;
using DcrDataSharp.Interfaces.Clients.Api;

namespace DcrDataSharp.Clients
{
    /// <inheritdoc />
    public class DcrDataClient : IDcrDataClient
    {
        #region Fields

        private readonly DcrDataClientOptions _options;

        #endregion

        #region Api clients

        /// <inheritdoc />
        public IAddressApi Address { get; set; }
        /// <inheritdoc />
        public IAgendaApi Agenda { get; set; }
        /// <inheritdoc />
        public IBlockApi Block { get; set; }
        /// <inheritdoc />
        public IChartApi Chart { get; set; }
        /// <inheritdoc />
        public IEndPointListApi EndPointList { get; set; }
        /// <inheritdoc />
        public IExchangeRateApi ExchangeRate { get; set; }
        /// <inheritdoc />
        public IExchangesApi Exchanges { get; set; }
        /// <inheritdoc />
        public IMemPoolApi MemPool { get; set; }
        /// <inheritdoc />
        public IProposalApi Proposal { get; set; }
        /// <inheritdoc />
        public IStakeApi Stake { get; set; }
        /// <inheritdoc />
        public IStatusApi Status { get; set; }
        /// <inheritdoc />
        public ISupplyApi Supply { get; set; }
        /// <inheritdoc />
        public ITicketPoolApi TicketPool { get; set; }
        /// <inheritdoc />
        public ITreasuryApi Treasury { get; set; }
        /// <inheritdoc />
        public ITransactionApi Transaction { get; set; }

        #endregion

        #region constructor/destructor

        /// <summary>
        /// Create a new instance of DcrDataClient using the default options
        /// </summary>
        public DcrDataClient() : this(DcrDataClientOptions.Default)
        {
        }

        /// <summary>
        /// Create a new instance of DcrDataClient using provided options
        /// </summary>
        /// <param name="options">The options to use for this client</param>
        public DcrDataClient(DcrDataClientOptions options)
        {
            // create default rest client for the api clients to use
            var restClient = new RestSharp.RestClient(options.BaseUrl);

            this._options = options;
            this.Address = new AddressApi(restClient);
            this.Agenda = new AgendaApi(restClient);
            this.Block = new Api.BlockApi(restClient);
            this.Chart = new ChartApi(restClient);
            this.EndPointList = new EndPointApi(restClient);
            this.ExchangeRate = new ExchangeRateApi(restClient);
            this.Exchanges = new ExchangesApi(restClient);
            this.MemPool = new MemPoolApi(restClient);
            this.Proposal = new ProposalApi(restClient);
            this.Stake = new StakeApi(restClient);
            this.Status = new StatusApi(restClient);
            this.Supply = new SupplyApi(restClient);
            this.TicketPool = new TicketPoolApi(restClient);
            this.Treasury = new TreasuryApi(restClient);
            this.Transaction = new TransactionApi(restClient);
        }

        #endregion

    }
}
