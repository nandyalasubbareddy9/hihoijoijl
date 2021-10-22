﻿// ----------------------------------------------------------------------------------
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

using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Common;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Compute
{
    [Cmdlet("Add", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssGalleryApplication"), OutputType(typeof(PSVirtualMachineScaleSetVMProfile))]
    public class AddAzureVmssGalleryApplicationCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The PSVirtualMachineScaleSetVMProfile object to add a Gallery Application Reference ID.")]
        public PSVirtualMachineScaleSetVMProfile VirtualMachineScaleSetVM { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "VM Gallery Application Object.")]
        public PSVMGalleryApplication GalleryApplication { get; set; }

        [Parameter(
            Mandatory = false)]
        public int Order { get; set; }

        public override void ExecuteCmdlet()
        {
            if (VirtualMachineScaleSetVM.ApplicationProfile == null)
            {
                VirtualMachineScaleSetVM.ApplicationProfile = new ApplicationProfile();
            }
            if (VirtualMachineScaleSetVM.ApplicationProfile.GalleryApplications == null)
            {
                VirtualMachineScaleSetVM.ApplicationProfile.GalleryApplications = new List<VMGalleryApplication>();
            }

            if (this.IsParameterBound(c => c.Order))
            {
                GalleryApplication.Order = this.Order;
            }

            var VMgalleryApplication = new VMGalleryApplication();
            ComputeAutoMapperProfile.Mapper.Map<PSVMGalleryApplication, VMGalleryApplication>(GalleryApplication, VMgalleryApplication);
            VirtualMachineScaleSetVM.ApplicationProfile.GalleryApplications.Add(VMgalleryApplication);

            WriteObject(VirtualMachineScaleSetVM);
        }
    }
}
