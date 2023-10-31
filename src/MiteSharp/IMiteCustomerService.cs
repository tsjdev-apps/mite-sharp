using MiteSharp.Models;
using MiteSharp.Models.Requests;
using MiteSharp.Models.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite Customer Service
    /// </summary>
    public interface IMiteCustomerService
    {
        /// <summary>
        ///     Creates a new customer asynchronously
        /// </summary>
        /// <param name="customerRequest">The customer request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the created customer</returns>
        Task<MiteResponse<Customer>> CreateAsync(CustomerRequest customerRequest, CancellationToken ct = default);

        /// <summary>
        ///     Deletes a customer asynchronously
        /// </summary>
        /// <param name="customerId">The ID of the customer to delete</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a boolean indicating success or failure</returns>
        Task<MiteResponse<bool>> DeleteAsync(int customerId, CancellationToken ct = default);

        /// <summary>
        ///     Gets all active customers asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active customers</returns>
        Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all active customers with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active customers with the specified name</returns>
        Task<MiteResponse<IEnumerable<Customer>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived customers asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived customers</returns>
        Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived customers with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived customers with the specified name</returns>
        Task<MiteResponse<IEnumerable<Customer>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets a customer by ID asynchronously
        /// </summary>
        /// <param name="customerId">The ID of the customer to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the requested customer</returns>
        Task<MiteResponse<Customer>> GetByIdAsync(int customerId, CancellationToken ct = default);

        /// <summary>
        ///     Updates a customer asynchronously
        /// </summary>
        /// <param name="customerId">The ID of the customer to update</param>
        /// <param name="customerRequest">The customer request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the updated customer</returns>
        Task<MiteResponse<Customer>> UpdateAsync(int customerId, CustomerRequest customerRequest, CancellationToken ct = default);
    }
}