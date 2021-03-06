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

using Microsoft.Azure.Commands.ScenarioTest.SqlTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;
using RestTestFramework = Microsoft.Rest.ClientRuntime.Azure.TestFramework;

namespace Microsoft.Azure.Commands.Sql.Test.ScenarioTests
{
    public class ServerCrudTests : SqlTestsBase
    {
        public ServerCrudTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerCreate()
        {
            RunPowerShellTest("Test-CreateServer");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdate()
        {
            RunPowerShellTest("Test-UpdateServer");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerGet()
        {
            RunPowerShellTest("Test-GetServer");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerRemove()
        {
            RunPowerShellTest("Test-RemoveServer");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerCreateWithIdentity()
        {
            RunPowerShellTest("Test-CreateServerWithIdentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdateWithIdentity()
        {
            RunPowerShellTest("Test-UpdateServerWithIdentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerCreateWithFederatedClientId()
        {
            RunPowerShellTest("Test-CreateServerWithFederatedClientId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdateWithFederatedClientId()
        {
            RunPowerShellTest("Test-UpdatingServerWithFederatedClientId");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdateWithoutIdentity()
        {
            RunPowerShellTest("Test-UpdateServerWithoutIdentity");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerCreateAndGetWithPublicNetworkAccess()
        {
            RunPowerShellTest("Test-CreateAndGetServerWithPublicNetworkAccess");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdateWithPublicNetworkAccess()
        {
            RunPowerShellTest("Test-UpdateServerWithPublicNetworkAccess");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestOutboundFirewallRulesCRUD()
        {
            RunPowerShellTest("Test-OutboundFirewallRulesCRUD");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerCreateAndGetWithRestrictOutboundNetworkAccess()
        {
            RunPowerShellTest("Test-CreateAndGetServerWithRestrictOutboundNetworkAccess");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestServerUpdateWithRestrictOutboundNetworkAccess()
        {
            RunPowerShellTest("Test-UpdateServerWithRestrictOutboundNetworkAccess");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void CreateandUpdateServerWithMinimalTlsVersion()
        {
            RunPowerShellTest("Test-CreateandUpdateServerWithMinimalTlsVersion");
        }
    }
}
