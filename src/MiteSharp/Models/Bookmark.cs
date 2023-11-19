using System;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite Bookmark
    /// </summary>
    public class Bookmark
    {
        /// <summary>
        ///     The associated ID of the account 
        /// </summary>
        [JsonPropertyName("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        ///     The date and time the bookmark was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The ID of the bookmark
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The name of the bookmark
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The date and time the bookmark was last updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     The associated ID of the user
        /// </summary>
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        /// <summary>
        ///     The query of the bookmark
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }

        /// <summary>
        ///     The type of the bookmark
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
