namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Collection administrator update.</summary>
    public partial class CollectionAdminUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICollectionAdminUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICollectionAdminUpdateInternal
    {

        /// <summary>Backing field for <see cref="ObjectId" /> property.</summary>
        private string _objectId;

        /// <summary>Gets or sets the object identifier of the admin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ObjectId { get => this._objectId; set => this._objectId = value; }

        /// <summary>Creates an new <see cref="CollectionAdminUpdate" /> instance.</summary>
        public CollectionAdminUpdate()
        {

        }
    }
    /// Collection administrator update.
    public partial interface ICollectionAdminUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the object identifier of the admin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the object identifier of the admin.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string ObjectId { get; set; }

    }
    /// Collection administrator update.
    internal partial interface ICollectionAdminUpdateInternal

    {
        /// <summary>Gets or sets the object identifier of the admin.</summary>
        string ObjectId { get; set; }

    }
}