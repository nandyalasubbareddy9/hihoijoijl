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

namespace Microsoft.Azure.Commands.PrivateDns.Models
{

    using System.Collections;

    /// <summary>
    /// A private DNS zone
    /// </summary>
    public class PSPrivateDnsZone
    {
        /// <summary>
        /// Gets or sets the name of the DNS zone.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the resource Id of the DNS zone.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group to which this zone belongs.
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the location to which this zone belongs.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the Etag of this zone
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the tags of this resource
        /// </summary>
        public Hashtable Tags { get; set; }

        /// <summary>
        /// Gets or sets the number of records for this zone
        /// </summary>
        public long? NumberOfRecordSets { get; set; }

        /// <summary>
        ///Gets or sets the max number of records for this zone
        /// </summary>
        public long? MaxNumberOfRecordSets { get; set; }

        /// <summary>
        /// Gets or sets the number of records for this zone
        /// </summary>
        public long? NumberOfVirtualNetworkLinks { get; set; }

        /// <summary>
        ///Gets or sets the max number of records for this zone
        /// </summary>
        public long? MaxNumberOfVirtualNetworkLinks { get; set; }

        /// <summary>
        /// Gets or sets the number of records for this zone
        /// </summary>
        public long? NumberOfVirtualNetworkLinksWithRegistration { get; set; }

        /// <summary>
        ///Gets or sets the max number of records for this zone
        /// </summary>
        public long? MaxNumberOfVirtualNetworkLinksWithRegistration { get; set; }


    }
}
