
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Get an ExpressRoute Circuit Authorization by name in a private cloud
.Description
Get an ExpressRoute Circuit Authorization by name in a private cloud
.Example
PS C:\> Get-AzVMwareAuthorization -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name                    Type                                       ResourceGroupName
----                    ----                                       -----------------
azps_test_authorization Microsoft.AVS/privateClouds/authorizations azps_test_group
.Example
PS C:\> Get-AzVMwareAuthorization -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Name azps_test_authorization

Name                    Type                                       ResourceGroupName
----                    ----                                       -----------------
azps_test_authorization Microsoft.AVS/privateClouds/authorizations azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IExpressRouteAuthorization
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwareauthorization
#>
function Get-AzVMwareAuthorization {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IExpressRouteAuthorization])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('AuthorizationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the ExpressRoute Circuit Authorization in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.VMware.private\Get-AzVMwareAuthorization_Get';
            GetViaIdentity = 'Az.VMware.private\Get-AzVMwareAuthorization_GetViaIdentity';
            List = 'Az.VMware.private\Get-AzVMwareAuthorization_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Get an cloud link by name in a private cloud
.Description
Get an cloud link by name in a private cloud
.Example
PS C:\> Get-AzVMwareCloudLink -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name                Type                                   ResourceGroupName
----                ----                                   -----------------
azps_test_cloudlink Microsoft.AVS/privateClouds/cloudLinks azps_test_group
.Example
PS C:\> Get-AzVMwareCloudLink -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Name azps_test_cloudlink

Name                Type                                   ResourceGroupName
----                ----                                   -----------------
azps_test_cloudlink Microsoft.AVS/privateClouds/cloudLinks azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICloudLink
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwarecloudlink
#>
function Get-AzVMwareCloudLink {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICloudLink])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('CloudLinkName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cloud link resource
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.VMware.private\Get-AzVMwareCloudLink_Get';
            GetViaIdentity = 'Az.VMware.private\Get-AzVMwareCloudLink_GetViaIdentity';
            List = 'Az.VMware.private\Get-AzVMwareCloudLink_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Get a cluster by name in a private cloud
.Description
Get a cluster by name in a private cloud
.Example
PS C:\> Get-AzVMwareCluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name              Type                                 ResourceGroupName
----              ----                                 -----------------
azps_test_cluster Microsoft.AVS/privateClouds/clusters azps_test_group
.Example
PS C:\> Get-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name              Type                                 ResourceGroupName
----              ----                                 -----------------
azps_test_cluster Microsoft.AVS/privateClouds/clusters azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwarecluster
#>
function Get-AzVMwareCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cluster in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.VMware.private\Get-AzVMwareCluster_Get';
            GetViaIdentity = 'Az.VMware.private\Get-AzVMwareCluster_GetViaIdentity';
            List = 'Az.VMware.private\Get-AzVMwareCluster_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Get a global reach connection by name in a private cloud
.Description
Get a global reach connection by name in a private cloud
.Example
PS C:\> Get-AzVMwareGlobalReachConnection -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name          Type                                               ResourceGroupName
----          ----                                               -----------------
azps_test_grc Microsoft.AVS/privateClouds/globalReachConnections azps_test_group
.Example
PS C:\> Get-AzVMwareGlobalReachConnection -Name azps_test_grc -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name          Type                                               ResourceGroupName
----          ----                                               -----------------
azps_test_grc Microsoft.AVS/privateClouds/globalReachConnections azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IGlobalReachConnection
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwareglobalreachconnection
#>
function Get-AzVMwareGlobalReachConnection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IGlobalReachConnection])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('GlobalReachConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the global reach connection in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.VMware.private\Get-AzVMwareGlobalReachConnection_Get';
            GetViaIdentity = 'Az.VMware.private\Get-AzVMwareGlobalReachConnection_GetViaIdentity';
            List = 'Az.VMware.private\Get-AzVMwareGlobalReachConnection_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
List the admin credentials for the private cloud
.Description
List the admin credentials for the private cloud
.Example
PS C:\> Get-AzVMwarePrivateCloudAdminCredential -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

NsxtUsername VcenterUsername
------------ ---------------
admin        cloudadmin@vsphere.local

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAdminCredentials
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwareprivatecloudadmincredential
#>
function Get-AzVMwarePrivateCloudAdminCredential {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAdminCredentials])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.VMware.private\Get-AzVMwarePrivateCloudAdminCredential_List';
        }
        if (('List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Get a private cloud
.Description
Get a private cloud
.Example
PS C:\> Get-AzVMwarePrivateCloud

Location      Name            Type
--------      ----            ----
australiaeast azps_test_cloud Microsoft.AVS/privateClouds
.Example
PS C:\> Get-AzVMwarePrivateCloud -ResourceGroupName azps_test_group

Location      Name            Type                        ResourceGroupName
--------      ----            ----                        -----------------
australiaeast azps_test_cloud Microsoft.AVS/privateClouds azps_test_group
.Example
PS C:\> Get-AzVMwarePrivateCloud -ResourceGroupName azps_test_group -Name azps_test_cloud

Location      Name            Type                        ResourceGroupName
--------      ----            ----                        -----------------
australiaeast azps_test_cloud Microsoft.AVS/privateClouds azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwareprivatecloud
#>
function Get-AzVMwarePrivateCloud {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud])]
[CmdletBinding(DefaultParameterSetName='List1', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('PrivateCloudName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='List1')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Get = 'Az.VMware.private\Get-AzVMwarePrivateCloud_Get';
            GetViaIdentity = 'Az.VMware.private\Get-AzVMwarePrivateCloud_GetViaIdentity';
            List = 'Az.VMware.private\Get-AzVMwarePrivateCloud_List';
            List1 = 'Az.VMware.private\Get-AzVMwarePrivateCloud_List1';
        }
        if (('Get', 'List', 'List1') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update an ExpressRoute Circuit Authorization in a private cloud
.Description
Create or update an ExpressRoute Circuit Authorization in a private cloud
.Example
PS C:\> New-AzVMwareAuthorization -Name azps_test_authorization -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name                    Type                                       ResourceGroupName
----                    ----                                       -----------------
azps_test_authorization Microsoft.AVS/privateClouds/authorizations azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IExpressRouteAuthorization
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwareauthorization
#>
function New-AzVMwareAuthorization {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IExpressRouteAuthorization])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('AuthorizationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the ExpressRoute Circuit Authorization in the private cloud
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.private\New-AzVMwareAuthorization_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update a cloud link in a private cloud
.Description
Create or update a cloud link in a private cloud
.Example
PS C:\> New-AzVMwareCloudLink -Name azps_test_cloudlink -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -LinkedCloud "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/azps_test_group2/providers/Microsoft.AVS/privateClouds/azps_test_cloud2/"

Name                Type                                   ResourceGroupName
----                ----                                   -----------------
azps_test_cloudlink Microsoft.AVS/privateClouds/cloudLinks azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICloudLink
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwarecloudlink
#>
function New-AzVMwareCloudLink {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICloudLink])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('CloudLinkName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cloud link resource
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Identifier of the other private cloud participating in the link.
    ${LinkedCloud},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.private\New-AzVMwareCloudLink_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update a cluster in a private cloud
.Description
Create or update a cluster in a private cloud
.Example
PS C:\> New-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -ClusterSize 3 -SkuName av36

Name              Type                                 ResourceGroupName
----              ----                                 -----------------
azps_test_cluster Microsoft.AVS/privateClouds/clusters azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwarecluster
#>
function New-AzVMwareCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cluster in the private cloud
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The name of the SKU.
    ${SkuName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The cluster size
    ${ClusterSize},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.private\New-AzVMwareCluster_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update a global reach connection in a private cloud
.Description
Create or update a global reach connection in a private cloud
.Example
PS C:\> New-AzVMwareGlobalReachConnection -Name azps_test_grc -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -AuthorizationKey "df530ffb-5a57-4437-a3eb-08e4c73ce011" -PeerExpressRouteResourceId "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/tnt16-cust-mp01-mock01/providers/Microsoft.Network/expressRouteCircuits/tnt16-cust-mp01-mock01-er"

Name          Type                                               ResourceGroupName
----          ----                                               -----------------
azps_test_grc Microsoft.AVS/privateClouds/globalReachConnections azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IGlobalReachConnection
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwareglobalreachconnection
#>
function New-AzVMwareGlobalReachConnection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IGlobalReachConnection])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('GlobalReachConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the global reach connection in the private cloud
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Authorization key from the peer express route used for the global reach connection
    ${AuthorizationKey},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Identifier of the ExpressRoute Circuit to peer with in the global reach connection
    ${PeerExpressRouteResourceId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.private\New-AzVMwareGlobalReachConnection_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Rotate the NSX-T Manager password
.Description
Rotate the NSX-T Manager password
.Example
PS C:\> New-AzVMwarePrivateCloudNsxtPassword -ResourceGroupName azps_test_group -PrivateCloudName azps_test_cloud -PassThru

True

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwareprivatecloudnsxtpassword
#>
function New-AzVMwarePrivateCloudNsxtPassword {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Rotate', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Rotate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Rotate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Rotate')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RotateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Rotate = 'Az.VMware.private\New-AzVMwarePrivateCloudNsxtPassword_Rotate';
            RotateViaIdentity = 'Az.VMware.private\New-AzVMwarePrivateCloudNsxtPassword_RotateViaIdentity';
        }
        if (('Rotate') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Rotate the vCenter password
.Description
Rotate the vCenter password
.Example
PS C:\> New-AzVMwarePrivateCloudVcenterPassword -ResourceGroupName azps_test_group -PrivateCloudName azps_test_cloud -PassThru

True

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwareprivatecloudvcenterpassword
#>
function New-AzVMwarePrivateCloudVcenterPassword {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Rotate', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Rotate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Rotate', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Rotate')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='RotateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Rotate = 'Az.VMware.private\New-AzVMwarePrivateCloudVcenterPassword_Rotate';
            RotateViaIdentity = 'Az.VMware.private\New-AzVMwarePrivateCloudVcenterPassword_RotateViaIdentity';
        }
        if (('Rotate') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete an ExpressRoute Circuit Authorization in a private cloud
.Description
Delete an ExpressRoute Circuit Authorization in a private cloud
.Example
PS C:\> Remove-AzVMwareAuthorization -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Name azps_test_authorization

.Example
PS C:\> Get-AzVMwareAuthorization -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Name azps_test_authorization | Remove-AzVMwareAuthorization


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwareauthorization
#>
function Remove-AzVMwareAuthorization {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('AuthorizationName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the ExpressRoute Circuit Authorization in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.private\Remove-AzVMwareAuthorization_Delete';
            DeleteViaIdentity = 'Az.VMware.private\Remove-AzVMwareAuthorization_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete a cloud link in a private cloud
.Description
Delete a cloud link in a private cloud
.Example
PS C:\> Remove-AzVMwareCloudLink -Name azps_test_cloudlink -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

.Example
PS C:\> Get-AzVMwareCloudLink -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Name azps_test_cloudlink | Remove-AzVMwareCloudLink


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwarecloudlink
#>
function Remove-AzVMwareCloudLink {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('CloudLinkName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cloud link resource
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.private\Remove-AzVMwareCloudLink_Delete';
            DeleteViaIdentity = 'Az.VMware.private\Remove-AzVMwareCloudLink_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete a cluster in a private cloud
.Description
Delete a cluster in a private cloud
.Example
PS C:\> Remove-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

.Example
PS C:\> Get-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group | Remove-AzVMwareCluster


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwarecluster
#>
function Remove-AzVMwareCluster {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cluster in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.private\Remove-AzVMwareCluster_Delete';
            DeleteViaIdentity = 'Az.VMware.private\Remove-AzVMwareCluster_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete a global reach connection in a private cloud
.Description
Delete a global reach connection in a private cloud
.Example
PS C:\> Remove-AzVMwareGlobalReachConnection -Name azps_test_grc -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

.Example
PS C:\> Get-AzVMwareGlobalReachConnection -Name azps_test_grc -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group | Remove-AzVMwareGlobalReachConnection


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwareglobalreachconnection
#>
function Remove-AzVMwareGlobalReachConnection {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('GlobalReachConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the global reach connection in the private cloud
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.private\Remove-AzVMwareGlobalReachConnection_Delete';
            DeleteViaIdentity = 'Az.VMware.private\Remove-AzVMwareGlobalReachConnection_DeleteViaIdentity';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Return quota for subscription by region
.Description
Return quota for subscription by region
.Example
PS C:\> Test-AzVMwareLocationQuotaAvailability -Location centralus

Enabled
-------
Enabled

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IQuota
.Link
https://docs.microsoft.com/powershell/module/az.vmware/test-azvmwarelocationquotaavailability
#>
function Test-AzVMwareLocationQuotaAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IQuota])]
[CmdletBinding(DefaultParameterSetName='Check', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Azure region
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Check = 'Az.VMware.private\Test-AzVMwareLocationQuotaAvailability_Check';
        }
        if (('Check') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Return trial status for subscription by region
.Description
Return trial status for subscription by region
.Example
PS C:\> Test-AzVMwareLocationTrialAvailability -Location westcentralus

AvailableHost Status
------------- ------
0             TrialDisabled

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ITrial
.Link
https://docs.microsoft.com/powershell/module/az.vmware/test-azvmwarelocationtrialavailability
#>
function Test-AzVMwareLocationTrialAvailability {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ITrial])]
[CmdletBinding(DefaultParameterSetName='Check', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Azure region
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Check = 'Az.VMware.private\Test-AzVMwareLocationTrialAvailability_Check';
        }
        if (('Check') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Update a cluster in a private cloud
.Description
Update a cluster in a private cloud
.Example
PS C:\> Update-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -ClusterSize 4

Name              Type                                 ResourceGroupName
----              ----                                 -----------------
azps_test_cluster Microsoft.AVS/privateClouds/clusters azps_test_group
.Example
PS C:\> Get-AzVMwareCluster -Name azps_test_cluster -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group | Update-AzVMwareCluster -ClusterSize 4

Name              Type                                 ResourceGroupName
----              ----                                 -----------------
azps_test_cluster Microsoft.AVS/privateClouds/clusters azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/update-azvmwarecluster
#>
function Update-AzVMwareCluster {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ICluster])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('ClusterName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the cluster in the private cloud
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The cluster size
    ${ClusterSize},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.VMware.private\Update-AzVMwareCluster_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.VMware.private\Update-AzVMwareCluster_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Update a private cloud
.Description
Update a private cloud
.Example
PS C:\> Update-AzVMwarePrivateCloud -Name azps_test_cloud -ResourceGroupName azps_test_group -ManagementClusterSize 4

Location      Name            Type                        ResourceGroupName
--------      ----            ----                        -----------------
australiaeast azps_test_cloud Microsoft.AVS/privateClouds azps_test_group
.Example
PS C:\> Get-AzVMwarePrivateCloud -ResourceGroupName azps_test_group -Name azps_test_cloud | Update-AzVMwarePrivateCloud -ManagementClusterSize 4

Location      Name            Type                        ResourceGroupName
--------      ----            ----                        -----------------
australiaeast azps_test_cloud Microsoft.AVS/privateClouds azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

IDENTITYSOURCE <IIdentitySource[]>: vCenter Single Sign On Identity Sources
  [Alias <String>]: The domain's NetBIOS name
  [BaseGroupDn <String>]: The base distinguished name for groups
  [BaseUserDn <String>]: The base distinguished name for users
  [Domain <String>]: The domain's dns name
  [Name <String>]: The name of the identity source
  [Password <String>]: The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups.
  [PrimaryServer <String>]: Primary server URL
  [SecondaryServer <String>]: Secondary server URL
  [Ssl <SslEnum?>]: Protect LDAP communication using SSL certificate (LDAPS)
  [Username <String>]: The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/update-azvmwareprivatecloud
#>
function Update-AzVMwarePrivateCloud {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Alias('PrivateCloudName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IIdentitySource[]]
    # vCenter Single Sign On Identity Sources
    # To construct, see NOTES section for IDENTITYSOURCE properties and create a hash table.
    ${IdentitySource},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum]
    # Connectivity to internet is enabled or disabled
    ${Internet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The cluster size
    ${ManagementClusterSize},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            UpdateExpanded = 'Az.VMware.private\Update-AzVMwarePrivateCloud_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.VMware.private\Update-AzVMwarePrivateCloud_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Get an addon by name in a private cloud
.Description
Get an addon by name in a private cloud
.Example
PS C:\> Get-AzVMwareAddon -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name Type                               ResourceGroupName
---- ----                               -----------------
srm  Microsoft.AVS/privateClouds/addons azps_test_group
vr   Microsoft.AVS/privateClouds/addons azps_test_group
.Example
PS C:\> Get-AzVMwareAddon -AddonType vr -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

Name Type                               ResourceGroupName
---- ----                               -----------------
vr   Microsoft.AVS/privateClouds/addons azps_test_group

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAddon
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/get-azvmwareaddon
#>
function Get-AzVMwareAddon {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAddon])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='List', Mandatory)]
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='List', Mandatory)]
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='List')]
    [Parameter(ParameterSetName='Get')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('AddonName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the addon for the private cloud
    ${AddonType},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            List = 'Az.VMware.custom\Get-AzVMwareAddon';
            Get = 'Az.VMware.custom\Get-AzVMwareAddon';
            GetViaIdentity = 'Az.VMware.custom\Get-AzVMwareAddon';
        }
        if (('List', 'Get') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update a addon in a private cloud
.Description
Create or update a addon in a private cloud
.Example
PS C:\> $data = New-AzVMwareAddonVrPropertiesObject -VrsCount 2
PS C:\> New-AzVMwareAddon -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group -Property $data

Name Type                               ResourceGroupName
---- ----                               -----------------
vr   Microsoft.AVS/privateClouds/addons azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAddon
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PROPERTY <IAddonProperties>: The properties of an addon resource
  AddonType <AddonType>: The type of private cloud addon
.Link
https://docs.microsoft.com/powershell/module/az.vmware/new-azvmwareaddon
#>
function New-AzVMwareAddon {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAddon])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the private cloud.
    ${PrivateCloudName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IAddonProperties]
    # The properties of an addon resource
    # To construct, see NOTES section for PROPERTY properties and create a hash table.
    ${Property},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.custom\New-AzVMwareAddon';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create a in-memory object for AddonSrmProperties
.Description
Create a in-memory object for AddonSrmProperties
.Example
PS C:\> New-AzVMwareAddonSrmPropertiesObject -LicenseKey "YourLicenseKeyValue"

AddonType ProvisioningState LicenseKey
--------- ----------------- ----------
SRM                         YourLicenseKeyValue

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.AddonSrmProperties
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwareAddonSrmPropertiesObject
#>
function New-AzVMwareAddonSrmPropertiesObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.AddonSrmProperties])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The Site Recovery Manager (SRM) license.
    ${LicenseKey}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwareAddonSrmPropertiesObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create a in-memory object for AddonVrProperties
.Description
Create a in-memory object for AddonVrProperties
.Example
PS C:\> New-AzVMwareAddonVrPropertiesObject -VrsCount 2

AddonType ProvisioningState VrsCount
--------- ----------------- --------
VR                          2

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.AddonVrProperties
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwareAddonVrPropertiesObject
#>
function New-AzVMwareAddonVrPropertiesObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.AddonVrProperties])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The vSphere Replication Server (VRS) count.
    ${VrsCount}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwareAddonVrPropertiesObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create or update a private cloud
.Description
Create or update a private cloud
.Example
PS C:\> New-AzVMwarePrivateCloud -Name azps_test_cloud -ResourceGroupName azps_test_group -NetworkBlock 192.168.48.0/22 -Sku av36 -ManagementClusterSize 3 -Location australiaeast

Location      Name            Type                        ResourceGroupName
--------      ----            ----                        -----------------
australiaeast azps_test_cloud Microsoft.AVS/privateClouds azps_test_group

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-azVMwareprivatecloud
#>
function New-AzVMwarePrivateCloud {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.IPrivateCloud])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('PrivateCloudName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The block of addresses should be unique across VNet in your subscription as well as on-premise.
    # Make sure the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22
    ${NetworkBlock},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The name of the SKU.
    ${Sku},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Int32]
    # The cluster size
    ${ManagementClusterSize},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum])]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Support.InternetEnum]
    # Connectivity to internet is enabled or disabled
    ${Internet},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Optionally, set the NSX-T Manager password when the private cloud is created
    ${NsxtPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # Optionally, set the vCenter admin password when the private cloud is created
    ${VcenterPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Accept EULA of AVS, legal term will pop up without this parameter provided
    ${AcceptEULA},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            CreateExpanded = 'Az.VMware.custom\New-AzVMwarePrivateCloud';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create a in-memory object for PSCredentialExecutionParameter
.Description
Create a in-memory object for PSCredentialExecutionParameter
.Example
PS C:\> New-AzVMwarePSCredentialExecutionParameterObject -Name azps_test_credentialvalue -Password "passwordValue" -Username "usernameValue"

Name                      Type       Password      Username
----                      ----       --------      --------
azps_test_credentialvalue Credential passwordValue usernameValue

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.PsCredentialExecutionParameter
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwarePSCredentialExecutionParameterObject
#>
function New-AzVMwarePSCredentialExecutionParameterObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.PSCredentialExecutionParameter])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The parameter name.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # password for login.
    ${Password},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # username for login.
    ${Username}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwarePSCredentialExecutionParameterObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create a in-memory object for ScriptSecureStringExecutionParameter
