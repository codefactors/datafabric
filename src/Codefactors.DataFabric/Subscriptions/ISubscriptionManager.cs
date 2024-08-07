﻿// Copyright (c) 2024, Codefactors Ltd.
//
// Codefactors Ltd licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Codefactors.DataFabric.Subscriptions;

public interface ISubscriptionManager
{
    Task<object> AddSubscriptionAsync(IRequestContext requestContext, string path);

    Task RemoveSubscriptionAsync(IRequestContext requestContext, string path);

    Task NotifySubscribersAsync(string path, object update);
}