// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Zone and capability info for resource sku</summary>
    public partial class ResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfo,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for Zone</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal.Zone { get => this._zone; set { {_zone = value;} } }

        /// <summary>Internal Acessors for ZoneDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuLocationInfoInternal.ZoneDetail { get => this._zoneDetail; set { {_zoneDetail = value;} } }

        /// <summary>Backing field for <see cref="Zone" /> property.</summary>
        private string[] _zone;

        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string[] Zone { get => this._zone; }

        /// <summary>Backing field for <see cref="ZoneDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] _zoneDetail;

        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] ZoneDetail { get => this._zoneDetail; }

        /// <summary>Creates an new <see cref="ResourceSkuLocationInfo" /> instance.</summary>
        public ResourceSkuLocationInfo()
        {

        }
    }
    /// Zone and capability info for resource sku
    public partial interface IResourceSkuLocationInfo :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable
    {
        /// <summary>Location of the SKU</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location of the SKU",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of availability zones where the SKU is supported.",
        SerializedName = @"zones",
        PossibleTypes = new [] { typeof(string) })]
        string[] Zone { get;  }
        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Details of capabilities available to a SKU in specific zones.",
        SerializedName = @"zoneDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] ZoneDetail { get;  }

    }
    /// Zone and capability info for resource sku
    internal partial interface IResourceSkuLocationInfoInternal

    {
        /// <summary>Location of the SKU</summary>
        string Location { get; set; }
        /// <summary>List of availability zones where the SKU is supported.</summary>
        string[] Zone { get; set; }
        /// <summary>Details of capabilities available to a SKU in specific zones.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.Api20210801.IResourceSkuZoneDetails[] ZoneDetail { get; set; }

    }
}