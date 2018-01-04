using System.Threading.Tasks;

namespace Stormancer.Server.Steam
{
    public class SteamUserTicketAuthenticator : ISteamUserTicketAuthenticator
    {
        private readonly ISteamService _steamService;

        public SteamUserTicketAuthenticator(ISteamService steamService)
        {
            _steamService = steamService;
        }

        public Task<ulong?> AuthenticateUserTicket(string ticket)
        {
            return _steamService.AuthenticateUserTicket(ticket);
        }
    }
}
