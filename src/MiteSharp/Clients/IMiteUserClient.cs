using MiteSharp.Models.Mite;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    internal interface IMiteUserClient
    {
        [Get("/myself.json")]
        Task<MiteUserRootObject> GetCurrentUserAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/users.json")]
        Task<IEnumerable<MiteUserRootObject>> GetActiveUsersAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/users.json")]
        Task<IEnumerable<MiteUserRootObject>> GetActiveUsersByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/users.json")]
        Task<IEnumerable<MiteUserRootObject>> GetActiveUsersByEmailAsync([Header("X-MiteApiKey")] string miteApiKey, string email, CancellationToken ct);

        [Get("/users/archived.json")]
        Task<IEnumerable<MiteUserRootObject>> GetArchivedUsersAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/users/archived.json")]
        Task<IEnumerable<MiteUserRootObject>> GetArchivedUsersByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/users/archived.json")]
        Task<IEnumerable<MiteUserRootObject>> GetArchivedUsersByEmailAsync([Header("X-MiteApiKey")] string miteApiKey, string email, CancellationToken ct);


        [Get("/users/{userId}.json")]
        Task<MiteUserRootObject> GetUserByIdAsync([Header("X-MiteApiKey")] string miteApiKey, int userId, CancellationToken ct);
    }
}
