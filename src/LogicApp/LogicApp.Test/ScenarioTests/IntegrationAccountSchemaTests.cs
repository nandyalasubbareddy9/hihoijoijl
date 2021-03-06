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


namespace Microsoft.Azure.Commands.LogicApp.Test.ScenarioTests
{
    using Microsoft.Rest.Azure;
    using Microsoft.WindowsAzure.Commands.ScenarioTest;
    using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
    using ServiceManagement.Common.Models;
    using Xunit;

    /// <summary>
    /// Scenario tests for integration account schema commands.
    /// </summary>
    public class IntegrationAccountSchemaTests : RMTestBase
    {
        public XunitTracingInterceptor _logger;

        public IntegrationAccountSchemaTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            _logger = new XunitTracingInterceptor(output);
            XunitTracingInterceptor.AddToContext(_logger);
        }

        /// <summary>
        /// Test New-AzIntegrationAccountSchema command to create a new integration account schema.
        /// </summary>
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestCreateSchema()
        {
            WorkflowController.NewInstance.RunPowerShellTest(_logger, "Test-CreateIntegrationAccountSchema");
        }

        /// <summary>
        /// Test Get-AzIntegrationAccountSchema command to get the integration account schema.
        /// </summary>
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestGetSchema()
        {
            WorkflowController.NewInstance.RunPowerShellTest(_logger, "Test-GetIntegrationAccountSchema");
        }

        /// <summary>
        /// Test Remove-AzIntegrationAccountSchema command to remove the integration account schema.
        /// </summary>
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestRemoveSchema()
        {
            WorkflowController.NewInstance.RunPowerShellTest(_logger, "Test-RemoveIntegrationAccountSchema");
        }

        /// <summary>
        /// Test Set-AzIntegrationAccountSchema command to update the integration account schema.
        /// </summary>
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestUpdateSchema()
        {
            WorkflowController.NewInstance.RunPowerShellTest(_logger, "Test-UpdateIntegrationAccountSchema");
        }

        /// <summary>
        /// Test Get-AzIntegrationAccountSchema command to get all the integration account schema.
        /// </summary>
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestListSchema()
        {
            WorkflowController.NewInstance.RunPowerShellTest(_logger, "Test-ListIntegrationAccountSchema");
        }
    }
}