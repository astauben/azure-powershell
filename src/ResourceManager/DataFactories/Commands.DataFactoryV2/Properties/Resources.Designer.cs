﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.DataFactoryV2.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.DataFactoryV2.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Continuing execution will renegerate the authentication key &apos;{0}&apos; of integration runtime {1}. This operation will invalidate the existing authentication key.
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string ContinueRegenerateAuthKey {
            get {
                return ResourceManager.GetString("ContinueRegenerateAuthKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data factory object provided is invalid. Use Get-AzureRmDataFactory to retrieve a specific data factory object, or use New-AzureRmDataFactory to create a new data factory object..
        /// </summary>
        internal static string DataFactoryArgumentInvalid {
            get {
                return ResourceManager.GetString("DataFactoryArgumentInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove data factory &apos;{0}&apos; in resource group &apos;{1}&apos;?.
        /// </summary>
        internal static string DataFactoryConfirmationMessage {
            get {
                return ResourceManager.GetString("DataFactoryConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating data factory &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryCreating {
            get {
                return ResourceManager.GetString("DataFactoryCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data factory with the name {0} in the resource group {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string DataFactoryExists {
            get {
                return ResourceManager.GetString("DataFactoryExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data factory &apos;{0}&apos; does not exist in the resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryNotFound {
            get {
                return ResourceManager.GetString("DataFactoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creation of data factory &apos;{0}&apos; failed..
        /// </summary>
        internal static string DataFactoryProvisioningError {
            get {
                return ResourceManager.GetString("DataFactoryProvisioningError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing data factory &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryRemoving {
            get {
                return ResourceManager.GetString("DataFactoryRemoving", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to update properties of the data factory &apos;{0}&apos; in resource group &apos;{1}&apos;?.
        /// </summary>
        internal static string DataFactoryUpdateConfirm
        {
            get
            {
                return ResourceManager.GetString("DataFactoryUpdateConfirm", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Updating properties of the data factory &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryUpdating
        {
            get
            {
                return ResourceManager.GetString("DataFactoryUpdating", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove dataset &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string DatasetConfirmationMessage {
            get {
                return ResourceManager.GetString("DatasetConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating dataset &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string DatasetCreating {
            get {
                return ResourceManager.GetString("DatasetCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A dataset with the name {0} in the data factory {1} already exists. 
        ///Continuing execution will overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string DatasetExists {
            get {
                return ResourceManager.GetString("DatasetExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dataset &apos;{0}&apos; does not exist in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string DatasetNotFound {
            get {
                return ResourceManager.GetString("DatasetNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing dataset &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string DatasetRemoving {
            get {
                return ResourceManager.GetString("DatasetRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument set for download method is incomplete..
        /// </summary>
        internal static string DownloadCredentialsNull {
            get {
                return ResourceManager.GetString("DownloadCredentialsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download failed. Please check if you have write permission to the path {0} or the sas url is valid. .
        /// </summary>
        internal static string DownloadFailed {
            get {
                return ResourceManager.GetString("DownloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download of the log is completed. Please find it in the directory {0}..
        /// </summary>
        internal static string DownloadLogCompleted {
            get {
                return ResourceManager.GetString("DownloadLogCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to encrypt the connection string of the linked service?.
        /// </summary>
        internal static string EncryptConfirm {
            get {
                return ResourceManager.GetString("EncryptConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encrypting the connection string..
        /// </summary>
        internal static string Encrypting {
            get {
                return ResourceManager.GetString("Encrypting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndDateTime is not specified and is set to 48 hours from StartDateTime (by default). Please use -EndDateTime parameter in Get-AzureRmDataFactorySlice command if you want to specify EndDateTime..
        /// </summary>
        internal static string EndDateTimeNotSpecifiedForGetSlice {
            get {
                return ResourceManager.GetString("EndDateTimeNotSpecifiedForGetSlice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EndDateTime is not specified and is set to 48 hours from StartDateTime (by default). Please use -EndDateTime parameter in Set-AzureRmDataFactorySliceStatus command if you want to specify EndDateTime..
        /// </summary>
        internal static string EndDateTimeNotSpecifiedForSetSliceStatus {
            get {
                return ResourceManager.GetString("EndDateTimeNotSpecifiedForSetSliceStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} name provided using -Name switch: &apos;{1}&apos; in cmdlet doesn&apos;t match with {0} name: &apos;{2}&apos; in JSON file. {0} will be created with name: &apos;{1}&apos;.
        /// </summary>
        internal static string ExtractedNameFromJsonMismatchWarning {
            get {
                return ResourceManager.GetString("ExtractedNameFromJsonMismatchWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}
        ///For data factory naming restrictions, please see http://msdn.microsoft.com/en-us/library/dn835027.aspx.
        /// </summary>
        internal static string FormattedArgumentOutOfRangeExceptionMessageTemplate {
            get {
                return ResourceManager.GetString("FormattedArgumentOutOfRangeExceptionMessageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP Status Code: {0}
        ///Error Code: {1}
        ///Error Message: {2}
        ///Request Id: {3}
        ///Timestamp (Utc):{4}.
        /// </summary>
        internal static string FormattedCloudExceptionMessageTemplate {
            get {
                return ResourceManager.GetString("FormattedCloudExceptionMessageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove hub &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string HubConfirmationMessage {
            get {
                return ResourceManager.GetString("HubConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating hub &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubCreating {
            get {
                return ResourceManager.GetString("HubCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A hub with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string HubExists {
            get {
                return ResourceManager.GetString("HubExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hub &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubNotFound {
            get {
                return ResourceManager.GetString("HubNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to provision the hub.  Please check if there is any error in the hub properties before re-create it again..
        /// </summary>
        internal static string HubProvisioningFailed {
            get {
                return ResourceManager.GetString("HubProvisioningFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing hub &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubRemoving {
            get {
                return ResourceManager.GetString("HubRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The integration runtime object provided is invalid. .
        /// </summary>
        internal static string IntegrationRuntimeArgumentInvalid {
            get {
                return ResourceManager.GetString("IntegrationRuntimeArgumentInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove integration runtime &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string IntegrationRuntimeConfirmationMessage {
            get {
                return ResourceManager.GetString("IntegrationRuntimeConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An integration runtime with the name {0} in the data factory {1} exists..
        /// </summary>
        internal static string IntegrationRuntimeExisting {
            get {
                return ResourceManager.GetString("IntegrationRuntimeExisting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An integration runtime with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the existing one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string IntegrationRuntimeExists {
            get {
                return ResourceManager.GetString("IntegrationRuntimeExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both VNetId and Subnet must be set..
        /// </summary>
        internal static string IntegrationRuntimeInvalidVnet {
            get {
                return ResourceManager.GetString("IntegrationRuntimeInvalidVnet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove node {0} in integration runtime &apos;{1}&apos;&apos;?.
        /// </summary>
        internal static string IntegrationRuntimeNodeConfirmationMessage {
            get {
                return ResourceManager.GetString("IntegrationRuntimeNodeConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The node &apos;{0}&apos; does not exist in integration runtime &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeNodeNotFound {
            get {
                return ResourceManager.GetString("IntegrationRuntimeNodeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the node {0} in integration runtime &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeNodeRemoving {
            get {
                return ResourceManager.GetString("IntegrationRuntimeNodeRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integration runtime &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeNotFound {
            get {
                return ResourceManager.GetString("IntegrationRuntimeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing the integration runtime &apos;{0}&apos; in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeRemoving {
            get {
                return ResourceManager.GetString("IntegrationRuntimeRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting integration runtime &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeStarting {
            get {
                return ResourceManager.GetString("IntegrationRuntimeStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping integration runtime &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeStopping {
            get {
                return ResourceManager.GetString("IntegrationRuntimeStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syncing node credentials in integration runtime &apos;{0}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeSyncingNodeCredential {
            get {
                return ResourceManager.GetString("IntegrationRuntimeSyncingNodeCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to sync node credentials in integration runtime &apos;{0}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeSyncNodeCredential {
            get {
                return ResourceManager.GetString("IntegrationRuntimeSyncNodeCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating integration runtime &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string IntegrationRuntimeUpdating {
            get {
                return ResourceManager.GetString("IntegrationRuntimeUpdating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value for pramater &apos;Type&apos; is different with existing integration runtime with name {0}..
        /// </summary>
        internal static string IntegrationRuntimeWrongType {
            get {
                return ResourceManager.GetString("IntegrationRuntimeWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All keys in the parameters hashtable must be of type string since they represent pipeline parameter names..
        /// </summary>
        internal static string InvalidCastParameterKeyExceptionMessage {
            get {
                return ResourceManager.GetString("InvalidCastParameterKeyExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to parse input JSON file. {0}. Please correct the error in the JSON file and re-deploy {1} again..
        /// </summary>
        internal static string InvalidJson {
            get {
                return ResourceManager.GetString("InvalidJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Json is not valid. Details: &apos;{0}&apos;.
        /// </summary>
        internal static string JsonIsInvalidTemplate {
            get {
                return ResourceManager.GetString("JsonIsInvalidTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove linked service &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string LinkedServiceConfirmationMessage {
            get {
                return ResourceManager.GetString("LinkedServiceConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating linked service &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceCreating {
            get {
                return ResourceManager.GetString("LinkedServiceCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A linked service with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string LinkedServiceExists {
            get {
                return ResourceManager.GetString("LinkedServiceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Linked service &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceNotFound {
            get {
                return ResourceManager.GetString("LinkedServiceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing linked service &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceRemoving {
            get {
                return ResourceManager.GetString("LinkedServiceRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pramater &apos;Type&apos; must be provided when creating new integration runtime..
        /// </summary>
        internal static string NeedIntegrationRuntimeType {
            get {
                return ResourceManager.GetString("NeedIntegrationRuntimeType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Slices were found in the time range specified. .
        /// </summary>
        internal static string NoDataSliceFound {
            get {
                return ResourceManager.GetString("NoDataSliceFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No access to write for the specified directory {0} or the directory does not exist..
        /// </summary>
        internal static string NoWriteAccessToDirectory {
            get {
                return ResourceManager.GetString("NoWriteAccessToDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string PipelineConfirmationMessage {
            get {
                return ResourceManager.GetString("PipelineConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineCreating {
            get {
                return ResourceManager.GetString("PipelineCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A pipeline with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string PipelineExists {
            get {
                return ResourceManager.GetString("PipelineExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipeline &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineNotFound {
            get {
                return ResourceManager.GetString("PipelineNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineRemoving {
            get {
                return ResourceManager.GetString("PipelineRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop pipeline run &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string PipelineRunStopConfirmation {
            get {
                return ResourceManager.GetString("PipelineRunStopConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping pipeline run &apos;{0}&apos; in data factory &apos;{1}&apos;.
        /// </summary>
        internal static string PipelineRunStopping {
            get {
                return ResourceManager.GetString("PipelineRunStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Renegerate the authentication key &apos;{0}&apos; of integration runtime {1}..
        /// </summary>
        internal static string RegenerateAuthKey {
            get {
                return ResourceManager.GetString("RegenerateAuthKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource group name cannot be null..
        /// </summary>
        internal static string ResourceGroupNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("ResourceGroupNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove trigger &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string TriggerConfirmationMessage {
            get {
                return ResourceManager.GetString("TriggerConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating trigger &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TriggerCreating {
            get {
                return ResourceManager.GetString("TriggerCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A trigger with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string TriggerExists {
            get {
                return ResourceManager.GetString("TriggerExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trigger &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TriggerNotFound {
            get {
                return ResourceManager.GetString("TriggerNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing trigger &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TriggerRemoving {
            get {
                return ResourceManager.GetString("TriggerRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to start trigger &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string TriggerStartConfirmation {
            get {
                return ResourceManager.GetString("TriggerStartConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting trigger &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TriggerStarting {
            get {
                return ResourceManager.GetString("TriggerStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop trigger &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string TriggerStopConfirmation {
            get {
                return ResourceManager.GetString("TriggerStopConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping trigger &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TriggerStopping {
            get {
                return ResourceManager.GetString("TriggerStopping", resourceCulture);
            }
        }
    }
}
