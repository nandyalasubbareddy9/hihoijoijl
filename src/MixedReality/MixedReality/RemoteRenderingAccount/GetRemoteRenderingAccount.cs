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

using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.MixedReality.RemoteRenderingAccount
{
    using Management.MixedReality;
    using ResourceManager.Common;
    using ResourceManager.Common.ArgumentCompleters;

    [Cmdlet("Get", AzureRMConstants.AzureRMPrefix + ResourceType, DefaultParameterSetName = ListParameterSet)]
    [OutputType(typeof(PSRemoteRenderingAccount))]
    public sealed class GetRemoteRenderingAccount : RemoteRenderingAccountCmdletBase
    {
        public const string GetParameterSet = "GetParameterSet";
        public const string ListParameterSet = "ListParameterSet";

        [Parameter(Mandatory = true, ParameterSetName = GetParameterSet, HelpMessage = "Resource Group Name.")]
        [Parameter(Mandatory = false, ParameterSetName = ListParameterSet, HelpMessage = "Resource Group Name.")]
        [ResourceGroupCompleter()]
        [Alias("ResourceGroup")]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = GetParameterSet, HelpMessage = "Remote Rendering Account Name.")]
        [ResourceNameCompleter(FullQualifiedResourceType, nameof(ResourceGroupName))]
        [Alias("RemoteRenderingAccountName", "AccountName")]
        public string Name { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ResourceIdParameterSet, ValueFromPipelineByPropertyName = true, HelpMessage = "Resource ID of Remote Rendering Account.")]
        [ResourceIdCompleter(FullQualifiedResourceType)]
        [Alias("Id")]
        public string ResourceId { get; set; }

        public override void ExecuteCmdlet()
        {
            var result = default(object);
            var enumeration = default(bool);

            if (ParameterSetName == ListParameterSet)
            {
                var accounts = string.IsNullOrEmpty(this.ResourceGroupName)
                    ? Client.RemoteRenderingAccounts.EnumerateBySubscription()
                    : Client.RemoteRenderingAccounts.EnumerateByResourceGroup(this.ResourceGroupName);

                result = accounts.Select(_ => new PSRemoteRenderingAccount(_));
                enumeration = true;
            }
            else
            {
                if (ParameterSetName == ResourceIdParameterSet)
                {
                    var resourceId = new ResourceId(ResourceId);

                    ResourceGroupName = resourceId.ResourceGroupName;
                    Name = resourceId.ResourceName;
                }

                var account = Client.RemoteRenderingAccounts.Get(this.ResourceGroupName, this.Name);

                result = new PSRemoteRenderingAccount(account);
                enumeration = false;
            }

            WriteObject(result, enumeration);
        }
    }
}
