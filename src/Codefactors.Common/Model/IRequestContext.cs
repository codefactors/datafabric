﻿// Copyright (c) 2024, Codefactors Ltd.
//
// Codefactors Ltd licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Codefactors.Common.Model;

/// <summary>
/// Interface that provides access to the request context.
/// </summary>
public interface IRequestContext
{
    /// <summary>
    /// Gets the id for the user of this request.
    /// </summary>
    object UserId { get; }
}
