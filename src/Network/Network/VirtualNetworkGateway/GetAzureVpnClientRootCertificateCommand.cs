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

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using System;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Get", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VpnClientRootCertificate"), OutputType(typeof(PSVpnClientRootCertificate))]
    public class GetAzureVpnClientRootCertificates : VirtualNetworkGatewayBaseCmdlet
    {
        [Alias("ResourceName")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The vpnclient root certificate name.")]
        [ValidateNotNullOrEmpty]
        public virtual string VpnClientRootCertificateName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The virtual network gateway name.")]
        [ResourceNameCompleter("Microsoft.Network/virtualNetworkGateways", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public virtual string VirtualNetworkGatewayName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The resource group name.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public virtual string ResourceGroupName { get; set; }

        public override void Execute()
        {
            base.Execute();
            var vnetGateway = this.GetVirtualNetworkGateway(this.ResourceGroupName, this.VirtualNetworkGatewayName);
            if (vnetGateway.VpnClientConfiguration == null)
            {
                throw new ArgumentException(string.Format(Properties.Resources.VirtualNetworkGatewayNoRootCertificate, VirtualNetworkGatewayName));
            }

            if (!string.IsNullOrEmpty(this.VpnClientRootCertificateName))
            {
                PSVpnClientRootCertificate rootCertificate = vnetGateway.VpnClientConfiguration.VpnClientRootCertificates.Find(cert => cert.Name.Equals(VpnClientRootCertificateName));
                if (rootCertificate == null)
                {
                    throw new ArgumentException(string.Format(Properties.Resources.ResourceNotFound, VpnClientRootCertificateName));
                }
                else
                {
                    WriteObject(rootCertificate);
                }
            }
            else
            {
                WriteObject(vnetGateway.VpnClientConfiguration.VpnClientRootCertificates, true);
            }
        }
    }
}
