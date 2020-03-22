﻿using System;
using System.IO;
using System.Text;

namespace Pirina.Kernel.Extensions
{
    public static class StreamExtensions
    {
        public static string ConvertToString(this Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));
            stream.Position = 0;

            var streamReader = new StreamReader(stream);
            return streamReader.ReadToEnd();
        }
    }
}