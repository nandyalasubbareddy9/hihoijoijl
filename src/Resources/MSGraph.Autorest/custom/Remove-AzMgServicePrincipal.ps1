
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
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
.Description
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
System.Boolean
.Link
https://docs.microsoft.com/powershell/module/az.resources/remove-azmgserviceprincipal
#>
function Remove-AzMgServicePrincipal {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='ObjectIdParameterSet', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ObjectIdParameterSet', Mandatory)]
    [Alias('ServicePrincipalId', 'Id')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.String]
    # key: id of servicePrincipal
    ${ObjectId},

    [Parameter(ParameterSetName='ApplicationIdParameterSet', Mandatory)]
    [Alias('AppId')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.String]
    # key: application id
    ${ApplicationId},

    [Parameter(ParameterSetName='SPNParameterSet', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.String]
    # key: service principal name
    ${ServicePrincipalName},

    [Parameter(ParameterSetName='DisplayNameParameterSet', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [System.String]
    # key: display name
    ${DisplayName},

    [Parameter(ParameterSetName='InputObjectParameterSet', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphServicePrincipal]
    # key: service principal object
    ${InputObject},

    [Parameter(ParameterSetName='ApplicationObjectParameterSet', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphApplication]
    # key: application object
    ${ApplicationObject},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Header')]
    [System.String]
    # ETag
    ${IfMatch},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

process {
    switch ($PSCmdlet.ParameterSetName) {
        'ObjectIdParameterSet' {
            $PSBoundParameters['Id'] = $PSBoundParameters['ObjectId']
            $null = $PSBoundParameters.Remove('ObjectId')
            break
        }
        'ApplicationIdParameterSet' {
            try {
                $PSBoundParameters['Id'] = (Get-AzMgServicePrincipal -ApplicationId $PSBoundParameters['ApplicationId']).Id
            } catch {
                throw
            }
            $null = $PSBoundParameters.Remove('ApplicationId')
            break
        }
        'SPNParameterSet' {
            try {
                $PSBoundParameters['Id'] = (Get-AzMgServicePrincipal -ServicePrincipalName $PSBoundParameters['ServicePrincipalName']).Id
            } catch {
                throw
            }
            $null = $PSBoundParameters['ServicePrincipalName']
            break
        }
        'DisplayNameParameterSet' {
            try {
                $PSBoundParameters['Id'] = (Get-AzMgServicePrincipal -DisplayName $PSBoundParameters['DisplayName']).Id
            } catch {
                throw
            }
            $null = $PSBoundParameters.Remove['DisplayName']
            break
        }
        'InputObjectParameterSet' {
            $PSBoundParameters['Id'] = $PSBoundParameters['InputObject'].Id
            $null = $PSBoundParameters.Remove('InputObject')
            break
        }
        'ApplicationObjectParameterSet' {
            try {
                $PSBoundParameters['Id'] = (Get-AzMgServicePrincipal -ApplicationId $PSBoundParameters['ApplicationObject'].AppId).Id
            } catch {
                throw
            }
            $null = $PSBoundParameters.Remove('ApplicationObject')
            break
        }
        default {
            break
        }
    }

    MsGraph.Internal\Remove-AzMgServicePrincipal @PSBoundParameters
}
}
