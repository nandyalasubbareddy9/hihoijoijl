// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models;
using Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.ProviderModel;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets
{
    /// <summary>
    /// Fetches backup management servers registered to the recovery services vault.
    /// </summary>
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "RecoveryServicesBackupManagementServer"),OutputType(typeof(BackupEngineBase))]
    public class GetAzureRmRecoveryServicesBackupManagementServer
        : RSBackupVaultCmdletBase
    {
        /// <summary>
        /// Name of the backup management server(s) to be fetched.
        /// </summary>
        [Parameter(Mandatory = false, Position = 1,
            HelpMessage = ParamHelpMsgs.Container.Name)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        public override void ExecuteCmdlet()
        {
            ExecutionBlock(() =>
            {
                base.ExecuteCmdlet();

                ResourceIdentifier resourceIdentifier = new ResourceIdentifier(VaultId);
                string vaultName = resourceIdentifier.ResourceName;
                string resourceGroupName = resourceIdentifier.ResourceGroupName;

                PsBackupProviderManager providerManager = new PsBackupProviderManager(
                    new Dictionary<System.Enum, object>()
                    {
                        { VaultParams.VaultName, vaultName },
                        { VaultParams.ResourceGroupName, resourceGroupName },
                        { ContainerParams.ContainerType, ContainerType.Windows },
                        { ContainerParams.Name, Name }
                    }, ServiceClientAdapter);

                IPsBackupProvider psBackupProvider =
                    providerManager.GetProviderInstanceForBackupManagementServer();

                var backupServerModels = psBackupProvider.ListBackupManagementServers();
                if (!string.IsNullOrEmpty(this.Name))
                {
                    if (backupServerModels != null)
                    {
                        backupServerModels = backupServerModels.Where(x => x.Name == this.Name).ToList();
                    }
                }
                WriteObject(backupServerModels, enumerateCollection: true);
            });
        }
    }
}
