﻿using System;

namespace Pirina.Kernel.Transport
{
    public interface ITransaction : IDisposable
    {
        void Begin();
        void Commit();
        void Abort();
    }
}