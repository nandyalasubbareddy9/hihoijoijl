// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>The result returned from a database check name availability request.</summary>
    public partial class DatabaseCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabaseCheckNameRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabaseCheckNameRequestInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Type _type;

        /// <summary>
        /// The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Type Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="DatabaseCheckNameRequest" /> instance.</summary>
        public DatabaseCheckNameRequest()
        {

        }
    }
    /// The result returned from a database check name availability request.
    public partial interface IDatabaseCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable
    {
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Type Type { get; set; }

    }
    /// The result returned from a database check name availability request.
    internal partial interface IDatabaseCheckNameRequestInternal

    {
        /// <summary>Resource name.</summary>
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.Type Type { get; set; }

    }
}