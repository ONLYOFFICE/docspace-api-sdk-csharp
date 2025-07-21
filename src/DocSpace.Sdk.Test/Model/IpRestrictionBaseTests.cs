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
    ///  Class for testing IpRestrictionBase
    /// </summary>
    public class IpRestrictionBaseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for IpRestrictionBase
        //private IpRestrictionBase instance;

        public IpRestrictionBaseTests()
        {
            // TODO uncomment below to create an instance of IpRestrictionBase
            //instance = new IpRestrictionBase();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IpRestrictionBase
        /// </summary>
        [Fact]
        public void IpRestrictionBaseInstanceTest()
        {
            // TODO uncomment below to test "IsType" IpRestrictionBase
            //Assert.IsType<IpRestrictionBase>(instance);
        }



        /// <summary>
        /// Test the property 'Ip'
        /// </summary>
        [Fact]
        public void IpTest()
        {
            // TODO unit test for the property 'Ip'
        }


        /// <summary>
        /// Test the property 'ForAdmin'
        /// </summary>
        [Fact]
        public void ForAdminTest()
        {
            // TODO unit test for the property 'ForAdmin'
        }
    }
}
