// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The data stored in Optimized Row Columnar (ORC) format. </summary>
    public partial class OrcFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of OrcFormat. </summary>
        public OrcFormat()
        {
            DatasetStorageFormatType = "OrcFormat";
        }

        /// <summary> Initializes a new instance of OrcFormat. </summary>
        /// <param name="datasetStorageFormatType"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal OrcFormat(string datasetStorageFormatType, BinaryData serializer, BinaryData deserializer, IDictionary<string, BinaryData> additionalProperties) : base(datasetStorageFormatType, serializer, deserializer, additionalProperties)
        {
            DatasetStorageFormatType = datasetStorageFormatType ?? "OrcFormat";
        }
    }
}
