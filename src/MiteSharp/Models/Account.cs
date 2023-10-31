using System;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite Account
    /// </summary>
    public class Account
    {
        /// <summary>
        ///     The date and time the account was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The currency used by the account
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        ///     The ID of the account
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The name of the account
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The title of the account
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        ///     The date and time the account was last updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
