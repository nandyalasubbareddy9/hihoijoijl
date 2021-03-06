// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    public partial class Plan :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlan,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal
    {

        /// <summary>Backing field for <see cref="Accessibility" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.Accessibility? _accessibility;

        /// <summary>Plan accessibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.Accessibility? Accessibility { get => this._accessibility; set => this._accessibility = value; }

        /// <summary>Backing field for <see cref="AltStackReference" /> property.</summary>
        private string _altStackReference;

        /// <summary>Alternative stack type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string AltStackReference { get => this._altStackReference; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Friendly name for the plan for display in the marketplace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Text identifier for this plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for AltStackReference</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal.AltStackReference { get => this._altStackReference; set { {_altStackReference = value;} } }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for SkuId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal.SkuId { get => this._skuId; set { {_skuId = value;} } }

        /// <summary>Internal Acessors for StackType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanInternal.StackType { get => this._stackType; set { {_stackType = value;} } }

        /// <summary>Backing field for <see cref="SkuId" /> property.</summary>
        private string _skuId;

        /// <summary>Identifier for this plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string SkuId { get => this._skuId; }

        /// <summary>Backing field for <see cref="StackType" /> property.</summary>
        private string _stackType;

        /// <summary>Stack type (classic or arm)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string StackType { get => this._stackType; }

        /// <summary>Creates an new <see cref="Plan" /> instance.</summary>
        public Plan()
        {

        }
    }
    public partial interface IPlan :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Plan accessibility</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan accessibility",
        SerializedName = @"accessibility",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.Accessibility) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.Accessibility? Accessibility { get; set; }
        /// <summary>Alternative stack type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Alternative stack type",
        SerializedName = @"altStackReference",
        PossibleTypes = new [] { typeof(string) })]
        string AltStackReference { get;  }
        /// <summary>Friendly name for the plan for display in the marketplace</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Friendly name for the plan for display in the marketplace",
        SerializedName = @"planDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Text identifier for this plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Text identifier for this plan",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Identifier for this plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Identifier for this plan",
        SerializedName = @"skuId",
        PossibleTypes = new [] { typeof(string) })]
        string SkuId { get;  }
        /// <summary>Stack type (classic or arm)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Stack type (classic or arm)",
        SerializedName = @"stackType",
        PossibleTypes = new [] { typeof(string) })]
        string StackType { get;  }

    }
    internal partial interface IPlanInternal

    {
        /// <summary>Plan accessibility</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.Accessibility? Accessibility { get; set; }
        /// <summary>Alternative stack type</summary>
        string AltStackReference { get; set; }
        /// <summary>Friendly name for the plan for display in the marketplace</summary>
        string DisplayName { get; set; }
        /// <summary>Text identifier for this plan</summary>
        string Id { get; set; }
        /// <summary>Identifier for this plan</summary>
        string SkuId { get; set; }
        /// <summary>Stack type (classic or arm)</summary>
        string StackType { get; set; }

    }
}