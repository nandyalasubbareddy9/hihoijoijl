// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Admin approval request resource properties</summary>
    public partial class AdminRequestApprovalProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdminAction" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction? _adminAction;

        /// <summary>Gets or sets admin action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction? AdminAction { get => this._adminAction; set => this._adminAction = value; }

        /// <summary>Backing field for <see cref="Administrator" /> property.</summary>
        private string _administrator;

        /// <summary>Gets or sets admin details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Administrator { get => this._administrator; set => this._administrator = value; }

        /// <summary>Backing field for <see cref="ApprovedPlan" /> property.</summary>
        private string[] _approvedPlan;

        /// <summary>Gets or sets Approved plans ids, empty in case of rejected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string[] ApprovedPlan { get => this._approvedPlan; set => this._approvedPlan = value; }

        /// <summary>Backing field for <see cref="CollectionId" /> property.</summary>
        private string[] _collectionId;

        /// <summary>Gets or sets list of associated collection ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string[] CollectionId { get => this._collectionId; set => this._collectionId = value; }

        /// <summary>Backing field for <see cref="Comment" /> property.</summary>
        private string _comment;

        /// <summary>Gets or sets admin comment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string Comment { get => this._comment; set => this._comment = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Gets display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; }

        /// <summary>Internal Acessors for DisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal.DisplayName { get => this._displayName; set { {_displayName = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[] Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IAdminRequestApprovalPropertiesInternal.Plan { get => this._plan; set { {_plan = value;} } }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Gets or sets offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; set => this._offerId = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[] _plan;

        /// <summary>Gets list of plans with requesters details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[] Plan { get => this._plan; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>Gets or sets publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; set => this._publisherId = value; }

        /// <summary>Creates an new <see cref="AdminRequestApprovalProperties" /> instance.</summary>
        public AdminRequestApprovalProperties()
        {

        }
    }
    /// Admin approval request resource properties
    public partial interface IAdminRequestApprovalProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets admin action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets admin action",
        SerializedName = @"adminAction",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction? AdminAction { get; set; }
        /// <summary>Gets or sets admin details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets admin details",
        SerializedName = @"administrator",
        PossibleTypes = new [] { typeof(string) })]
        string Administrator { get; set; }
        /// <summary>Gets or sets Approved plans ids, empty in case of rejected</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets Approved plans ids, empty in case of rejected",
        SerializedName = @"approvedPlans",
        PossibleTypes = new [] { typeof(string) })]
        string[] ApprovedPlan { get; set; }
        /// <summary>Gets or sets list of associated collection ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets list of associated collection ids",
        SerializedName = @"collectionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] CollectionId { get; set; }
        /// <summary>Gets or sets admin comment</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets admin comment",
        SerializedName = @"comment",
        PossibleTypes = new [] { typeof(string) })]
        string Comment { get; set; }
        /// <summary>Gets display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get;  }
        /// <summary>Gets or sets offer Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets offer Id",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get; set; }
        /// <summary>Gets list of plans with requesters details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets list of plans with requesters details",
        SerializedName = @"plans",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[] Plan { get;  }
        /// <summary>Gets or sets publisher Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets publisher Id",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get; set; }

    }
    /// Admin approval request resource properties
    internal partial interface IAdminRequestApprovalPropertiesInternal

    {
        /// <summary>Gets or sets admin action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Support.AdminAction? AdminAction { get; set; }
        /// <summary>Gets or sets admin details</summary>
        string Administrator { get; set; }
        /// <summary>Gets or sets Approved plans ids, empty in case of rejected</summary>
        string[] ApprovedPlan { get; set; }
        /// <summary>Gets or sets list of associated collection ids</summary>
        string[] CollectionId { get; set; }
        /// <summary>Gets or sets admin comment</summary>
        string Comment { get; set; }
        /// <summary>Gets display name</summary>
        string DisplayName { get; set; }
        /// <summary>Gets or sets offer Id</summary>
        string OfferId { get; set; }
        /// <summary>Gets list of plans with requesters details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IPlanRequesterDetails[] Plan { get; set; }
        /// <summary>Gets or sets publisher Id</summary>
        string PublisherId { get; set; }

    }
}