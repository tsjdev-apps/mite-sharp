using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MiteSharp.Models.Requests
{
    /// <summary>
    ///     Represents a request to create or update a Mite customer
    /// </summary>
    public class CustomerRequest
    {
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
        ///     The active hourly rate for the customer
        /// </summary>
        [JsonPropertyName("active_hourly_rate")]
        public string ActiveHourlyRate { get; set; }

        /// <summary>
        ///     The hourly rate for the customer
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int HourlyRate { get; set; }

        /// <summary>
        ///     The hourly rates per service for the customer
        /// </summary>
        [JsonPropertyName("hourly_rates_per_service")]
        public IEnumerable<HourlyRates> HourlyRatesPerService { get; set; }

        /// <summary>
        ///     Indicates whether the customer is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    }
}
