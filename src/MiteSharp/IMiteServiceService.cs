using MiteSharp.Models;
using MiteSharp.Models.Requests;
using MiteSharp.Models.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    /// Interface for Mite Service Service
    /// </summary>
    public interface IMiteServiceService
    {
        /// <summary>
        ///     Creates a new service asynchronously
        /// </summary>
        /// <param name="serviceRequest">The service request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the created service</returns>
        Task<MiteResponse<Service>> CreateAsync(ServiceRequest serviceRequest, CancellationToken ct = default);

        /// <summary>
        ///     Deletes a service asynchronously
        /// </summary>
        /// <param name="serviceId">The ID of the service to delete</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a boolean indicating success or failure</returns>
        Task<MiteResponse<bool>> DeleteAsync(int serviceId, CancellationToken ct = default);

        /// <summary>
        ///     Gets all active services asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active services</returns>
        Task<MiteResponse<IEnumerable<Service>>> GetAllActiveAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all active services with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active services with the specified name</returns>
        Task<MiteResponse<IEnumerable<Service>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived services asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived services</returns>
        Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived services with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived services with the specified name</returns>
        Task<MiteResponse<IEnumerable<Service>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets a service by ID asynchronously
        /// </summary>
        /// <param name="serviceId">The ID of the service to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the requested service</returns>
        Task<MiteResponse<Service>> GetByIdAsync(int serviceId, CancellationToken ct = default);

        /// <summary>
        ///     Updates a service asynchronously
        /// </summary>
        /// <param name="serviceId">The ID of the service to update</param>
        /// <param name="serviceRequest">The service request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the updated service</returns>
        Task<MiteResponse<Service>> UpdateAsync(int serviceId, ServiceRequest serviceRequest, CancellationToken ct = default);
    }
}