// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Sql always encrypted properties. </summary>
    public partial class SqlAlwaysEncryptedProperties
    {
        /// <summary> Initializes a new instance of SqlAlwaysEncryptedProperties. </summary>
        /// <param name="alwaysEncryptedAkvAuthType"> Sql always encrypted AKV authentication type. Type: string (or Expression with resultType string). </param>
        public SqlAlwaysEncryptedProperties(SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType)
        {
            AlwaysEncryptedAkvAuthType = alwaysEncryptedAkvAuthType;
        }

        /// <summary> Initializes a new instance of SqlAlwaysEncryptedProperties. </summary>
        /// <param name="alwaysEncryptedAkvAuthType"> Sql always encrypted AKV authentication type. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The client ID of the application in Azure Active Directory used for Azure Key Vault authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey">
        /// The key of the service principal used to authenticate against Azure Key Vault.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal SqlAlwaysEncryptedProperties(SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType, BinaryData servicePrincipalId, SecretBase servicePrincipalKey, CredentialReference credential)
        {
            AlwaysEncryptedAkvAuthType = alwaysEncryptedAkvAuthType;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Credential = credential;
        }

        /// <summary> Sql always encrypted AKV authentication type. Type: string (or Expression with resultType string). </summary>
        public SqlAlwaysEncryptedAkvAuthType AlwaysEncryptedAkvAuthType { get; set; }
        /// <summary> The client ID of the application in Azure Active Directory used for Azure Key Vault authentication. Type: string (or Expression with resultType string). </summary>
        public BinaryData ServicePrincipalId { get; set; }
        /// <summary>
        /// The key of the service principal used to authenticate against Azure Key Vault.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecureString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
