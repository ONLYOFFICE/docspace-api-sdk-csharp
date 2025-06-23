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


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Docspace.Model;
using Docspace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Docspace.Test.Model
{
    /// <summary>
    ///  Class for testing FileDtoInteger
    /// </summary>
    public class FileDtoIntegerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FileDtoInteger
        //private FileDtoInteger instance;

        public FileDtoIntegerTests()
        {
            // TODO uncomment below to create an instance of FileDtoInteger
            //instance = new FileDtoInteger();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FileDtoInteger
        /// </summary>
        [Fact]
        public void FileDtoIntegerInstanceTest()
        {
            // TODO uncomment below to test "IsType" FileDtoInteger
            //Assert.IsType<FileDtoInteger>(instance);
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'Access'
        /// </summary>
        [Fact]
        public void AccessTest()
        {
            // TODO unit test for the property 'Access'
        }

        /// <summary>
        /// Test the property 'Shared'
        /// </summary>
        [Fact]
        public void SharedTest()
        {
            // TODO unit test for the property 'Shared'
        }

        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Fact]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }

        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }

        /// <summary>
        /// Test the property 'Updated'
        /// </summary>
        [Fact]
        public void UpdatedTest()
        {
            // TODO unit test for the property 'Updated'
        }

        /// <summary>
        /// Test the property 'AutoDelete'
        /// </summary>
        [Fact]
        public void AutoDeleteTest()
        {
            // TODO unit test for the property 'AutoDelete'
        }

        /// <summary>
        /// Test the property 'RootFolderType'
        /// </summary>
        [Fact]
        public void RootFolderTypeTest()
        {
            // TODO unit test for the property 'RootFolderType'
        }

        /// <summary>
        /// Test the property 'ParentRoomType'
        /// </summary>
        [Fact]
        public void ParentRoomTypeTest()
        {
            // TODO unit test for the property 'ParentRoomType'
        }

        /// <summary>
        /// Test the property 'UpdatedBy'
        /// </summary>
        [Fact]
        public void UpdatedByTest()
        {
            // TODO unit test for the property 'UpdatedBy'
        }

        /// <summary>
        /// Test the property 'ProviderItem'
        /// </summary>
        [Fact]
        public void ProviderItemTest()
        {
            // TODO unit test for the property 'ProviderItem'
        }

        /// <summary>
        /// Test the property 'ProviderKey'
        /// </summary>
        [Fact]
        public void ProviderKeyTest()
        {
            // TODO unit test for the property 'ProviderKey'
        }

        /// <summary>
        /// Test the property 'ProviderId'
        /// </summary>
        [Fact]
        public void ProviderIdTest()
        {
            // TODO unit test for the property 'ProviderId'
        }

        /// <summary>
        /// Test the property 'Order'
        /// </summary>
        [Fact]
        public void OrderTest()
        {
            // TODO unit test for the property 'Order'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'RootFolderId'
        /// </summary>
        [Fact]
        public void RootFolderIdTest()
        {
            // TODO unit test for the property 'RootFolderId'
        }

        /// <summary>
        /// Test the property 'OriginId'
        /// </summary>
        [Fact]
        public void OriginIdTest()
        {
            // TODO unit test for the property 'OriginId'
        }

        /// <summary>
        /// Test the property 'OriginRoomId'
        /// </summary>
        [Fact]
        public void OriginRoomIdTest()
        {
            // TODO unit test for the property 'OriginRoomId'
        }

        /// <summary>
        /// Test the property 'OriginTitle'
        /// </summary>
        [Fact]
        public void OriginTitleTest()
        {
            // TODO unit test for the property 'OriginTitle'
        }

        /// <summary>
        /// Test the property 'OriginRoomTitle'
        /// </summary>
        [Fact]
        public void OriginRoomTitleTest()
        {
            // TODO unit test for the property 'OriginRoomTitle'
        }

        /// <summary>
        /// Test the property 'CanShare'
        /// </summary>
        [Fact]
        public void CanShareTest()
        {
            // TODO unit test for the property 'CanShare'
        }

        /// <summary>
        /// Test the property 'Security'
        /// </summary>
        [Fact]
        public void SecurityTest()
        {
            // TODO unit test for the property 'Security'
        }

        /// <summary>
        /// Test the property 'RequestToken'
        /// </summary>
        [Fact]
        public void RequestTokenTest()
        {
            // TODO unit test for the property 'RequestToken'
        }

        /// <summary>
        /// Test the property 'FolderId'
        /// </summary>
        [Fact]
        public void FolderIdTest()
        {
            // TODO unit test for the property 'FolderId'
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'VersionGroup'
        /// </summary>
        [Fact]
        public void VersionGroupTest()
        {
            // TODO unit test for the property 'VersionGroup'
        }

        /// <summary>
        /// Test the property 'ContentLength'
        /// </summary>
        [Fact]
        public void ContentLengthTest()
        {
            // TODO unit test for the property 'ContentLength'
        }

        /// <summary>
        /// Test the property 'PureContentLength'
        /// </summary>
        [Fact]
        public void PureContentLengthTest()
        {
            // TODO unit test for the property 'PureContentLength'
        }

        /// <summary>
        /// Test the property 'FileStatus'
        /// </summary>
        [Fact]
        public void FileStatusTest()
        {
            // TODO unit test for the property 'FileStatus'
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
        /// Test the property 'ViewUrl'
        /// </summary>
        [Fact]
        public void ViewUrlTest()
        {
            // TODO unit test for the property 'ViewUrl'
        }

        /// <summary>
        /// Test the property 'WebUrl'
        /// </summary>
        [Fact]
        public void WebUrlTest()
        {
            // TODO unit test for the property 'WebUrl'
        }

        /// <summary>
        /// Test the property 'ShortWebUrl'
        /// </summary>
        [Fact]
        public void ShortWebUrlTest()
        {
            // TODO unit test for the property 'ShortWebUrl'
        }

        /// <summary>
        /// Test the property 'FileType'
        /// </summary>
        [Fact]
        public void FileTypeTest()
        {
            // TODO unit test for the property 'FileType'
        }

        /// <summary>
        /// Test the property 'FileExst'
        /// </summary>
        [Fact]
        public void FileExstTest()
        {
            // TODO unit test for the property 'FileExst'
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
        /// Test the property 'Encrypted'
        /// </summary>
        [Fact]
        public void EncryptedTest()
        {
            // TODO unit test for the property 'Encrypted'
        }

        /// <summary>
        /// Test the property 'ThumbnailUrl'
        /// </summary>
        [Fact]
        public void ThumbnailUrlTest()
        {
            // TODO unit test for the property 'ThumbnailUrl'
        }

        /// <summary>
        /// Test the property 'ThumbnailStatus'
        /// </summary>
        [Fact]
        public void ThumbnailStatusTest()
        {
            // TODO unit test for the property 'ThumbnailStatus'
        }

        /// <summary>
        /// Test the property 'Locked'
        /// </summary>
        [Fact]
        public void LockedTest()
        {
            // TODO unit test for the property 'Locked'
        }

        /// <summary>
        /// Test the property 'LockedBy'
        /// </summary>
        [Fact]
        public void LockedByTest()
        {
            // TODO unit test for the property 'LockedBy'
        }

        /// <summary>
        /// Test the property 'HasDraft'
        /// </summary>
        [Fact]
        public void HasDraftTest()
        {
            // TODO unit test for the property 'HasDraft'
        }

        /// <summary>
        /// Test the property 'FormFillingStatus'
        /// </summary>
        [Fact]
        public void FormFillingStatusTest()
        {
            // TODO unit test for the property 'FormFillingStatus'
        }

        /// <summary>
        /// Test the property 'IsForm'
        /// </summary>
        [Fact]
        public void IsFormTest()
        {
            // TODO unit test for the property 'IsForm'
        }

        /// <summary>
        /// Test the property 'CustomFilterEnabled'
        /// </summary>
        [Fact]
        public void CustomFilterEnabledTest()
        {
            // TODO unit test for the property 'CustomFilterEnabled'
        }

        /// <summary>
        /// Test the property 'CustomFilterEnabledBy'
        /// </summary>
        [Fact]
        public void CustomFilterEnabledByTest()
        {
            // TODO unit test for the property 'CustomFilterEnabledBy'
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
        /// Test the property 'InProcessFolderId'
        /// </summary>
        [Fact]
        public void InProcessFolderIdTest()
        {
            // TODO unit test for the property 'InProcessFolderId'
        }

        /// <summary>
        /// Test the property 'InProcessFolderTitle'
        /// </summary>
        [Fact]
        public void InProcessFolderTitleTest()
        {
            // TODO unit test for the property 'InProcessFolderTitle'
        }

        /// <summary>
        /// Test the property 'DraftLocation'
        /// </summary>
        [Fact]
        public void DraftLocationTest()
        {
            // TODO unit test for the property 'DraftLocation'
        }

        /// <summary>
        /// Test the property 'ViewAccessibility'
        /// </summary>
        [Fact]
        public void ViewAccessibilityTest()
        {
            // TODO unit test for the property 'ViewAccessibility'
        }

        /// <summary>
        /// Test the property 'AvailableExternalRights'
        /// </summary>
        [Fact]
        public void AvailableExternalRightsTest()
        {
            // TODO unit test for the property 'AvailableExternalRights'
        }

        /// <summary>
        /// Test the property 'LastOpened'
        /// </summary>
        [Fact]
        public void LastOpenedTest()
        {
            // TODO unit test for the property 'LastOpened'
        }

        /// <summary>
        /// Test the property 'Expired'
        /// </summary>
        [Fact]
        public void ExpiredTest()
        {
            // TODO unit test for the property 'Expired'
        }

        /// <summary>
        /// Test the property 'FileEntryType'
        /// </summary>
        [Fact]
        public void FileEntryTypeTest()
        {
            // TODO unit test for the property 'FileEntryType'
        }
    }
}
