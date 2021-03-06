// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class ComputeManagementTestEnvironment : TestEnvironment
    {
        public ComputeManagementTestEnvironment() : base("compute")
        {
        }
    }
}
