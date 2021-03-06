namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The Account access keys.</summary>
    public partial class AccessKeys :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccessKeys,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccessKeysInternal
    {

        /// <summary>Backing field for <see cref="AtlasKafkaPrimaryEndpoint" /> property.</summary>
        private string _atlasKafkaPrimaryEndpoint;

        /// <summary>Gets or sets the primary connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AtlasKafkaPrimaryEndpoint { get => this._atlasKafkaPrimaryEndpoint; set => this._atlasKafkaPrimaryEndpoint = value; }

        /// <summary>Backing field for <see cref="AtlasKafkaSecondaryEndpoint" /> property.</summary>
        private string _atlasKafkaSecondaryEndpoint;

        /// <summary>Gets or sets the secondary connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AtlasKafkaSecondaryEndpoint { get => this._atlasKafkaSecondaryEndpoint; set => this._atlasKafkaSecondaryEndpoint = value; }

        /// <summary>Creates an new <see cref="AccessKeys" /> instance.</summary>
        public AccessKeys()
        {

        }
    }
    /// The Account access keys.
    public partial interface IAccessKeys :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the primary connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the primary connection string.",
        SerializedName = @"atlasKafkaPrimaryEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string AtlasKafkaPrimaryEndpoint { get; set; }
        /// <summary>Gets or sets the secondary connection string.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the secondary connection string.",
        SerializedName = @"atlasKafkaSecondaryEndpoint",
        PossibleTypes = new [] { typeof(string) })]
        string AtlasKafkaSecondaryEndpoint { get; set; }

    }
    /// The Account access keys.
    internal partial interface IAccessKeysInternal

    {
        /// <summary>Gets or sets the primary connection string.</summary>
        string AtlasKafkaPrimaryEndpoint { get; set; }
        /// <summary>Gets or sets the secondary connection string.</summary>
        string AtlasKafkaSecondaryEndpoint { get; set; }

    }
}