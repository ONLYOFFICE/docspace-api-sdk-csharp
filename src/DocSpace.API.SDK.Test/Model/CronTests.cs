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
    ///  Class for testing Cron
    /// </summary>
    public class CronTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Cron
        //private Cron instance;

        public CronTests()
        {
            // TODO uncomment below to create an instance of Cron
            //instance = new Cron();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Cron
        /// </summary>
        [Fact]
        public void CronInstanceTest()
        {
            // TODO uncomment below to test "IsType" Cron
            //Assert.IsType<Cron>(instance);
        }



        /// <summary>
        /// Test the property 'Period'
        /// </summary>
        [Fact]
        public void PeriodTest()
        {
            // TODO unit test for the property 'Period'
        }


        /// <summary>
        /// Test the property 'Hour'
        /// </summary>
        [Fact]
        public void HourTest()
        {
            // TODO unit test for the property 'Hour'
        }


        /// <summary>
        /// Test the property 'Day'
        /// </summary>
        [Fact]
        public void DayTest()
        {
            // TODO unit test for the property 'Day'
        }
    }
}
