using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a stopped time entry in Mite
    /// </summary>
    public class StoppedTimeEntry
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
    }
}
