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
    ///  Class for testing SettingsMessagesApi
    /// </summary>
    public class SettingsMessagesApiTests : IDisposable
    {
        private SettingsMessagesApi instance;

        public SettingsMessagesApiTests()
        {
            instance = new SettingsMessagesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsMessagesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsMessagesApi
            //Assert.IsType<SettingsMessagesApi>(instance);
        }

        /// <summary>
        /// Test EnableAdminMessageSettings
        /// </summary>
        [Fact]
        public void EnableAdminMessageSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TurnOnAdminMessageSettingsRequestDto? turnOnAdminMessageSettingsRequestDto = null;
            //var response = instance.EnableAdminMessageSettings(turnOnAdminMessageSettingsRequestDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SendAdminMail
        /// </summary>
        [Fact]
        public void SendAdminMailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminMessageSettingsRequestsDto? adminMessageSettingsRequestsDto = null;
            //var response = instance.SendAdminMail(adminMessageSettingsRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SendJoinInviteMail
        /// </summary>
        [Fact]
        public void SendJoinInviteMailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AdminMessageBaseSettingsRequestsDto? adminMessageBaseSettingsRequestsDto = null;
            //var response = instance.SendJoinInviteMail(adminMessageBaseSettingsRequestsDto);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
