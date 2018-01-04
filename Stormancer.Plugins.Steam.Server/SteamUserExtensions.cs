using Stormancer.Server.Users;

namespace Stormancer
{
    public static class SteamUserExtensions
    {
        public static ulong? GetSteamId(this User user)
        {
            var steamId = user.UserData["steamid"].ToObject<string>();
            if (steamId == null)
            {
                return null;
            }
            else
            {
                return ulong.Parse(steamId);
            }
        }
    }
}
