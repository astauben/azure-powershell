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
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Sql.Common;
using Microsoft.Azure.Commands.Sql.ThreatDetection.Model;

namespace Microsoft.Azure.Commands.Sql.ThreatDetection.Cmdlet
{
    /// <summary>
    /// Sets the auditing policy properties for a specific database.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, "AzureRmSqlDatabaseThreatDetectionPolicy"), OutputType(typeof(ThreatDetectionPolicyModel))]
    public class SetAzureSqlDatabaseThreatDetection : SqlDatabaseThreatDetectionCmdletBase
    {
        /// <summary>
        ///  Defines whether the cmdlets will output the model object at the end of its execution
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        /// Gets or sets the Threat Detection Email Addresses
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "A semicolon separated list of email addresses to send the alerts to")]
        public string NotificationRecipientsEmail { get; set; }

        /// <summary>
        /// Gets or sets the whether to email administrators
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Defines whether to email administrators")]
        [ValidateNotNullOrEmpty]
        public bool? EmailAdmins { get; set; }


        /// <summary>
        /// Gets or sets the names of the detection types to filter.
        /// </summary>
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "Detection types to filter")]
        [ValidateSet(SecurityConstants.Successful_SQLi, SecurityConstants.Attempted_SQLi, SecurityConstants.Client_GEO_Anomaly, SecurityConstants.Failed_Logins_Anomaly, SecurityConstants.Failed_Queries_Anomaly, SecurityConstants.Data_Extraction_Anomaly, SecurityConstants.Data_Alteration_Anomaly, IgnoreCase = false)]
        public string[] FilterDetectionTypes { get; set; }

        /// <summary>
        /// Returns true if the model object that was constructed by this cmdlet should be written out
        /// </summary>
        /// <returns>True if the model object should be written out, False otherwise</returns>
        protected override bool WriteResult() { return PassThru; }

        /// <summary>
        /// Updates the given model element with the cmdlet specific operation 
        /// </summary>
        /// <param name="model">A model object</param>
        protected override ThreatDetectionPolicyModel ApplyUserInputToModel(ThreatDetectionPolicyModel model)
        {
            base.ApplyUserInputToModel(model);

            model.ThreatDetectionState = ThreatDetectionStateType.Disabled;

            if (NotificationRecipientsEmail != null)
            {
                model.NotificationRecipientsEmail = NotificationRecipientsEmail;
            }

            if (EmailAdmins != null)
            {
                model.EmailAdmins = (bool)EmailAdmins;
            }

            if (FilterDetectionTypes != null)
            {
                model.FilterDetectionTypes = FilterDetectionTypes.Select(s => SecurityConstants.FilterDetectionToFilterDetectionTypes[s]).ToArray(); ;
            }

            if (model.ThreatDetectionState == ThreatDetectionStateType.Enabled)
            {
                // Validity checks:
                // 1. check that EmailAdmins is not False and NotificationRecipientsEmail is not empty
                if (!model.EmailAdmins && string.IsNullOrEmpty(model.NotificationRecipientsEmail))
                {
                    throw new Exception(Properties.Resources.NeedToProvideEmail);
                }
            }

            return model;
        }
    }
}