.Description
Create a in-memory object for ScriptSecureStringExecutionParameter
.Example
PS C:\> New-AzVMwareScriptSecureStringExecutionParameterObject -Name azps_test_securevalue -SecureValue "passwordValue"

Name                  Type        SecureValue
----                  ----        -----------
azps_test_securevalue SecureValue passwordValue

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptSecureStringExecutionParameter
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwareScriptSecureStringExecutionParameterObject
#>
function New-AzVMwareScriptSecureStringExecutionParameterObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptSecureStringExecutionParameter])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The parameter name.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # A secure value for the passed parameter, not to be stored in logs.
    ${SecureValue}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwareScriptSecureStringExecutionParameterObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Create a in-memory object for ScriptStringExecutionParameter
.Description
Create a in-memory object for ScriptStringExecutionParameter
.Example
PS C:\> New-AzVMwareScriptStringExecutionParameterObject -Name azps_test_stringvalue -Value "stringValue"

Name                  Type   Value
----                  ----   -----
azps_test_stringvalue Value  stringValue

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptStringExecutionParameter
.Link
https://docs.microsoft.com/powershell/module/az.VMware/new-AzVMwareScriptStringExecutionParameterObject
#>
function New-AzVMwareScriptStringExecutionParameterObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.Api20210601.ScriptStringExecutionParameter])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The parameter name.
    ${Name},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Body')]
    [System.String]
    # The value for the passed parameter.
    ${Value}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            __AllParameterSets = 'Az.VMware.custom\New-AzVMwareScriptStringExecutionParameterObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete a addon in a private cloud
