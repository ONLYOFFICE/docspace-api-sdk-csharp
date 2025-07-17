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
    ///  Class for testing IpRestrictionsDto
    /// </summary>
    public class IpRestrictionsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IpRestrictionsDto
        //private IpRestrictionsDto instance;

        public IpRestrictionsDtoTests()
        {
            // TODO uncomment below to create an instance of IpRestrictionsDto
            //instance = new IpRestrictionsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IpRestrictionsDto
        /// </summary>
        [Fact]
        public void IpRestrictionsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" IpRestrictionsDto
            //Assert.IsType<IpRestrictionsDto>(instance);
        }



        /// <summary>
        /// Test the property 'IpRestrictions'
        /// </summary>
        [Fact]
        public void IpRestrictionsTest()
        {
            // TODO unit test for the property 'IpRestrictions'
        }


        /// <summary>
        /// Test the property 'Enable'
        /// </summary>
        [Fact]
        public void EnableTest()
        {
            // TODO unit test for the property 'Enable'
        }
    }
}
