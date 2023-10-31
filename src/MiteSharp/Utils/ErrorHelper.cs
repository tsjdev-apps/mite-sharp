using MiteSharp.Models.Mite;
using System.Text.Json;

namespace MiteSharp.Utils
{
    /// <summary>
    ///     Provides helper methods for handling errors returned by the Mite API
    /// </summary>
    internal static class ErrorHelper
    {
        /// <summary>
        ///     Gets the error message from the API error response
        /// </summary>
        /// <param name="apiError">The API error response</param>
        /// <returns>The error message</returns>
        public static string GetErrorMessage(string apiError)
        {
            if (string.IsNullOrEmpty(apiError))
            {
                return "Unknown error";
            }

            try
            {
                MiteError miteError = JsonSerializer.Deserialize<MiteError>(apiError);
                return miteError.Error;
            }
            catch
            {
                return "Unknown error";
            }
        }
    }
}
