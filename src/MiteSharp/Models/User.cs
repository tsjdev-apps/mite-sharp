using System;
using System.Text.Json.Serialization;

namespace MiteSharp.Models
{
    /// <summary>
    ///     Represents a Mite User
    /// </summary>
    public class User
    {
        /// <summary>
        ///     The date and time the user was created
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     The email address of the user
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     The ID of the user
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        ///     The name of the user
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     The note of the user
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        ///     The date and time the user was last updated
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Indicates whether the user is archived
        /// </summary>
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        ///     The language of the user
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        ///     The role of the user
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
