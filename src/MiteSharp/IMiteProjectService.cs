using MiteSharp.Models;
using MiteSharp.Models.Requests;
using MiteSharp.Models.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite Project Service
    /// </summary>
    public interface IMiteProjectService
    {
        /// <summary>
        ///     Creates a new project asynchronously
        /// </summary>
        /// <param name="projectRequest">The project request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the created project</returns>
        Task<MiteResponse<Project>> CreateAsync(ProjectRequest projectRequest, CancellationToken ct = default);

        /// <summary>
        ///     Deletes a project asynchronously
        /// </summary>
        /// <param name="projectId">The ID of the project to delete</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a boolean indicating success or failure</returns>
        Task<MiteResponse<bool>> DeleteAsync(int projectId, CancellationToken ct = default);

        /// <summary>
        ///     Gets all active projects asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active projects</returns>
        Task<MiteResponse<IEnumerable<Project>>> GetAllActiveAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all active projects with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of active projects with the specified name</returns>
        Task<MiteResponse<IEnumerable<Project>>> GetAllActiveByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived projects asynchronously
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived projects</returns>
        Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedAsync(CancellationToken ct = default);

        /// <summary>
        ///     Gets all archived projects with a specific name asynchronously
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with a list of archived projects with the specified name</returns>
        Task<MiteResponse<IEnumerable<Project>>> GetAllArchivedByNameAsync(string name, CancellationToken ct = default);

        /// <summary>
        ///     Gets a project by ID asynchronously
        /// </summary>
        /// <param name="projectId">The ID of the project to get</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the requested project</returns>
        Task<MiteResponse<Project>> GetByIdAsync(int projectId, CancellationToken ct = default);

        /// <summary>
        ///     Updates a project asynchronously
        /// </summary>
        /// <param name="projectId">The ID of the project to update</param>
        /// <param name="projectRequest">The project request object</param>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with the updated project</returns>
        Task<MiteResponse<Project>> UpdateAsync(int projectId, ProjectRequest projectRequest, CancellationToken ct = default);
    }
}