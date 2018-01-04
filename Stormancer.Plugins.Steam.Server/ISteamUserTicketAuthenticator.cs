using System.Threading.Tasks;

namespace Stormancer.Server.Steam
{
    public interface ISteamUserTicketAuthenticator
    {
        Task<ulong?> AuthenticateUserTicket(string ticket);
    }
}