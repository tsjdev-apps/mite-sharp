using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents a Mite error response
    /// </summary>
    internal class MiteError
    {
        /// <summary>
        ///     The error message returned by the API
        /// </summary>
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}
