using MiteSharp.Models;
using MiteSharp.Models.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace MiteSharp
{
    /// <summary>
    ///     Interface for Mite Account Service
    /// </summary>
    public interface IMiteAccountService
    {
        /// <summary>
        ///     Gets the account information
        /// </summary>
        /// <param name="ct">Cancellation token</param>
        /// <returns>Mite response with account information</returns>
        Task<MiteResponse<Account>> GetAccountAsync(CancellationToken ct = default);
    }
}