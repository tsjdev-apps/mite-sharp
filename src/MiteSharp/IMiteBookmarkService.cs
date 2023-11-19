using MiteSharp.Models;
using MiteSharp.Models.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite Bookmark Service
    /// </summary>
    internal interface IMiteBookmarkService
    {
        /// <summary>
        ///     Gets all bookmarks asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of bookmarks</returns>
        Task<MiteResponse<IEnumerable<Bookmark>>> GetAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets a bookmark by ID asyncrhonously
        /// </summary>
        /// <param name="bookmarkId">The ID of the bookmark to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the requested bookmark</returns>
        Task<MiteResponse<Bookmark>> GetById(int bookmarkId, CancellationToken ct = default);
    }
}