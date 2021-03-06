namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>A privately linkable resource properties.</summary>
    public partial class PrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal
    {

        /// <summary>Backing field for <see cref="GroupId" /> property.</summary>
        private string _groupId;

        /// <summary>The private link resource group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string GroupId { get => this._groupId; }

        /// <summary>Internal Acessors for GroupId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal.GroupId { get => this._groupId; set { {_groupId = value;} } }

        /// <summary>Internal Acessors for RequiredMember</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal.RequiredMember { get => this._requiredMember; set { {_requiredMember = value;} } }

        /// <summary>Internal Acessors for RequiredZoneName</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateLinkResourcePropertiesInternal.RequiredZoneName { get => this._requiredZoneName; set { {_requiredZoneName = value;} } }

        /// <summary>Backing field for <see cref="RequiredMember" /> property.</summary>
        private string[] _requiredMember;

        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string[] RequiredMember { get => this._requiredMember; }

        /// <summary>Backing field for <see cref="RequiredZoneName" /> property.</summary>
        private string[] _requiredZoneName;

        /// <summary>The required zone names for private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string[] RequiredZoneName { get => this._requiredZoneName; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceProperties" /> instance.</summary>
        public PrivateLinkResourceProperties()
        {

        }
    }
    /// A privately linkable resource properties.
    public partial interface IPrivateLinkResourceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The private link resource group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The private link resource group identifier.",
        SerializedName = @"groupId",
        PossibleTypes = new [] { typeof(string) })]
        string GroupId { get;  }
        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"This translates to how many Private IPs should be created for each privately linkable resource.",
        SerializedName = @"requiredMembers",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredMember { get;  }
        /// <summary>The required zone names for private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The required zone names for private link resource.",
        SerializedName = @"requiredZoneNames",
        PossibleTypes = new [] { typeof(string) })]
        string[] RequiredZoneName { get;  }

    }
    /// A privately linkable resource properties.
    internal partial interface IPrivateLinkResourcePropertiesInternal

    {
        /// <summary>The private link resource group identifier.</summary>
        string GroupId { get; set; }
        /// <summary>
        /// This translates to how many Private IPs should be created for each privately linkable resource.
        /// </summary>
        string[] RequiredMember { get; set; }
        /// <summary>The required zone names for private link resource.</summary>
        string[] RequiredZoneName { get; set; }

    }
}