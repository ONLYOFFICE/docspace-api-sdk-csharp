// (c) Copyright Ascensio System SIA 2025
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


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
    ///  Class for testing SettingsWebhooksApi
    /// </summary>
    public class SettingsWebhooksApiTests : IDisposable
    {
        private SettingsWebhooksApi instance;

        public SettingsWebhooksApiTests()
        {
            instance = new SettingsWebhooksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsWebhooksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsWebhooksApi
            //Assert.IsType<SettingsWebhooksApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhook
        /// </summary>
        [Fact]
        public void CreateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateWebhooksConfigRequestsDto? createWebhooksConfigRequestsDto = null;
            //var response = instance.CreateWebhook(createWebhooksConfigRequestsDto);
            //Assert.IsType<WebhooksConfigWrapper>(response);
        }

        /// <summary>
        /// Test EnableWebhook
        /// </summary>
        [Fact]
        public void EnableWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = null;
            //var response = instance.EnableWebhook(updateWebhooksConfigRequestsDto);
            //Assert.IsType<WebhooksConfigWrapper>(response);
        }

        /// <summary>
        /// Test GetTenantWebhooks
        /// </summary>
        [Fact]
        public void GetTenantWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetTenantWebhooks();
            //Assert.IsType<WebhooksConfigWithStatusArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetWebhookTriggers
        /// </summary>
        [Fact]
        public void GetWebhookTriggersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetWebhookTriggers();
            //Assert.IsType<UnknownWrapper>(response);
        }

        /// <summary>
        /// Test GetWebhooksLogs
        /// </summary>
        [Fact]
        public void GetWebhooksLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? deliveryFrom = null;
            //DateTime? deliveryTo = null;
            //string? hookUri = null;
            //int? configId = null;
            //int? eventId = null;
            //WebhookGroupStatus? groupStatus = null;
            //Guid? userId = null;
            //WebhookTrigger? trigger = null;
            //int? count = null;
            //int? startIndex = null;
            //string fields = null;
            //var response = instance.GetWebhooksLogs(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex, fields);
            //Assert.IsType<WebhooksLogArrayWrapper>(response);
        }

        /// <summary>
        /// Test RemoveWebhook
        /// </summary>
        [Fact]
        public void RemoveWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.RemoveWebhook(id);
            //Assert.IsType<WebhooksConfigWrapper>(response);
        }

        /// <summary>
        /// Test RetryWebhook
        /// </summary>
        [Fact]
        public void RetryWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.RetryWebhook(id);
            //Assert.IsType<WebhooksLogWrapper>(response);
        }

        /// <summary>
        /// Test RetryWebhooks
        /// </summary>
        [Fact]
        public void RetryWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebhookRetryRequestsDto? webhookRetryRequestsDto = null;
            //var response = instance.RetryWebhooks(webhookRetryRequestsDto);
            //Assert.IsType<WebhooksLogArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateWebhook
        /// </summary>
        [Fact]
        public void UpdateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateWebhooksConfigRequestsDto? updateWebhooksConfigRequestsDto = null;
            //var response = instance.UpdateWebhook(updateWebhooksConfigRequestsDto);
            //Assert.IsType<WebhooksConfigWrapper>(response);
        }
    }
}
