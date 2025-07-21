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
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using System.Text.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing RoomInvitationRequest
    /// </summary>
    public class RoomInvitationRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for RoomInvitationRequest
        //private RoomInvitationRequest instance;

        public RoomInvitationRequestTests()
        {
            // TODO uncomment below to create an instance of RoomInvitationRequest
            //instance = new RoomInvitationRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoomInvitationRequest
        /// </summary>
        [Fact]
        public void RoomInvitationRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" RoomInvitationRequest
            //Assert.IsType<RoomInvitationRequest>(instance);
        }



        /// <summary>
        /// Test the property 'Invitations'
        /// </summary>
        [Fact]
        public void InvitationsTest()
        {
            // TODO unit test for the property 'Invitations'
        }


        /// <summary>
        /// Test the property 'Notify'
        /// </summary>
        [Fact]
        public void NotifyTest()
        {
            // TODO unit test for the property 'Notify'
        }


        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }


        /// <summary>
        /// Test the property 'Culture'
        /// </summary>
        [Fact]
        public void CultureTest()
        {
            // TODO unit test for the property 'Culture'
        }


        /// <summary>
        /// Test the property 'Force'
        /// </summary>
        [Fact]
        public void ForceTest()
        {
            // TODO unit test for the property 'Force'
        }
    }
}
