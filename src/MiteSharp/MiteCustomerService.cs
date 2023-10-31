using MiteSharp.Clients;
using MiteSharp.Models;
using MiteSharp.Models.Mite;
using MiteSharp.Models.Requests;
using MiteSharp.Models.Responses;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Service for interacting with Mite customers
    /// </summary>
    public sealed class MiteCustomerService : BaseMiteService, IMiteCustomerService
    {
        private readonly IMiteCustomerClient _miteCustomerClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteCustomerService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteCustomerService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteCustomerClient = RestService.For<IMiteCustomerClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteCustomerRootObject> response = await _miteCustomerClient.GetActiveCustomersAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Customer>>(response?.Select(x => x.Customer));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteCustomerRootObject> response = await _miteCustomerClient.GetActiveCustomersByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Customer>>(response?.Select(x => x.Customer));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteCustomerRootObject> response = await _miteCustomerClient.GetArchivedCustomersAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Customer>>(response?.Select(x => x.Customer));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteCustomerRootObject> response = await _miteCustomerClient.GetArchivedCustomersByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Customer>>(response?.Select(x => x.Customer));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Customer>> GetByIdAsync(int customerId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteCustomerRootObject response = await _miteCustomerClient.GetCustomerByIdAsync(MiteApiKey, customerId, ct).ConfigureAwait(false);
                return new MiteResponse<Customer>(response?.Customer);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Customer>> CreateAsync(CustomerRequest customerRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteCustomerRootObject response = await _miteCustomerClient.CreateCustomerAsync(MiteApiKey, customerRequest, ct).ConfigureAwait(false);
                return new MiteResponse<Customer>(response?.Customer);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Customer>> UpdateAsync(int customerId, CustomerRequest customerRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteCustomerClient.UpdateCustomerAsync(MiteApiKey, customerId, customerRequest, ct).ConfigureAwait(false);
                return await GetByIdAsync(customerId).ConfigureAwait(false);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<bool>> DeleteAsync(int customerId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteCustomerClient.DeleteCustomerAsync(MiteApiKey, customerId, ct).ConfigureAwait(false);
                return new MiteResponse<bool>(true);
            });
        }
    }
}
