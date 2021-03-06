namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Operation resource</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplay _display;

        /// <summary>Properties on the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationDisplay()); set => this._display = value; }

        /// <summary>Description of the operation for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Description = value ?? null; }

        /// <summary>Name of the operation for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>Name of the provider for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>Name of the resource type for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>Whether operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; set => this._isDataAction = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationProperties Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationInternal.ServiceSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecification = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Operation name for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>origin of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationProperties _property;

        /// <summary>properties for the operation meta info</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.OperationProperties()); set => this._property = value; }

        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecificationLogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecificationLogSpecification = value ?? null /* arrayOf */; }

        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecificationMetricSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationPropertiesInternal)Property).ServiceSpecificationMetricSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Operation resource
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Description of the operation for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the operation for display purposes",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Name of the operation for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the operation for display purposes",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the provider for display purposes",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the resource type for display purposes",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Whether operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether operation is a data action",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get; set; }
        /// <summary>Operation name for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation name for display purposes",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>origin of the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"origin of the operation",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }
        /// <summary>log specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"log specifications for the operation",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"metric specifications for the operation",
        SerializedName = @"metricSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
    /// Operation resource
    internal partial interface IOperationInternal

    {
        /// <summary>Properties on the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationDisplay Display { get; set; }
        /// <summary>Description of the operation for display purposes</summary>
        string DisplayDescription { get; set; }
        /// <summary>Name of the operation for display purposes</summary>
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider for display purposes</summary>
        string DisplayProvider { get; set; }
        /// <summary>Name of the resource type for display purposes</summary>
        string DisplayResource { get; set; }
        /// <summary>Whether operation is a data action</summary>
        bool? IsDataAction { get; set; }
        /// <summary>Operation name for display purposes</summary>
        string Name { get; set; }
        /// <summary>origin of the operation</summary>
        string Origin { get; set; }
        /// <summary>properties for the operation meta info</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationProperties Property { get; set; }
        /// <summary>meta service specification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaServiceSpecification ServiceSpecification { get; set; }
        /// <summary>log specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaLogSpecification[] ServiceSpecificationLogSpecification { get; set; }
        /// <summary>metric specifications for the operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification[] ServiceSpecificationMetricSpecification { get; set; }

    }
}