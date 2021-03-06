namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Payload to get and set the default account in the given scope</summary>
    public partial class DefaultAccountPayload :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDefaultAccountPayload,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDefaultAccountPayloadInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>The name of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The resource group name of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="Scope" /> property.</summary>
        private string _scope;

        /// <summary>The scope object ID. For example, sub ID or tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Scope { get => this._scope; set => this._scope = value; }

        /// <summary>Backing field for <see cref="ScopeTenantId" /> property.</summary>
        private string _scopeTenantId;

        /// <summary>The scope tenant in which the default account is set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ScopeTenantId { get => this._scopeTenantId; set => this._scopeTenantId = value; }

        /// <summary>Backing field for <see cref="ScopeType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType? _scopeType;

        /// <summary>The scope where the default account is set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType? ScopeType { get => this._scopeType; set => this._scopeType = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription ID of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="DefaultAccountPayload" /> instance.</summary>
        public DefaultAccountPayload()
        {

        }
    }
    /// Payload to get and set the default account in the given scope
    public partial interface IDefaultAccountPayload :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The name of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the account that is set as the default.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>The resource group name of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource group name of the account that is set as the default.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The scope object ID. For example, sub ID or tenant ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope object ID. For example, sub ID or tenant ID.",
        SerializedName = @"scope",
        PossibleTypes = new [] { typeof(string) })]
        string Scope { get; set; }
        /// <summary>The scope tenant in which the default account is set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope tenant in which the default account is set.",
        SerializedName = @"scopeTenantId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeTenantId { get; set; }
        /// <summary>The scope where the default account is set.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scope where the default account is set.",
        SerializedName = @"scopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType? ScopeType { get; set; }
        /// <summary>The subscription ID of the account that is set as the default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription ID of the account that is set as the default.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// Payload to get and set the default account in the given scope
    internal partial interface IDefaultAccountPayloadInternal

    {
        /// <summary>The name of the account that is set as the default.</summary>
        string AccountName { get; set; }
        /// <summary>The resource group name of the account that is set as the default.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The scope object ID. For example, sub ID or tenant ID.</summary>
        string Scope { get; set; }
        /// <summary>The scope tenant in which the default account is set.</summary>
        string ScopeTenantId { get; set; }
        /// <summary>The scope where the default account is set.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ScopeType? ScopeType { get; set; }
        /// <summary>The subscription ID of the account that is set as the default.</summary>
        string SubscriptionId { get; set; }

    }
}