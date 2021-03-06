$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzMigrateServerReplication.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzMigrateServerReplication' {
    It 'ByIdDefaultUser' -skip {
         $output = New-AzMigrateServerReplication -MachineId $env.srsSDSMachineId1  -LicenseType $env.srsLicense -TargetResourceGroupId $env.srsTargetRGId -TargetNetworkId $env.srsTgtNId -TargetSubnetName default -TargetVMName $env.srsTgtVMName -DiskType $env.srsDiskType -OSDiskID $env.srsDiskId1 -SubscriptionId $env.srsSubscriptionId
         $output.Count | Should -BeGreaterOrEqual 1 
    }

    It 'ByIdPowerUser' -skip {
        $OSDisk = New-AzMigrateDiskMapping -DiskID $env.srsDiskId -DiskType $env.srsDiskType -IsOSDisk 'true'
        $output = New-AzMigrateServerReplication -MachineId $env.srsSDSMachineId -LicenseType $env.srsLicense -TargetResourceGroupId $env.srsTargetRGId -TargetNetworkId $env.srsTgtNId -TargetSubnetName default -TargetVMName $env.srsTgtVMName -DiskToInclude $OSDisk -PerformAutoResync true -SubscriptionId $env.srsSubscriptionId
        $output.Count | Should -BeGreaterOrEqual 1 
    }

    It 'ByInputObjectDefaultUser' -skip {
        $obj = Get-AzMigrateDiscoveredServer  -ResourceGroupName $env.migResourceGroup -ProjectName $env.srsProjectName -SubscriptionId $env.srsSubscriptionId
    $obj.Count | Should -BeGreaterOrEqual 1 
        $temp = ""
        foreach($ob in $obj){if($ob.Id -eq $env.srsSDSMachineId2){$temp = $ob}}
        $output = New-AzMigrateServerReplication -InputObject $temp -LicenseType $env.srsLicense -TargetResourceGroupId $env.srsTargetRGId -TargetNetworkId $env.srsTgtNId -TargetSubnetName default -TargetVMName $env.srsTgtVMName -DiskType $env.srsDiskType -OSDiskID $env.srsDiskId2 -SubscriptionId $env.srsSubscriptionId
        $output.Count | Should -BeGreaterOrEqual 1 
    }

    It 'ByInputObjectPowerUser' -skip {
        $OSDisk = New-AzMigrateDiskMapping -DiskID $env.srsDiskId3 -DiskType $env.srsDiskType -IsOSDisk 'true'
        $obj = Get-AzMigrateDiscoveredServer  -ResourceGroupName $env.migResourceGroup -ProjectName $env.srsProjectName -SubscriptionId $env.srsSubscriptionId
        $obj.Count | Should -BeGreaterOrEqual 1 
        $temp = ""
        foreach($ob in $obj){if($ob.Id -eq $env.srsSDSMachineId3){$temp = $ob}}
        $output = New-AzMigrateServerReplication -InputObject $temp -LicenseType $env.srsLicense -TargetResourceGroupId $env.srsTargetRGId -TargetNetworkId $env.srsTgtNId -TargetSubnetName default -TargetVMName $env.srsTgtVMName -DiskToInclude $OSDisk -PerformAutoResync true -SubscriptionId $env.srsSubscriptionId
        $output.Count | Should -BeGreaterOrEqual 1 
    }
}
