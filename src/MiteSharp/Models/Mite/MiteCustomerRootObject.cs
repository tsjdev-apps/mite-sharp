using System.Text.Json.Serialization;

namespace MiteSharp.Models.Mite
{
    /// <summary>
    ///     Represents the root object of a Mite customer response
    /// </summary>
    internal class MiteCustomerRootObject
    {
        /// <summary>
        ///     The customer object returned by the API
        /// </summary>
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }
    }
}
