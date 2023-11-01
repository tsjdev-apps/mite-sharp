using System;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a tracking time entry in Mite
    /// </summary>
    public class TrackingTimeEntry
    {
        /// <summary>
        ///     The ID of the time entry
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The number of minutes for the stopped time entry
        /// </summary>
        [JsonPropertyName("minutes")]
        public int Minutes { get; set; }

        /// <summary>
        ///     Indicates the date and time since the tracker is running
        /// </summary>
        [JsonPropertyName("since")]
        public DateTime Since { get; set; }
    }

}
