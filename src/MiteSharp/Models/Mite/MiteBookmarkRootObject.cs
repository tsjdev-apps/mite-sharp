using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite bookmark response
    /// </summary>
    public class MiteBookmarkRootObject
    {
        /// <summary>
        ///     The bookmark object returned by the API
        /// </summary>
        [JsonPropertyName("bookmark")]
        public Bookmark Bookmark { get; set; }
    }
}
