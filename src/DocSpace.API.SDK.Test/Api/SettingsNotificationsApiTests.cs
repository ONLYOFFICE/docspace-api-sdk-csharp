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

using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Api;
// uncomment below to import models
//using DocSpace.API.SDK.Model;

namespace DocSpace.API.SDK.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsNotificationsApi
    /// </summary>
    public class SettingsNotificationsApiTests : IDisposable
    {
        private SettingsNotificationsApi instance;

        public SettingsNotificationsApiTests()
        {
            instance = new SettingsNotificationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsNotificationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsNotificationsApi
            //Assert.IsType<SettingsNotificationsApi>(instance);
        }

        /// <summary>
        /// Test GetNotificationSettings
        /// </summary>
        [Fact]
        public void GetNotificationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotificationType type = null;
            //var response = instance.GetNotificationSettings(type);
            //Assert.IsType<NotificationSettingsWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomsNotificationSettings
        /// </summary>
        [Fact]
        public void GetRoomsNotificationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomsNotificationSettings();
            //Assert.IsType<RoomsNotificationSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SetNotificationSettings
        /// </summary>
        [Fact]
        public void SetNotificationSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NotificationSettingsRequestsDto? notificationSettingsRequestsDto = null;
            //var response = instance.SetNotificationSettings(notificationSettingsRequestsDto);
            //Assert.IsType<NotificationSettingsWrapper>(response);
        }

        /// <summary>
        /// Test SetRoomsNotificationStatus
        /// </summary>
        [Fact]
        public void SetRoomsNotificationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoomsNotificationsSettingsRequestDto? roomsNotificationsSettingsRequestDto = null;
            //var response = instance.SetRoomsNotificationStatus(roomsNotificationsSettingsRequestDto);
            //Assert.IsType<RoomsNotificationSettingsWrapper>(response);
        }
    }
}
