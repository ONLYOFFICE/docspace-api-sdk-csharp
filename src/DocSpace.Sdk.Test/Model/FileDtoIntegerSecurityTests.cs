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
    ///  Class for testing FileDtoIntegerSecurity
    /// </summary>
    public class FileDtoIntegerSecurityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FileDtoIntegerSecurity
        //private FileDtoIntegerSecurity instance;

        public FileDtoIntegerSecurityTests()
        {
            // TODO uncomment below to create an instance of FileDtoIntegerSecurity
            //instance = new FileDtoIntegerSecurity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileDtoIntegerSecurity
        /// </summary>
        [Fact]
        public void FileDtoIntegerSecurityInstanceTest()
        {
            // TODO uncomment below to test "IsType" FileDtoIntegerSecurity
            //Assert.IsType<FileDtoIntegerSecurity>(instance);
        }



        /// <summary>
        /// Test the property 'Read'
        /// </summary>
        [Fact]
        public void ReadTest()
        {
            // TODO unit test for the property 'Read'
        }


        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }


        /// <summary>
        /// Test the property 'FillForms'
        /// </summary>
        [Fact]
        public void FillFormsTest()
        {
            // TODO unit test for the property 'FillForms'
        }


        /// <summary>
        /// Test the property 'Review'
        /// </summary>
        [Fact]
        public void ReviewTest()
        {
            // TODO unit test for the property 'Review'
        }


        /// <summary>
        /// Test the property 'Create'
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO unit test for the property 'Create'
        }


        /// <summary>
        /// Test the property 'CreateFrom'
        /// </summary>
        [Fact]
        public void CreateFromTest()
        {
            // TODO unit test for the property 'CreateFrom'
        }


        /// <summary>
        /// Test the property 'Edit'
        /// </summary>
        [Fact]
        public void EditTest()
        {
            // TODO unit test for the property 'Edit'
        }


        /// <summary>
        /// Test the property 'Delete'
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO unit test for the property 'Delete'
        }


        /// <summary>
        /// Test the property 'CustomFilter'
        /// </summary>
        [Fact]
        public void CustomFilterTest()
        {
            // TODO unit test for the property 'CustomFilter'
        }


        /// <summary>
        /// Test the property 'EditRoom'
        /// </summary>
        [Fact]
        public void EditRoomTest()
        {
            // TODO unit test for the property 'EditRoom'
        }


        /// <summary>
        /// Test the property 'Rename'
        /// </summary>
        [Fact]
        public void RenameTest()
        {
            // TODO unit test for the property 'Rename'
        }


        /// <summary>
        /// Test the property 'ReadHistory'
        /// </summary>
        [Fact]
        public void ReadHistoryTest()
        {
            // TODO unit test for the property 'ReadHistory'
        }


        /// <summary>
        /// Test the property 'Lock'
        /// </summary>
        [Fact]
        public void LockTest()
        {
            // TODO unit test for the property 'Lock'
        }


        /// <summary>
        /// Test the property 'EditHistory'
        /// </summary>
        [Fact]
        public void EditHistoryTest()
        {
            // TODO unit test for the property 'EditHistory'
        }


        /// <summary>
        /// Test the property 'CopyTo'
        /// </summary>
        [Fact]
        public void CopyToTest()
        {
            // TODO unit test for the property 'CopyTo'
        }


        /// <summary>
        /// Test the property 'Copy'
        /// </summary>
        [Fact]
        public void CopyTest()
        {
            // TODO unit test for the property 'Copy'
        }


        /// <summary>
        /// Test the property 'MoveTo'
        /// </summary>
        [Fact]
        public void MoveToTest()
        {
            // TODO unit test for the property 'MoveTo'
        }


        /// <summary>
        /// Test the property 'Move'
        /// </summary>
        [Fact]
        public void MoveTest()
        {
            // TODO unit test for the property 'Move'
        }


        /// <summary>
        /// Test the property 'Pin'
        /// </summary>
        [Fact]
        public void PinTest()
        {
            // TODO unit test for the property 'Pin'
        }


        /// <summary>
        /// Test the property 'Mute'
        /// </summary>
        [Fact]
        public void MuteTest()
        {
            // TODO unit test for the property 'Mute'
        }


        /// <summary>
        /// Test the property 'EditAccess'
        /// </summary>
        [Fact]
        public void EditAccessTest()
        {
            // TODO unit test for the property 'EditAccess'
        }


        /// <summary>
        /// Test the property 'Duplicate'
        /// </summary>
        [Fact]
        public void DuplicateTest()
        {
            // TODO unit test for the property 'Duplicate'
        }


        /// <summary>
        /// Test the property 'SubmitToFormGallery'
        /// </summary>
        [Fact]
        public void SubmitToFormGalleryTest()
        {
            // TODO unit test for the property 'SubmitToFormGallery'
        }


        /// <summary>
        /// Test the property 'Download'
        /// </summary>
        [Fact]
        public void DownloadTest()
        {
            // TODO unit test for the property 'Download'
        }


        /// <summary>
        /// Test the property 'Convert'
        /// </summary>
        [Fact]
        public void ConvertTest()
        {
            // TODO unit test for the property 'Convert'
        }


        /// <summary>
        /// Test the property 'CopySharedLink'
        /// </summary>
        [Fact]
        public void CopySharedLinkTest()
        {
            // TODO unit test for the property 'CopySharedLink'
        }


        /// <summary>
        /// Test the property 'ReadLinks'
        /// </summary>
        [Fact]
        public void ReadLinksTest()
        {
            // TODO unit test for the property 'ReadLinks'
        }


        /// <summary>
        /// Test the property 'Reconnect'
        /// </summary>
        [Fact]
        public void ReconnectTest()
        {
            // TODO unit test for the property 'Reconnect'
        }


        /// <summary>
        /// Test the property 'CreateRoomFrom'
        /// </summary>
        [Fact]
        public void CreateRoomFromTest()
        {
            // TODO unit test for the property 'CreateRoomFrom'
        }


        /// <summary>
        /// Test the property 'CopyLink'
        /// </summary>
        [Fact]
        public void CopyLinkTest()
        {
            // TODO unit test for the property 'CopyLink'
        }


        /// <summary>
        /// Test the property 'Embed'
        /// </summary>
        [Fact]
        public void EmbedTest()
        {
            // TODO unit test for the property 'Embed'
        }


        /// <summary>
        /// Test the property 'ChangeOwner'
        /// </summary>
        [Fact]
        public void ChangeOwnerTest()
        {
            // TODO unit test for the property 'ChangeOwner'
        }


        /// <summary>
        /// Test the property 'IndexExport'
        /// </summary>
        [Fact]
        public void IndexExportTest()
        {
            // TODO unit test for the property 'IndexExport'
        }


        /// <summary>
        /// Test the property 'StartFilling'
        /// </summary>
        [Fact]
        public void StartFillingTest()
        {
            // TODO unit test for the property 'StartFilling'
        }


        /// <summary>
        /// Test the property 'FillingStatus'
        /// </summary>
        [Fact]
        public void FillingStatusTest()
        {
            // TODO unit test for the property 'FillingStatus'
        }


        /// <summary>
        /// Test the property 'ResetFilling'
        /// </summary>
        [Fact]
        public void ResetFillingTest()
        {
            // TODO unit test for the property 'ResetFilling'
        }


        /// <summary>
        /// Test the property 'StopFilling'
        /// </summary>
        [Fact]
        public void StopFillingTest()
        {
            // TODO unit test for the property 'StopFilling'
        }


        /// <summary>
        /// Test the property 'OpenForm'
        /// </summary>
        [Fact]
        public void OpenFormTest()
        {
            // TODO unit test for the property 'OpenForm'
        }
    }
}
