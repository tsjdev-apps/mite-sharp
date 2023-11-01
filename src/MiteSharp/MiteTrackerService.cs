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
    ///     Service for interacting with Mite trackers
    /// </summary>
    public class MiteTrackerService : BaseMiteService, IMiteTrackerService
    {
        private readonly IMiteTrackerClient _miteTrackerClient;


        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteTrackerService"/> class.
        /// </summary>
        /// <param name="host">The Mite host name</param>
        /// <param name="miteApiKey">The Mite API key</param>
        public MiteTrackerService(string host, string miteApiKey) : base(miteApiKey)
        {
            _miteTrackerClient = RestService.For<IMiteTrackerClient>($"https://{host}.mite.de", new RefitSettings { ContentSerializer = new SystemTextJsonContentSerializer(new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault }) });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<Tracker>> StartTrackerAsync(int timeEntryId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteTrackerRootObject response = await _miteTrackerClient.StartTrackerAsync(MiteApiKey, timeEntryId, ct).ConfigureAwait(false);
                return new MiteResponse<Tracker>(response?.Tracker);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<TrackingTimeEntry>> GetTrackerAsync(CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteTrackerRootObject response = await _miteTrackerClient.GetTrackerAsync(MiteApiKey, ct).ConfigureAwait(false);
                return new MiteResponse<TrackingTimeEntry>(response?.Tracker?.TrackingTimeEntry);
            });
        }

        /// <inheritdoc/>
        public async Task<MiteResponse<StoppedTimeEntry>> StopTrackerAsync(int timeEntryId, CancellationToken ct = default)
        {
            return await ExecuteRequestAsync(async () =>
            {
                MiteTrackerRootObject response = await _miteTrackerClient.StopTrackerAsync(MiteApiKey, timeEntryId, ct).ConfigureAwait(false);
                return new MiteResponse<StoppedTimeEntry>(response?.Tracker?.StoppedTimeEntry);
            });
        }
    }
}
