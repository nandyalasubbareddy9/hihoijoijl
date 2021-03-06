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
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.DataBoxEdge;
using Microsoft.Rest.Azure;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using ResourceModel = Microsoft.Azure.Management.DataBoxEdge.Models.BandwidthSchedule;
using PSResourceModel = Microsoft.Azure.PowerShell.Cmdlets.DataBoxEdge.Models.PSDataBoxEdgeBandWidthSchedule;
using PSTopLevelResourceModel = Microsoft.Azure.PowerShell.Cmdlets.DataBoxEdge.Models.PSDataBoxEdgeDevice;


namespace Microsoft.Azure.PowerShell.Cmdlets.DataBoxEdge.Common.Cmdlets.Bandwidth
{
    [Cmdlet(VerbsCommon.Get, Constants.BandwidthSchedule, DefaultParameterSetName = ListParameterSet
     ),
     OutputType(typeof(PSResourceModel))]
    public class DataBoxEdgeBandwidthGetCmdletBase : AzureDataBoxEdgeCmdletBase
    {
        private const string ListParameterSet = "ListParameterSet";
        private const string GetByNameParameterSet = "GetByNameParameterSet";
        private const string GetByResourceIdParameterSet = "GetByResourceIdParameterSet";
        private const string GetByParentObjectParameterSet = "GetByParentObjectParameterSet";

        [Parameter(Mandatory = true, ParameterSetName = GetByResourceIdParameterSet,
            HelpMessage = Constants.ResourceIdHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ListParameterSet,
            HelpMessage = Constants.ResourceGroupNameHelpMessage, Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet,
            HelpMessage = Constants.ResourceGroupNameHelpMessage, Position = 0)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = ListParameterSet,
            HelpMessage = Constants.DeviceNameHelpMessage, Position = 1)]
        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet,
            HelpMessage = Constants.DeviceNameHelpMessage, Position = 1)]
        [ResourceNameCompleter("Microsoft.DataBoxEdge/dataBoxEdgeDevices", nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        public string DeviceName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet, HelpMessage = Constants.NameHelpMessage,
            Position = 2)]
        [Parameter(Mandatory = false,
            ParameterSetName = GetByParentObjectParameterSet,
            HelpMessage = Constants.NameHelpMessage
        )]
        [ValidateNotNullOrEmpty]
        [ResourceNameCompleter("bandwidthSchedules", nameof(ResourceGroupName), nameof(DeviceName))]
        public string Name { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true,
            ParameterSetName = GetByParentObjectParameterSet,
            HelpMessage = Constants.PsDeviceObjectHelpMessage)]
        [ValidateNotNull]
        public PSTopLevelResourceModel DeviceObject;

        private ResourceModel GetResourceModel()
        {
            return BandwidthSchedulesOperationsExtensions.Get(
                this.DataBoxEdgeManagementClient.BandwidthSchedules,
                this.DeviceName,
                this.Name,
                this.ResourceGroupName);
        }

        private List<PSResourceModel> GetByResourceName()
        {
            var resourceModel = GetResourceModel();
            return new List<PSResourceModel>() {new PSResourceModel(resourceModel)};
        }

        private IPage<ResourceModel> ListResourceModel()
        {
            return BandwidthSchedulesOperationsExtensions.ListByDataBoxEdgeDevice(
                this.DataBoxEdgeManagementClient.BandwidthSchedules,
                this.DeviceName,
                this.ResourceGroupName);
        }

        private IPage<ResourceModel> ListResourceModel(string nextPageLink)
        {
            return BandwidthSchedulesOperationsExtensions.ListByDataBoxEdgeDeviceNext(
                this.DataBoxEdgeManagementClient.BandwidthSchedules,
                nextPageLink
            );
        }

        private List<PSResourceModel> ListPSResourceModels()
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                return GetByResourceName();
            }

            var resourceModel = ListResourceModel();
            var paginatedResult = new List<ResourceModel>(resourceModel);
            while (!string.IsNullOrEmpty(resourceModel.NextPageLink))
            {
                resourceModel = ListResourceModel(resourceModel.NextPageLink);
                paginatedResult.AddRange(resourceModel);
            }

            return paginatedResult.Select(t => new PSResourceModel(t)).ToList();
        }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.ResourceId))
            {
                var resourceIdentifier = new DataBoxEdgeResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.DeviceName = resourceIdentifier.DeviceName;
                this.Name = resourceIdentifier.ResourceName;
            }

            if (this.IsParameterBound(c => this.DeviceObject))
            {
                this.ResourceGroupName = this.DeviceObject.ResourceGroupName;
                this.DeviceName = this.DeviceObject.Name;
            }

            var results = ListPSResourceModels();
            WriteObject(results, true);
        }
    }
}