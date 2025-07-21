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
    ///  Class for testing FilesSharingApi
    /// </summary>
    public class FilesSharingApiTests : IDisposable
    {
        private FilesSharingApi instance;

        public FilesSharingApiTests()
        {
            instance = new FilesSharingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesSharingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesSharingApi
            //Assert.IsType<FilesSharingApi>(instance);
        }

        /// <summary>
        /// Test ApplyExternalSharePassword
        /// </summary>
        [Fact]
        public void ApplyExternalSharePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //ExternalShareRequestParam? externalShareRequestParam = null;
            //var response = instance.ApplyExternalSharePassword(key, externalShareRequestParam);
            //Assert.IsType<ExternalShareWrapper>(response);
        }

        /// <summary>
        /// Test ChangeFileOwner
        /// </summary>
        [Fact]
        public void ChangeFileOwnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChangeOwnerRequestDto? changeOwnerRequestDto = null;
            //var response = instance.ChangeFileOwner(changeOwnerRequestDto);
            //Assert.IsType<FileEntryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetExternalShareData
        /// </summary>
        [Fact]
        public void GetExternalShareDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string? fileId = null;
            //var response = instance.GetExternalShareData(key, fileId);
            //Assert.IsType<ExternalShareWrapper>(response);
        }

        /// <summary>
        /// Test GetSharedUsers
        /// </summary>
        [Fact]
        public void GetSharedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetSharedUsers(fileId);
            //Assert.IsType<MentionWrapperArrayWrapper>(response);
        }

        /// <summary>
        /// Test SendEditorNotify
        /// </summary>
        [Fact]
        public void SendEditorNotifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //MentionMessageWrapper? mentionMessageWrapper = null;
            //var response = instance.SendEditorNotify(fileId, mentionMessageWrapper);
            //Assert.IsType<AceShortWrapperArrayWrapper>(response);
        }
    }
}
