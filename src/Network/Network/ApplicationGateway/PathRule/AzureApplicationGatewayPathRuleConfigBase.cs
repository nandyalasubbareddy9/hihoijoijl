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

using Microsoft.Azure.Commands.Network.Models;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Network
{
    public class AzureApplicationGatewayPathRuleConfigBase : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "Name of the path rule")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
               Mandatory = true,
               HelpMessage = "List of URL paths")]
        [ValidateNotNullOrEmpty]
        public string[] Paths { get; set; }

        [Parameter(
        ParameterSetName = "SetByResourceId",
        HelpMessage = "ID of the application gateway BackendAddressPool")]
        [ValidateNotNullOrEmpty]
        public string BackendAddressPoolId { get; set; }

        [Parameter(
                ParameterSetName = "SetByResource",
                HelpMessage = "Application gateway BackendAddressPool")]
        [ValidateNotNullOrEmpty]
        public PSApplicationGatewayBackendAddressPool BackendAddressPool { get; set; }

        [Parameter(
                ParameterSetName = "SetByResourceId",
                HelpMessage = "ID of the application gateway BackendHttpSettings")]
        [ValidateNotNullOrEmpty]
        public string BackendHttpSettingsId { get; set; }

        [Parameter(
                ParameterSetName = "SetByResource",
                HelpMessage = "Application gateway BackendHttpSettings")]
        [ValidateNotNullOrEmpty]
        public PSApplicationGatewayBackendHttpSettings BackendHttpSettings { get; set; }

        [Parameter(
                ParameterSetName = "SetByResourceId",
                HelpMessage = "ID of the application gateway RewriteRuleSet")]
        [ValidateNotNullOrEmpty]
        public string RewriteRuleSetId { get; set; }

        [Parameter(
                ParameterSetName = "SetByResource",
                HelpMessage = "Application gateway RewriteRuleSet")]
        [ValidateNotNullOrEmpty]
        public PSApplicationGatewayRewriteRuleSet RewriteRuleSet { get; set; }

        [Parameter(
                ParameterSetName = "SetByResourceId",
                HelpMessage = "ID of the application gateway RedirectConfiguration")]
        [ValidateNotNullOrEmpty]
        public string RedirectConfigurationId { get; set; }

        [Parameter(
                ParameterSetName = "SetByResource",
                HelpMessage = "Application gateway RedirectConfiguration")]
        [ValidateNotNullOrEmpty]
        public PSApplicationGatewayRedirectConfiguration RedirectConfiguration { get; set; }
        
        [Parameter(
           ParameterSetName = "SetByResourceId",
           HelpMessage = "FirewallPolicyId")]
        public string FirewallPolicyId { get; set; }

        [Parameter(
            ParameterSetName = "SetByResource",
            HelpMessage = "FirewallPolicy")]
        public PSApplicationGatewayWebApplicationFirewallPolicy FirewallPolicy { get; set; }
        
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();

            if (string.Equals(ParameterSetName, Microsoft.Azure.Commands.Network.Properties.Resources.SetByResource))
            {
                if (BackendAddressPool != null)
                {
                    this.BackendAddressPoolId = this.BackendAddressPool.Id;
                }

                if (BackendHttpSettings != null)
                {
                    this.BackendHttpSettingsId = this.BackendHttpSettings.Id;
                }

                if (RewriteRuleSet != null)
                {
                    this.RewriteRuleSetId = this.RewriteRuleSet.Id;
                }

                if (RedirectConfiguration != null)
                {
                    this.RedirectConfigurationId = this.RedirectConfiguration.Id;
                }

                if (FirewallPolicy != null)
                {
                    this.FirewallPolicyId = this.FirewallPolicy.Id;
                }
            }
        }

        public PSApplicationGatewayPathRule NewObject()
        {
            var pathRule = new PSApplicationGatewayPathRule();

            pathRule.Name = this.Name;
            pathRule.Paths = this.Paths?.ToList();

            if (!string.IsNullOrEmpty(this.BackendAddressPoolId))
            {
                pathRule.BackendAddressPool = new PSResourceId();
                pathRule.BackendAddressPool.Id = this.BackendAddressPoolId;
            }

            if (!string.IsNullOrEmpty(this.BackendHttpSettingsId))
            {
                pathRule.BackendHttpSettings = new PSResourceId();
                pathRule.BackendHttpSettings.Id = this.BackendHttpSettingsId;
            }

            if (!string.IsNullOrEmpty(this.RewriteRuleSetId))
            {
                pathRule.RewriteRuleSet = new PSResourceId();
                pathRule.RewriteRuleSet.Id = this.RewriteRuleSetId;
            }

            if (!string.IsNullOrEmpty(this.RedirectConfigurationId))
            {
                pathRule.RedirectConfiguration = new PSResourceId();
                pathRule.RedirectConfiguration.Id = this.RedirectConfigurationId;
            }
            
            if (!string.IsNullOrEmpty(this.FirewallPolicyId))
            {
                pathRule.FirewallPolicy = new PSResourceId();
                pathRule.FirewallPolicy.Id = this.FirewallPolicyId;
            }

            return pathRule;
        }
    }
}
