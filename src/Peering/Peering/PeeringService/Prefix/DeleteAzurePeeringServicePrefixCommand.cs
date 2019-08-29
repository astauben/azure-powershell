﻿// ----------------------------------------------------------------------------------
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
namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Peering
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Management.Automation;
    using System.Net.Http;

    using Microsoft.Azure.Commands.Peering.Properties;
    using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
    using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
    using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
    using Microsoft.Azure.Management.Peering;
    using Microsoft.Azure.Management.Peering.Models;
    using Microsoft.Azure.PowerShell.Cmdlets.Peering.Common;
    using Microsoft.Azure.PowerShell.Cmdlets.Peering.Models;

    /// <summary>
    /// New Azure InputObject Command-let
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "AzPeeringServicePrefix", DefaultParameterSetName = Constants.ParameterSetNameByName, SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public class DeleteAzurePeeringServicePrefixCommand : PeeringBaseCmdlet
    {
        /// <summary>
        /// Gets or sets the legacy InputObject.
        /// </summary>
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            ParameterSetName = Constants.ParameterSetNameDefault,
            HelpMessage = Constants.PrefixInputObjectHelp + "Prefix")]
        [ValidateNotNullOrEmpty]
        public PSPeeringServicePrefix InputObject { get; set; }

        /// <summary>
        /// Gets or sets The Resource Group Name
        /// </summary>
        [Parameter(
            Position = 0,
            Mandatory = true,
            HelpMessage = Constants.ResourceGroupNameHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets The InputObject NameMD5AuthenticationKeyHelp
        /// </summary>
        [Parameter(
            Position = 1,
            Mandatory = true,
            HelpMessage = Constants.PeeringNameHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets The InputObject NameMD5AuthenticationKeyHelp
        /// </summary>
        [Parameter(
            Position = 2,
            Mandatory = true,
            HelpMessage = Constants.PeeringNameHelp,
            ParameterSetName = Constants.ParameterSetNameByName)]
        [ValidateNotNullOrEmpty]
        public string PeeringServiceName { get; set; }

        /// <summary>
        /// The resource  id
        /// </summary>
        [Parameter(
            Position = 0,
            Mandatory = true,
            HelpMessage = Constants.ResourceIdHelp,
            ParameterSetName = Constants.ParameterSetNameByResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = Constants.ForceHelp)]
        public SwitchParameter Force { get; set; }

        /// <summary>
        ///     The AsJob parameter to run in the background.
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = Constants.AsJobHelp)]
        public SwitchParameter AsJob { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }


        /// <summary>
        /// The inherited Execute function.
        /// </summary>
        public override void ExecuteCmdlet()
        {
            try
            {
                this.ConfirmAction(
                    Force.IsPresent,
                    string.Format(Resources.ProcessMessage, this.Name),
                    Resources.ContinueMessage,
                    this.Name,
                    () =>
                    {
                        if (this.ResourceId != null)
                        {
                            var resourceId = new ResourceIdentifier(this.ResourceId);
                            this.ResourceGroupName = resourceId.ResourceGroupName;
                            this.Name = resourceId.ResourceName;
                            this.PeeringServiceName = resourceId.ParentResource.Split('/')?[1];
                        }
                        if (this.InputObject != null)
                        {
                            var resourceId = new ResourceIdentifier(this.InputObject.Id);
                            this.ResourceGroupName = resourceId.ResourceGroupName;
                            this.Name = resourceId.ResourceName;
                            this.PeeringServiceName = resourceId.ParentResource.Split('/')?[1];
                        }
                        try
                        {
                            this.PeeringServicePrefixesClient.Delete(this.ResourceGroupName, this.PeeringServiceName, this.Name);
                            if (this.PassThru.IsPresent)
                            {
                                WriteObject(true);
                            }
                        }
                        catch (Exception ex)
                        {
                            this.WriteVerbose(ex.Message);
                            if (this.PassThru.IsPresent)
                            {
                                WriteObject(false);
                            }
                        }
                    }
                    );
            }
            catch (InvalidOperationException mapException)
            {
                throw new InvalidOperationException(string.Format(Resources.Error_Mapping, mapException));
            }
            catch (ErrorResponseException ex)
            {
                var error = GetErrorCodeAndMessageFromArmOrErm(ex);
                throw new ErrorResponseException(string.Format(Resources.Error_CloudError, error.Code, error.Message));
            }
        }
    }
}
