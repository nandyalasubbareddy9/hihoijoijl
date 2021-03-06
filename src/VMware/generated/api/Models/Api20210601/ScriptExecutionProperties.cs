// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>Properties of a user-invoked script</summary>
    public partial class ScriptExecutionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private string[] _error;

        /// <summary>Standard error output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string[] Error { get => this._error; }

        /// <summary>Backing field for <see cref="FailureReason" /> property.</summary>
        private string _failureReason;

        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string FailureReason { get => this._failureReason; set => this._failureReason = value; }

        /// <summary>Backing field for <see cref="FinishedAt" /> property.</summary>
        private global::System.DateTime? _finishedAt;

        /// <summary>Time the script execution was finished</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public global::System.DateTime? FinishedAt { get => this._finishedAt; }

        /// <summary>Backing field for <see cref="HiddenParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] _hiddenParameter;

        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get => this._hiddenParameter; set => this._hiddenParameter = value; }

        /// <summary>Backing field for <see cref="Information" /> property.</summary>
        private string[] _information;

        /// <summary>Standard information out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string[] Information { get => this._information; }

        /// <summary>Internal Acessors for Error</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.Error { get => this._error; set { {_error = value;} } }

        /// <summary>Internal Acessors for FinishedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.FinishedAt { get => this._finishedAt; set { {_finishedAt = value;} } }

        /// <summary>Internal Acessors for Information</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.Information { get => this._information; set { {_information = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for StartedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.StartedAt { get => this._startedAt; set { {_startedAt = value;} } }

        /// <summary>Internal Acessors for SubmittedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.SubmittedAt { get => this._submittedAt; set { {_submittedAt = value;} } }

        /// <summary>Internal Acessors for Warning</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesInternal.Warning { get => this._warning; set { {_warning = value;} } }

        /// <summary>Backing field for <see cref="NamedOutput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs _namedOutput;

        /// <summary>User-defined dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get => (this._namedOutput = this._namedOutput ?? new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptExecutionPropertiesNamedOutputs()); set => this._namedOutput = value; }

        /// <summary>Backing field for <see cref="Output" /> property.</summary>
        private string[] _output;

        /// <summary>Standard output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string[] Output { get => this._output; set => this._output = value; }

        /// <summary>Backing field for <see cref="Parameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] _parameter;

        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] Parameter { get => this._parameter; set => this._parameter = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState? _provisioningState;

        /// <summary>The state of the script execution resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Retention" /> property.</summary>
        private string _retention;

        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Retention { get => this._retention; set => this._retention = value; }

        /// <summary>Backing field for <see cref="ScriptCmdletId" /> property.</summary>
        private string _scriptCmdletId;

        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string ScriptCmdletId { get => this._scriptCmdletId; set => this._scriptCmdletId = value; }

        /// <summary>Backing field for <see cref="StartedAt" /> property.</summary>
        private global::System.DateTime? _startedAt;

        /// <summary>Time the script execution was started</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public global::System.DateTime? StartedAt { get => this._startedAt; }

        /// <summary>Backing field for <see cref="SubmittedAt" /> property.</summary>
        private global::System.DateTime? _submittedAt;

        /// <summary>Time the script execution was submitted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public global::System.DateTime? SubmittedAt { get => this._submittedAt; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private string _timeout;

        /// <summary>Time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Backing field for <see cref="Warning" /> property.</summary>
        private string[] _warning;

        /// <summary>Standard warning out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public string[] Warning { get => this._warning; }

        /// <summary>Creates an new <see cref="ScriptExecutionProperties" /> instance.</summary>
        public ScriptExecutionProperties()
        {

        }
    }
    /// Properties of a user-invoked script
    public partial interface IScriptExecutionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>Standard error output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard error output stream from the powershell execution",
        SerializedName = @"errors",
        PossibleTypes = new [] { typeof(string) })]
        string[] Error { get;  }
        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Error message if the script was able to run, but if the script itself had errors or powershell threw an exception",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string FailureReason { get; set; }
        /// <summary>Time the script execution was finished</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was finished",
        SerializedName = @"finishedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? FinishedAt { get;  }
        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parameters that will be hidden/not visible to ARM, such as passwords and credentials",
        SerializedName = @"hiddenParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get; set; }
        /// <summary>Standard information out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard information out stream from the powershell execution",
        SerializedName = @"information",
        PossibleTypes = new [] { typeof(string) })]
        string[] Information { get;  }
        /// <summary>User-defined dictionary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User-defined dictionary.",
        SerializedName = @"namedOutputs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get; set; }
        /// <summary>Standard output stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Standard output stream from the powershell execution",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string[] Output { get; set; }
        /// <summary>Parameters the script will accept</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Parameters the script will accept",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] Parameter { get; set; }
        /// <summary>The state of the script execution resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The state of the script execution resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState? ProvisioningState { get;  }
        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time to live for the resource. If not provided, will be available for 60 days",
        SerializedName = @"retention",
        PossibleTypes = new [] { typeof(string) })]
        string Retention { get; set; }
        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A reference to the script cmdlet resource if user is running a AVS script",
        SerializedName = @"scriptCmdletId",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptCmdletId { get; set; }
        /// <summary>Time the script execution was started</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was started",
        SerializedName = @"startedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartedAt { get;  }
        /// <summary>Time the script execution was submitted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Time the script execution was submitted",
        SerializedName = @"submittedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SubmittedAt { get;  }
        /// <summary>Time limit for execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Time limit for execution",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get; set; }
        /// <summary>Standard warning out stream from the powershell execution</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Standard warning out stream from the powershell execution",
        SerializedName = @"warnings",
        PossibleTypes = new [] { typeof(string) })]
        string[] Warning { get;  }

    }
    /// Properties of a user-invoked script
    internal partial interface IScriptExecutionPropertiesInternal

    {
        /// <summary>Standard error output stream from the powershell execution</summary>
        string[] Error { get; set; }
        /// <summary>
        /// Error message if the script was able to run, but if the script itself had errors or powershell threw an exception
        /// </summary>
        string FailureReason { get; set; }
        /// <summary>Time the script execution was finished</summary>
        global::System.DateTime? FinishedAt { get; set; }
        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] HiddenParameter { get; set; }
        /// <summary>Standard information out stream from the powershell execution</summary>
        string[] Information { get; set; }
        /// <summary>User-defined dictionary.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionPropertiesNamedOutputs NamedOutput { get; set; }
        /// <summary>Standard output stream from the powershell execution</summary>
        string[] Output { get; set; }
        /// <summary>Parameters the script will accept</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IScriptExecutionParameter[] Parameter { get; set; }
        /// <summary>The state of the script execution resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.ScriptExecutionProvisioningState? ProvisioningState { get; set; }
        /// <summary>Time to live for the resource. If not provided, will be available for 60 days</summary>
        string Retention { get; set; }
        /// <summary>A reference to the script cmdlet resource if user is running a AVS script</summary>
        string ScriptCmdletId { get; set; }
        /// <summary>Time the script execution was started</summary>
        global::System.DateTime? StartedAt { get; set; }
        /// <summary>Time the script execution was submitted</summary>
        global::System.DateTime? SubmittedAt { get; set; }
        /// <summary>Time limit for execution</summary>
        string Timeout { get; set; }
        /// <summary>Standard warning out stream from the powershell execution</summary>
        string[] Warning { get; set; }

    }
}