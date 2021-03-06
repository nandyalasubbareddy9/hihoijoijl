// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Configuration request object.</summary>
    public partial class ConfigurationsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationsRequest,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationsRequestInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationFilter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationFilters[] _configurationFilter;

        /// <summary>Holds details about product hierarchy information and filterable property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationFilters[] ConfigurationFilter { get => this._configurationFilter; set => this._configurationFilter = value; }

        /// <summary>Backing field for <see cref="CustomerSubscriptionDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails _customerSubscriptionDetail;

        /// <summary>
        /// Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing
        /// subscription details
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails CustomerSubscriptionDetail { get => (this._customerSubscriptionDetail = this._customerSubscriptionDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.CustomerSubscriptionDetails()); set => this._customerSubscriptionDetail = value; }

        /// <summary>Creates an new <see cref="ConfigurationsRequest" /> instance.</summary>
        public ConfigurationsRequest()
        {

        }
    }
    /// Configuration request object.
    public partial interface IConfigurationsRequest :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Holds details about product hierarchy information and filterable property.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Holds details about product hierarchy information and filterable property.",
        SerializedName = @"configurationFilters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationFilters) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationFilters[] ConfigurationFilter { get; set; }
        /// <summary>
        /// Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing
        /// subscription details
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing subscription details",
        SerializedName = @"customerSubscriptionDetails",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails CustomerSubscriptionDetail { get; set; }

    }
    /// Configuration request object.
    internal partial interface IConfigurationsRequestInternal

    {
        /// <summary>Holds details about product hierarchy information and filterable property.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IConfigurationFilters[] ConfigurationFilter { get; set; }
        /// <summary>
        /// Customer subscription properties. Clients can display available products to unregistered customers by explicitly passing
        /// subscription details
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICustomerSubscriptionDetails CustomerSubscriptionDetail { get; set; }

    }
}