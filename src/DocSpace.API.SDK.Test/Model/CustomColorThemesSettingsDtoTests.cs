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
    ///  Class for testing CustomColorThemesSettingsDto
    /// </summary>
    public class CustomColorThemesSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CustomColorThemesSettingsDto
        //private CustomColorThemesSettingsDto instance;

        public CustomColorThemesSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of CustomColorThemesSettingsDto
            //instance = new CustomColorThemesSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomColorThemesSettingsDto
        /// </summary>
        [Fact]
        public void CustomColorThemesSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" CustomColorThemesSettingsDto
            //Assert.IsType<CustomColorThemesSettingsDto>(instance);
        }



        /// <summary>
        /// Test the property 'Themes'
        /// </summary>
        [Fact]
        public void ThemesTest()
        {
            // TODO unit test for the property 'Themes'
        }


        /// <summary>
        /// Test the property 'Selected'
        /// </summary>
        [Fact]
        public void SelectedTest()
        {
            // TODO unit test for the property 'Selected'
        }


        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }
    }
}
