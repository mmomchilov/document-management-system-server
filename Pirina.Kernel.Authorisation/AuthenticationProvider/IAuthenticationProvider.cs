﻿using System.Threading.Tasks;

namespace Pirina.Kernel.Authorisation.AuthenticationProvider
{
    public interface IAuthenticationProvider<TContext>
    {
        Task Authenticated(TContext context);

        Task ReturnEndpoint(TContext context);

        void ApplyRedirect(TContext context);
    }
}