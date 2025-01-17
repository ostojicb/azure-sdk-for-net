// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to list replications for a container registry. </summary>
    internal partial class ReplicationListResult
    {
        /// <summary> Initializes a new instance of ReplicationListResult. </summary>
        internal ReplicationListResult()
        {
            Value = new ChangeTrackingList<ReplicationData>();
        }

        /// <summary> Initializes a new instance of ReplicationListResult. </summary>
        /// <param name="value"> The list of replications. Since this list may be incomplete, the nextLink field should be used to request the next list of replications. </param>
        /// <param name="nextLink"> The URI that can be used to request the next list of replications. </param>
        internal ReplicationListResult(IReadOnlyList<ReplicationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of replications. Since this list may be incomplete, the nextLink field should be used to request the next list of replications. </summary>
        public IReadOnlyList<ReplicationData> Value { get; }
        /// <summary> The URI that can be used to request the next list of replications. </summary>
        public string NextLink { get; }
    }
}
