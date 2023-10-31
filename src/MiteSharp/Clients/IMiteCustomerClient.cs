using MiteSharp.Models.Mite;
using MiteSharp.Models.Requests;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    internal interface IMiteCustomerClient
    {
        [Get("/customers.json")]
        Task<IEnumerable<MiteCustomerRootObject>> GetActiveCustomersAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/customers.json")]
        Task<IEnumerable<MiteCustomerRootObject>> GetActiveCustomersByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/customers/archived.json")]
        Task<IEnumerable<MiteCustomerRootObject>> GetArchivedCustomersAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/customers/archived.json")]
        Task<IEnumerable<MiteCustomerRootObject>> GetArchivedCustomersByNameAsync([Header("X-MiteApiKey")] string miteApiKey, string name, CancellationToken ct);

        [Get("/customers/{customerId}.json")]
        Task<MiteCustomerRootObject> GetCustomerByIdAsync([Header("X-MiteApiKey")] string miteApiKey, int customerId, CancellationToken ct);

        [Post("/customers.json")]
        Task<MiteCustomerRootObject> CreateCustomerAsync([Header("X-MiteApiKey")] string miteApiKey, [Body] CustomerRequest customerRequest, CancellationToken ct);

        [Patch("/customers/{customerId}.json")]
        Task UpdateCustomerAsync([Header("X-MiteApiKey")] string miteApiKey, int customerId, [Body] CustomerRequest customerRequest, CancellationToken ct);

        [Delete("/customers/{customerId}.json")]
        Task DeleteCustomerAsync([Header("X-MiteApiKey")] string miteApiKey, int customerId, CancellationToken ct);
    }
}
