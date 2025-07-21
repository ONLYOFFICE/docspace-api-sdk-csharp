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
    ///  Class for testing SecurityFirebaseApi
    /// </summary>
    public class SecurityFirebaseApiTests : IDisposable
    {
        private SecurityFirebaseApi instance;

        public SecurityFirebaseApiTests()
        {
            instance = new SecurityFirebaseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityFirebaseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SecurityFirebaseApi
            //Assert.IsType<SecurityFirebaseApi>(instance);
        }

        /// <summary>
        /// Test DocRegisterPusnNotificationDevice
        /// </summary>
        [Fact]
        public void DocRegisterPusnNotificationDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FirebaseRequestsDto? firebaseRequestsDto = null;
            //var response = instance.DocRegisterPusnNotificationDevice(firebaseRequestsDto);
            //Assert.IsType<FireBaseUserWrapper>(response);
        }

        /// <summary>
        /// Test SubscribeDocumentsPushNotification
        /// </summary>
        [Fact]
        public void SubscribeDocumentsPushNotificationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FirebaseRequestsDto? firebaseRequestsDto = null;
            //var response = instance.SubscribeDocumentsPushNotification(firebaseRequestsDto);
            //Assert.IsType<FireBaseUserWrapper>(response);
        }
    }
}
