// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>The list of the SKU descriptions</summary>
    public partial class SkuDescriptionList :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescriptionList,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescriptionListInternal
    {

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription[] Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescriptionListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription[] _value;

        /// <summary>SKU descriptions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="SkuDescriptionList" /> instance.</summary>
        public SkuDescriptionList()
        {

        }
    }
    /// The list of the SKU descriptions
    public partial interface ISkuDescriptionList :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable
    {
        /// <summary>SKU descriptions</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"SKU descriptions",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription) })]
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription[] Value { get;  }

    }
    /// The list of the SKU descriptions
    internal partial interface ISkuDescriptionListInternal

    {
        /// <summary>SKU descriptions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.ISkuDescription[] Value { get; set; }

    }
}