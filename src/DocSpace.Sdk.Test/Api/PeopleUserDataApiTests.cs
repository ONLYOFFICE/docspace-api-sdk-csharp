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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing PeopleUserDataApi
    /// </summary>
    public class PeopleUserDataApiTests : IDisposable
    {
        private PeopleUserDataApi instance;

        public PeopleUserDataApiTests()
        {
            instance = new PeopleUserDataApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeopleUserDataApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeopleUserDataApi
            //Assert.IsType<PeopleUserDataApi>(instance);
        }

        /// <summary>
        /// Test GetDeletePersonalFolderProgress
        /// </summary>
        [Fact]
        public void GetDeletePersonalFolderProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDeletePersonalFolderProgress();
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test GetReassignProgress
        /// </summary>
        [Fact]
        public void GetReassignProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userid = null;
            //var response = instance.GetReassignProgress(userid);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test GetRemoveProgress
        /// </summary>
        [Fact]
        public void GetRemoveProgressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid userid = null;
            //var response = instance.GetRemoveProgress(userid);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test NecessaryReassign
        /// </summary>
        [Fact]
        public void NecessaryReassignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? userId = null;
            //EmployeeType? type = null;
            //var response = instance.NecessaryReassign(userId, type);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test SendInstructionsToDelete
        /// </summary>
        [Fact]
        public void SendInstructionsToDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SendInstructionsToDelete();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test StartDeletePersonalFolder
        /// </summary>
        [Fact]
        public void StartDeletePersonalFolderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.StartDeletePersonalFolder();
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test StartReassign
        /// </summary>
        [Fact]
        public void StartReassignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StartReassignRequestDto? startReassignRequestDto = null;
            //var response = instance.StartReassign(startReassignRequestDto);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test StartRemove
        /// </summary>
        [Fact]
        public void StartRemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TerminateRequestDto? terminateRequestDto = null;
            //var response = instance.StartRemove(terminateRequestDto);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test TerminateReassign
        /// </summary>
        [Fact]
        public void TerminateReassignTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TerminateRequestDto? terminateRequestDto = null;
            //var response = instance.TerminateReassign(terminateRequestDto);
            //Assert.IsType<TaskProgressResponseWrapper>(response);
        }

        /// <summary>
        /// Test TerminateRemove
        /// </summary>
        [Fact]
        public void TerminateRemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TerminateRequestDto? terminateRequestDto = null;
            //instance.TerminateRemove(terminateRequestDto);
        }
    }
}
