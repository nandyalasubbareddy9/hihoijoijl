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
// ------------------------------------

using System.Management.Automation;
using Microsoft.Azure.Commands.SecurityInsights;
using Microsoft.Azure.Commands.SecurityInsights.Common;
using Microsoft.Azure.Commands.SecurityInsights.Models.AlertRules;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.SecurityInsights.Models.Actions;
using Microsoft.Azure.Management.SecurityInsights;

namespace Microsoft.Azure.Commands.SecurityInsights.Cmdlets.Actions
{
    [Cmdlet(VerbsCommon.Remove, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SentinelAlertRuleAction", DefaultParameterSetName = ParameterSetNames.ActionId, SupportsShouldProcess = true), OutputType(typeof(PSSentinelActionResponse))]
    public class RemoveAlertRuleActions : SecurityInsightsCmdletBase
    {
        [Parameter(ParameterSetName = ParameterSetNames.ActionId, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.ResourceGroupName)]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ActionId, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.WorkspaceName)]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ActionId, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = ParameterHelpMessages.AlertRuleId)]
        [ValidateNotNullOrEmpty]
        public string AlertRuleId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ActionId, Mandatory = true, HelpMessage = ParameterHelpMessages.ActionId)]
        [ValidateNotNullOrEmpty]
        public string ActionId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.InputObject, Mandatory = true, ValueFromPipeline = true, HelpMessage = ParameterHelpMessages.InputObject)]
        [ValidateNotNullOrEmpty]
        public PSSentinelActionResponse InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = ParameterHelpMessages.PassThru)]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            var name = ActionId;
            var alertrule = AlertRuleId;
            var resourcegroup = ResourceGroupName;
            var workspacename = WorkspaceName;
            switch (ParameterSetName)
            {
                case ParameterSetNames.ActionId:
                    break;
                case ParameterSetNames.InputObject:
                    name = InputObject.Name;
                    alertrule = AzureIdUtilities.GetAlertRuleName(InputObject.Id);
                    workspacename = AzureIdUtilities.GetWorkspaceName(InputObject.Id);
                    resourcegroup = AzureIdUtilities.GetResourceGroup(InputObject.Id);
                    break;
                default:
                    throw new PSInvalidOperationException();
            }

            if (ShouldProcess(name, VerbsCommon.Remove))
            {
                var result = SecurityInsightsClient.Actions.DeleteWithHttpMessagesAsync(resourcegroup, workspacename, alertrule, name).Result;
                if (result.Response.StatusCode == (System.Net.HttpStatusCode)200)
                {
                    System.Console.WriteLine("success");
                }
                else if (result.Response.StatusCode == (System.Net.HttpStatusCode)204)
                {
                    System.Console.WriteLine("success");
                }
            }

            if (PassThru.IsPresent)
            {
                WriteObject(true);
            }
        }
    }
}
