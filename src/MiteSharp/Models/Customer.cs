using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        ///     The date and time the customer was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The hourly rate of the customer
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int HourlyRate { get; set; }

        /// <summary>
        ///     The ID of the customer
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The name of the customer
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The note of the customer
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        ///     The date and time the customer was last updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Indicates whether the customer is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        ///     The active hourly rate of the customer
        /// </summary>
        [JsonPropertyName("active_hourly_rate")]
        public string ActiveHourlyRate { get; set; }

        /// <summary>
        ///     The hourly rates per service of the customer
        /// </summary>
        [JsonPropertyName("hourly_rates_per_service")]
        public IEnumerable<HourlyRates> HourlyRatesPerService { get; set; }
    }
}
