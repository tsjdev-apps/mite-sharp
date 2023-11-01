using MiteSharp.Models.Mite;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp.Clients
{
    /// <summary>
    /// Interface for Mite Tracker Client
    /// </summary>
    internal interface IMiteTrackerClient
    {
        /// <summary>
        /// Gets the tracker asynchronously
        /// </summary>
        /// <param name="miteApiKey">The Mite API key</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Tracker Root Object</returns>
        [Get("/tracker.json")]
        Task<MiteTrackerRootObject> GetTrackerAsync([Header("X-MiteApiKey")] string miteApiKey, CancellationToken ct);

        /// <summary>
        /// Starts the tracker asynchronously
        /// </summary>
        /// <param name="miteApiKey">The Mite API key</param>
        /// <param name="timeEntryId">The time entry ID</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Tracker Root Object</returns>
        [Patch("/tracker/{timeEntryId}.json")]
        Task<MiteTrackerRootObject> StartTrackerAsync([Header("X-MiteApiKey")] string miteApiKey, int timeEntryId, CancellationToken ct);

        /// <summary>
        /// Stops the tracker asynchronously
        /// </summary>
        /// <param name="miteApiKey">The Mite API key</param>
        /// <param name="timeEntryId">The time entry ID</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Tracker Root Object</returns>
        [Delete("/tracker/{timeEntryId}.json")]
        Task<MiteTrackerRootObject> StopTrackerAsync([Header("X-MiteApiKey")] string miteApiKey, int timeEntryId, CancellationToken ct);
    }
}
