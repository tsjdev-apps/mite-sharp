using System.Text.Json.Serialization;

namespace MiteSharp.Models.Requests
{
    /// <summary>
    ///     Represents a request to create or update a Mite service
    /// </summary>
    public class ServiceRequest
    {
        /// <summary>
        ///     The name of the service
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The note of the service
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        ///     The hourly rate for the service
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int? HourlyRate { get; set; }

        /// <summary>
        ///     Indicates whether the service is billable
        /// </summary>
        [JsonPropertyName("billable")]
        public bool Billable { get; set; }

        /// <summary>
        ///     Indicates whether the service is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    }
}
