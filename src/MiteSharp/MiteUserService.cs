using MiteSharp.Clients;
using MiteSharp.Models.Mite;
using MiteSharp.Models.Responses;
using MiteSharp.Models;
using Refit;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MiteSharp
{
    /// <summary>
    ///     Service for interacting with Mite users
    /// </summary>
    public sealed class MiteUserService : BaseMiteService, IMiteUserService
    {
        private readonly IMiteUserClient _miteUserClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteUserService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteUserService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteUserClient = RestService.For<IMiteUserClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc/>
        public async Task<MiteResponse<User>> GetCurrentUserAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteUserRootObject response = await _miteUserClient.GetCurrentUserAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<User>(response?.User);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllActiveAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetActiveUsersAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetActiveUsersByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllActiveByEmailAsync(string email, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetActiveUsersByEmailAsync(MiteApiKey, email, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllArchivedAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetArchivedUsersAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetArchivedUsersByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByEmailAsync(string email, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteUserRootObject> response = await _miteUserClient.GetArchivedUsersByEmailAsync(MiteApiKey, email, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<User>>(response?.Select(x => x.User));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<User>> GetByIdAsync(int userId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteUserRootObject response = await _miteUserClient.GetUserByIdAsync(MiteApiKey, userId, ct).ConfigureAwait(false);
                return new MiteResponse<User>(response?.User);
            });
        }
    }
}
