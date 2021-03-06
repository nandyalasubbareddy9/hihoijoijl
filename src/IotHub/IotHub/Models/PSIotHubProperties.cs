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

namespace Microsoft.Azure.Commands.Management.IotHub.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PSIotHubProperties
    {
        /// <summary>
        /// The authorization rules.
        /// </summary>
        [JsonProperty(PropertyName = "authorizationPolicies")]
        public IList<PSSharedAccessSignatureAuthorizationRule> AuthorizationPolicies { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// The event hub endpoint properties.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubEndpoints")]
        public IDictionary<string, PSEventHubProperties> EventHubEndpoints { get; set; }

        /// <summary>
        /// The list of storage end points where files can be uploaded.
        /// Currently only one storage account can be configured.
        /// </summary>
        [JsonProperty(PropertyName = "storageEndpoints")]
        public IDictionary<string, PSStorageEndpointProperties> StorageEndpoints { get; set; }

        /// <summary>
        /// The list of messaging end points configured.
        /// </summary>
        [JsonProperty(PropertyName = "messagingEndpoints")]
        public IDictionary<string, PSMessagingEndpointProperties> MessagingEndpoints { get; set; }

        /// <summary>
        /// The flag which indicates whether file upload notification should
        /// be enabled. This is optional at iot hub level. When enabled
        /// upload notifications will be available.
        /// </summary>
        [JsonProperty(PropertyName = "enableFileUploadNotifications")]
        public bool? EnableFileUploadNotifications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloudToDevice")]
        public PSCloudToDeviceProperties CloudToDevice { get; set; }

        /// <summary>
        /// The comments.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routing")]
        public PSRoutingProperties Routing { get; set; }

        /// <summary>
        /// Gets the hub state state.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        /// <summary>
        /// The Capabilities/Features that need to be enabled for the Hub.
        /// Possible values include: 'None', 'DeviceManagement'
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public PSCapabilities Features { get; set; }

        /// <summary>
        /// Gets primary and secondary location for iot hub
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<PSIotHubLocationDescription> Locations { get; set; }
    }
}
