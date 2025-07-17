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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing SecurityDto
    /// </summary>
    public class SecurityDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SecurityDto
        //private SecurityDto instance;

        public SecurityDtoTests()
        {
            // TODO uncomment below to create an instance of SecurityDto
            //instance = new SecurityDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SecurityDto
        /// </summary>
        [Fact]
        public void SecurityDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" SecurityDto
            //Assert.IsType<SecurityDto>(instance);
        }



        /// <summary>
        /// Test the property 'WebItemId'
        /// </summary>
        [Fact]
        public void WebItemIdTest()
        {
            // TODO unit test for the property 'WebItemId'
        }


        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }


        /// <summary>
        /// Test the property 'Groups'
        /// </summary>
        [Fact]
        public void GroupsTest()
        {
            // TODO unit test for the property 'Groups'
        }


        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }


        /// <summary>
        /// Test the property 'IsSubItem'
        /// </summary>
        [Fact]
        public void IsSubItemTest()
        {
            // TODO unit test for the property 'IsSubItem'
        }
    }
}
