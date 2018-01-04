using System.Threading.Tasks;

namespace Stormancer.Server.Steam
{
    public class SteamUserTicketAuthenticatorMockup : ISteamUserTicketAuthenticator
    {
        public Task<ulong?> AuthenticateUserTicket(string ticket)
        {
            if(ticket  == "invalid")
            {
                return Task.FromResult<ulong?>(null);
            }
            else
            {
                return Task.FromResult<ulong?>((ulong)(ticket.GetHashCode()));
            }
        }
    }
}
