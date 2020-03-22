using System;

namespace Pirina.Kernel.Web.Authorisation
{
    public class TokenDescriptor
    {
        private readonly uint _expireIn;
        public TokenDescriptor(string tokenType, string token, DateTimeOffset issuedAt, uint expireIn)
        {
            if (String.IsNullOrWhiteSpace(tokenType))
                throw new ArgumentNullException(nameof(tokenType));
            if (String.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token));
            if (issuedAt > DateTimeOffset.Now)
                throw new InvalidOperationException("Issued time in the future.");

            this.TokenType = tokenType;
            this.Token = token;
            this._expireIn = expireIn;
            this.IssuedAt = issuedAt;
        }

        public DateTimeOffset IssuedAt { get; private set; }

        public DateTimeOffset ExpireOn
        {
            get
            {
                return this.IssuedAt.AddSeconds(this._expireIn);
            }
        }

        public string Token { get; private set; }

        public string TokenType { get; private set; }
    }
}