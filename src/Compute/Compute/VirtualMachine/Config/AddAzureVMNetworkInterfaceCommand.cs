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
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.Azure.Management.Internal.Network.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;

namespace Microsoft.Azure.Commands.Compute
{
    /// <summary>
    /// Setup the network interface.
    /// </summary>
    [Cmdlet("Add", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VMNetworkInterface",DefaultParameterSetName = NicIdParamSetName),OutputType(typeof(PSVirtualMachine))]
    public class AddAzureVMNetworkInterfaceCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        protected const string NicIdParamSetName = "GetNicFromNicId";
        protected const string NicObjectParamSetName = "GetNicFromNicObject";

        [Alias("VMProfile")]
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = NicIdParamSetName,
            HelpMessage = HelpMessages.VMProfile)]
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = NicObjectParamSetName,
            HelpMessage = HelpMessages.VMProfile)]
        [ValidateNotNullOrEmpty]
        public PSVirtualMachine VM { get; set; }

        [Alias("NicId", "NetworkInterfaceId")]
        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = HelpMessages.VMNetworkInterfaceID,
            ParameterSetName = NicIdParamSetName)]
        [ValidateNotNullOrEmpty]
        public string Id { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipeline = true,
            ParameterSetName = NicObjectParamSetName)]
        [ValidateNotNullOrEmpty]
        public List<INetworkInterfaceReference> NetworkInterface { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true,
            ParameterSetName = NicIdParamSetName)]
        [ValidateNotNullOrEmpty]
        public SwitchParameter Primary { get; set; }

        [Parameter(
           Mandatory = false,
           ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Delete", "Detach")]
        public string DeleteOption { get; set; }

        public override void ExecuteCmdlet()
        {
            var networkProfile = this.VM.NetworkProfile;

            if (networkProfile == null)
            {
                networkProfile = new NetworkProfile
                {
                    NetworkInterfaces = new List<NetworkInterfaceReference>()
                };
            }

            if (networkProfile.NetworkInterfaces == null)
            {
                networkProfile.NetworkInterfaces = new List<NetworkInterfaceReference>();
            }

            if (this.ParameterSetName.Equals(NicIdParamSetName))
            {
                if (!this.Primary.IsPresent)
                {
                    if (!networkProfile.NetworkInterfaces.Any(e => e.Id.Equals(this.Id)))
                    {
                        networkProfile.NetworkInterfaces.Add(new NetworkInterfaceReference
                        {
                            Id = this.Id,
                        });
                    }

                    if (networkProfile.NetworkInterfaces.Count > 1)
                    {
                        // run through the entire list of networkInterfaces and if Primary is not set, set them to false
                        foreach (var nic in networkProfile.NetworkInterfaces)
                        {
                            nic.Primary = nic.Primary ?? false;
                        }
                    }
                }
                else
                {
                    foreach (var networkInterfaceReference in networkProfile.NetworkInterfaces)
                    {
                        networkInterfaceReference.Primary = false;
                    }

                    var existingNic = networkProfile.NetworkInterfaces.FirstOrDefault(e => e.Id.Equals(this.Id));
                    if (existingNic == null)
                    {
                        networkProfile.NetworkInterfaces.Add(
                            new NetworkInterfaceReference
                            {
                                Id = this.Id,
                                Primary = true
                            });
                    }
                    else
                    {
                        existingNic.Primary = true;
                    }
                }

                if (!string.IsNullOrEmpty(this.DeleteOption))
                {
                    var existingNic = networkProfile.NetworkInterfaces.FirstOrDefault(e => e.Id.Equals(this.Id));
                    existingNic.DeleteOption = this.DeleteOption;
                }
            }
            else
            { // Nic Object Parameter Set
                foreach (var nic in this.NetworkInterface)
                {
                    var existingNic = networkProfile.NetworkInterfaces.FirstOrDefault(e => e.Id.Equals(nic.Id));

                    if (existingNic == null)
                    {
                        networkProfile.NetworkInterfaces.Add(
                            new NetworkInterfaceReference
                            {
                                Id = nic.Id,
                                Primary = nic.Primary,
                                DeleteOption = this.IsParameterBound(c => c.DeleteOption) ? this.DeleteOption : null
                            });
                    }
                    else
                    {
                        existingNic.Primary = nic.Primary;
                        if (this.IsParameterBound(c => c.DeleteOption))
                        {
                            existingNic.DeleteOption = this.DeleteOption;
                        }
                    }
                }
            }

            this.VM.NetworkProfile = networkProfile;

            WriteObject(this.VM);
        }
    }
}
