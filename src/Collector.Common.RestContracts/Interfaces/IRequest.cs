﻿namespace Collector.Common.RestContracts.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Marker interface for all requests
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Gets the context.
        /// </summary>
        string Context { get; set; }

        /// <summary>
        /// Gets the Http method.
        /// </summary>
        /// <returns>The Http method.</returns>
        HttpMethod GetHttpMethod();

        /// <summary>
        /// Gets the key for loading base URL, authentication logic, logging etc..
        /// </summary>
        /// <returns>The configuration key name.</returns>
        string GetConfigurationKey();

        /// <summary>
        /// Validates the request.
        /// </summary>
        /// <returns>A list of validation error info's.</returns>
        IEnumerable<ErrorInfo> GetValidationErrors();
    }

    public interface IRequest<out TResourceIdentifier> : IRequest where TResourceIdentifier : class, IResourceIdentifier
    {
        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        TResourceIdentifier GetResourceIdentifier();
    }
}