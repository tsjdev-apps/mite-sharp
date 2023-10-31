using System;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite Service
    /// </summary>
    public class Service
    {
        /// <summary>
        ///     Indicates whether the service is billable
        /// </summary>
        [JsonPropertyName("billable")]
        public bool Billable { get; set; }

        /// <summary>
        ///     The date and time the service was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The hourly rate for the service
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int? HourlyRate { get; set; }

        /// <summary>
        ///     The ID of the service
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

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
        ///     The date and time the service was last updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Indicates whether the service is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    }

}
