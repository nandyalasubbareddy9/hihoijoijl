// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of a datastore</summary>
    public partial class DatastoreProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastoreProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiskPoolVolume" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume _diskPoolVolume;

        /// <summary>An iSCSI volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume DiskPoolVolume { get => (this._diskPoolVolume = this._diskPoolVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.DiskPoolVolume()); set => this._diskPoolVolume = value; }

        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumeLunName { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).LunName; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).LunName = value ?? null; }

        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).MountOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).MountOption = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum)""); }

        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).Path; }

        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string DiskPoolVolumeTargetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).TargetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).TargetId = value ?? null; }

        /// <summary>Internal Acessors for DiskPoolVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal.DiskPoolVolume { get => (this._diskPoolVolume = this._diskPoolVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.DiskPoolVolume()); set { {_diskPoolVolume = value;} } }

        /// <summary>Internal Acessors for DiskPoolVolumePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal.DiskPoolVolumePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolumeInternal)DiskPoolVolume).Path = value; }

        /// <summary>Internal Acessors for NetAppVolume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal.NetAppVolume { get => (this._netAppVolume = this._netAppVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.NetAppVolume()); set { {_netAppVolume = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDatastorePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="NetAppVolume" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume _netAppVolume;

        /// <summary>An Azure NetApp Files volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume NetAppVolume { get => (this._netAppVolume = this._netAppVolume ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.NetAppVolume()); set => this._netAppVolume = value; }

        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inlined)]
        public string NetAppVolumeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolumeInternal)NetAppVolume).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolumeInternal)NetAppVolume).Id = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? _provisioningState;

        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="DatastoreProperties" /> instance.</summary>
        public DatastoreProperties()
        {

        }
    }
    /// The properties of a datastore
    public partial interface IDatastoreProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>Name of the LUN to be used for datastore</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the LUN to be used for datastore",
        SerializedName = @"lunName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN",
        SerializedName = @"mountOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get; set; }
        /// <summary>Device path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Device path",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumePath { get;  }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource ID of the iSCSI target",
        SerializedName = @"targetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskPoolVolumeTargetId { get; set; }
        /// <summary>Azure resource ID of the NetApp volume</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource ID of the NetApp volume",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetAppVolumeId { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the datastore provisioning",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get;  }

    }
    /// The properties of a datastore
    internal partial interface IDatastorePropertiesInternal

    {
        /// <summary>An iSCSI volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IDiskPoolVolume DiskPoolVolume { get; set; }
        /// <summary>Name of the LUN to be used for datastore</summary>
        string DiskPoolVolumeLunName { get; set; }
        /// <summary>
        /// Mode that describes whether the LUN has to be mounted as a datastore or attached as a LUN
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.MountOptionEnum? DiskPoolVolumeMountOption { get; set; }
        /// <summary>Device path</summary>
        string DiskPoolVolumePath { get; set; }
        /// <summary>Azure resource ID of the iSCSI target</summary>
        string DiskPoolVolumeTargetId { get; set; }
        /// <summary>An Azure NetApp Files volume</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.INetAppVolume NetAppVolume { get; set; }
        /// <summary>Azure resource ID of the NetApp volume</summary>
        string NetAppVolumeId { get; set; }
        /// <summary>The state of the datastore provisioning</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.DatastoreProvisioningState? ProvisioningState { get; set; }

    }
}