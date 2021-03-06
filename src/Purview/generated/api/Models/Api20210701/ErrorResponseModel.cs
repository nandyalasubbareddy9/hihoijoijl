namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Default error response model</summary>
    public partial class ErrorResponseModel :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModel,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal
    {

        /// <summary>Gets or sets the code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Code; }

        /// <summary>Gets or sets the details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel _error;

        /// <summary>Gets or sets the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorModel()); }

        /// <summary>Gets or sets the messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ErrorModel()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorResponseModelInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Target = value; }

        /// <summary>Gets or sets the target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal)Error).Target; }

        /// <summary>Creates an new <see cref="ErrorResponseModel" /> instance.</summary>
        public ErrorResponseModel()
        {

        }
    }
    /// Default error response model
    public partial interface IErrorResponseModel :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>Gets or sets the details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Detail { get;  }
        /// <summary>Gets or sets the messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the messages.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Gets or sets the target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }

    }
    /// Default error response model
    internal partial interface IErrorResponseModelInternal

    {
        /// <summary>Gets or sets the code.</summary>
        string Code { get; set; }
        /// <summary>Gets or sets the details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Detail { get; set; }
        /// <summary>Gets or sets the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel Error { get; set; }
        /// <summary>Gets or sets the messages.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target.</summary>
        string Target { get; set; }

    }
}