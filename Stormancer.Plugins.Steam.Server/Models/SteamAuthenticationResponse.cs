namespace Stormancer.Server.Steam.Models
{
    public class SteamAuthenticationResponse
    {
        public InnerResponse response { get; set; } 
    }

    public class InnerResponse
    {
        public ErrorResponse error { get; set; }
        public ParamsResponse @params {get; set;}
    }

    public class ParamsResponse
    {
        public string result { get; set; }
        public ulong steamid { get; set; }
        public ulong ownersteamid { get; set; }
        public bool vacbanned { get; set; }
        public bool publisherbanned { get; set; }
    }

    public class ErrorResponse
    {
        public int errorcode { get; set; }
        public string errordesc { get; set; }
    }
}
