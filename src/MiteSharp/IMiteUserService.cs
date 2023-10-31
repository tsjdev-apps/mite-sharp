using MiteSharp.Models;
using MiteSharp.Models.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite User Service
    /// </summary>
    public interface IMiteUserService
    {
        /// <summary>
        ///     Gets all active users asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active users</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllActiveAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all active users with a specific email asynchronously
        /// </summary>
        /// <param name="email">The email to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active users with the specified email</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllActiveByEmailAsync(string email, CancellationToken ct = default);

        /// <summary>
        ///     Gets all active users with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active users with the specified name</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived users asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived users</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllArchivedAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived users with a specific email asynchronously
        /// </summary>
        /// <param name="email">The email to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived users with the specified email</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByEmailAsync(string email, CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived users with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived users with the specified name</returns>
        Task<MiteResponse<IEnumerable<User>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets a user by ID asynchronously
        /// </summary>
        /// <param name="userId">The ID of the user to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the requested user</returns>
        Task<MiteResponse<User>> GetByIdAsync(int userId, CancellationToken ct = default);

        /// <summary>
        ///     Gets the current user asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the current user</returns>
        Task<MiteResponse<User>> GetCurrentUserAsync(CancellationToken ct = default);
    }
}