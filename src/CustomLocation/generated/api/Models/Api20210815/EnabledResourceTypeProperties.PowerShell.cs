// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815
{
    using Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.PowerShell;

    /// <summary>Properties for EnabledResourceType of a custom location.</summary>
    [System.ComponentModel.TypeConverter(typeof(EnabledResourceTypePropertiesTypeConverter))]
    public partial class EnabledResourceTypeProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypeProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EnabledResourceTypeProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypeProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypeProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EnabledResourceTypeProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EnabledResourceTypeProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ClusterExtensionId = (string) content.GetValueForProperty("ClusterExtensionId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ClusterExtensionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).TypesMetadata = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesTypesMetadataItem[]) content.GetValueForProperty("TypesMetadata",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).TypesMetadata, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesTypesMetadataItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypePropertiesTypesMetadataItemTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypeProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EnabledResourceTypeProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ClusterExtensionId = (string) content.GetValueForProperty("ClusterExtensionId",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ClusterExtensionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ExtensionType = (string) content.GetValueForProperty("ExtensionType",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).ExtensionType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).TypesMetadata = (Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesTypesMetadataItem[]) content.GetValueForProperty("TypesMetadata",((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesInternal)this).TypesMetadata, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypePropertiesTypesMetadataItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.EnabledResourceTypePropertiesTypesMetadataItemTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EnabledResourceTypeProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.Api20210815.IEnabledResourceTypeProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Properties for EnabledResourceType of a custom location.
    [System.ComponentModel.TypeConverter(typeof(EnabledResourceTypePropertiesTypeConverter))]
    public partial interface IEnabledResourceTypeProperties

    {

    }
}