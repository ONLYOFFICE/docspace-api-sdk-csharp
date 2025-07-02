// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PortalSettingsApi
    /// </summary>
    public class PortalSettingsApiTests : IDisposable
    {
        private PortalSettingsApi instance;

        public PortalSettingsApiTests()
        {
            instance = new PortalSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PortalSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PortalSettingsApi
            //Assert.IsType<PortalSettingsApi>(instance);
        }

        /// <summary>
        /// Test ContinuePortal
        /// </summary>
        [Fact]
        public void ContinuePortalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ContinuePortal();
        }

        /// <summary>
        /// Test DeletePortal
        /// </summary>
        [Fact]
        public void DeletePortalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.DeletePortal();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalInformation
        /// </summary>
        [Fact]
        public void GetPortalInformationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetPortalInformation();
            //Assert.IsType<TenantWrapper>(response);
        }

        /// <summary>
        /// Test GetPortalPath
        /// </summary>
        [Fact]
        public void GetPortalPathTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? virtualPath = null;
            //var response = instance.GetPortalPath(virtualPath);
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test SendDeleteInstructions
        /// </summary>
        [Fact]
        public void SendDeleteInstructionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.SendDeleteInstructions();
        }

        /// <summary>
        /// Test SendSuspendInstructions
        /// </summary>
        [Fact]
        public void SendSuspendInstructionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.SendSuspendInstructions();
        }

        /// <summary>
        /// Test SuspendPortal
        /// </summary>
        [Fact]
        public void SuspendPortalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.SuspendPortal();
        }
    }
}
