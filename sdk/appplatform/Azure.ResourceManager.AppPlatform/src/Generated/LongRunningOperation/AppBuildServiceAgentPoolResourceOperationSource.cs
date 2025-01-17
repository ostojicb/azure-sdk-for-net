// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppPlatform
{
    internal class AppBuildServiceAgentPoolResourceOperationSource : IOperationSource<AppBuildServiceAgentPoolResource>
    {
        private readonly ArmClient _client;

        internal AppBuildServiceAgentPoolResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        AppBuildServiceAgentPoolResource IOperationSource<AppBuildServiceAgentPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppBuildServiceAgentPoolResourceData.DeserializeAppBuildServiceAgentPoolResourceData(document.RootElement);
            return new AppBuildServiceAgentPoolResource(_client, data);
        }

        async ValueTask<AppBuildServiceAgentPoolResource> IOperationSource<AppBuildServiceAgentPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppBuildServiceAgentPoolResourceData.DeserializeAppBuildServiceAgentPoolResourceData(document.RootElement);
            return new AppBuildServiceAgentPoolResource(_client, data);
        }
    }
}
