// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A collection of AssetTrack items. </summary>
    internal partial class AssetTrackCollection
    {
        /// <summary> Initializes a new instance of AssetTrackCollection. </summary>
        internal AssetTrackCollection()
        {
            Value = new ChangeTrackingList<AssetTrackData>();
        }

        /// <summary> Initializes a new instance of AssetTrackCollection. </summary>
        /// <param name="value"> A collection of AssetTrack items. </param>
        internal AssetTrackCollection(IReadOnlyList<AssetTrackData> value)
        {
            Value = value;
        }

        /// <summary> A collection of AssetTrack items. </summary>
        public IReadOnlyList<AssetTrackData> Value { get; }
    }
}
