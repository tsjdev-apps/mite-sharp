using MiteSharp.Models.Mite;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    internal interface IMiteAccountClient
    {
        [Get("/account.json")]
        Task<MiteAccountRootObject> GetAccountAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);
    }
}
