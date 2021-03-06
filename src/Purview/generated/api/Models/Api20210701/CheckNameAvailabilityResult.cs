namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The response payload for CheckNameAvailability API</summary>
    public partial class CheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICheckNameAvailabilityResult,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICheckNameAvailabilityResultInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>Indicates if name is valid and available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Reason? _reason;

        /// <summary>The reason the name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Reason? Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResult" /> instance.</summary>
        public CheckNameAvailabilityResult()
        {

        }
    }
    /// The response payload for CheckNameAvailability API
    public partial interface ICheckNameAvailabilityResult :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Error message</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>Indicates if name is valid and available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if name is valid and available.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>The reason the name is not available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason the name is not available.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Reason) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Reason? Reason { get; set; }

    }
    /// The response payload for CheckNameAvailability API
    internal partial interface ICheckNameAvailabilityResultInternal

    {
        /// <summary>Error message</summary>
        string Message { get; set; }
        /// <summary>Indicates if name is valid and available.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason the name is not available.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.Reason? Reason { get; set; }

    }
}