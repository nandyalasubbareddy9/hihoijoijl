// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Management.Sql.Models;
using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Azure.Commands.Sql.Server.Model
{
    /// <summary>
    /// Represents the core properties of an Azure Sql Server
    /// </summary>
    public class AzureSqlServerModel
    {
        /// <summary>
        /// Gets or sets the name of the resource group the server is in
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the name of the server
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the location the server is in
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the sql login credentials for the admin
        /// </summary>
        public string SqlAdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the password for the sql admin
        /// </summary>
        public SecureString SqlAdministratorPassword { get; set; }

        /// <summary>
        /// Gets or sets the server version
        /// </summary>
        public string ServerVersion { get; set; }

        /// <summary>
        /// Gets or sets the tags associated with the server.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the server.
        /// </summary>
        public Management.Sql.Models.ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified domain name of the server
        /// </summary>
        public string FullyQualifiedDomainName { get; set; }
        
        /// <summary>
        /// Gets or sets the resource id of the server
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the managed instance minimal tls version
        /// </summary>
        public string MinimalTlsVersion { get; set; }

        /// <summary>
        /// Gets or sets the flag to control enable/disable public network access
        /// </summary>
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the flag to restrict the outbound network access from the server
        /// </summary>
        public string RestrictOutboundNetworkAccess { get; set; }

        /// <summary>
        /// Gets or sets the Azure SQL Server Active Directory administrator
        /// </summary>
        public Management.Sql.Models.ServerExternalAdministrator Administrators{ get; set; }

        /// <summary>
        /// Gets or sets the resource id of a user assigned identity to be used
        /// </summary>
        public string PrimaryUserAssignedIdentityId { get; set; }

        /// <summary>
        /// Gets or sets a CMK URI of the key to use for encryption.
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or sets a federated client id to use in xtcmk scenario
        /// </summary>
        public Guid? FederatedClientId { get; set; }
    }
}
