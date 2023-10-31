using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents Hourly Rates
    /// </summary>
    public class HourlyRates
    {
        /// <summary>
        ///     The ID
        /// </summary>
        [JsonPropertyName("service_id")]
        public int ServiceId { get; set; }

        /// <summary>
        ///     The hourly rate
        /// </summary>
        [JsonPropertyName("hourly_rate")]
        public int HourlyRate { get; set; }
    }
}
