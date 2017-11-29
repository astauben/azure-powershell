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

using System;
using System.Collections;
using System.Globalization;
using System.Management.Automation;
using System.Security.Permissions;
using Microsoft.Azure.Commands.DataFactoryV2.Models;
using Microsoft.Azure.Commands.DataFactoryV2.Properties;
using Microsoft.Azure.Management.DataFactory.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;

namespace Microsoft.Azure.Commands.DataFactoryV2
{
    [Cmdlet(VerbsData.Update, Constants.DataFactory, DefaultParameterSetName = ParameterSetNames.ByFactoryName, SupportsShouldProcess = true),
        OutputType(typeof(PSDataFactory))]
    public class UpdateAzureDataFactoryCommand : DataFactoryBaseCmdlet
    {
        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryName, Position = 0, Mandatory = true,
            HelpMessage = Constants.HelpResourceGroup)]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryName, Position = 1, Mandatory = true,
            HelpMessage = Constants.HelpFactoryName)]
        [Alias(Constants.DataFactoryName)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryObject, Position = 0, Mandatory = true, ValueFromPipeline = true,
            HelpMessage = Constants.HelpFactoryObject)]
        [ValidateNotNullOrEmpty]
        public PSDataFactory InputObject { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ByResourceId, Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true,
            HelpMessage = Constants.HelpResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryName, Position = 2, Mandatory = false,
            HelpMessage = Constants.HelpTagsForFactory)]
        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryObject, Position = 1, Mandatory = false,
            HelpMessage = Constants.HelpTagsForFactory)]
        [Parameter(ParameterSetName = ParameterSetNames.ByResourceId, Position = 1, Mandatory = false,
            HelpMessage = Constants.HelpTagsForFactory)]
        public Hashtable Tag { get; set; }

        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryName, Position = 2, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = Constants.HelpIdentityForFactory)]
        [Parameter(ParameterSetName = ParameterSetNames.ByFactoryObject, Position = 1, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = Constants.HelpIdentityForFactory)]
        [Parameter(ParameterSetName = ParameterSetNames.ByResourceId, Position = 1, Mandatory = false, ValueFromPipelineByPropertyName = true,
            HelpMessage = Constants.HelpIdentityForFactory)]
        public FactoryIdentity Identity { get; set; }

        [Parameter(Mandatory = false, HelpMessage = Constants.HelpDontAskConfirmation)]
        public SwitchParameter Force { get; set; }

        [EnvironmentPermission(SecurityAction.Demand, Unrestricted = true)]
        public override void ExecuteCmdlet()
        {
            if (ParameterSetName.Equals(ParameterSetNames.ByFactoryObject, StringComparison.OrdinalIgnoreCase))
            {
                Name = InputObject.DataFactoryName;
                ResourceGroupName = InputObject.ResourceGroupName;
            }
            else if (ParameterSetName.Equals(ParameterSetNames.ByResourceId, StringComparison.OrdinalIgnoreCase))
            {
                var parsedResourceId = new ResourceIdentifier(ResourceId);
                Name = parsedResourceId.ResourceName;
                ResourceGroupName = parsedResourceId.ResourceGroupName;
            }

            var parameters = new UpdatePSDataFactoryParameters()
            {
                ResourceGroupName = ResourceGroupName,
                DataFactoryName = Name,
                Tags = Tag,
                Identity = Identity
            };

            ConfirmAction(Force.IsPresent,
                string.Format(
                    CultureInfo.InvariantCulture,
                    Resources.DataFactoryUpdateConfirm,
                    parameters.DataFactoryName,
                    parameters.ResourceGroupName),
                string.Format(
                    CultureInfo.InvariantCulture,
                    Resources.DataFactoryUpdating,
                    parameters.DataFactoryName,
                    parameters.ResourceGroupName),
                Name,
                () => WriteObject(DataFactoryClient.UpdatePSDataFactory(parameters)));
        }
    }
}