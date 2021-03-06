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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net;
using Microsoft.Azure.Commands.Cdn.Common;
using Microsoft.Azure.Commands.Cdn.Helpers;
using Microsoft.Azure.Commands.Cdn.Models.Endpoint;
using Microsoft.Azure.Commands.Cdn.Properties;
using Microsoft.Azure.Management.Cdn;
using Microsoft.Azure.Management.Cdn.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Cdn.Endpoint
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "CdnDeliveryPolicy"), OutputType(typeof(PSDeliveryPolicy))]
    public class NewAzCdnDeliveryPolicy : AzureCdnCmdletBase
    {
        [Parameter(Mandatory = false, HelpMessage = "Description of the policy")]
        public string Description { get; set; }

        [Parameter(Mandatory = true, HelpMessage = "A list of deliveryRules.")]
        public PSDeliveryRule[] Rule { get; set; }

        public override void ExecuteCmdlet()
        {
            var deliveryPolicy = new PSDeliveryPolicy
            {
                Description = Description,
                Rules = Rule
            };

            WriteObject(deliveryPolicy);
        }
    }
}
