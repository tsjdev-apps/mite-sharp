using MiteSharp.Models.Responses;
using MiteSharp.Utils;
using Refit;
using System;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Base class for Mite services
    /// </summary>
    public abstract class BaseMiteService
    {
        public string MiteApiKey { get; }

        public BaseMiteService(string miteApiKey)
        {
            MiteApiKey = miteApiKey;
        }

        /// <summary>
        ///     Executes a Mite API request asynchronously
        /// </summary>
        /// <typeparam name="T">The type of the response object</typeparam>
        /// <param name="requestFunc">The function that returns the Mite API response</param>
        /// <returns>A MiteResponse object with the response data</returns>
        public async Task<MiteResponse<T>> ExecuteRequestAsync<T>(Func<Task<MiteResponse<T>>> requestFunc)
        {
            try
            {
                MiteResponse<T> response = await requestFunc().ConfigureAwait(false);
                return new MiteResponse<T>(response.Response);
            }
            catch (ApiException apiException)
            {
                string error = ErrorHelper.GetErrorMessage(apiException.Content);
                return new MiteResponse<T>(error, apiException.StatusCode);
            }
            catch (Exception ex)
            {
                return new MiteResponse<T>(ex.Message);
            }
        }
    }
}
