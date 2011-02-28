﻿// --------------------------------
// <copyright file="IFacebookSettings.cs" company="Facebook C# SDK">
//     Microsoft Public License (Ms-PL)
// </copyright>
// <author>Nathan Totten (ntotten.com) and Jim Zimmerman (jimzimmerman.com)</author>
// <license>Released under the terms of the Microsoft Public License (Ms-PL)</license>
// <website>http://facebooksdk.codeplex.com</website>
// ---------------------------------

namespace Facebook
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Represents the settings of a Facebook application.
    /// </summary>
    [Obsolete]
    [TypeForwardedFrom("Facebook, Version=4.2.1.0, Culture=neutral, PublicKeyToken=58cb4f2111d1e6de")]
    public interface IFacebookSettings : IFacebookApplication
    {

        /// <summary>
        /// Gets or sets the max retries.
        /// </summary>
        /// <value>The max retries.</value>
        int MaxRetries { get; set; }
        /// <summary>
        /// Gets or sets the retry delay.
        /// </summary>
        /// <value>The retry delay.</value>
        int RetryDelay { get; set; }

    }
}
