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

using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Security.Models;

namespace Microsoft.Azure.Commands.Security.Models.Locations
{
    public static class PSSecurityLocationConverters
    {
        public static PSSecurityLocation ConvertToPSType(this AscLocation value)
        {
            return new PSSecurityLocation()
            {
                Id = value.Id,
                Name = value.Name,
            };
        }

        public static List<PSSecurityLocation> ConvertToPSType(this IEnumerable<AscLocation> value)
        {
            return value.Select(location => location.ConvertToPSType()).ToList();
        }
    }
}
