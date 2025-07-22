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
    ///  Class for testing PasswordSettingsDto
    /// </summary>
    public class PasswordSettingsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PasswordSettingsDto
        //private PasswordSettingsDto instance;

        public PasswordSettingsDtoTests()
        {
            // TODO uncomment below to create an instance of PasswordSettingsDto
            //instance = new PasswordSettingsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PasswordSettingsDto
        /// </summary>
        [Fact]
        public void PasswordSettingsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" PasswordSettingsDto
            //Assert.IsType<PasswordSettingsDto>(instance);
        }



        /// <summary>
        /// Test the property 'MinLength'
        /// </summary>
        [Fact]
        public void MinLengthTest()
        {
            // TODO unit test for the property 'MinLength'
        }


        /// <summary>
        /// Test the property 'UpperCase'
        /// </summary>
        [Fact]
        public void UpperCaseTest()
        {
            // TODO unit test for the property 'UpperCase'
        }


        /// <summary>
        /// Test the property 'Digits'
        /// </summary>
        [Fact]
        public void DigitsTest()
        {
            // TODO unit test for the property 'Digits'
        }


        /// <summary>
        /// Test the property 'SpecSymbols'
        /// </summary>
        [Fact]
        public void SpecSymbolsTest()
        {
            // TODO unit test for the property 'SpecSymbols'
        }


        /// <summary>
        /// Test the property 'AllowedCharactersRegexStr'
        /// </summary>
        [Fact]
        public void AllowedCharactersRegexStrTest()
        {
            // TODO unit test for the property 'AllowedCharactersRegexStr'
        }


        /// <summary>
        /// Test the property 'DigitsRegexStr'
        /// </summary>
        [Fact]
        public void DigitsRegexStrTest()
        {
            // TODO unit test for the property 'DigitsRegexStr'
        }


        /// <summary>
        /// Test the property 'UpperCaseRegexStr'
        /// </summary>
        [Fact]
        public void UpperCaseRegexStrTest()
        {
            // TODO unit test for the property 'UpperCaseRegexStr'
        }


        /// <summary>
        /// Test the property 'SpecSymbolsRegexStr'
        /// </summary>
        [Fact]
        public void SpecSymbolsRegexStrTest()
        {
            // TODO unit test for the property 'SpecSymbolsRegexStr'
        }
    }
}
