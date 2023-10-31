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
    ///     Service for interacting with Mite services
    /// </summary>
    public sealed class MiteServiceService : BaseMiteService, IMiteServiceService
    {
        private readonly IMiteServiceClient _miteServiceClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteServiceService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteServiceService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteServiceClient = RestService.For<IMiteServiceClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Service>>> GetAllActiveAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteServiceRootObject> response = await _miteServiceClient.GetActiveServicesAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Service>>(response?.Select(x => x.Service));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Service>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteServiceRootObject> response = await _miteServiceClient.GetActiveServicesByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Service>>(response?.Select(x => x.Service));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteServiceRootObject> response = await _miteServiceClient.GetArchivedServicesAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Service>>(response?.Select(x => x.Service));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteServiceRootObject> response = await _miteServiceClient.GetArchivedServicesByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Service>>(response?.Select(x => x.Service));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Service>> GetByIdAsync(int serviceId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteServiceRootObject response = await _miteServiceClient.GetServiceByIdAsync(MiteApiKey, serviceId, ct).ConfigureAwait(false);
                return new MiteResponse<Service>(response?.Service);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Service>> CreateAsync(ServiceRequest serviceRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteServiceRootObject response = await _miteServiceClient.CreateServiceAsync(MiteApiKey, serviceRequest, ct).ConfigureAwait(false);
                return new MiteResponse<Service>(response?.Service);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Service>> UpdateAsync(int serviceId, ServiceRequest serviceRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteServiceClient.UpdateServiceAsync(MiteApiKey, serviceId, serviceRequest, ct).ConfigureAwait(false);
                return await GetByIdAsync(serviceId).ConfigureAwait(false);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<bool>> DeleteAsync(int serviceId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteServiceClient.DeleteServiceAsync(MiteApiKey, serviceId, ct).ConfigureAwait(false);
                return new MiteResponse<bool>(true);
            });
        }
    }
}
