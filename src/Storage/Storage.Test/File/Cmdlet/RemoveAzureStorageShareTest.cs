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

using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Storage.File;
using Microsoft.WindowsAzure.Commands.Storage.File.Cmdlet;
using Microsoft.Azure.Storage.File;

namespace Microsoft.WindowsAzure.Management.Storage.Test.File.Cmdlet
{
    [TestClass]
    public class RemoveAzureStorageShareTest : StorageFileTestBase<RemoveAzureStorageShare>
    {
        [TestMethod]
        public void RemoveShareUsingShareNameTest()
        {
            this.CmdletInstance.RunCmdlet(
                Constants.ShareNameParameterSetName,
                new KeyValuePair<string, object>("Name", "share"),
                new KeyValuePair<string, object>("PassThru", new SwitchParameter(true)));

            this.MockCmdRunTime.OutputPipeline
                .Cast<CloudFileShare>()
                .AssertSingleObject(x => x.Name == "share");
        }

        [TestMethod]
        public void RemoveFileUsingShareObjectTest()
        {
            this.CmdletInstance.RunCmdlet(
                Constants.ShareParameterSetName,
                new KeyValuePair<string, object>("Share", this.MockChannel.GetShareReference("share")),
                new KeyValuePair<string, object>("PassThru", new SwitchParameter(true)));

            this.MockCmdRunTime.OutputPipeline
                .Cast<CloudFileShare>()
                .AssertSingleObject(x => x.Name == "share");
        }
    }
}
