/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

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
