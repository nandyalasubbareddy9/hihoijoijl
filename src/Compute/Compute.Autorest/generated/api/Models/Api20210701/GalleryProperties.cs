// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the properties of a Shared Image Gallery.</summary>
    public partial class GalleryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// The description of this Shared Image Gallery resource. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Identifier" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifier _identifier;

        /// <summary>Describes the gallery unique name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifier Identifier { get => (this._identifier = this._identifier ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryIdentifier()); set => this._identifier = value; }

        /// <summary>
        /// The unique name of the Shared Image Gallery. This name is generated automatically by Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public string IdentifierUniqueName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifierInternal)Identifier).UniqueName; }

        /// <summary>Internal Acessors for Identifier</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifier Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.Identifier { get => (this._identifier = this._identifier ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryIdentifier()); set { {_identifier = value;} } }

        /// <summary>Internal Acessors for IdentifierUniqueName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.IdentifierUniqueName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifierInternal)Identifier).UniqueName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifierInternal)Identifier).UniqueName = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for SharingProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfile Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.SharingProfile { get => (this._sharingProfile = this._sharingProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.SharingProfile()); set { {_sharingProfile = value;} } }

        /// <summary>Internal Acessors for SharingProfileGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileGroup[] Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.SharingProfileGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileInternal)SharingProfile).Group; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileInternal)SharingProfile).Group = value; }

        /// <summary>Internal Acessors for SoftDeletePolicy</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicy Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryPropertiesInternal.SoftDeletePolicy { get => (this._softDeletePolicy = this._softDeletePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.SoftDeletePolicy()); set { {_softDeletePolicy = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="SharingProfile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfile _sharingProfile;

        /// <summary>Profile for gallery sharing to subscription or tenant</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfile SharingProfile { get => (this._sharingProfile = this._sharingProfile ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.SharingProfile()); set => this._sharingProfile = value; }

        /// <summary>A list of sharing profile groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileGroup[] SharingProfileGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileInternal)SharingProfile).Group; }

        /// <summary>
        /// This property allows you to specify the permission of sharing gallery. <br><br> Possible values are: <br><br> **Private**
        /// <br><br> **Groups**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GallerySharingPermissionTypes? SharingProfilePermission { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileInternal)SharingProfile).Permission; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileInternal)SharingProfile).Permission = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GallerySharingPermissionTypes)""); }

        /// <summary>Backing field for <see cref="SoftDeletePolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicy _softDeletePolicy;

        /// <summary>Contains information about the soft deletion policy of the gallery.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicy SoftDeletePolicy { get => (this._softDeletePolicy = this._softDeletePolicy ?? new Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.SoftDeletePolicy()); set => this._softDeletePolicy = value; }

        /// <summary>
        /// Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Inlined)]
        public bool? SoftDeletePolicyIsSoftDeleteEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicyInternal)SoftDeletePolicy).IsSoftDeleteEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicyInternal)SoftDeletePolicy).IsSoftDeleteEnabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="GalleryProperties" /> instance.</summary>
        public GalleryProperties()
        {

        }
    }
    /// Describes the properties of a Shared Image Gallery.
    public partial interface IGalleryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The description of this Shared Image Gallery resource. This property is updatable.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of this Shared Image Gallery resource. This property is updatable.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>
        /// The unique name of the Shared Image Gallery. This name is generated automatically by Azure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique name of the Shared Image Gallery. This name is generated automatically by Azure.",
        SerializedName = @"uniqueName",
        PossibleTypes = new [] { typeof(string) })]
        string IdentifierUniqueName { get;  }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state, which only appears in the response.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>A list of sharing profile groups.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A list of sharing profile groups.",
        SerializedName = @"groups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileGroup[] SharingProfileGroup { get;  }
        /// <summary>
        /// This property allows you to specify the permission of sharing gallery. <br><br> Possible values are: <br><br> **Private**
        /// <br><br> **Groups**
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This property allows you to specify the permission of sharing gallery. <br><br> Possible values are: <br><br> **Private** <br><br> **Groups**",
        SerializedName = @"permissions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GallerySharingPermissionTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GallerySharingPermissionTypes? SharingProfilePermission { get; set; }
        /// <summary>
        /// Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.",
        SerializedName = @"isSoftDeleteEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SoftDeletePolicyIsSoftDeleteEnabled { get; set; }

    }
    /// Describes the properties of a Shared Image Gallery.
    internal partial interface IGalleryPropertiesInternal

    {
        /// <summary>
        /// The description of this Shared Image Gallery resource. This property is updatable.
        /// </summary>
        string Description { get; set; }
        /// <summary>Describes the gallery unique name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryIdentifier Identifier { get; set; }
        /// <summary>
        /// The unique name of the Shared Image Gallery. This name is generated automatically by Azure.
        /// </summary>
        string IdentifierUniqueName { get; set; }
        /// <summary>The provisioning state, which only appears in the response.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Profile for gallery sharing to subscription or tenant</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfile SharingProfile { get; set; }
        /// <summary>A list of sharing profile groups.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISharingProfileGroup[] SharingProfileGroup { get; set; }
        /// <summary>
        /// This property allows you to specify the permission of sharing gallery. <br><br> Possible values are: <br><br> **Private**
        /// <br><br> **Groups**
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.GallerySharingPermissionTypes? SharingProfilePermission { get; set; }
        /// <summary>Contains information about the soft deletion policy of the gallery.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ISoftDeletePolicy SoftDeletePolicy { get; set; }
        /// <summary>
        /// Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.
        /// </summary>
        bool? SoftDeletePolicyIsSoftDeleteEnabled { get; set; }

    }
}