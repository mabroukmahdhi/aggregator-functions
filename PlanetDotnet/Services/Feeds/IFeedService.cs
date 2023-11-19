﻿// ---------------------------------------------------------------
// Copyright (c) 2023 Planet Dotnet. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.ServiceModel.Syndication;
using System.Threading.Tasks;

namespace PlanetDotnet.Services.Feeds
{
    public interface IFeedService
    {
        ValueTask<SyndicationFeed> CombineFeedsAsync();
        ValueTask<SyndicationFeed> CombineFeedsAsync();
    }
}