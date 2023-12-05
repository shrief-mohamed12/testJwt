namespace JwtApi.Helpers
{
    public class Jwt
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Vudience { get; set; }
        public double DurationInDays { get; set; }
    
    }
}
