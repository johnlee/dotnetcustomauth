using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Primitives;

namespace AuthAndAuth.Auth
{
    public class CustomAuthNOptions : AuthenticationSchemeOptions
    {
        public const string DefaultScheme = "CustomAuth";
        public string Scheme => DefaultScheme;
        public StringValues AuthKey { get; set; }
    }
}