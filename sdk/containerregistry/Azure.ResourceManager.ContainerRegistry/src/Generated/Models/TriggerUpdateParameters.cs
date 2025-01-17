// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating triggers. </summary>
    public partial class TriggerUpdateParameters
    {
        /// <summary> Initializes a new instance of TriggerUpdateParameters. </summary>
        public TriggerUpdateParameters()
        {
            TimerTriggers = new ChangeTrackingList<TimerTriggerUpdateParameters>();
            SourceTriggers = new ChangeTrackingList<SourceTriggerUpdateParameters>();
        }

        /// <summary> The collection of timer triggers. </summary>
        public IList<TimerTriggerUpdateParameters> TimerTriggers { get; }
        /// <summary> The collection of triggers based on source code repository. </summary>
        public IList<SourceTriggerUpdateParameters> SourceTriggers { get; }
        /// <summary> The trigger based on base image dependencies. </summary>
        public BaseImageTriggerUpdateParameters BaseImageTrigger { get; set; }
    }
}
