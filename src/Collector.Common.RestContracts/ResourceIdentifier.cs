﻿namespace Collector.Common.RestContracts
{
    using Interfaces;

    /// <summary>
    /// The resource identifier to be used for the request.
    /// </summary>
    public abstract class ResourceIdentifier : IResourceIdentifier
    {
        /// <summary>
        /// The Uri for the request.
        /// </summary>
        public abstract string Uri { get; }
    }
}