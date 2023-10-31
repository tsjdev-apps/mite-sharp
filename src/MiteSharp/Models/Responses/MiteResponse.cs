using System.Net;

namespace MiteSharp.Models.Responses
{
    /// <summary>
    ///     Represents a response from the Mite API
    /// </summary>
    /// <typeparam name="T">The type of the response</typeparam>
    public class MiteResponse<T>
    {
        /// <summary>
        ///     Indicates whether the API request was successful
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        ///     The response from the API
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        ///     The HTTP status code of the API response
        /// </summary>
        public HttpStatusCode? StatusCode { get; set; }

        /// <summary>
        ///     The error message returned by the API, if any
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteResponse{T}"/> class with a successful response
        /// </summary>
        /// <param name="response">The response from the API</param>
        public MiteResponse(T response)
        {
            IsSuccess = true;
            Response = response;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="MiteResponse{T}"/> class with an error response
        /// </summary>
        /// <param name="error">The error message returned by the API</param>
        /// <param name="httpStatusCode">The HTTP status code of the API response</param>
        public MiteResponse(string error, HttpStatusCode? httpStatusCode = null)
        {
            IsSuccess = false;
            Error = error;
            StatusCode = httpStatusCode;
        }
    }
}
