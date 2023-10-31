using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MiteSharp.Models.Requests
{
    /// <summary>
    ///     Represents a request to create or update a Mite project
    /// </summary>
    public class ProjectRequest
    {
        /// <summary>
        ///     The name of the project
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The note of the project
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        ///     The ID of the customer associated with the project
        /// </summary>
        [JsonPropertyName("customer_id")]
        public int? CustomerId { get; set; }

        /// <summary>
        ///     The budget of the project
        /// </summary>
        [JsonPropertyName("budget")]
        public int Budget { get; set; }

        /// <summary>
        ///     The type of budget for the project
        /// </summary>
        [JsonPropertyName("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        ///     The active hourly rate for the project
        /// </summary>
        [JsonPropertyName("active_hourly_rate")]
        public string ActiveHourlyRate { get; set; }

        /// <summary>
        ///     The hourly rate for the project
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int HourlyRate { get; set; }

        /// <summary>
        ///     The hourly rates per service for the project
        /// </summary>
        [JsonPropertyName("hourly_rates_per_service")]
        public IEnumerable<HourlyRates> HourlyRatesPerService { get; set; }

        /// <summary>
        ///     Indicates whether the project is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }
    }
}
