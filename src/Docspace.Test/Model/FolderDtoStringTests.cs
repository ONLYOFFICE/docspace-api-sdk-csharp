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
using DocSpace.Model;
using DocSpace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Test.Model
{
    /// <summary>
    ///  Class for testing FolderDtoString
    /// </summary>
    public class FolderDtoStringTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FolderDtoString
        //private FolderDtoString instance;

        public FolderDtoStringTests()
        {
            // TODO uncomment below to create an instance of FolderDtoString
            //instance = new FolderDtoString();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FolderDtoString
        /// </summary>
        [Fact]
        public void FolderDtoStringInstanceTest()
        {
            // TODO uncomment below to test "IsType" FolderDtoString
            //Assert.IsType<FolderDtoString>(instance);
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
        /// Test the property 'ParentId'
        /// </summary>
        [Fact]
        public void ParentIdTest()
        {
            // TODO unit test for the property 'ParentId'
        }

        /// <summary>
        /// Test the property 'FilesCount'
        /// </summary>
        [Fact]
        public void FilesCountTest()
        {
            // TODO unit test for the property 'FilesCount'
        }

        /// <summary>
        /// Test the property 'FoldersCount'
        /// </summary>
        [Fact]
        public void FoldersCountTest()
        {
            // TODO unit test for the property 'FoldersCount'
        }

        /// <summary>
        /// Test the property 'IsShareable'
        /// </summary>
        [Fact]
        public void IsShareableTest()
        {
            // TODO unit test for the property 'IsShareable'
        }

        /// <summary>
        /// Test the property 'IsFavorite'
        /// </summary>
        [Fact]
        public void IsFavoriteTest()
        {
            // TODO unit test for the property 'IsFavorite'
        }

        /// <summary>
        /// Test the property 'New'
        /// </summary>
        [Fact]
        public void NewTest()
        {
            // TODO unit test for the property 'New'
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
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }

        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Fact]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }

        /// <summary>
        /// Test the property 'Pinned'
        /// </summary>
        [Fact]
        public void PinnedTest()
        {
            // TODO unit test for the property 'Pinned'
        }

        /// <summary>
        /// Test the property 'RoomType'
        /// </summary>
        [Fact]
        public void RoomTypeTest()
        {
            // TODO unit test for the property 'RoomType'
        }

        /// <summary>
        /// Test the property 'Private'
        /// </summary>
        [Fact]
        public void PrivateTest()
        {
            // TODO unit test for the property 'Private'
        }

        /// <summary>
        /// Test the property 'Indexing'
        /// </summary>
        [Fact]
        public void IndexingTest()
        {
            // TODO unit test for the property 'Indexing'
        }

        /// <summary>
        /// Test the property 'DenyDownload'
        /// </summary>
        [Fact]
        public void DenyDownloadTest()
        {
            // TODO unit test for the property 'DenyDownload'
        }

        /// <summary>
        /// Test the property 'Lifetime'
        /// </summary>
        [Fact]
        public void LifetimeTest()
        {
            // TODO unit test for the property 'Lifetime'
        }

        /// <summary>
        /// Test the property 'Watermark'
        /// </summary>
        [Fact]
        public void WatermarkTest()
        {
            // TODO unit test for the property 'Watermark'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }

        /// <summary>
        /// Test the property 'InRoom'
        /// </summary>
        [Fact]
        public void InRoomTest()
        {
            // TODO unit test for the property 'InRoom'
        }

        /// <summary>
        /// Test the property 'QuotaLimit'
        /// </summary>
        [Fact]
        public void QuotaLimitTest()
        {
            // TODO unit test for the property 'QuotaLimit'
        }

        /// <summary>
        /// Test the property 'IsCustomQuota'
        /// </summary>
        [Fact]
        public void IsCustomQuotaTest()
        {
            // TODO unit test for the property 'IsCustomQuota'
        }

        /// <summary>
        /// Test the property 'UsedSpace'
        /// </summary>
        [Fact]
        public void UsedSpaceTest()
        {
            // TODO unit test for the property 'UsedSpace'
        }

        /// <summary>
        /// Test the property 'External'
        /// </summary>
        [Fact]
        public void ExternalTest()
        {
            // TODO unit test for the property 'External'
        }

        /// <summary>
        /// Test the property 'PasswordProtected'
        /// </summary>
        [Fact]
        public void PasswordProtectedTest()
        {
            // TODO unit test for the property 'PasswordProtected'
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
