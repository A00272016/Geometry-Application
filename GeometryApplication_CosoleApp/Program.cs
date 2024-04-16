﻿using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
var featureManagement = new Dictionary<string, string> {
    { "FeatureManagement:Square", "true" },
    { "FeatureManagement:Rectangle", "false" },
    { "FeatureManagement:Triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
    .Build();