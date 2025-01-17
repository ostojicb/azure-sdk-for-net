// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> storage edition capability. </summary>
    public partial class StorageEditionCapability
    {
        /// <summary> Initializes a new instance of StorageEditionCapability. </summary>
        internal StorageEditionCapability()
        {
        }

        /// <summary> Initializes a new instance of StorageEditionCapability. </summary>
        /// <param name="name"> storage edition name. </param>
        /// <param name="minStorageSize"> The minimal supported storage size. </param>
        /// <param name="maxStorageSize"> The maximum supported storage size. </param>
        /// <param name="minBackupRetentionDays"> Minimal backup retention days. </param>
        /// <param name="maxBackupRetentionDays"> Maximum backup retention days. </param>
        internal StorageEditionCapability(string name, long? minStorageSize, long? maxStorageSize, long? minBackupRetentionDays, long? maxBackupRetentionDays)
        {
            Name = name;
            MinStorageSize = minStorageSize;
            MaxStorageSize = maxStorageSize;
            MinBackupRetentionDays = minBackupRetentionDays;
            MaxBackupRetentionDays = maxBackupRetentionDays;
        }

        /// <summary> storage edition name. </summary>
        public string Name { get; }
        /// <summary> The minimal supported storage size. </summary>
        public long? MinStorageSize { get; }
        /// <summary> The maximum supported storage size. </summary>
        public long? MaxStorageSize { get; }
        /// <summary> Minimal backup retention days. </summary>
        public long? MinBackupRetentionDays { get; }
        /// <summary> Maximum backup retention days. </summary>
        public long? MaxBackupRetentionDays { get; }
    }
}
