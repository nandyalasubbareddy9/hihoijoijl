// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>The properties of a server backup.</summary>
    public partial class ServerBackupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerBackupProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501.IServerBackupPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BackupType" /> property.</summary>
        private string _backupType;

        /// <summary>Backup type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string BackupType { get => this._backupType; set => this._backupType = value; }

        /// <summary>Backing field for <see cref="CompletedTime" /> property.</summary>
        private global::System.DateTime? _completedTime;

        /// <summary>Backup completed time (ISO8601 format).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public global::System.DateTime? CompletedTime { get => this._completedTime; set => this._completedTime = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private string _source;

        /// <summary>Backup source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string Source { get => this._source; set => this._source = value; }

        /// <summary>Creates an new <see cref="ServerBackupProperties" /> instance.</summary>
        public ServerBackupProperties()
        {

        }
    }
    /// The properties of a server backup.
    public partial interface IServerBackupProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>Backup type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup type.",
        SerializedName = @"backupType",
        PossibleTypes = new [] { typeof(string) })]
        string BackupType { get; set; }
        /// <summary>Backup completed time (ISO8601 format).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup completed time (ISO8601 format).",
        SerializedName = @"completedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CompletedTime { get; set; }
        /// <summary>Backup source</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup source",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(string) })]
        string Source { get; set; }

    }
    /// The properties of a server backup.
    internal partial interface IServerBackupPropertiesInternal

    {
        /// <summary>Backup type.</summary>
        string BackupType { get; set; }
        /// <summary>Backup completed time (ISO8601 format).</summary>
        global::System.DateTime? CompletedTime { get; set; }
        /// <summary>Backup source</summary>
        string Source { get; set; }

    }
}