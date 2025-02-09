//******************************************************************************************************
//  ServiceHost.cs - Gbtc
//
//  Copyright © 2011, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the Eclipse Public License -v 1.0 (the "License"); you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/eclipse-1.0.php
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  09/02/2009 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using GSF.TimeSeries;
using GSF;
using GSF.Configuration;
using GSF.Diagnostics;

namespace SIEGate
{
    public class ServiceHost : ServiceHostBase
    {
        public ServiceHost()
        {
            ServiceName = "SIEGate";
        }

        protected override void ServiceStartingHandler(object sender, EventArgs<string[]> e)
        {
            // Handle base class service starting procedures
            base.ServiceStartingHandler(sender, e);

            try
            {
                // Make sure SIEGate specific default service settings exist
                CategorizedSettingsElementCollection systemSettings = ConfigurationFile.Current.Settings["systemSettings"];

                systemSettings.Add("CompanyName", "Grid Protection Alliance", "The name of the company who owns this instance of the SIEGate.");
                systemSettings.Add("CompanyAcronym", "GPA", "The acronym representing the company who owns this instance of the SIEGate.");
                systemSettings.Add("DefaultCalculationLagTime", 5.0, "Defines the default lag-time value, in seconds, for template calculations");
                systemSettings.Add("DefaultCalculationLeadTime", 5.0, "Defines the default lead-time value, in seconds, for template calculations");
                systemSettings.Add("DefaultCalculationFramesPerSecond", 30, "Defines the default frames-per-second value for template calculations");

                ConfigurationFile.Current.Save();
            }
            catch (Exception ex)
            {
                Logger.SwallowException(new InvalidOperationException($"{nameof(ServiceStartingHandler)} failed while adding default settings: {ex.Message}", ex));
            }
        }
    }
}
