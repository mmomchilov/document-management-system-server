﻿using System;

namespace Pirina.Kernel.Messaging
{
    [Serializable]
    public abstract class Message
    {
        public Guid Id { get; }

        protected Message(Guid id)
        {
            Id = id;
        }
    }
}