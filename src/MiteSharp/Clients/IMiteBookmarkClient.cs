using MiteSharp.Models.Mite;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    internal interface IMiteBookmarkClient
    {
        [Get("/time_entries/bookmarks.json")]
        Task<IEnumerable<MiteBookmarkRootObject>> GetBookmarksAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        [Get("/time_entries/bookmarks/{bookmarkId}.json")]
        Task<MiteBookmarkRootObject> GetBookmarkByIdAsync([Header("X-MiteApiKey")] string miteApiKey, int bookmarkId, CancellationToken ct);
    }
}
