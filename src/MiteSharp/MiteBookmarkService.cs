using MiteSharp.Clients;
using MiteSharp.Models;
using MiteSharp.Models.Mite;
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
    internal class MiteBookmarkService : BaseMiteService, IMiteBookmarkService
    {
        private readonly IMiteBookmarkClient _miteBookmarkClient;


        /// <summary>
        ///     Initialize a new instance of the <see cref="MiteBookmarkService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteBookmarkService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteBookmarkClient = RestService.For<IMiteBookmarkClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc/>
        public async Task<MiteResponse<IEnumerable<Bookmark>>> GetAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                IEnumerable<MiteBookmarkRootObject> response = await _miteBookmarkClient.GetBookmarksAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<IEnumerable<Bookmark>>(response?.Select(x => x.Bookmark));
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Bookmark>> GetById(int bookmarkId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteBookmarkRootObject response = await _miteBookmarkClient.GetBookmarkByIdAsync(MiteApiKey, bookmarkId, ct).ConfigureAwait(false);
                return new MiteResponse<Bookmark>(response?.Bookmark);
            });
        }
    }
}
