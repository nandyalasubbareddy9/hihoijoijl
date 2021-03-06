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

using Microsoft.Azure.Batch;
using Microsoft.Azure.Batch.Protocol;
using Microsoft.Rest.Azure;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using System;
using System.Collections.Generic;
using System.Management.Automation;
using Xunit;
using BatchClient = Microsoft.Azure.Commands.Batch.Models.BatchClient;
using ProxyModels = Microsoft.Azure.Batch.Protocol.Models;

namespace Microsoft.Azure.Commands.Batch.Test.Pools
{
    public class TestBatchAutoScaleCommandTests : WindowsAzure.Commands.Test.Utilities.Common.RMTestBase
    {
        private TestBatchAutoScaleCommand cmdlet;
        private Mock<BatchClient> batchClientMock;
        private Mock<ICommandRuntime> commandRuntimeMock;

        public TestBatchAutoScaleCommandTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            ServiceManagement.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagement.Common.Models.XunitTracingInterceptor(output));
            batchClientMock = new Mock<BatchClient>();
            commandRuntimeMock = new Mock<ICommandRuntime>();
            cmdlet = new TestBatchAutoScaleCommand()
            {
                CommandRuntime = commandRuntimeMock.Object,
                BatchClient = batchClientMock.Object,
            };
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAutoScaleParametersTest()
        {
            BatchAccountContext context = BatchTestHelpers.CreateBatchContextWithKeys();
            cmdlet.BatchContext = context;
            cmdlet.Id = null;

            Assert.Throws<ArgumentNullException>(() => cmdlet.ExecuteCmdlet());

            cmdlet.Id = "testPool";

            Assert.Throws<ArgumentNullException>(() => cmdlet.ExecuteCmdlet());

            cmdlet.AutoScaleFormula = "formula";

            AzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders> response =
                BatchTestHelpers.CreateGenericAzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders>();

            // Don't go to the service on an Evaluate AutoScale call
            RequestInterceptor interceptor = BatchTestHelpers.CreateFakeServiceResponseInterceptor<
                string,
                ProxyModels.PoolEvaluateAutoScaleOptions,
                AzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders>>(response);

            cmdlet.AdditionalBehaviors = new List<BatchClientBehavior>() { interceptor };

            // Verify no exceptions when required parameter is set
            cmdlet.ExecuteCmdlet();
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAutoScaleRequestTest()
        {
            BatchAccountContext context = BatchTestHelpers.CreateBatchContextWithKeys();
            cmdlet.BatchContext = context;

            string formula = "$TargetDedicated=2";
            string requestFormula = null;

            cmdlet.Id = "testPool";
            cmdlet.AutoScaleFormula = formula;

            AzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders> response =
                BatchTestHelpers.CreateGenericAzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders>();

            // Don't go to the service on an Evaluate AutoScale call
            Action<BatchRequest<string, ProxyModels.PoolEvaluateAutoScaleOptions, AzureOperationResponse<ProxyModels.AutoScaleRun, ProxyModels.PoolEvaluateAutoScaleHeaders>>> extractFormulaAction =
                (request) =>
                {
                    requestFormula = request.Parameters;
                };

            RequestInterceptor interceptor = BatchTestHelpers.CreateFakeServiceResponseInterceptor(responseToUse: response, requestAction: extractFormulaAction);
            cmdlet.AdditionalBehaviors = new List<BatchClientBehavior>() { interceptor };

            cmdlet.ExecuteCmdlet();

            // Verify that the autoscale formula was properly set on the outgoing request
            Assert.Equal(formula, requestFormula);
        }
    }
}
