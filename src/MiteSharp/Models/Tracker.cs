using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite Tracker object
    /// </summary>
    public class Tracker
    {
        /// <summary>
        ///     Gets or sets the tracking time entry
        /// </summary>
        [JsonPropertyName("tracking_time_entry")]
        public TrackingTimeEntry TrackingTimeEntry { get; set; }

        /// <summary>
        ///     Gets or sets the stopped time entry
        /// </summary>
        [JsonPropertyName("stopped_time_entry")]
        public StoppedTimeEntry StoppedTimeEntry { get; set; }
    }
}
