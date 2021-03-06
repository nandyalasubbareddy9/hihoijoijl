namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Default error model</summary>
    public partial class ErrorModel :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Gets or sets the code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] _detail;

        /// <summary>Gets or sets the details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Detail { get => this._detail; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Gets or sets the messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal.Detail { get => this._detail; set { {_detail = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModelInternal.Target { get => this._target; set { {_target = value;} } }

        /// <summary>Backing field for <see cref="Target" /> property.</summary>
        private string _target;

        /// <summary>Gets or sets the target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Target { get => this._target; }

        /// <summary>Creates an new <see cref="ErrorModel" /> instance.</summary>
        public ErrorModel()
        {

        }
    }
    /// Default error model
    public partial interface IErrorModel :
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
    /// Default error model
    internal partial interface IErrorModelInternal

    {
        /// <summary>Gets or sets the code.</summary>
        string Code { get; set; }
        /// <summary>Gets or sets the details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IErrorModel[] Detail { get; set; }
        /// <summary>Gets or sets the messages.</summary>
        string Message { get; set; }
        /// <summary>Gets or sets the target.</summary>
        string Target { get; set; }

    }
}