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
    ///     Service for interacting with Mite projects
    /// </summary>
    public sealed class MiteProjectService : BaseMiteService, IMiteProjectService
    {
        private readonly IMiteProjectClient _miteProjectClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteProjectService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteProjectService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteProjectClient = RestService.For<IMiteProjectClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllActiveAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetActiveProjectsAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetActiveProjectsByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllActiveByCustomerIdsAsync(IEnumerable<int> customerIds, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetActiveProjectsByCustomerIdAsync(MiteApiKey, string.Join(",", customerIds), ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetArchivedProjectsAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetArchivedProjectsByNameAsync(MiteApiKey, name, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedByCustomerIdsAsync(IEnumerable<int> projectIds, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteProjectRootObject> response = await _miteProjectClient.GetArchivedProjectsByCustomerIdAsync(MiteApiKey, string.Join(",", projectIds), ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Project>>(response?.Select(x => x.Project));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Project>> GetByIdAsync(int projectId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteProjectRootObject response = await _miteProjectClient.GetProjectByIdAsync(MiteApiKey, projectId, ct).ConfigureAwait(false);
                return new MiteResponse<Project>(response?.Project);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Project>> CreateAsync(ProjectRequest projectRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteProjectRootObject response = await _miteProjectClient.CreateProjectAsync(MiteApiKey, projectRequest, ct).ConfigureAwait(false);
                return new MiteResponse<Project>(response?.Project);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Project>> UpdateAsync(int projectId, ProjectRequest projectRequest, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteProjectClient.UpdateProjectAsync(MiteApiKey, projectId, projectRequest, ct).ConfigureAwait(false);
                return await GetByIdAsync(projectId).ConfigureAwait(false);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<bool>> DeleteAsync(int projectId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                await _miteProjectClient.DeleteProjectAsync(MiteApiKey, projectId, ct).ConfigureAwait(false);
                return new MiteResponse<bool>(true);
            });
        }
    }
}
