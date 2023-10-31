using MiteSharp.Models.Mite;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using MiteSharp.Models.Requests;

namespace MiteSharp.Clients
{
    internal interface IMiteServiceClient
    {
        [Get("/services.json")]
        Task<IEnumerable<MiteServiceRootObject>> GetActiveServicesAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/services.json")]
        Task<IEnumerable<MiteServiceRootObject>> GetActiveServicesByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/services/archived.json")]
        Task<IEnumerable<MiteServiceRootObject>> GetArchivedServicesAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/services/archived.json")]
        Task<IEnumerable<MiteServiceRootObject>> GetArchivedServicesByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/services/{serviceId}.json")]
        Task<MiteServiceRootObject> GetServiceByIdAsync([Header("X-MiteApiKey")] string miteApiKey, int serviceId, CancellationToken ct);

        [Post("/services.json")]
        Task<MiteServiceRootObject> CreateServiceAsync([Header("X-MiteApiKey")] string miteApiKey, [Body] ServiceRequest serviceRequest, CancellationToken ct);

        [Patch("/services/{serviceId}.json")]
        Task UpdateServiceAsync([Header("X-MiteApiKey")] string miteApiKey, int serviceId, [Body] ServiceRequest serviceRequest, CancellationToken ct);

        [Delete("/services/{serviceId}.json")]
        Task DeleteServiceAsync([Header("X-MiteApiKey")] string miteApiKey, int serviceId, CancellationToken ct);
    }
}
