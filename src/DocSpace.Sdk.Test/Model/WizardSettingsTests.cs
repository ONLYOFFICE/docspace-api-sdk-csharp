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
    ///  Class for testing WizardSettings
    /// </summary>
    public class WizardSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WizardSettings
        //private WizardSettings instance;

        public WizardSettingsTests()
        {
            // TODO uncomment below to create an instance of WizardSettings
            //instance = new WizardSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WizardSettings
        /// </summary>
        [Fact]
        public void WizardSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" WizardSettings
            //Assert.IsType<WizardSettings>(instance);
        }



        /// <summary>
        /// Test the property 'Completed'
        /// </summary>
        [Fact]
        public void CompletedTest()
        {
            // TODO unit test for the property 'Completed'
        }


        /// <summary>
        /// Test the property 'LastModified'
        /// </summary>
        [Fact]
        public void LastModifiedTest()
        {
            // TODO unit test for the property 'LastModified'
        }
    }
}
