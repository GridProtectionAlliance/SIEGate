﻿//******************************************************************************************************
//  App.xaml.cs - Gbtc
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
//  09/07/2010 - Stephen C. Wills
//       Generated original version of source code.
//  03/02/2011 - J. Ritchie Carroll
//       Added unhandled exception logger with dialog for better end user problem diagnosis.
//
//******************************************************************************************************

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows;
using GSF.IO;
using GSF.Security.Cryptography;
using GSF.Windows.ErrorManagement;

namespace ConfigurationSetupUtility
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region [ Members ]

        // Constants
        public const CipherStrength CryptoStrength = CipherStrength.Aes256;
        public const string CipherLookupKey = "0679d9ae-aca5-4702-a3f5-604415096987";
        public const string ApplicationExe = "SIEGate.exe";
        public const string ApplicationConfig = "SIEGate.exe.config";
        public const string Manager = "SIEGateManager";
        public const string ManagerExe = "SIEGateManager.exe";
        public const string ManagerConfig = "SIEGateManager.exe.config";
        public const string BaseSqliteConfig = "SIEGate.db";
        public readonly static string SqliteConfigv2 = "SIEGate" + DatabaseVersionSuffix + ".db";
        public const string SqliteSampleData = "SIEGate-SampleDataSet.db";
        public const string SqliteInitialData = "SIEGate-InitialDataSet.db";
        private readonly ErrorLogger m_errorLogger;
        private readonly Func<string> m_defaultErrorText;

        #endregion

        #region [ Constructors ]

        public App()
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);

            m_errorLogger = new ErrorLogger();
            m_defaultErrorText = m_errorLogger.ErrorTextMethod;
            m_errorLogger.ErrorTextMethod = ErrorText;
            m_errorLogger.ExitOnUnhandledException = false;
            m_errorLogger.HandleUnhandledException = true;
            m_errorLogger.LogToEmail = false;
            m_errorLogger.LogToEventLog = true;
            m_errorLogger.LogToFile = true;
            m_errorLogger.LogToScreenshot = true;
            m_errorLogger.LogToUI = true;
            m_errorLogger.Initialize();

            // When run from the installer the current directory may not be the directory where this application is running
            Directory.SetCurrentDirectory(FilePath.GetAbsolutePath(""));

            // Attempt to create an event log source for the SIEGate Manager for authentication logging. This needs to be done
            // here since the CSU runs with administrative privileges and the SIEGate Manager normally does not; also there is
            // a short system delay that exists before you can write to a new event log source after it is first created.
            try
            {
                string applicationName = "SIEGate";

                // Create the event log source based on defined application name for SIEGate if it does not already exist
                if (!EventLog.SourceExists(applicationName))
                    EventLog.CreateEventSource(applicationName, "Application");

                applicationName = "SIEGate Manager";

                // Create the event log source based on defined application name for SIEGate Manager if it does not already exist
                if (!EventLog.SourceExists(applicationName))
                    EventLog.CreateEventSource(applicationName, "Application");
            }
            catch (Exception ex)
            {
                m_errorLogger.Log(new InvalidOperationException(string.Format("Warning: failed to create or validate the event log source for the SIEGate Manager: {0}", ex.Message), ex), false);
            }
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets the error logger for the configuration setup utility.
        /// </summary>
        public ErrorLogger ErrorLogger
        {
            get
            {
                return m_errorLogger;
            }
        }

        #endregion

        #region [ Methods ]

        private string ErrorText()
        {
            string errorMessage = m_defaultErrorText();
            Exception ex = m_errorLogger.LastException;

            if (ex != null)
            {
                if (string.Compare(ex.Message, "UnhandledException", true) == 0 && ex.InnerException != null)
                    ex = ex.InnerException;

                errorMessage = string.Format("{0}\r\n\r\nError details: {1}", errorMessage, ex.Message);
            }

            return errorMessage;
        }

        #endregion

        #region [ Static ]

        // Static Methods

        private static string s_currentVersionLabel;

        /// <summary>
        /// Gets database name suffix for current application version, e.g., "v21" for version 2.1
        /// </summary>
        public static string DatabaseVersionSuffix
        {
            get
            {
                if (!string.IsNullOrEmpty(s_currentVersionLabel))
                    return s_currentVersionLabel;

                try
                {
                    Version version = Assembly.GetEntryAssembly().GetName().Version;
                    s_currentVersionLabel = string.Format("v{0}{1}", version.Major, version.Minor);
                }
                catch
                {
                    s_currentVersionLabel = "v2";
                }

                return s_currentVersionLabel;
            }
        }

        #endregion
    }
}
