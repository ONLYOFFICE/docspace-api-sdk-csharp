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
    ///  Class for testing SecurityAuditTrailDataApi
    /// </summary>
    public class SecurityAuditTrailDataApiTests : IDisposable
    {
        private SecurityAuditTrailDataApi instance;

        public SecurityAuditTrailDataApiTests()
        {
            instance = new SecurityAuditTrailDataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityAuditTrailDataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecurityAuditTrailDataApi
            //Assert.IsType<SecurityAuditTrailDataApi>(instance);
        }

        /// <summary>
        /// Test CreateAuditTrailReport
        /// </summary>
        [Fact]
        public void CreateAuditTrailReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.CreateAuditTrailReport();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetAuditEventsByFilter
        /// </summary>
        [Fact]
        public void GetAuditEventsByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //ProductType? productType = null;
            //ModuleType? moduleType = null;
            //ActionType? actionType = null;
            //MessageAction? action = null;
            //EntryType? entryType = null;
            //string? target = null;
            //ApiDateTime? from = null;
            //ApiDateTime? to = null;
            //int? count = null;
            //int? startIndex = null;
            //string fields = null;
            //var response = instance.GetAuditEventsByFilter(userId, productType, moduleType, actionType, action, entryType, target, from, to, count, startIndex, fields);
            //Assert.IsType<AuditEventArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetAuditSettings
        /// </summary>
        [Fact]
        public void GetAuditSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAuditSettings();
            //Assert.IsType<TenantAuditSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetAuditTrailMappers
        /// </summary>
        [Fact]
        public void GetAuditTrailMappersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductType? productType = null;
            //ModuleType? moduleType = null;
            //var response = instance.GetAuditTrailMappers(productType, moduleType);
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetAuditTrailTypes
        /// </summary>
        [Fact]
        public void GetAuditTrailTypesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAuditTrailTypes();
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test GetLastAuditEvents
        /// </summary>
        [Fact]
        public void GetLastAuditEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLastAuditEvents();
            //Assert.IsType<AuditEventArrayWrapper>(response);
        }

        /// <summary>
        /// Test SetAuditSettings
        /// </summary>
        [Fact]
        public void SetAuditSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TenantAuditSettingsWrapper? tenantAuditSettingsWrapper = null;
            //var response = instance.SetAuditSettings(tenantAuditSettingsWrapper);
            //Assert.IsType<TenantAuditSettingsWrapper>(response);
        }
    }
}
