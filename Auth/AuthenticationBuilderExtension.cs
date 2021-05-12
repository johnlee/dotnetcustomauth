using System;
using Microsoft.AspNetCore.Authentication;

namespace AuthAndAuth.Auth
{
    public static class AuthenticationBuilderExtension
    {
        // Custom authentication extension method
        public static AuthenticationBuilder AddCustomAuthentication(this AuthenticationBuilder builder, Action<CustomAuthNOptions> configureOptions)
        {
            // Add custom authentication scheme with custom options and custom handler
            return builder.AddScheme<CustomAuthNOptions, CustomAuthNHandler>(CustomAuthNOptions.DefaultScheme, configureOptions);
        }
    }
}