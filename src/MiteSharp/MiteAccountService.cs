using MiteSharp.Clients;
using MiteSharp.Models;
using MiteSharp.Models.Mite;
using MiteSharp.Models.Responses;
using Refit;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Service for interacting with Mite accounts
    /// </summary>
    public sealed class MiteAccountService : BaseMiteService, IMiteAccountService
    {
        private readonly IMiteAccountClient _miteAccountClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteAccountService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteAccountService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteAccountClient = RestService.For<IMiteAccountClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }


        /// <inheritdoc />
        public async Task<MiteResponse<Account>> GetAccountAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteAccountRootObject response = await _miteAccountClient.GetAccountAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<Account>(response?.Account);
            });
        }
    }
}