.Description
Delete a addon in a private cloud
.Example
PS C:\> Remove-AzVMwareAddon -AddonType vr -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group

.Example
PS C:\> Get-AzVMwareAddon -AddonType vr -PrivateCloudName azps_test_cloud -ResourceGroupName azps_test_group | Remove-AzVMwareAddon


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwareaddon
#>
function Remove-AzVMwareAddon {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('AddonName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the addon for the private cloud
    ${AddonType},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${PrivateCloudName},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.custom\Remove-AzVMwareAddon';
            DeleteViaIdentity = 'Az.VMware.custom\Remove-AzVMwareAddon';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}

<#
.Synopsis
Delete a private cloud
.Description
Delete a private cloud
.Example
PS C:\> Remove-AzVMwarePrivateCloud -ResourceGroupName azps_test_group -Name azps_test_cloud

.Example
PS C:\> Get-AzVMwarePrivateCloud -ResourceGroupName azps_test_group -Name azps_test_cloud | Remove-AzVMwarePrivateCloud


.Inputs
Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IVMwareIdentity>: Identity Parameter
  [AddonName <String>]: Name of the addon for the private cloud
  [AuthorizationName <String>]: Name of the ExpressRoute Circuit Authorization in the private cloud
  [CloudLinkName <String>]: Name of the cloud link resource
  [ClusterName <String>]: Name of the cluster in the private cloud
  [DatastoreName <String>]: Name of the datastore in the private cloud cluster
  [DhcpId <String>]: NSX DHCP identifier. Generally the same as the DHCP display name
  [DnsServiceId <String>]: NSX DNS Service identifier. Generally the same as the DNS Service's display name
  [DnsZoneId <String>]: NSX DNS Zone identifier. Generally the same as the DNS Zone's display name
  [GatewayId <String>]: NSX Gateway identifier. Generally the same as the Gateway's display name
  [GlobalReachConnectionName <String>]: Name of the global reach connection in the private cloud
  [HcxEnterpriseSiteName <String>]: Name of the HCX Enterprise Site in the private cloud
  [Id <String>]: Resource identity path
  [Location <String>]: Azure region
  [PortMirroringId <String>]: NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
  [PrivateCloudName <String>]: Name of the private cloud
  [PublicIPId <String>]: NSX Public IP Block identifier. Generally the same as the Public IP Block's display name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScriptCmdletName <String>]: Name of the script cmdlet resource in the script package in the private cloud
  [ScriptExecutionName <String>]: Name of the user-invoked script execution resource
  [ScriptPackageName <String>]: Name of the script package in the private cloud
  [SegmentId <String>]: NSX Segment identifier. Generally the same as the Segment's display name
  [SubscriptionId <String>]: The ID of the target subscription.
  [VMGroupId <String>]: NSX VM Group identifier. Generally the same as the VM Group's display name
  [VirtualMachineId <String>]: Virtual Machine identifier
.Link
https://docs.microsoft.com/powershell/module/az.vmware/remove-azvmwareprivatecloud
#>
function Remove-AzVMwarePrivateCloud {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Delete', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Alias('PrivateCloudName')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # Name of the private cloud
    ${Name},

    [Parameter(ParameterSetName='Delete', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Delete')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='DeleteViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IVMwareIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.VMware.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Delete = 'Az.VMware.custom\Remove-AzVMwarePrivateCloud';
            DeleteViaIdentity = 'Az.VMware.custom\Remove-AzVMwarePrivateCloud';
        }
        if (('Delete') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
