using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite project response
    /// </summary>
    internal class MiteProjectRootObject
    {
        /// <summary>
        ///     The project object returned by the API
        /// </summary>
        [JsonPropertyName("project")]
        public Project Project { get; set; }
    }
}
