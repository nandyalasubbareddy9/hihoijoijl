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
.SYNOPSIS
Gets valid resource group name
#>
function Get-ResourceGroupName
{
    return getAssetName
}

<#
.SYNOPSIS
Gets valid resource name
#>
function Get-ResourceName
{
    return getAssetName
}

<#
.SYNOPSIS
Gets valid virtual network name
#>
function Get-VirtualNetworkName
{
    return getAssetName
}

<#
.SYNOPSIS
Gets the default location for a provider
#>
function Get-ProviderLocation($provider)
{
	if ([Microsoft.Azure.Test.HttpRecorder.HttpMockServer]::Mode -ne [Microsoft.Azure.Test.HttpRecorder.HttpRecorderMode]::Playback)
	{
		$namespace = $provider.Split("/")[0]
		if($provider.Contains("/"))
		{
			$type = $provider.Substring($namespace.Length + 1)
			$location = Get-AzResourceProvider -ProviderNamespace $namespace | where {$_.ResourceTypes[0].ResourceTypeName -eq $type}

			if ($location -eq $null)
			{
				return "West US"
			} else
			{
				return $location.Locations[0]
			}
		}

		return "West US"
	}

	return "WestUS"
}

<#
.SYNOPSIS
Creates a resource group to use in tests
#>
function TestSetup-CreateResourceGroup
{
    $resourceGroupName = Get-ResourceGroupName
	$rglocation = Get-ProviderLocation "microsoft.compute"
    $resourceGroup = New-AzResourceGroup -Name $resourceGroupName -location $rglocation
	return $resourceGroup
}

<#
.SYNOPSIS
Creates a virtual network to use in tests
#>
function TestSetup-CreateVirtualNetwork($resourceGroup)
{
    $virtualNetworkName = Get-VirtualNetworkName
	$location = Get-ProviderLocation "microsoft.network/virtualNetworks"
    $virtualNetwork = New-AzVirtualNetwork -Name $virtualNetworkName -ResourceGroupName $resourceGroup.ResourceGroupName -Location $location -AddressPrefix "10.0.0.0/8"
	return $virtualNetwork
}

function Get-RandomZoneName
{
	$prefix = getAssetName;
	return $prefix + ".pstest.test" ;
}

function Get-TxtOfSpecifiedLength([int] $length)
{
	$returnValue = "";
	for ($i = 0; $i -lt $length ; $i++)
	{
		$returnValue += "a";
	}
	return $returnValue;
}