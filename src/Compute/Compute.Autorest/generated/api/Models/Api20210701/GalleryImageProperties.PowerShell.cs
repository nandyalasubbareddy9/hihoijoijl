// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>Describes the properties of a gallery image definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(GalleryImagePropertiesTypeConverter))]
    public partial class GalleryImageProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new GalleryImageProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new GalleryImageProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GalleryImageProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal GalleryImageProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Identifier = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageIdentifier) content.GetValueForProperty("Identifier",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Identifier, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageIdentifierTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Recommended = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRecommendedMachineConfiguration) content.GetValueForProperty("Recommended",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Recommended, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.RecommendedMachineConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Disallowed = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDisallowed) content.GetValueForProperty("Disallowed",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Disallowed, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.DisallowedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlan = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IImagePurchasePlan) content.GetValueForProperty("PurchasePlan",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlan, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ImagePurchasePlanTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Eula = (string) content.GetValueForProperty("Eula",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Eula, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PrivacyStatementUri = (string) content.GetValueForProperty("PrivacyStatementUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PrivacyStatementUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ReleaseNoteUri = (string) content.GetValueForProperty("ReleaseNoteUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ReleaseNoteUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSState = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemStateTypes) content.GetValueForProperty("OSState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSState, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemStateTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).HyperVGeneration = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HyperVGeneration?) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).HyperVGeneration, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HyperVGeneration.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature[]) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Feature, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageFeatureTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).DisallowedDiskType = (string[]) content.GetValueForProperty("DisallowedDiskType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).DisallowedDiskType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierPublisher = (string) content.GetValueForProperty("IdentifierPublisher",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierOffer = (string) content.GetValueForProperty("IdentifierOffer",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierOffer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierSku = (string) content.GetValueForProperty("IdentifierSku",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedVCpUs = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceRange) content.GetValueForProperty("RecommendedVCpUs",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedVCpUs, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceRangeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedMemory = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceRange) content.GetValueForProperty("RecommendedMemory",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedMemory, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceRangeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanName = (string) content.GetValueForProperty("PurchasePlanName",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanPublisher = (string) content.GetValueForProperty("PurchasePlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanProduct = (string) content.GetValueForProperty("PurchasePlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanProduct, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMin = (int?) content.GetValueForProperty("VCpUsMin",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMax = (int?) content.GetValueForProperty("VCpUsMax",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMin = (int?) content.GetValueForProperty("MemoryMin",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMax = (int?) content.GetValueForProperty("MemoryMax",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal GalleryImageProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Identifier = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageIdentifier) content.GetValueForProperty("Identifier",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Identifier, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageIdentifierTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Recommended = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IRecommendedMachineConfiguration) content.GetValueForProperty("Recommended",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Recommended, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.RecommendedMachineConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Disallowed = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IDisallowed) content.GetValueForProperty("Disallowed",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Disallowed, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.DisallowedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlan = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IImagePurchasePlan) content.GetValueForProperty("PurchasePlan",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlan, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ImagePurchasePlanTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Eula = (string) content.GetValueForProperty("Eula",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Eula, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PrivacyStatementUri = (string) content.GetValueForProperty("PrivacyStatementUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PrivacyStatementUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ReleaseNoteUri = (string) content.GetValueForProperty("ReleaseNoteUri",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ReleaseNoteUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSType = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSType, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSState = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemStateTypes) content.GetValueForProperty("OSState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).OSState, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.OperatingSystemStateTypes.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).HyperVGeneration = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HyperVGeneration?) content.GetValueForProperty("HyperVGeneration",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).HyperVGeneration, Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.HyperVGeneration.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).EndOfLifeDate = (global::System.DateTime?) content.GetValueForProperty("EndOfLifeDate",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).EndOfLifeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Feature = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature[]) content.GetValueForProperty("Feature",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).Feature, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImageFeature>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.GalleryImageFeatureTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).DisallowedDiskType = (string[]) content.GetValueForProperty("DisallowedDiskType",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).DisallowedDiskType, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierPublisher = (string) content.GetValueForProperty("IdentifierPublisher",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierOffer = (string) content.GetValueForProperty("IdentifierOffer",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierOffer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierSku = (string) content.GetValueForProperty("IdentifierSku",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).IdentifierSku, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedVCpUs = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceRange) content.GetValueForProperty("RecommendedVCpUs",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedVCpUs, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceRangeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedMemory = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IResourceRange) content.GetValueForProperty("RecommendedMemory",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).RecommendedMemory, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.ResourceRangeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanName = (string) content.GetValueForProperty("PurchasePlanName",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanPublisher = (string) content.GetValueForProperty("PurchasePlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanProduct = (string) content.GetValueForProperty("PurchasePlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).PurchasePlanProduct, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMin = (int?) content.GetValueForProperty("VCpUsMin",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMax = (int?) content.GetValueForProperty("VCpUsMax",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).VCpUsMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMin = (int?) content.GetValueForProperty("MemoryMin",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMax = (int?) content.GetValueForProperty("MemoryMax",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20210701.IGalleryImagePropertiesInternal)this).MemoryMax, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Describes the properties of a gallery image definition.
    [System.ComponentModel.TypeConverter(typeof(GalleryImagePropertiesTypeConverter))]
    public partial interface IGalleryImageProperties

    {

    }
}