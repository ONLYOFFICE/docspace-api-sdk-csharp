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
    ///  Class for testing MemberBaseRequestDto
    /// </summary>
    public class MemberBaseRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MemberBaseRequestDto
        //private MemberBaseRequestDto instance;

        public MemberBaseRequestDtoTests()
        {
            // TODO uncomment below to create an instance of MemberBaseRequestDto
            //instance = new MemberBaseRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MemberBaseRequestDto
        /// </summary>
        [Fact]
        public void MemberBaseRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" MemberBaseRequestDto
            //Assert.IsType<MemberBaseRequestDto>(instance);
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
        /// Test the property 'PasswordHash'
        /// </summary>
        [Fact]
        public void PasswordHashTest()
        {
            // TODO unit test for the property 'PasswordHash'
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
    }
}
