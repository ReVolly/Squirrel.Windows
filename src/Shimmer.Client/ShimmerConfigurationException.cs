﻿using System;

namespace Shimmer.Client
{
    public class ShimmerConfigurationException : Exception
    {
        public ShimmerConfigurationException(string message) : base(message) { }
    }

    public class ShimmerDownloadException : Exception
    {
        public ShimmerDownloadException(string message) : base(message) { }
    }
}