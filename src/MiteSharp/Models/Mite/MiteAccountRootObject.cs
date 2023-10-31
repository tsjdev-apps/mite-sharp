using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite account response
    /// </summary>
    internal class MiteAccountRootObject
    {
        /// <summary>
        ///     The account object returned by the API
        /// </summary>
        [JsonPropertyName("account")]
        public Account Account { get; set; }
    }
}
