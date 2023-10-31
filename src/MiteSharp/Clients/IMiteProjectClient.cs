using MiteSharp.Models.Mite;
using MiteSharp.Models.Requests;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    internal interface IMiteProjectClient
    {
        [Get("/projects.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetActiveProjectsAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/projects.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetActiveProjectsByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/projects.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetActiveProjectsByCustomerIdAsync([Header("X-MiteApiKey")] string miteApiKey, [AliasAs("customer_id")] string customerId, CancellationToken ct);

        [Get("/projects/archived.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetArchivedProjectsAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/projects/archived.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetArchivedProjectsByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/projects/archived.json")]
        Task<IEnumerable<MiteProjectRootObject>> GetArchivedProjectsByCustomerIdAsync([Header("X-MiteApiKey")] string miteApiKey, [AliasAs("customer_id")] string customerId, CancellationToken ct);

        [Get("/projects/{projectId}.json")]
        Task<MiteProjectRootObject> GetProjectByIdAsync([Header("X-MiteApiKey")] string miteApiKey, int projectId, CancellationToken ct);

        [Post("/projects.json")]
        Task<MiteProjectRootObject> CreateProjectAsync([Header("X-MiteApiKey")] string miteApiKey, [Body] ProjectRequest projectRequest, CancellationToken ct);

        [Patch("/projects/{projectId}.json")]
        Task UpdateProjectAsync([Header("X-MiteApiKey")] string miteApiKey, int projectId, [Body] ProjectRequest projectRequest, CancellationToken ct);

        [Delete("/projects/{projectId}.json")]
        Task DeleteProjectAsync([Header("X-MiteApiKey")] string miteApiKey, int projectId, CancellationToken ct);
    }
}
