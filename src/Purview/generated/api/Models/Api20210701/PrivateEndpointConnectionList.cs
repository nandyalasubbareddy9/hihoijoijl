namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Paged list of private endpoint connections</summary>
    public partial class PrivateEndpointConnectionList :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnectionList,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnectionListInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private long? _count;

        /// <summary>Total item count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public long? Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The Url of next result page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] _value;

        /// <summary>Collection of items of type results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateEndpointConnectionList" /> instance.</summary>
        public PrivateEndpointConnectionList()
        {

        }
    }
    /// Paged list of private endpoint connections
    public partial interface IPrivateEndpointConnectionList :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Total item count.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total item count.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? Count { get; set; }
        /// <summary>The Url of next result page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Url of next result page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Collection of items of type results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Collection of items of type results.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Value { get; set; }

    }
    /// Paged list of private endpoint connections
    internal partial interface IPrivateEndpointConnectionListInternal

    {
        /// <summary>Total item count.</summary>
        long? Count { get; set; }
        /// <summary>The Url of next result page.</summary>
        string NextLink { get; set; }
        /// <summary>Collection of items of type results.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Value { get; set; }

    }
}