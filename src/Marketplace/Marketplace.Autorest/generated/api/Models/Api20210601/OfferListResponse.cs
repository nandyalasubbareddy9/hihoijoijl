// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    public partial class OfferListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOfferListResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOfferListResponseInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URL to get the next set of offer list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOffer[] _value;

        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOffer[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OfferListResponse" /> instance.</summary>
        public OfferListResponse()
        {

        }
    }
    public partial interface IOfferListResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>URL to get the next set of offer list results if there are any.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URL to get the next set of offer list results if there are any.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOffer) })]
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOffer[] Value { get; set; }

    }
    internal partial interface IOfferListResponseInternal

    {
        /// <summary>URL to get the next set of offer list results if there are any.</summary>
        string NextLink { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.Api20210601.IOffer[] Value { get; set; }

    }
}