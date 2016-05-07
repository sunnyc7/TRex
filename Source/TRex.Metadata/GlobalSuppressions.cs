// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
    Justification = "Project is open source, and anyone can modify and sign at their leisure when required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "TRex.Extensions",
    Justification = "Namespace is meaningful and allows consuming developers to aovid bringing in extension methods they don't want")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments",
    Scope = "type", Target = "TRex.Metadata.MetadataAttribute",
    Justification = "Consuming developers should be able to choose between positional and named arguments, moving only to named arguments makes for unneeded verbosity when all arguments are provided")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments",
    Scope = "type", Target = "TRex.Metadata.TriggerAttribute",
    Justification = "Consuming developers should be able to choose between positional and named arguments, moving only to named arguments makes for unneeded verbosity when all arguments are provided")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
    Scope = "member", Target = "TRex.Metadata.MetadataAttribute.#.ctor(System.String,System.String,TRex.Metadata.VisibilityType)",
    Justification = "Providing ctor overload with all default arguments would be meaningless, but providing multiple overloads for all combinations would lead to ambiguity given 2 string arguments that could be passed all alone")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.ParameterExtensions.#SetVisibility(Swashbuckle.Swagger.Parameter,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetVisibility(Swashbuckle.Swagger.Operation,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.SchemaExtensions.#SetVisibility(Swashbuckle.Swagger.Schema,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.TRexOperationFilter.#applyTriggerInfo(Swashbuckle.Swagger.Operation,System.Web.Http.Description.ApiDescription,Swashbuckle.Swagger.SchemaRegistry)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "TRex.Metadata",
    Justification = "Split the assembly to allow for sharing models between projects targeting different devices. Some items had to stay behind.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.SchemaExtensions.#SetCallbackUrl(Swashbuckle.Swagger.Schema)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValueTitle",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValueCollection",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValuePath",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#OperationId",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.NotificationContentModel.#Description",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.NotificationContentModel.#Schema",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.SchemaModel.#Type",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.SchemaModel.#Ref",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetTrigger(Swashbuckle.Swagger.Operation,TRex.Metadata.BatchMode)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicSchemaModel.#OperationId",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-schema extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicSchemaModel.#ValuePath",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-schema extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetTrigger(Swashbuckle.Swagger.Operation,Swashbuckle.Swagger.SchemaRegistry,TRex.Metadata.TriggerAttribute)",
    Justification = "Designer needs it to be lowercase")]

