using System;

namespace Pirina.Kernel.Smtp.Text
{
    public interface ITokenEnumeratorCheckpoint : IDisposable
    {
        /// <summary>
        /// Rollback to the checkpoint;
        /// </summary>
        void Rollback();
    }
}