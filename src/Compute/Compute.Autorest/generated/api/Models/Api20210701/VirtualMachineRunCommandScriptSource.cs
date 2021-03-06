// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>Describes the script sources for run command.</summary>
    public partial class VirtualMachineRunCommandScriptSource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IVirtualMachineRunCommandScriptSource,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IVirtualMachineRunCommandScriptSourceInternal
    {

        /// <summary>Backing field for <see cref="CommandId" /> property.</summary>
        private string _commandId;

        /// <summary>Specifies a commandId of predefined built-in script.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string CommandId { get => this._commandId; set => this._commandId = value; }

        /// <summary>Backing field for <see cref="Script" /> property.</summary>
        private string _script;

        /// <summary>Specifies the script content to be executed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Script { get => this._script; set => this._script = value; }

        /// <summary>Backing field for <see cref="ScriptUri" /> property.</summary>
        private string _scriptUri;

        /// <summary>Specifies the script download location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string ScriptUri { get => this._scriptUri; set => this._scriptUri = value; }

        /// <summary>Creates an new <see cref="VirtualMachineRunCommandScriptSource" /> instance.</summary>
        public VirtualMachineRunCommandScriptSource()
        {

        }
    }
    /// Describes the script sources for run command.
    public partial interface IVirtualMachineRunCommandScriptSource :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>Specifies a commandId of predefined built-in script.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies a commandId of predefined built-in script.",
        SerializedName = @"commandId",
        PossibleTypes = new [] { typeof(string) })]
        string CommandId { get; set; }
        /// <summary>Specifies the script content to be executed on the VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the script content to be executed on the VM.",
        SerializedName = @"script",
        PossibleTypes = new [] { typeof(string) })]
        string Script { get; set; }
        /// <summary>Specifies the script download location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the script download location.",
        SerializedName = @"scriptUri",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptUri { get; set; }

    }
    /// Describes the script sources for run command.
    internal partial interface IVirtualMachineRunCommandScriptSourceInternal

    {
        /// <summary>Specifies a commandId of predefined built-in script.</summary>
        string CommandId { get; set; }
        /// <summary>Specifies the script content to be executed on the VM.</summary>
        string Script { get; set; }
        /// <summary>Specifies the script download location.</summary>
        string ScriptUri { get; set; }

    }
}