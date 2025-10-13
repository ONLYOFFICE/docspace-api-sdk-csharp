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


using DocSpace.API.SDK.Client;
using DocSpace.API.SDK.Model;
namespace DocSpace.API.SDK.Api.Rooms
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoomsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper AddRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> AddRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper ArchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> ArchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper ChangeRoomCover(int id, CoverRequestDto coverRequestDto);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> ChangeRoomCoverWithHttpInfo(int id, CoverRequestDto coverRequestDto);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateRoom(CreateRoomRequestDto? createRoomRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateRoomWithHttpInfo(CreateRoomRequestDto? createRoomRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        RoomFromTemplateStatusWrapper CreateRoomFromTemplate(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        ApiResponse<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateWithHttpInfo(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateRoomLogo(int id, LogoRequest logoRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateRoomLogoWithHttpInfo(int id, LogoRequest logoRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper CreateRoomTag(CreateTagRequestDto? createTagRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> CreateRoomTagWithHttpInfo(CreateTagRequestDto? createTagRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        RoomTemplateStatusWrapper CreateRoomTemplate(RoomTemplateDto? roomTemplateDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        ApiResponse<RoomTemplateStatusWrapper> CreateRoomTemplateWithHttpInfo(RoomTemplateDto? roomTemplateDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        FolderStringWrapper CreateRoomThirdParty(string id, CreateThirdPartyRoom createThirdPartyRoom);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        ApiResponse<FolderStringWrapper> CreateRoomThirdPartyWithHttpInfo(string id, CreateThirdPartyRoom createThirdPartyRoom);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns></returns>
        void DeleteCustomTags(BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomTagsWithHttpInfo(BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper DeleteRoom(int id, DeleteRoomRequest deleteRoomRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> DeleteRoomWithHttpInfo(int id, DeleteRoomRequest deleteRoomRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper DeleteRoomLogo(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> DeleteRoomLogoWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper DeleteRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> DeleteRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>NewItemsFileEntryBaseArrayWrapper</returns>
        NewItemsFileEntryBaseArrayWrapper GetNewRoomItems(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsFileEntryBaseArrayWrapper</returns>
        ApiResponse<NewItemsFileEntryBaseArrayWrapper> GetNewRoomItemsWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper GetPublicSettings(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> GetPublicSettingsWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>CoversResultArrayWrapper</returns>
        CoversResultArrayWrapper GetRoomCovers();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>ApiResponse of CoversResultArrayWrapper</returns>
        ApiResponse<CoversResultArrayWrapper> GetRoomCoversWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        RoomFromTemplateStatusWrapper GetRoomCreatingStatus();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        ApiResponse<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetRoomIndexExport();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetRoomIndexExportWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper GetRoomInfo(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> GetRoomInfoWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetRoomLinks(int id, LinkType? type = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetRoomLinksWithHttpInfo(int id, LinkType? type = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetRoomSecurityInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetRoomSecurityInfoWithHttpInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetRoomTagsInfo(int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetRoomTagsInfoWithHttpInfo(int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        RoomTemplateStatusWrapper GetRoomTemplateCreatingStatus();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        ApiResponse<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        FolderContentIntegerWrapper GetRoomsFolder(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        ApiResponse<FolderContentIntegerWrapper> GetRoomsFolderWithHttpInfo(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>NewItemsRoomNewItemsArrayWrapper</returns>
        NewItemsRoomNewItemsArrayWrapper GetRoomsNewItems();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsRoomNewItemsArrayWrapper</returns>
        ApiResponse<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetRoomsPrimaryExternalLink(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetRoomsPrimaryExternalLinkWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper PinRoom(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> PinRoomWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper ReorderRoom(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> ReorderRoomWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns></returns>
        void ResendEmailInvitations(int id, UserInvitation userInvitation);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResendEmailInvitationsWithHttpInfo(int id, UserInvitation userInvitation);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns></returns>
        void SetPublicSettings(SetPublicDto? setPublicDto = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SetPublicSettingsWithHttpInfo(SetPublicDto? setPublicDto = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper SetRoomLink(int id, RoomLinkRequest roomLinkRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> SetRoomLinkWithHttpInfo(int id, RoomLinkRequest roomLinkRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>RoomSecurityWrapper</returns>
        RoomSecurityWrapper SetRoomSecurity(int id, RoomInvitationRequest roomInvitationRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>ApiResponse of RoomSecurityWrapper</returns>
        ApiResponse<RoomSecurityWrapper> SetRoomSecurityWithHttpInfo(int id, RoomInvitationRequest roomInvitationRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper StartRoomIndexExport(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> StartRoomIndexExportWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns></returns>
        void TerminateRoomIndexExport();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateRoomIndexExportWithHttpInfo();
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper UnarchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> UnarchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper UnpinRoom(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> UnpinRoomWithHttpInfo(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper UpdateRoom(int id, UpdateRoomRequest updateRoomRequest);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> UpdateRoomWithHttpInfo(int id, UpdateRoomRequest updateRoomRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>UploadResultWrapper</returns>
        UploadResultWrapper UploadRoomLogo(List<KeyValuePairStringStringValues>? formCollection = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>ApiResponse of UploadResultWrapper</returns>
        ApiResponse<UploadResultWrapper> UploadRoomLogoWithHttpInfo(List<KeyValuePairStringStringValues>? formCollection = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoomsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> AddRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> AddRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        Task<FileOperationWrapper> ArchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        Task<ApiResponse<FileOperationWrapper>> ArchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> ChangeRoomCoverAsync(int id, CoverRequestDto coverRequestDto, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> ChangeRoomCoverWithHttpInfoAsync(int id, CoverRequestDto coverRequestDto, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> CreateRoomAsync(CreateRoomRequestDto? createRoomRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> CreateRoomWithHttpInfoAsync(CreateRoomRequestDto? createRoomRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        Task<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        Task<ApiResponse<RoomFromTemplateStatusWrapper>> CreateRoomFromTemplateWithHttpInfoAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> CreateRoomLogoAsync(int id, LogoRequest logoRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> CreateRoomLogoWithHttpInfoAsync(int id, LogoRequest logoRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        Task<ObjectWrapper> CreateRoomTagAsync(CreateTagRequestDto? createTagRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        Task<ApiResponse<ObjectWrapper>> CreateRoomTagWithHttpInfoAsync(CreateTagRequestDto? createTagRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        Task<RoomTemplateStatusWrapper> CreateRoomTemplateAsync(RoomTemplateDto? roomTemplateDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        Task<ApiResponse<RoomTemplateStatusWrapper>> CreateRoomTemplateWithHttpInfoAsync(RoomTemplateDto? roomTemplateDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        Task<FolderStringWrapper> CreateRoomThirdPartyAsync(string id, CreateThirdPartyRoom createThirdPartyRoom, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        Task<ApiResponse<FolderStringWrapper>> CreateRoomThirdPartyWithHttpInfoAsync(string id, CreateThirdPartyRoom createThirdPartyRoom, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of void</returns>
        Task DeleteCustomTagsAsync(BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteCustomTagsWithHttpInfoAsync(BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        Task<FileOperationWrapper> DeleteRoomAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        Task<ApiResponse<FileOperationWrapper>> DeleteRoomWithHttpInfoAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> DeleteRoomLogoAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomLogoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> DeleteRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of NewItemsFileEntryBaseArrayWrapper</returns>
        Task<NewItemsFileEntryBaseArrayWrapper> GetNewRoomItemsAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsFileEntryBaseArrayWrapper)</returns>
        Task<ApiResponse<NewItemsFileEntryBaseArrayWrapper>> GetNewRoomItemsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        Task<BooleanWrapper> GetPublicSettingsAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        Task<ApiResponse<BooleanWrapper>> GetPublicSettingsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of CoversResultArrayWrapper</returns>
        Task<CoversResultArrayWrapper> GetRoomCoversAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of ApiResponse (CoversResultArrayWrapper)</returns>
        Task<ApiResponse<CoversResultArrayWrapper>> GetRoomCoversWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        Task<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        Task<ApiResponse<RoomFromTemplateStatusWrapper>> GetRoomCreatingStatusWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> GetRoomIndexExportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> GetRoomIndexExportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> GetRoomInfoAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> GetRoomInfoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetRoomLinksAsync(int id, LinkType? type = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetRoomLinksWithHttpInfoAsync(int id, LinkType? type = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        Task<FileShareArrayWrapper> GetRoomSecurityInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        Task<ApiResponse<FileShareArrayWrapper>> GetRoomSecurityInfoWithHttpInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        Task<ObjectArrayWrapper> GetRoomTagsInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        Task<ApiResponse<ObjectArrayWrapper>> GetRoomTagsInfoWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        Task<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        Task<ApiResponse<RoomTemplateStatusWrapper>> GetRoomTemplateCreatingStatusWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        Task<FolderContentIntegerWrapper> GetRoomsFolderAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        Task<ApiResponse<FolderContentIntegerWrapper>> GetRoomsFolderWithHttpInfoAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of NewItemsRoomNewItemsArrayWrapper</returns>
        Task<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsRoomNewItemsArrayWrapper)</returns>
        Task<ApiResponse<NewItemsRoomNewItemsArrayWrapper>> GetRoomsNewItemsWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> GetRoomsPrimaryExternalLinkAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> GetRoomsPrimaryExternalLinkWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> PinRoomAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> PinRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> ReorderRoomAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> ReorderRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of void</returns>
        Task ResendEmailInvitationsAsync(int id, UserInvitation userInvitation, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> ResendEmailInvitationsWithHttpInfoAsync(int id, UserInvitation userInvitation, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of void</returns>
        Task SetPublicSettingsAsync(SetPublicDto? setPublicDto = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> SetPublicSettingsWithHttpInfoAsync(SetPublicDto? setPublicDto = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        Task<FileShareWrapper> SetRoomLinkAsync(int id, RoomLinkRequest roomLinkRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        Task<ApiResponse<FileShareWrapper>> SetRoomLinkWithHttpInfoAsync(int id, RoomLinkRequest roomLinkRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of RoomSecurityWrapper</returns>
        Task<RoomSecurityWrapper> SetRoomSecurityAsync(int id, RoomInvitationRequest roomInvitationRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (RoomSecurityWrapper)</returns>
        Task<ApiResponse<RoomSecurityWrapper>> SetRoomSecurityWithHttpInfoAsync(int id, RoomInvitationRequest roomInvitationRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        Task<DocumentBuilderTaskWrapper> StartRoomIndexExportAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        Task<ApiResponse<DocumentBuilderTaskWrapper>> StartRoomIndexExportWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of void</returns>
        Task TerminateRoomIndexExportAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> TerminateRoomIndexExportWithHttpInfoAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        Task<FileOperationWrapper> UnarchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        Task<ApiResponse<FileOperationWrapper>> UnarchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> UnpinRoomAsync(int id, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> UnpinRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        Task<FolderIntegerWrapper> UpdateRoomAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        Task<ApiResponse<FolderIntegerWrapper>> UpdateRoomWithHttpInfoAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of UploadResultWrapper</returns>
        Task<UploadResultWrapper> UploadRoomLogoAsync(List<KeyValuePairStringStringValues>? formCollection = default, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (UploadResultWrapper)</returns>
        Task<ApiResponse<UploadResultWrapper>> UploadRoomLogoWithHttpInfoAsync(List<KeyValuePairStringStringValues>? formCollection = default, CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoomsApi : IRoomsApiSync, IRoomsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoomsApi : IDisposable, IRoomsApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public RoomsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public RoomsApi(string basePath)
        {
            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public RoomsApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(Configuration.BasePath);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public RoomsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public RoomsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client =  ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class using a Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public RoomsApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            Configuration = DocSpace.API.SDK.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            ApiClient = new ApiClient(client, Configuration.BasePath, handler);
            Client = ApiClient;
            AsynchronousClient = ApiClient;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RoomsApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

            Client = client;
            AsynchronousClient = asyncClient;
            Configuration = configuration;
            ExceptionFactory = DocSpace.API.SDK.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            ApiClient.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value; 
        }

        private string? _fields;

        /// <summary>
        /// Specifies which fields should be included in the API response.
        /// </summary>
        /// <param name="fields">A comma-separated list of field paths to include in the response</param>
        /// <returns></returns>

        public RoomsApi WithFields(string fields)
        {
            _fields = fields;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper AddRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            var localVarResponse = AddRoomTagsWithHttpInfo(id, batchTagsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> AddRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddRoomTags", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> AddRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await AddRoomTagsWithHttpInfoAsync(id, batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> AddRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("AddRoomTags", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper ArchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            var localVarResponse = ArchiveRoomWithHttpInfo(id, archiveRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public ApiResponse<FileOperationWrapper> ArchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (archiveRoomRequest != null) localVarRequestOptions.Data = archiveRoomRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationWrapper>("/api/2.0/files/rooms/{id}/archive", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ArchiveRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async Task<FileOperationWrapper> ArchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ArchiveRoomWithHttpInfoAsync(id, archiveRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async Task<ApiResponse<FileOperationWrapper>> ArchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (archiveRoomRequest != null) localVarRequestOptions.Data = archiveRoomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}/archive", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ArchiveRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper ChangeRoomCover(int id, CoverRequestDto coverRequestDto)
        {
            var localVarResponse = ChangeRoomCoverWithHttpInfo(id, coverRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> ChangeRoomCoverWithHttpInfo(int id, CoverRequestDto coverRequestDto)
        {
            // verify the required parameter 'coverRequestDto' is set
            if (coverRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'coverRequestDto' when calling RoomsApi->ChangeRoomCover");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (coverRequestDto != null) localVarRequestOptions.Data = coverRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/cover", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeRoomCover", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> ChangeRoomCoverAsync(int id, CoverRequestDto coverRequestDto, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ChangeRoomCoverWithHttpInfoAsync(id, coverRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> ChangeRoomCoverWithHttpInfoAsync(int id, CoverRequestDto coverRequestDto, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'coverRequestDto' is set
            if (coverRequestDto == null)
                throw new ApiException(400, "Missing required parameter 'coverRequestDto' when calling RoomsApi->ChangeRoomCover");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (coverRequestDto != null) localVarRequestOptions.Data = coverRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/cover", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ChangeRoomCover", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateRoom(CreateRoomRequestDto? createRoomRequestDto = default)
        {
            var localVarResponse = CreateRoomWithHttpInfo(createRoomRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> CreateRoomWithHttpInfo(CreateRoomRequestDto? createRoomRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createRoomRequestDto != null) localVarRequestOptions.Data = createRoomRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> CreateRoomAsync(CreateRoomRequestDto? createRoomRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomWithHttpInfoAsync(createRoomRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto">The request parameters for creating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> CreateRoomWithHttpInfoAsync(CreateRoomRequestDto? createRoomRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createRoomRequestDto != null) localVarRequestOptions.Data = createRoomRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        public RoomFromTemplateStatusWrapper CreateRoomFromTemplate(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default)
        {
            var localVarResponse = CreateRoomFromTemplateWithHttpInfo(createRoomFromTemplateDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        public ApiResponse<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateWithHttpInfo(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createRoomFromTemplateDto != null) localVarRequestOptions.Data = createRoomFromTemplateDto;


            // make the HTTP request
            var localVarResponse = Client.Post<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomFromTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        public async Task<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomFromTemplateWithHttpInfoAsync(createRoomFromTemplateDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto">The parameters for creating a room from a template. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        public async Task<ApiResponse<RoomFromTemplateStatusWrapper>> CreateRoomFromTemplateWithHttpInfoAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createRoomFromTemplateDto != null) localVarRequestOptions.Data = createRoomFromTemplateDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomFromTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateRoomLogo(int id, LogoRequest logoRequest)
        {
            var localVarResponse = CreateRoomLogoWithHttpInfo(id, logoRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> CreateRoomLogoWithHttpInfo(int id, LogoRequest logoRequest)
        {
            // verify the required parameter 'logoRequest' is set
            if (logoRequest == null)
                throw new ApiException(400, "Missing required parameter 'logoRequest' when calling RoomsApi->CreateRoomLogo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (logoRequest != null) localVarRequestOptions.Data = logoRequest;


            // make the HTTP request
            var localVarResponse = Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomLogo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> CreateRoomLogoAsync(int id, LogoRequest logoRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomLogoWithHttpInfoAsync(id, logoRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> CreateRoomLogoWithHttpInfoAsync(int id, LogoRequest logoRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'logoRequest' is set
            if (logoRequest == null)
                throw new ApiException(400, "Missing required parameter 'logoRequest' when calling RoomsApi->CreateRoomLogo");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (logoRequest != null) localVarRequestOptions.Data = logoRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomLogo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper CreateRoomTag(CreateTagRequestDto? createTagRequestDto = default)
        {
            var localVarResponse = CreateRoomTagWithHttpInfo(createTagRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> CreateRoomTagWithHttpInfo(CreateTagRequestDto? createTagRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTagRequestDto != null) localVarRequestOptions.Data = createTagRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Post<ObjectWrapper>("/api/2.0/files/tags", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomTag", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async Task<ObjectWrapper> CreateRoomTagAsync(CreateTagRequestDto? createTagRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomTagWithHttpInfoAsync(createTagRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto">The request parameters for creating a tag. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async Task<ApiResponse<ObjectWrapper>> CreateRoomTagWithHttpInfoAsync(CreateTagRequestDto? createTagRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTagRequestDto != null) localVarRequestOptions.Data = createTagRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/tags", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomTag", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        public RoomTemplateStatusWrapper CreateRoomTemplate(RoomTemplateDto? roomTemplateDto = default)
        {
            var localVarResponse = CreateRoomTemplateWithHttpInfo(roomTemplateDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        public ApiResponse<RoomTemplateStatusWrapper> CreateRoomTemplateWithHttpInfo(RoomTemplateDto? roomTemplateDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomTemplateDto != null) localVarRequestOptions.Data = roomTemplateDto;


            // make the HTTP request
            var localVarResponse = Client.Post<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomTemplate", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        public async Task<RoomTemplateStatusWrapper> CreateRoomTemplateAsync(RoomTemplateDto? roomTemplateDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomTemplateWithHttpInfoAsync(roomTemplateDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto">The room template parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        public async Task<ApiResponse<RoomTemplateStatusWrapper>> CreateRoomTemplateWithHttpInfoAsync(RoomTemplateDto? roomTemplateDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (roomTemplateDto != null) localVarRequestOptions.Data = roomTemplateDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomTemplate", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        public FolderStringWrapper CreateRoomThirdParty(string id, CreateThirdPartyRoom createThirdPartyRoom)
        {
            var localVarResponse = CreateRoomThirdPartyWithHttpInfo(id, createThirdPartyRoom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        public ApiResponse<FolderStringWrapper> CreateRoomThirdPartyWithHttpInfo(string id, CreateThirdPartyRoom createThirdPartyRoom)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomsApi->CreateRoomThirdParty");

            // verify the required parameter 'createThirdPartyRoom' is set
            if (createThirdPartyRoom == null)
                throw new ApiException(400, "Missing required parameter 'createThirdPartyRoom' when calling RoomsApi->CreateRoomThirdParty");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (createThirdPartyRoom != null) localVarRequestOptions.Data = createThirdPartyRoom;


            // make the HTTP request
            var localVarResponse = Client.Post<FolderStringWrapper>("/api/2.0/files/rooms/thirdparty/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomThirdParty", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        public async Task<FolderStringWrapper> CreateRoomThirdPartyAsync(string id, CreateThirdPartyRoom createThirdPartyRoom, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await CreateRoomThirdPartyWithHttpInfoAsync(id, createThirdPartyRoom, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        public async Task<ApiResponse<FolderStringWrapper>> CreateRoomThirdPartyWithHttpInfoAsync(string id, CreateThirdPartyRoom createThirdPartyRoom, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomsApi->CreateRoomThirdParty");

            // verify the required parameter 'createThirdPartyRoom' is set
            if (createThirdPartyRoom == null)
                throw new ApiException(400, "Missing required parameter 'createThirdPartyRoom' when calling RoomsApi->CreateRoomThirdParty");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (createThirdPartyRoom != null) localVarRequestOptions.Data = createThirdPartyRoom;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<FolderStringWrapper>("/api/2.0/files/rooms/thirdparty/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("CreateRoomThirdParty", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns></returns>
        public void DeleteCustomTags(BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            DeleteCustomTagsWithHttpInfo(batchTagsRequestDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomTagsWithHttpInfo(BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/tags", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteCustomTags", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task DeleteCustomTagsAsync(BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            await DeleteCustomTagsWithHttpInfoAsync(batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> DeleteCustomTagsWithHttpInfoAsync(BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/tags", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteCustomTags", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper DeleteRoom(int id, DeleteRoomRequest deleteRoomRequest)
        {
            var localVarResponse = DeleteRoomWithHttpInfo(id, deleteRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public ApiResponse<FileOperationWrapper> DeleteRoomWithHttpInfo(int id, DeleteRoomRequest deleteRoomRequest)
        {
            // verify the required parameter 'deleteRoomRequest' is set
            if (deleteRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomRequest' when calling RoomsApi->DeleteRoom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (deleteRoomRequest != null) localVarRequestOptions.Data = deleteRoomRequest;


            // make the HTTP request
            var localVarResponse = Client.Delete<FileOperationWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async Task<FileOperationWrapper> DeleteRoomAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteRoomWithHttpInfoAsync(id, deleteRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async Task<ApiResponse<FileOperationWrapper>> DeleteRoomWithHttpInfoAsync(int id, DeleteRoomRequest deleteRoomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'deleteRoomRequest' is set
            if (deleteRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteRoomRequest' when calling RoomsApi->DeleteRoom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (deleteRoomRequest != null) localVarRequestOptions.Data = deleteRoomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper DeleteRoomLogo(int id)
        {
            var localVarResponse = DeleteRoomLogoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> DeleteRoomLogoWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Delete<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomLogo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> DeleteRoomLogoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteRoomLogoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomLogoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomLogo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper DeleteRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            var localVarResponse = DeleteRoomTagsWithHttpInfo(id, batchTagsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> DeleteRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request
            var localVarResponse = Client.Delete<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomTags", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> DeleteRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await DeleteRoomTagsWithHttpInfoAsync(id, batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (batchTagsRequestDto != null) localVarRequestOptions.Data = batchTagsRequestDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("DeleteRoomTags", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>NewItemsFileEntryBaseArrayWrapper</returns>
        public NewItemsFileEntryBaseArrayWrapper GetNewRoomItems(int id)
        {
            var localVarResponse = GetNewRoomItemsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsFileEntryBaseArrayWrapper</returns>
        public ApiResponse<NewItemsFileEntryBaseArrayWrapper> GetNewRoomItemsWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<NewItemsFileEntryBaseArrayWrapper>("/api/2.0/files/rooms/{id}/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNewRoomItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of NewItemsFileEntryBaseArrayWrapper</returns>
        public async Task<NewItemsFileEntryBaseArrayWrapper> GetNewRoomItemsAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetNewRoomItemsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsFileEntryBaseArrayWrapper)</returns>
        public async Task<ApiResponse<NewItemsFileEntryBaseArrayWrapper>> GetNewRoomItemsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewItemsFileEntryBaseArrayWrapper>("/api/2.0/files/rooms/{id}/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetNewRoomItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper GetPublicSettings(int id)
        {
            var localVarResponse = GetPublicSettingsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> GetPublicSettingsWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<BooleanWrapper>("/api/2.0/files/roomtemplate/{id}/public", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPublicSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async Task<BooleanWrapper> GetPublicSettingsAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetPublicSettingsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async Task<ApiResponse<BooleanWrapper>> GetPublicSettingsWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/roomtemplate/{id}/public", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetPublicSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>CoversResultArrayWrapper</returns>
        public CoversResultArrayWrapper GetRoomCovers()
        {
            var localVarResponse = GetRoomCoversWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>ApiResponse of CoversResultArrayWrapper</returns>
        public ApiResponse<CoversResultArrayWrapper> GetRoomCoversWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<CoversResultArrayWrapper>("/api/2.0/files/rooms/covers", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomCovers", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of CoversResultArrayWrapper</returns>
        public async Task<CoversResultArrayWrapper> GetRoomCoversAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomCoversWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of ApiResponse (CoversResultArrayWrapper)</returns>
        public async Task<ApiResponse<CoversResultArrayWrapper>> GetRoomCoversWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<CoversResultArrayWrapper>("/api/2.0/files/rooms/covers", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomCovers", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        public RoomFromTemplateStatusWrapper GetRoomCreatingStatus()
        {
            var localVarResponse = GetRoomCreatingStatusWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        public ApiResponse<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate/status", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomCreatingStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        public async Task<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomCreatingStatusWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        public async Task<ApiResponse<RoomFromTemplateStatusWrapper>> GetRoomCreatingStatusWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate/status", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomCreatingStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetRoomIndexExport()
        {
            var localVarResponse = GetRoomIndexExportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> GetRoomIndexExportWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomIndexExport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> GetRoomIndexExportAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomIndexExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> GetRoomIndexExportWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomIndexExport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper GetRoomInfo(int id)
        {
            var localVarResponse = GetRoomInfoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> GetRoomInfoWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> GetRoomInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomInfoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> GetRoomInfoWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetRoomLinks(int id, LinkType? type = default)
        {
            var localVarResponse = GetRoomLinksWithHttpInfo(id, type);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetRoomLinksWithHttpInfo(int id, LinkType? type = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomLinks", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetRoomLinksAsync(int id, LinkType? type = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomLinksWithHttpInfoAsync(id, type, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetRoomLinksWithHttpInfoAsync(int id, LinkType? type = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "type", type));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomLinks", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetRoomSecurityInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarResponse = GetRoomSecurityInfoWithHttpInfo(id, filterType, count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetRoomSecurityInfoWithHttpInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomSecurityInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async Task<FileShareArrayWrapper> GetRoomSecurityInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomSecurityInfoWithHttpInfoAsync(id, filterType, count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async Task<ApiResponse<FileShareArrayWrapper>> GetRoomSecurityInfoWithHttpInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomSecurityInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetRoomTagsInfo(int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarResponse = GetRoomTagsInfoWithHttpInfo(count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> GetRoomTagsInfoWithHttpInfo(int? count = default, int? startIndex = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<ObjectArrayWrapper>("/api/2.0/files/tags", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomTagsInfo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async Task<ObjectArrayWrapper> GetRoomTagsInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomTagsInfoWithHttpInfoAsync(count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async Task<ApiResponse<ObjectArrayWrapper>> GetRoomTagsInfoWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/files/tags", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomTagsInfo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        public RoomTemplateStatusWrapper GetRoomTemplateCreatingStatus()
        {
            var localVarResponse = GetRoomTemplateCreatingStatusWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        public ApiResponse<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate/status", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomTemplateCreatingStatus", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        public async Task<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomTemplateCreatingStatusWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        public async Task<ApiResponse<RoomTemplateStatusWrapper>> GetRoomTemplateCreatingStatusWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate/status", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomTemplateCreatingStatus", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>FolderContentIntegerWrapper</returns>
        public FolderContentIntegerWrapper GetRoomsFolder(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarResponse = GetRoomsFolderWithHttpInfo(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>ApiResponse of FolderContentIntegerWrapper</returns>
        public ApiResponse<FolderContentIntegerWrapper> GetRoomsFolderWithHttpInfo(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
            }
            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (storageFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storageFilter", storageFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }
            if (_fields != null)
            {
                localVarRequestOptions.HeaderParameters.Add("fields", _fields); // header parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsFolder", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>Task of FolderContentIntegerWrapper</returns>
        public async Task<FolderContentIntegerWrapper> GetRoomsFolderAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomsFolderWithHttpInfoAsync(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The filter by room type. (optional)</param>
        /// <param name="subjectId">The filter by user ID. (optional)</param>
        /// <param name="searchArea">The room search area (Active, Archive, Any, Recent by links). (optional)</param>
        /// <param name="withoutTags">Specifies whether to search by tags or not. (optional)</param>
        /// <param name="tags">The tags in the serialized format. (optional)</param>
        /// <param name="excludeSubject">Specifies whether to exclude search by user or group ID. (optional)</param>
        /// <param name="provider">The filter by provider name (None, Box, DropBox, GoogleDrive, kDrive, OneDrive, SharePoint, WebDav, Yandex, Storage). (optional)</param>
        /// <param name="subjectFilter">The filter by user (Owner - 0, Member - 1). (optional)</param>
        /// <param name="quotaFilter">The filter by quota (All - 0, Default - 1, Custom - 2). (optional)</param>
        /// <param name="storageFilter">The filter by storage (None - 0, Internal - 1, ThirdParty - 2). (optional)</param>
        /// <param name="count">Specifies the maximum number of items to retrieve. (optional)</param>
        /// <param name="startIndex">The index from which to start retrieving the room content. (optional)</param>
        /// <param name="sortBy">Specifies the field by which the room content should be sorted. (optional)</param>
        /// <param name="sortOrder">The order in which the results are sorted. (optional)</param>
        /// <param name="filterValue">The text filter value used to refine search or query operations. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-folder/">REST API Reference for GetRoomsFolder Operation</seealso>
        /// <returns>Task of ApiResponse (FolderContentIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderContentIntegerWrapper>> GetRoomsFolderWithHttpInfoAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("csv", "type", type));
            }
            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (storageFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "storageFilter", storageFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsFolder", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>NewItemsRoomNewItemsArrayWrapper</returns>
        public NewItemsRoomNewItemsArrayWrapper GetRoomsNewItems()
        {
            var localVarResponse = GetRoomsNewItemsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsRoomNewItemsArrayWrapper</returns>
        public ApiResponse<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Get<NewItemsRoomNewItemsArrayWrapper>("/api/2.0/files/rooms/news", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsNewItems", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of NewItemsRoomNewItemsArrayWrapper</returns>
        public async Task<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsAsync(CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomsNewItemsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsRoomNewItemsArrayWrapper)</returns>
        public async Task<ApiResponse<NewItemsRoomNewItemsArrayWrapper>> GetRoomsNewItemsWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<NewItemsRoomNewItemsArrayWrapper>("/api/2.0/files/rooms/news", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsNewItems", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetRoomsPrimaryExternalLink(int id)
        {
            var localVarResponse = GetRoomsPrimaryExternalLinkWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> GetRoomsPrimaryExternalLinkWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Get<FileShareWrapper>("/api/2.0/files/rooms/{id}/link", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsPrimaryExternalLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> GetRoomsPrimaryExternalLinkAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await GetRoomsPrimaryExternalLinkWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> GetRoomsPrimaryExternalLinkWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/rooms/{id}/link", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("GetRoomsPrimaryExternalLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper PinRoom(int id)
        {
            var localVarResponse = PinRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> PinRoomWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/pin", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("PinRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> PinRoomAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await PinRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> PinRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/pin", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("PinRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper ReorderRoom(int id)
        {
            var localVarResponse = ReorderRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> ReorderRoomWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/reorder", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReorderRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> ReorderRoomAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await ReorderRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> ReorderRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/reorder", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ReorderRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns></returns>
        public void ResendEmailInvitations(int id, UserInvitation userInvitation)
        {
            ResendEmailInvitationsWithHttpInfo(id, userInvitation);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ResendEmailInvitationsWithHttpInfo(int id, UserInvitation userInvitation)
        {
            // verify the required parameter 'userInvitation' is set
            if (userInvitation == null)
                throw new ApiException(400, "Missing required parameter 'userInvitation' when calling RoomsApi->ResendEmailInvitations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (userInvitation != null) localVarRequestOptions.Data = userInvitation;


            // make the HTTP request
            var localVarResponse = Client.Post<Object>("/api/2.0/files/rooms/{id}/resend", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendEmailInvitations", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task ResendEmailInvitationsAsync(int id, UserInvitation userInvitation, CancellationToken cancellationToken = default)
        {
            await ResendEmailInvitationsWithHttpInfoAsync(id, userInvitation, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> ResendEmailInvitationsWithHttpInfoAsync(int id, UserInvitation userInvitation, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'userInvitation' is set
            if (userInvitation == null)
                throw new ApiException(400, "Missing required parameter 'userInvitation' when calling RoomsApi->ResendEmailInvitations");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (userInvitation != null) localVarRequestOptions.Data = userInvitation;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<Object>("/api/2.0/files/rooms/{id}/resend", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("ResendEmailInvitations", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns></returns>
        public void SetPublicSettings(SetPublicDto? setPublicDto = default)
        {
            SetPublicSettingsWithHttpInfo(setPublicDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> SetPublicSettingsWithHttpInfo(SetPublicDto? setPublicDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setPublicDto != null) localVarRequestOptions.Data = setPublicDto;


            // make the HTTP request
            var localVarResponse = Client.Put<Object>("/api/2.0/files/roomtemplate/public", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetPublicSettings", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task SetPublicSettingsAsync(SetPublicDto? setPublicDto = default, CancellationToken cancellationToken = default)
        {
            await SetPublicSettingsWithHttpInfoAsync(setPublicDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto">The public settings of the room template to set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> SetPublicSettingsWithHttpInfoAsync(SetPublicDto? setPublicDto = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (setPublicDto != null) localVarRequestOptions.Data = setPublicDto;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<Object>("/api/2.0/files/roomtemplate/public", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetPublicSettings", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper SetRoomLink(int id, RoomLinkRequest roomLinkRequest)
        {
            var localVarResponse = SetRoomLinkWithHttpInfo(id, roomLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> SetRoomLinkWithHttpInfo(int id, RoomLinkRequest roomLinkRequest)
        {
            // verify the required parameter 'roomLinkRequest' is set
            if (roomLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'roomLinkRequest' when calling RoomsApi->SetRoomLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (roomLinkRequest != null) localVarRequestOptions.Data = roomLinkRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<FileShareWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomLink", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async Task<FileShareWrapper> SetRoomLinkAsync(int id, RoomLinkRequest roomLinkRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetRoomLinkWithHttpInfoAsync(id, roomLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async Task<ApiResponse<FileShareWrapper>> SetRoomLinkWithHttpInfoAsync(int id, RoomLinkRequest roomLinkRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'roomLinkRequest' is set
            if (roomLinkRequest == null)
                throw new ApiException(400, "Missing required parameter 'roomLinkRequest' when calling RoomsApi->SetRoomLink");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (roomLinkRequest != null) localVarRequestOptions.Data = roomLinkRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileShareWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomLink", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>RoomSecurityWrapper</returns>
        public RoomSecurityWrapper SetRoomSecurity(int id, RoomInvitationRequest roomInvitationRequest)
        {
            var localVarResponse = SetRoomSecurityWithHttpInfo(id, roomInvitationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>ApiResponse of RoomSecurityWrapper</returns>
        public ApiResponse<RoomSecurityWrapper> SetRoomSecurityWithHttpInfo(int id, RoomInvitationRequest roomInvitationRequest)
        {
            // verify the required parameter 'roomInvitationRequest' is set
            if (roomInvitationRequest == null)
                throw new ApiException(400, "Missing required parameter 'roomInvitationRequest' when calling RoomsApi->SetRoomSecurity");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (roomInvitationRequest != null) localVarRequestOptions.Data = roomInvitationRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<RoomSecurityWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomSecurity", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of RoomSecurityWrapper</returns>
        public async Task<RoomSecurityWrapper> SetRoomSecurityAsync(int id, RoomInvitationRequest roomInvitationRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await SetRoomSecurityWithHttpInfoAsync(id, roomInvitationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (RoomSecurityWrapper)</returns>
        public async Task<ApiResponse<RoomSecurityWrapper>> SetRoomSecurityWithHttpInfoAsync(int id, RoomInvitationRequest roomInvitationRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'roomInvitationRequest' is set
            if (roomInvitationRequest == null)
                throw new ApiException(400, "Missing required parameter 'roomInvitationRequest' when calling RoomsApi->SetRoomSecurity");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (roomInvitationRequest != null) localVarRequestOptions.Data = roomInvitationRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<RoomSecurityWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("SetRoomSecurity", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper StartRoomIndexExport(int id)
        {
            var localVarResponse = StartRoomIndexExportWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public ApiResponse<DocumentBuilderTaskWrapper> StartRoomIndexExportWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/{id}/indexexport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartRoomIndexExport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async Task<DocumentBuilderTaskWrapper> StartRoomIndexExportAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await StartRoomIndexExportWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async Task<ApiResponse<DocumentBuilderTaskWrapper>> StartRoomIndexExportWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/{id}/indexexport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("StartRoomIndexExport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns></returns>
        public void TerminateRoomIndexExport()
        {
            TerminateRoomIndexExportWithHttpInfo();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TerminateRoomIndexExportWithHttpInfo()
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = Client.Delete<Object>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateRoomIndexExport", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of void</returns>
        public async Task TerminateRoomIndexExportAsync(CancellationToken cancellationToken = default)
        {
            await TerminateRoomIndexExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async Task<ApiResponse<Object>> TerminateRoomIndexExportWithHttpInfoAsync(CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("TerminateRoomIndexExport", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper UnarchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            var localVarResponse = UnarchiveRoomWithHttpInfo(id, archiveRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public ApiResponse<FileOperationWrapper> UnarchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (archiveRoomRequest != null) localVarRequestOptions.Data = archiveRoomRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<FileOperationWrapper>("/api/2.0/files/rooms/{id}/unarchive", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnarchiveRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async Task<FileOperationWrapper> UnarchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UnarchiveRoomWithHttpInfoAsync(id, archiveRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async Task<ApiResponse<FileOperationWrapper>> UnarchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (archiveRoomRequest != null) localVarRequestOptions.Data = archiveRoomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}/unarchive", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnarchiveRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper UnpinRoom(int id)
        {
            var localVarResponse = UnpinRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> UnpinRoomWithHttpInfo(int id)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/unpin", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnpinRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> UnpinRoomAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UnpinRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> UnpinRoomWithHttpInfoAsync(int id, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/unpin", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UnpinRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper UpdateRoom(int id, UpdateRoomRequest updateRoomRequest)
        {
            var localVarResponse = UpdateRoomWithHttpInfo(id, updateRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public ApiResponse<FolderIntegerWrapper> UpdateRoomWithHttpInfo(int id, UpdateRoomRequest updateRoomRequest)
        {
            // verify the required parameter 'updateRoomRequest' is set
            if (updateRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateRoomRequest' when calling RoomsApi->UpdateRoom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateRoomRequest != null) localVarRequestOptions.Data = updateRoomRequest;


            // make the HTTP request
            var localVarResponse = Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateRoom", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async Task<FolderIntegerWrapper> UpdateRoomAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UpdateRoomWithHttpInfoAsync(id, updateRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async Task<ApiResponse<FolderIntegerWrapper>> UpdateRoomWithHttpInfoAsync(int id, UpdateRoomRequest updateRoomRequest, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'updateRoomRequest' is set
            if (updateRoomRequest == null)
                throw new ApiException(400, "Missing required parameter 'updateRoomRequest' when calling RoomsApi->UpdateRoom");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (updateRoomRequest != null) localVarRequestOptions.Data = updateRoomRequest;


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UpdateRoom", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>UploadResultWrapper</returns>
        public UploadResultWrapper UploadRoomLogo(List<KeyValuePairStringStringValues>? formCollection = default)
        {
            var localVarResponse = UploadRoomLogoWithHttpInfo(formCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>ApiResponse of UploadResultWrapper</returns>
        public ApiResponse<UploadResultWrapper> UploadRoomLogoWithHttpInfo(List<KeyValuePairStringStringValues>? formCollection = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (formCollection != null)
            {
                localVarRequestOptions.FormParameters.Add("FormCollection",ClientUtils.ParameterToString(formCollection)); // form parameter
            }


            // make the HTTP request
            var localVarResponse = Client.Post<UploadResultWrapper>("/api/2.0/files/logos", localVarRequestOptions, Configuration);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadRoomLogo", localVarResponse);
                if (exception != null)
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of UploadResultWrapper</returns>
        public async Task<UploadResultWrapper> UploadRoomLogoAsync(List<KeyValuePairStringStringValues>? formCollection = default, CancellationToken cancellationToken = default)
        {
            var localVarResponse = await UploadRoomLogoWithHttpInfoAsync(formCollection, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="DocSpace.API.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (UploadResultWrapper)</returns>
        public async Task<ApiResponse<UploadResultWrapper>> UploadRoomLogoWithHttpInfoAsync(List<KeyValuePairStringStringValues>? formCollection = default, CancellationToken cancellationToken = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [ "application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (formCollection != null)
            {
                localVarRequestOptions.FormParameters.Add("FormCollection", DocSpace.API.SDK.Client.ClientUtils.ParameterToString(formCollection)); // form parameter
            }


            // make the HTTP request

            var localVarResponse = await AsynchronousClient.PostAsync<UploadResultWrapper>("/api/2.0/files/logos", localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

            if (ExceptionFactory != null)
            {
                var exception = ExceptionFactory("UploadRoomLogo", localVarResponse);
                if (exception != null) 
                {
                    throw exception;
                }
            }

            return localVarResponse;
        }

    }
}
