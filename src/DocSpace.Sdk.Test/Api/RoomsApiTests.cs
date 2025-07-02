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

using DocSpace.Sdk.Client;
using DocSpace.Sdk.Api;
// uncomment below to import models
//using DocSpace.Sdk.Model;

namespace DocSpace.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing RoomsApi
    /// </summary>
    public class RoomsApiTests : IDisposable
    {
        private RoomsApi instance;

        public RoomsApiTests()
        {
            instance = new RoomsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RoomsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RoomsApi
            //Assert.IsType<RoomsApi>(instance);
        }

        /// <summary>
        /// Test AddRoomTags
        /// </summary>
        [Fact]
        public void AddRoomTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //BatchTagsRequestDto? batchTagsRequestDto = null;
            //var response = instance.AddRoomTags(id, batchTagsRequestDto);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test ArchiveRoom
        /// </summary>
        [Fact]
        public void ArchiveRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //ArchiveRoomRequest? archiveRoomRequest = null;
            //var response = instance.ArchiveRoom(id, archiveRoomRequest);
            //Assert.IsType<FileOperationWrapper>(response);
        }

        /// <summary>
        /// Test ChangeRoomCover
        /// </summary>
        [Fact]
        public void ChangeRoomCoverTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //CoverRequestDto? coverRequestDto = null;
            //var response = instance.ChangeRoomCover(id, coverRequestDto);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoom
        /// </summary>
        [Fact]
        public void CreateRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateRoomRequestDto? createRoomRequestDto = null;
            //var response = instance.CreateRoom(createRoomRequestDto);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoomFromTemplate
        /// </summary>
        [Fact]
        public void CreateRoomFromTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateRoomFromTemplateDto? createRoomFromTemplateDto = null;
            //var response = instance.CreateRoomFromTemplate(createRoomFromTemplateDto);
            //Assert.IsType<RoomFromTemplateStatusWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoomLogo
        /// </summary>
        [Fact]
        public void CreateRoomLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //LogoRequest? logoRequest = null;
            //var response = instance.CreateRoomLogo(id, logoRequest);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoomTag
        /// </summary>
        [Fact]
        public void CreateRoomTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTagRequestDto? createTagRequestDto = null;
            //var response = instance.CreateRoomTag(createTagRequestDto);
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoomTemplate
        /// </summary>
        [Fact]
        public void CreateRoomTemplateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RoomTemplateDto? roomTemplateDto = null;
            //var response = instance.CreateRoomTemplate(roomTemplateDto);
            //Assert.IsType<RoomTemplateStatusWrapper>(response);
        }

        /// <summary>
        /// Test CreateRoomThirdParty
        /// </summary>
        [Fact]
        public void CreateRoomThirdPartyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CreateThirdPartyRoom? createThirdPartyRoom = null;
            //var response = instance.CreateRoomThirdParty(id, createThirdPartyRoom);
            //Assert.IsType<FolderStringWrapper>(response);
        }

        /// <summary>
        /// Test DeleteCustomTags
        /// </summary>
        [Fact]
        public void DeleteCustomTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchTagsRequestDto? batchTagsRequestDto = null;
            //instance.DeleteCustomTags(batchTagsRequestDto);
        }

        /// <summary>
        /// Test DeleteRoom
        /// </summary>
        [Fact]
        public void DeleteRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DeleteRoomRequest? deleteRoomRequest = null;
            //var response = instance.DeleteRoom(id, deleteRoomRequest);
            //Assert.IsType<FileOperationWrapper>(response);
        }

        /// <summary>
        /// Test DeleteRoomLogo
        /// </summary>
        [Fact]
        public void DeleteRoomLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.DeleteRoomLogo(id);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test DeleteRoomTags
        /// </summary>
        [Fact]
        public void DeleteRoomTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //BatchTagsRequestDto? batchTagsRequestDto = null;
            //var response = instance.DeleteRoomTags(id, batchTagsRequestDto);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test GetNewRoomItems
        /// </summary>
        [Fact]
        public void GetNewRoomItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetNewRoomItems(id);
            //Assert.IsType<NewItemsFileEntryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetPublicSettings
        /// </summary>
        [Fact]
        public void GetPublicSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetPublicSettings(id);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomCovers
        /// </summary>
        [Fact]
        public void GetRoomCoversTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomCovers();
            //Assert.IsType<CoversResultArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomCreatingStatus
        /// </summary>
        [Fact]
        public void GetRoomCreatingStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomCreatingStatus();
            //Assert.IsType<RoomFromTemplateStatusWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomIndexExport
        /// </summary>
        [Fact]
        public void GetRoomIndexExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomIndexExport();
            //Assert.IsType<DocumentBuilderTaskWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomInfo
        /// </summary>
        [Fact]
        public void GetRoomInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetRoomInfo(id);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomLinks
        /// </summary>
        [Fact]
        public void GetRoomLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //LinkType? type = null;
            //var response = instance.GetRoomLinks(id, type);
            //Assert.IsType<FileShareArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomSecurityInfo
        /// </summary>
        [Fact]
        public void GetRoomSecurityInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //ShareFilterType? filterType = null;
            //int? count = null;
            //int? startIndex = null;
            //string? filterValue = null;
            //var response = instance.GetRoomSecurityInfo(id, filterType, count, startIndex, filterValue);
            //Assert.IsType<FileShareArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomTagsInfo
        /// </summary>
        [Fact]
        public void GetRoomTagsInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? count = null;
            //int? startIndex = null;
            //string? filterValue = null;
            //var response = instance.GetRoomTagsInfo(count, startIndex, filterValue);
            //Assert.IsType<ObjectArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomTemplateCreatingStatus
        /// </summary>
        [Fact]
        public void GetRoomTemplateCreatingStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomTemplateCreatingStatus();
            //Assert.IsType<RoomTemplateStatusWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomsFolder
        /// </summary>
        [Fact]
        public void GetRoomsFolderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<RoomType>? type = null;
            //string? subjectId = null;
            //SearchArea? searchArea = null;
            //bool? withoutTags = null;
            //string? tags = null;
            //bool? excludeSubject = null;
            //ProviderFilter? provider = null;
            //SubjectFilter? subjectFilter = null;
            //QuotaFilter? quotaFilter = null;
            //StorageFilter? storageFilter = null;
            //int? count = null;
            //int? startIndex = null;
            //string? sortBy = null;
            //SortOrder? sortOrder = null;
            //string? filterValue = null;
            //var response = instance.GetRoomsFolder(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue);
            //Assert.IsType<FolderContentIntegerWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomsNewItems
        /// </summary>
        [Fact]
        public void GetRoomsNewItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetRoomsNewItems();
            //Assert.IsType<NewItemsRoomNewItemsArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetRoomsPrimaryExternalLink
        /// </summary>
        [Fact]
        public void GetRoomsPrimaryExternalLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetRoomsPrimaryExternalLink(id);
            //Assert.IsType<FileShareWrapper>(response);
        }

        /// <summary>
        /// Test PinRoom
        /// </summary>
        [Fact]
        public void PinRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.PinRoom(id);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test ReorderRoom
        /// </summary>
        [Fact]
        public void ReorderRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.ReorderRoom(id);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test ResendEmailInvitations
        /// </summary>
        [Fact]
        public void ResendEmailInvitationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //UserInvitation? userInvitation = null;
            //instance.ResendEmailInvitations(id, userInvitation);
        }

        /// <summary>
        /// Test SetPublicSettings
        /// </summary>
        [Fact]
        public void SetPublicSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SetPublicDto? setPublicDto = null;
            //instance.SetPublicSettings(setPublicDto);
        }

        /// <summary>
        /// Test SetRoomLink
        /// </summary>
        [Fact]
        public void SetRoomLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //RoomLinkRequest? roomLinkRequest = null;
            //var response = instance.SetRoomLink(id, roomLinkRequest);
            //Assert.IsType<FileShareWrapper>(response);
        }

        /// <summary>
        /// Test SetRoomSecurity
        /// </summary>
        [Fact]
        public void SetRoomSecurityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //RoomInvitationRequest? roomInvitationRequest = null;
            //var response = instance.SetRoomSecurity(id, roomInvitationRequest);
            //Assert.IsType<RoomSecurityWrapper>(response);
        }

        /// <summary>
        /// Test StartRoomIndexExport
        /// </summary>
        [Fact]
        public void StartRoomIndexExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.StartRoomIndexExport(id);
            //Assert.IsType<DocumentBuilderTaskWrapper>(response);
        }

        /// <summary>
        /// Test TerminateRoomIndexExport
        /// </summary>
        [Fact]
        public void TerminateRoomIndexExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.TerminateRoomIndexExport();
        }

        /// <summary>
        /// Test UnarchiveRoom
        /// </summary>
        [Fact]
        public void UnarchiveRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //ArchiveRoomRequest? archiveRoomRequest = null;
            //var response = instance.UnarchiveRoom(id, archiveRoomRequest);
            //Assert.IsType<FileOperationWrapper>(response);
        }

        /// <summary>
        /// Test UnpinRoom
        /// </summary>
        [Fact]
        public void UnpinRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.UnpinRoom(id);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test UpdateRoom
        /// </summary>
        [Fact]
        public void UpdateRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //UpdateRoomRequest? updateRoomRequest = null;
            //var response = instance.UpdateRoom(id, updateRoomRequest);
            //Assert.IsType<FolderIntegerWrapper>(response);
        }

        /// <summary>
        /// Test UploadRoomLogo
        /// </summary>
        [Fact]
        public void UploadRoomLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<KeyValuePairStringStringValues>? formCollection = null;
            //var response = instance.UploadRoomLogo(formCollection);
            //Assert.IsType<UploadResultWrapper>(response);
        }
    }
}
