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

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
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
            //var response = instance.GetWebhooksLogs(deliveryFrom, deliveryTo, hookUri, configId, eventId, groupStatus, userId, trigger, count, startIndex);
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
