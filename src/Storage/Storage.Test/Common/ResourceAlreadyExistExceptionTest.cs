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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Storage.Common;

namespace Microsoft.WindowsAzure.Commands.Storage.Test.Common
{
    /// <summary>
    /// unit test for ResourceAlreadyExistException
    /// </summary>
    [TestClass]
    public class ResourceAlreadyExistExceptionTest : StorageTestBase
    {
        [TestMethod]
        public void ResourceAlreadyExistExceptionInitTest()
        {
            string message = string.Empty;

            ResourceAlreadyExistException exception = new ResourceAlreadyExistException(message);

            message = "ResourceAlreadyExistException";
            exception = new ResourceAlreadyExistException(message);
        }
    }
}
