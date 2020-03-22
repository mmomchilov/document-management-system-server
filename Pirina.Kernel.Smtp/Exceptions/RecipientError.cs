﻿using Pirina.Kernel.Mime;

namespace Pirina.Kernel.Smtp.Exceptions
{
    public class RecipientError
    {
        public int StatusCode { get; }
        public string ErrorMessage { get; }
        public Mailbox EmailAddress { get; }

        public RecipientError(int statusCode, string errorMessage, Mailbox emailAddress)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
            EmailAddress = emailAddress;
        }
    }
}
