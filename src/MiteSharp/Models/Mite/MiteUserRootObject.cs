using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite user response
    /// </summary>
    internal class MiteUserRootObject
    {
        /// <summary>
        ///     The user object returned by the API
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}
