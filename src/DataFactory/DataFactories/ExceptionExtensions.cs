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

using Hyak.Common;
using Microsoft.Azure.Commands.DataFactories.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Azure.Commands.DataFactories
{
    internal static class ExceptionExtensions
    {
        public static CloudException CreateFormattedException(this CloudException cloudException)
        {
            return new CloudException(
                string.Format(
                    CultureInfo.InvariantCulture,
                    Resources.FormattedCloudExceptionMessageTemplate,
                    cloudException.Response.StatusCode,
                    cloudException.Error.Code,
                    cloudException.Error.Message,
                    cloudException.GetRequestId(),
                    DateTime.UtcNow));
        }

        public static string GetRequestId(this CloudException exception)
        {
            IEnumerable<string> strings;

            if (exception.Response != null
                && exception.Response.Headers != null
                && exception.Response.Headers.TryGetValue("x-ms-request-id", out strings))
            {
                return string.Join(";", strings);
            }

            return string.Empty;
        }

        public static ArgumentOutOfRangeException CreateFormattedException(this ArgumentOutOfRangeException exception)
        {
            return new ArgumentOutOfRangeException(
                exception.ParamName,
                exception.ActualValue,
                string.Format(CultureInfo.InvariantCulture,
                    Resources.FormattedArgumentOutOfRangeExceptionMessageTemplate,
                    exception.Message));
        }
    }
}