// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using DocSpace.Client;
using DocSpace.Api;
// uncomment below to import models
//using DocSpace.Model;

namespace DocSpace.Test.Api
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
