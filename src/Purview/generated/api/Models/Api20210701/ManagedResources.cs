namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The managed resources in customer subscription.</summary>
    public partial class ManagedResources :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal
    {

        /// <summary>Backing field for <see cref="EventHubNamespace" /> property.</summary>
        private string _eventHubNamespace;

        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string EventHubNamespace { get => this._eventHubNamespace; }

        /// <summary>Internal Acessors for EventHubNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.EventHubNamespace { get => this._eventHubNamespace; set { {_eventHubNamespace = value;} } }

        /// <summary>Internal Acessors for ResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.ResourceGroup { get => this._resourceGroup; set { {_resourceGroup = value;} } }

        /// <summary>Internal Acessors for StorageAccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResourcesInternal.StorageAccount { get => this._storageAccount; set { {_storageAccount = value;} } }

        /// <summary>Backing field for <see cref="ResourceGroup" /> property.</summary>
        private string _resourceGroup;

        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceGroup { get => this._resourceGroup; }

        /// <summary>Backing field for <see cref="StorageAccount" /> property.</summary>
        private string _storageAccount;

        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string StorageAccount { get => this._storageAccount; }

        /// <summary>Creates an new <see cref="ManagedResources" /> instance.</summary>
        public ManagedResources()
        {

        }
    }
    /// The managed resources in customer subscription.
    public partial interface IManagedResources :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed event hub namespace resource identifier.",
        SerializedName = @"eventHubNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubNamespace { get;  }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get;  }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed storage account resource identifier.",
        SerializedName = @"storageAccount",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccount { get;  }

    }
    /// The managed resources in customer subscription.
    internal partial interface IManagedResourcesInternal

    {
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        string EventHubNamespace { get; set; }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        string ResourceGroup { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        string StorageAccount { get; set; }

    }
}