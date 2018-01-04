using Stormancer.Server.Steam.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stormancer.Server.Steam
{
    public interface ISteamService
    {
        Task<ulong?> AuthenticateUserTicket(string ticket);

        Task<Dictionary<ulong, SteamPlayerSummary>> GetPlayerSummaries(IEnumerable<ulong> steamIds);

        Task<SteamPlayerSummary> GetPlayerSummary(ulong steamId);

        Task<string> OpenVACSession(string steamId);
        Task CloseVACSession(string steamId, string sessionId);
        Task<bool> RequestVACStatusForUser(string steamId, string sessionId);

        
    }
}