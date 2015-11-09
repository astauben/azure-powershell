﻿# ----------------------------------------------------------------------------------
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
Tests the default values of database's threat detection policy
#>
function Test-ThreatDetectionDatabaseGetDefualtPolicy
{
	# Setup
	$testSuffix = 5000
	Create-ThreatDetectionTestEnvironmentWithStorageV2 $testSuffix
	$params = Get-SqlThreatDetectionTestEnvironmentParameters $testSuffix

	try 
	{
		# Test
		$policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName

        # Assert
		Assert-AreEqual $policy.ThreatDetectionState "New"
		Assert-AreEqual $policy.NotificationRecipientsEmail ""
        Assert-True {$policy.EmailAdmins}
        Assert-AreEqual $policy.FilterDetectionTypes ""
	}
	finally
	{
		# Cleanup
		Remove-ThreatDetectionTestEnvironment $testSuffix
	}
}

<#
.SYNOPSIS
Tests that when modifying the properties of a databases's threat detection policy , they are later fetched properly
#>
function Test-ThreatDetectionDatabaseUpdatePolicy
{
	# Setup
	$testSuffix = 5001
	Create-ThreatDetectionTestEnvironmentWithStorageV2 $testSuffix
	$params = Get-SqlThreatDetectionTestEnvironmentParameters $testSuffix

	try
	{
		# Test
        Set-AzureRmSqlDatabaseAuditingPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -StorageAccountName $params.storageAccount
        Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -NotificationRecipientsEmail "koko@mailTest.com;koko1@mailTest.com" -EmailAdmins $false -FilterDetectionTypes "Successful_SQLi", "Attempted_SQLi"
        $policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName
	
		# Assert
		Assert-AreEqual $policy.ThreatDetectionState "Enabled"
		Assert-AreEqual $policy.NotificationRecipientsEmail "koko@mailTest.com;koko1@mailTest.com"
        Assert-False {$policy.EmailAdmins}
        Assert-AreEqual $policy.FilterDetectionTypes.Length 2
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Successful_SQLi)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Attempted_SQLi)}


        # Test
        Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -FilterDetectionTypes "Successful_SQLi", "Attempted_SQLi", "Client_Access_Anomaly", "Failed_Logins_Anomaly", "Failed_Queries_Anomaly", "Data_Extraction_Anomaly", "Data_Alteration_Anomaly"
        $policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName
	
		# Assert
		Assert-AreEqual $policy.ThreatDetectionState "Enabled"
		Assert-AreEqual $policy.NotificationRecipientsEmail "koko@mailTest.com;koko1@mailTest.com"
        Assert-False {$policy.EmailAdmins}
        Assert-AreEqual $policy.FilterDetectionTypes.Length 7
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Successful_SQLi)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Attempted_SQLi)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Client_Access_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Failed_Logins_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Failed_Queries_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Data_Extraction_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Data_Alteration_Anomaly)}

        
        # Test
		Remove-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName
		$policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName
	
		# Assert
		Assert-AreEqual $policy.ThreatDetectionState "Disabled"
		Assert-AreEqual $policy.NotificationRecipientsEmail "koko@mailTest.com;koko1@mailTest.com"
        Assert-False {$policy.EmailAdmins}
        Assert-AreEqual $policy.FilterDetectionTypes.Length 7
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Successful_SQLi)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Attempted_SQLi)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Client_Access_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Failed_Logins_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Failed_Queries_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Data_Extraction_Anomaly)}
		Assert-True {$policy.EventType.Contains([Microsoft.Azure.Commands.Sql.ThreatDetection.Model.FilterDetectionType]::Data_Alteration_Anomaly)}
	}
	finally
	{
		# Cleanup
		Remove-ThreatDetectionTestEnvironment $testSuffix
	}
}

<#
.SYNOPSIS
Tests that when turning off auditing or marking it as "use server default" , threat detection is disabled
#>
function Test-DisablingThreatDetection
{
	# Setup
	$testSuffix = 5002
	Create-ThreatDetectionTestEnvironmentWithStorageV2 $testSuffix
	$params = Get-SqlThreatDetectionTestEnvironmentParameters $testSuffix

	try
	{
		# 1. Test
        Set-AzureRmSqlDatabaseAuditingPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -StorageAccountName $params.storageAccount
		Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName 
		$policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName
	
		# Assert
		Assert-AreEqual $policy.ThreatDetectionState "Enabled"


        # 2. Test
        Remove-AzureRmSqlDatabaseThreatDetection -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName 
		$policy = Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName

        # Assert
		Assert-AreEqual $policy.ThreatDetectionState "Disabled"
     }
	finally
	{
		# Cleanup
		Remove-ThreatDetectionTestEnvironment $testSuffix
	}
}

<#
.SYNOPSIS
Tests sending invalid arguments in database's threat detection
#>
function Test-InvalidArgumentsThreatDetection
{
	# Setup
	$testSuffix = 5003
	Create-ThreatDetectionTestEnvironmentWithStorageV2 $testSuffix
	$params = Get-SqlThreatDetectionTestEnvironmentParameters $testSuffix

	try
	{
         # turning on threat detection without auditing
         Assert-Throws {Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName} 
 
         Set-AzureRmSqlDatabaseAuditingPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -StorageAccountName $params.storageAccount

		 #  Check that NotificationRecipientsEmail are in correct format 
		 Assert-Throws {Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -NotificationRecipientsEmail "kokogmail.com"} 

         #  Check that EmailAdmins is not False and NotificationRecipientsEmail is not empty 
         Assert-Throws {Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -EmailAdmins $false} 
         Assert-Throws {Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -EmailAdmins $false -NotificationRecipientsEmail ""} 
	}
	finally
	{
		# Cleanup
		Remove-ThreatDetectionTestEnvironment $testSuffix
	}
}

<#
.SYNOPSIS
Tests that thread detection doesn't work on 0.2v servers
#>
function Test-ThreatDetectionOnV02Server
{
	# Setup
	$testSuffix = 5004
	Create-ThreatDetectionTestEnvironmentWithStorageV2 $testSuffix "0.2"
	$params = Get-SqlThreatDetectionTestEnvironmentParameters $testSuffix

	try
	{
         Set-AzureRmSqlDatabaseAuditingPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -StorageAccountName $params.storageAccount
         Assert-Throws {Set-AzureRmSqlDatabaseAuditingPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName -StorageAccountName $params.storageAccount -ThreatDetectionState "Enabled"}
		 Assert-Throws {Set-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName} 
		 Assert-Throws {Get-AzureRmSqlDatabaseThreatDetectionPolicy -ResourceGroupName $params.rgname -ServerName $params.serverName -DatabaseName $params.databaseName} 
	}
	finally
	{
		# Cleanup
		Remove-ThreatDetectionTestEnvironment $testSuffix
	}
}