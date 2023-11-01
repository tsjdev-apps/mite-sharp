using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite tracker response
    /// </summary>
    public class MiteTrackerRootObject
    {
        /// <summary>
        ///     The tracker object returned by the API
        /// </summary>
        [JsonPropertyName("tracker")]
        public Tracker Tracker { get; set; }
    }

}
