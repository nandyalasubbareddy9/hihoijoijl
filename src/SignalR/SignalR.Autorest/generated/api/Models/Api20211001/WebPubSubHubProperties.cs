// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Properties of a hub.</summary>
    public partial class WebPubSubHubProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IWebPubSubHubProperties,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IWebPubSubHubPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AnonymousConnectPolicy" /> property.</summary>
        private string _anonymousConnectPolicy;

        /// <summary>
        /// The settings for configuring if anonymous connections are allowed for this hub: "allow" or "deny". Default to "deny".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string AnonymousConnectPolicy { get => this._anonymousConnectPolicy; set => this._anonymousConnectPolicy = value; }

        /// <summary>Backing field for <see cref="EventHandler" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IEventHandler[] _eventHandler;

        /// <summary>Event handler of a hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IEventHandler[] EventHandler { get => this._eventHandler; set => this._eventHandler = value; }

        /// <summary>Creates an new <see cref="WebPubSubHubProperties" /> instance.</summary>
        public WebPubSubHubProperties()
        {

        }
    }
    /// Properties of a hub.
    public partial interface IWebPubSubHubProperties :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The settings for configuring if anonymous connections are allowed for this hub: "allow" or "deny". Default to "deny".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The settings for configuring if anonymous connections are allowed for this hub: ""allow"" or ""deny"". Default to ""deny"".",
        SerializedName = @"anonymousConnectPolicy",
        PossibleTypes = new [] { typeof(string) })]
        string AnonymousConnectPolicy { get; set; }
        /// <summary>Event handler of a hub.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Event handler of a hub.",
        SerializedName = @"eventHandlers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IEventHandler) })]
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IEventHandler[] EventHandler { get; set; }

    }
    /// Properties of a hub.
    internal partial interface IWebPubSubHubPropertiesInternal

    {
        /// <summary>
        /// The settings for configuring if anonymous connections are allowed for this hub: "allow" or "deny". Default to "deny".
        /// </summary>
        string AnonymousConnectPolicy { get; set; }
        /// <summary>Event handler of a hub.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20211001.IEventHandler[] EventHandler { get; set; }

    }
}