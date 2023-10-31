using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite service response
    /// </summary>
    internal class MiteServiceRootObject
    {
        /// <summary>
        ///     The service object returned by the API
        /// </summary>
        [JsonPropertyName("service")]
        public Service Service { get; set; }
    }
}
