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

using System;
using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.Common.Authentication
{
    /// <summary>
    /// Wire representation of MSI token
    /// </summary>
    public class ManagedServiceTokenInfo : ICacheable
    {
        public static readonly TimeSpan TimeoutThreshold = TimeSpan.FromMinutes(4);
        [JsonProperty(PropertyName ="access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "expires_on")]
        public int ExpiresOn { get; set; }

        [JsonProperty(PropertyName = "not_before")]
        public int NotBefore { get; set; }

        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonIgnore]
        public DateTimeOffset CreationDate { get; } = DateTimeOffset.Now;

        public override string ToString()
        {
            return $"(AccessToken: {AccessToken}, ExpiresIn: {ExpiresIn}, ExpiresOn: {ExpiresOn}, Resource:{Resource})";
        }

        public bool ShouldCache()
        {
            return !IsExpired();
        }

        public bool IsExpired()
        {
            return DateTimeOffset.Now - CreationDate > (TimeSpan.FromSeconds(ExpiresIn) - TimeoutThreshold);
        }
    }
}
