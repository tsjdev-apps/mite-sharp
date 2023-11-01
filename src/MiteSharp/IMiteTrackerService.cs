using MiteSharp.Models;
using MiteSharp.Models.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite Tracker Service
    /// </summary>
    public interface IMiteTrackerService
    {
        /// <summary>
        ///     Stops the tracker asynchronously
        /// </summary>
        /// <param name="timeEntryId">The time entry ID</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Response of Stopped Time Entry</returns>
        Task<MiteResponse<StoppedTimeEntry>> StopTrackerAsync(int timeEntryId, CancellationToken ct = default);

        /// <summary>
        ///     Gets the tracker asynchronously
        /// </summary>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Response of Tracking Time Entry</returns>
        Task<MiteResponse<TrackingTimeEntry>> GetTrackerAsync(CancellationToken ct = default);

        /// <summary>
        ///     Starts the tracker asynchronously
        /// </summary>
        /// <param name="timeEntryId">The time entry ID</param>
        /// <param name="ct">The cancellation token</param>
        /// <returns>The Mite Response of Tracker</returns>
        Task<MiteResponse<Tracker>> StartTrackerAsync(int timeEntryId, CancellationToken ct = default);
    }
}