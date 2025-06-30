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
    ///  Class for testing FilesSharingApi
    /// </summary>
    public class FilesSharingApiTests : IDisposable
    {
        private FilesSharingApi instance;

        public FilesSharingApiTests()
        {
            instance = new FilesSharingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesSharingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesSharingApi
            //Assert.IsType<FilesSharingApi>(instance);
        }

        /// <summary>
        /// Test ApplyExternalSharePassword
        /// </summary>
        [Fact]
        public void ApplyExternalSharePasswordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //ExternalShareRequestParam? externalShareRequestParam = null;
            //var response = instance.ApplyExternalSharePassword(key, externalShareRequestParam);
            //Assert.IsType<ExternalShareWrapper>(response);
        }

        /// <summary>
        /// Test ChangeFileOwner
        /// </summary>
        [Fact]
        public void ChangeFileOwnerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChangeOwnerRequestDto? changeOwnerRequestDto = null;
            //var response = instance.ChangeFileOwner(changeOwnerRequestDto);
            //Assert.IsType<FileEntryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetExternalShareData
        /// </summary>
        [Fact]
        public void GetExternalShareDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string? fileId = null;
            //var response = instance.GetExternalShareData(key, fileId);
            //Assert.IsType<ExternalShareWrapper>(response);
        }

        /// <summary>
        /// Test GetSharedUsers
        /// </summary>
        [Fact]
        public void GetSharedUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetSharedUsers(fileId);
            //Assert.IsType<MentionWrapperArrayWrapper>(response);
        }

        /// <summary>
        /// Test SendEditorNotify
        /// </summary>
        [Fact]
        public void SendEditorNotifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //MentionMessageWrapper? mentionMessageWrapper = null;
            //var response = instance.SendEditorNotify(fileId, mentionMessageWrapper);
            //Assert.IsType<AceShortWrapperArrayWrapper>(response);
        }
    }
}
