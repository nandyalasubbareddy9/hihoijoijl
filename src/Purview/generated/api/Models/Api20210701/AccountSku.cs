namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The Sku</summary>
    public partial class AccountSku :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSku,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountSkuInternal
    {

        /// <summary>Backing field for <see cref="Capacity" /> property.</summary>
        private int? _capacity;

        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public int? Capacity { get => this._capacity; set => this._capacity = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? _name;

        /// <summary>Gets or sets the sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="AccountSku" /> instance.</summary>
        public AccountSku()
        {

        }
    }
    /// The Sku
    public partial interface IAccountSku :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku capacity. Possible values include: 4, 16",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(int) })]
        int? Capacity { get; set; }
        /// <summary>Gets or sets the sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? Name { get; set; }

    }
    /// The Sku
    internal partial interface IAccountSkuInternal

    {
        /// <summary>Gets or sets the sku capacity. Possible values include: 4, 16</summary>
        int? Capacity { get; set; }
        /// <summary>Gets or sets the sku name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Name? Name { get; set; }

    }
}