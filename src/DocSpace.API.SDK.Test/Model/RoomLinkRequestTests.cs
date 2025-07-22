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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.API.SDK.Model;
using DocSpace.API.SDK.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.API.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing RoomLinkRequest
    /// </summary>
    public class RoomLinkRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoomLinkRequest
        //private RoomLinkRequest instance;

        public RoomLinkRequestTests()
        {
            // TODO uncomment below to create an instance of RoomLinkRequest
            //instance = new RoomLinkRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoomLinkRequest
        /// </summary>
        [Fact]
        public void RoomLinkRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RoomLinkRequest
            //Assert.IsType<RoomLinkRequest>(instance);
        }



        /// <summary>
        /// Test the property 'LinkId'
        /// </summary>
        [Fact]
        public void LinkIdTest()
        {
            // TODO unit test for the property 'LinkId'
        }


        /// <summary>
        /// Test the property 'Access'
        /// </summary>
        [Fact]
        public void AccessTest()
        {
            // TODO unit test for the property 'Access'
        }


        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Fact]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }


        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }


        /// <summary>
        /// Test the property 'LinkType'
        /// </summary>
        [Fact]
        public void LinkTypeTest()
        {
            // TODO unit test for the property 'LinkType'
        }


        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }


        /// <summary>
        /// Test the property 'DenyDownload'
        /// </summary>
        [Fact]
        public void DenyDownloadTest()
        {
            // TODO unit test for the property 'DenyDownload'
        }
    }
}
