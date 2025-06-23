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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using Docspace.Client;
using Docspace.Model;

namespace Docspace.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoomsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add the room tags
        /// </summary>
        /// <remarks>
        /// Adds the tags to a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper AddRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// Add the room tags
        /// </summary>
        /// <remarks>
        /// Adds the tags to a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> AddRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// Archive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper ArchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default);

        /// <summary>
        /// Archive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> ArchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default);
        /// <summary>
        /// Change the room cover
        /// </summary>
        /// <remarks>
        /// Changes a cover of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper ChangeRoomCover(int id, CoverRequestDto? coverRequestDto = default);

        /// <summary>
        /// Change the room cover
        /// </summary>
        /// <remarks>
        /// Changes a cover of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> ChangeRoomCoverWithHttpInfo(int id, CoverRequestDto? coverRequestDto = default);
        /// <summary>
        /// Create a room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateRoom(CreateRoomRequestDto? createRoomRequestDto = default);

        /// <summary>
        /// Create a room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateRoomWithHttpInfo(CreateRoomRequestDto? createRoomRequestDto = default);
        /// <summary>
        /// Create a room from the template
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        RoomFromTemplateStatusWrapper CreateRoomFromTemplate(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default);

        /// <summary>
        /// Create a room from the template
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        ApiResponse<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateWithHttpInfo(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default);
        /// <summary>
        /// Create a room logo
        /// </summary>
        /// <remarks>
        /// Creates a logo for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper CreateRoomLogo(int id, LogoRequest? logoRequest = default);

        /// <summary>
        /// Create a room logo
        /// </summary>
        /// <remarks>
        /// Creates a logo for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> CreateRoomLogoWithHttpInfo(int id, LogoRequest? logoRequest = default);
        /// <summary>
        /// Create a tag
        /// </summary>
        /// <remarks>
        /// Creates a custom tag with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper CreateRoomTag(CreateTagRequestDto? createTagRequestDto = default);

        /// <summary>
        /// Create a tag
        /// </summary>
        /// <remarks>
        /// Creates a custom tag with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> CreateRoomTagWithHttpInfo(CreateTagRequestDto? createTagRequestDto = default);
        /// <summary>
        /// Start creating room template
        /// </summary>
        /// <remarks>
        /// Starts creating the room template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        RoomTemplateStatusWrapper CreateRoomTemplate(RoomTemplateDto? roomTemplateDto = default);

        /// <summary>
        /// Start creating room template
        /// </summary>
        /// <remarks>
        /// Starts creating the room template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        ApiResponse<RoomTemplateStatusWrapper> CreateRoomTemplateWithHttpInfo(RoomTemplateDto? roomTemplateDto = default);
        /// <summary>
        /// Create a third-party room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        FolderStringWrapper CreateRoomThirdParty(string id, CreateThirdPartyRoom? createThirdPartyRoom = default);

        /// <summary>
        /// Create a third-party room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        ApiResponse<FolderStringWrapper> CreateRoomThirdPartyWithHttpInfo(string id, CreateThirdPartyRoom? createThirdPartyRoom = default);
        /// <summary>
        /// Delete tags
        /// </summary>
        /// <remarks>
        /// Deletes a bunch of custom tags specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns></returns>
        void DeleteCustomTags(BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// Delete tags
        /// </summary>
        /// <remarks>
        /// Deletes a bunch of custom tags specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomTagsWithHttpInfo(BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// Remove a room
        /// </summary>
        /// <remarks>
        /// Removes a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper DeleteRoom(int id, DeleteRoomRequest? deleteRoomRequest = default);

        /// <summary>
        /// Remove a room
        /// </summary>
        /// <remarks>
        /// Removes a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> DeleteRoomWithHttpInfo(int id, DeleteRoomRequest? deleteRoomRequest = default);
        /// <summary>
        /// Remove a room logo
        /// </summary>
        /// <remarks>
        /// Removes a logo from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper DeleteRoomLogo(int id);

        /// <summary>
        /// Remove a room logo
        /// </summary>
        /// <remarks>
        /// Removes a logo from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> DeleteRoomLogoWithHttpInfo(int id);
        /// <summary>
        /// Remove the room tags
        /// </summary>
        /// <remarks>
        /// Removes the tags from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper DeleteRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default);

        /// <summary>
        /// Remove the room tags
        /// </summary>
        /// <remarks>
        /// Removes the tags from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> DeleteRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default);
        /// <summary>
        /// Get the new room items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>NewItemsFileEntryArrayWrapper</returns>
        NewItemsFileEntryArrayWrapper GetNewRoomItems(int id);

        /// <summary>
        /// Get the new room items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsFileEntryArrayWrapper</returns>
        ApiResponse<NewItemsFileEntryArrayWrapper> GetNewRoomItemsWithHttpInfo(int id);
        /// <summary>
        /// Get public settings
        /// </summary>
        /// <remarks>
        /// Returns the public settings of the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper GetPublicSettings(int id);

        /// <summary>
        /// Get public settings
        /// </summary>
        /// <remarks>
        /// Returns the public settings of the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> GetPublicSettingsWithHttpInfo(int id);
        /// <summary>
        /// Get covers
        /// </summary>
        /// <remarks>
        /// Returns a list of all covers.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>CoversResultArrayWrapper</returns>
        CoversResultArrayWrapper GetRoomCovers();

        /// <summary>
        /// Get covers
        /// </summary>
        /// <remarks>
        /// Returns a list of all covers.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>ApiResponse of CoversResultArrayWrapper</returns>
        ApiResponse<CoversResultArrayWrapper> GetRoomCoversWithHttpInfo();
        /// <summary>
        /// Get the room creation progress
        /// </summary>
        /// <remarks>
        /// Returns the progress of creating a room from the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        RoomFromTemplateStatusWrapper GetRoomCreatingStatus();

        /// <summary>
        /// Get the room creation progress
        /// </summary>
        /// <remarks>
        /// Returns the progress of creating a room from the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        ApiResponse<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusWithHttpInfo();
        /// <summary>
        /// Get the room index export
        /// </summary>
        /// <remarks>
        /// Returns the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper GetRoomIndexExport();

        /// <summary>
        /// Get the room index export
        /// </summary>
        /// <remarks>
        /// Returns the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> GetRoomIndexExportWithHttpInfo();
        /// <summary>
        /// Get room information
        /// </summary>
        /// <remarks>
        /// Returns the room information.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper GetRoomInfo(int id);

        /// <summary>
        /// Get room information
        /// </summary>
        /// <remarks>
        /// Returns the room information.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> GetRoomInfoWithHttpInfo(int id);
        /// <summary>
        /// Get the room links
        /// </summary>
        /// <remarks>
        /// Returns the links of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetRoomLinks(int id, LinkType? type = default);

        /// <summary>
        /// Get the room links
        /// </summary>
        /// <remarks>
        /// Returns the links of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetRoomLinksWithHttpInfo(int id, LinkType? type = default);
        /// <summary>
        /// Get the room access rights
        /// </summary>
        /// <remarks>
        /// Returns the access rights of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetRoomSecurityInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// Get the room access rights
        /// </summary>
        /// <remarks>
        /// Returns the access rights of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetRoomSecurityInfoWithHttpInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// Get tags
        /// </summary>
        /// <remarks>
        /// Returns a list of custom tags.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper GetRoomTagsInfo(int? count = default, int? startIndex = default, string? filterValue = default);

        /// <summary>
        /// Get tags
        /// </summary>
        /// <remarks>
        /// Returns a list of custom tags.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> GetRoomTagsInfoWithHttpInfo(int? count = default, int? startIndex = default, string? filterValue = default);
        /// <summary>
        /// Get status of room template creation
        /// </summary>
        /// <remarks>
        /// Returns the progress status of the room template creation process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        RoomTemplateStatusWrapper GetRoomTemplateCreatingStatus();

        /// <summary>
        /// Get status of room template creation
        /// </summary>
        /// <remarks>
        /// Returns the progress status of the room template creation process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        ApiResponse<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusWithHttpInfo();
        /// <summary>
        /// Get rooms
        /// </summary>
        /// <remarks>
        /// Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get rooms
        /// </summary>
        /// <remarks>
        /// Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>NewItemsRoomNewItemsArrayWrapper</returns>
        NewItemsRoomNewItemsArrayWrapper GetRoomsNewItems();

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsRoomNewItemsArrayWrapper</returns>
        ApiResponse<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsWithHttpInfo();
        /// <summary>
        /// Get the room primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetRoomsPrimaryExternalLink(int id);

        /// <summary>
        /// Get the room primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetRoomsPrimaryExternalLinkWithHttpInfo(int id);
        /// <summary>
        /// Pin a room
        /// </summary>
        /// <remarks>
        /// Pins a room with the ID specified in the request to the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper PinRoom(int id);

        /// <summary>
        /// Pin a room
        /// </summary>
        /// <remarks>
        /// Pins a room with the ID specified in the request to the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> PinRoomWithHttpInfo(int id);
        /// <summary>
        /// Reorder the room
        /// </summary>
        /// <remarks>
        /// Reorders the room with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper ReorderRoom(int id);

        /// <summary>
        /// Reorder the room
        /// </summary>
        /// <remarks>
        /// Reorders the room with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> ReorderRoomWithHttpInfo(int id);
        /// <summary>
        /// Resend the room invitations
        /// </summary>
        /// <remarks>
        /// Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns></returns>
        void ResendEmailInvitations(int id, UserInvitation? userInvitation = default);

        /// <summary>
        /// Resend the room invitations
        /// </summary>
        /// <remarks>
        /// Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ResendEmailInvitationsWithHttpInfo(int id, UserInvitation? userInvitation = default);
        /// <summary>
        /// Set public settings
        /// </summary>
        /// <remarks>
        /// Sets the public settings for the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns></returns>
        void SetPublicSettings(SetPublicDto? setPublicDto = default);

        /// <summary>
        /// Set public settings
        /// </summary>
        /// <remarks>
        /// Sets the public settings for the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SetPublicSettingsWithHttpInfo(SetPublicDto? setPublicDto = default);
        /// <summary>
        /// Set the room external or invitation link
        /// </summary>
        /// <remarks>
        /// Sets the room external or invitation link with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper SetRoomLink(int id, RoomLinkRequest? roomLinkRequest = default);

        /// <summary>
        /// Set the room external or invitation link
        /// </summary>
        /// <remarks>
        /// Sets the room external or invitation link with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> SetRoomLinkWithHttpInfo(int id, RoomLinkRequest? roomLinkRequest = default);
        /// <summary>
        /// Set the room access rights
        /// </summary>
        /// <remarks>
        /// Sets the access rights to the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>RoomSecurityWrapper</returns>
        RoomSecurityWrapper SetRoomSecurity(int id, RoomInvitationRequest? roomInvitationRequest = default);

        /// <summary>
        /// Set the room access rights
        /// </summary>
        /// <remarks>
        /// Sets the access rights to the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>ApiResponse of RoomSecurityWrapper</returns>
        ApiResponse<RoomSecurityWrapper> SetRoomSecurityWithHttpInfo(int id, RoomInvitationRequest? roomInvitationRequest = default);
        /// <summary>
        /// Start the room index export
        /// </summary>
        /// <remarks>
        /// Starts the index export of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        DocumentBuilderTaskWrapper StartRoomIndexExport(int id);

        /// <summary>
        /// Start the room index export
        /// </summary>
        /// <remarks>
        /// Starts the index export of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        ApiResponse<DocumentBuilderTaskWrapper> StartRoomIndexExportWithHttpInfo(int id);
        /// <summary>
        /// Terminate the room index export
        /// </summary>
        /// <remarks>
        /// Terminates the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns></returns>
        void TerminateRoomIndexExport();

        /// <summary>
        /// Terminate the room index export
        /// </summary>
        /// <remarks>
        /// Terminates the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TerminateRoomIndexExportWithHttpInfo();
        /// <summary>
        /// Unarchive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        FileOperationWrapper UnarchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default);

        /// <summary>
        /// Unarchive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        ApiResponse<FileOperationWrapper> UnarchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default);
        /// <summary>
        /// Unpin a room
        /// </summary>
        /// <remarks>
        /// Unpins a room with the ID specified in the request from the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper UnpinRoom(int id);

        /// <summary>
        /// Unpin a room
        /// </summary>
        /// <remarks>
        /// Unpins a room with the ID specified in the request from the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> UnpinRoomWithHttpInfo(int id);
        /// <summary>
        /// Update a room
        /// </summary>
        /// <remarks>
        /// Updates a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        FolderIntegerWrapper UpdateRoom(int id, UpdateRoomRequest? updateRoomRequest = default);

        /// <summary>
        /// Update a room
        /// </summary>
        /// <remarks>
        /// Updates a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        ApiResponse<FolderIntegerWrapper> UpdateRoomWithHttpInfo(int id, UpdateRoomRequest? updateRoomRequest = default);
        /// <summary>
        /// Upload a room logo image
        /// </summary>
        /// <remarks>
        /// Uploads a temporary image to create a room logo.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>UploadResultWrapper</returns>
        UploadResultWrapper UploadRoomLogo(List<KeyValuePairStringStringValues>? formCollection = default);

        /// <summary>
        /// Upload a room logo image
        /// </summary>
        /// <remarks>
        /// Uploads a temporary image to create a room logo.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// Add the room tags
        /// </summary>
        /// <remarks>
        /// Adds the tags to a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> AddRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add the room tags
        /// </summary>
        /// <remarks>
        /// Adds the tags to a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> AddRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Archive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        System.Threading.Tasks.Task<FileOperationWrapper> ArchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Archive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileOperationWrapper>> ArchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change the room cover
        /// </summary>
        /// <remarks>
        /// Changes a cover of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> ChangeRoomCoverAsync(int id, CoverRequestDto? coverRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change the room cover
        /// </summary>
        /// <remarks>
        /// Changes a cover of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> ChangeRoomCoverWithHttpInfoAsync(int id, CoverRequestDto? coverRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> CreateRoomAsync(CreateRoomRequestDto? createRoomRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> CreateRoomWithHttpInfoAsync(CreateRoomRequestDto? createRoomRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a room from the template
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        System.Threading.Tasks.Task<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a room from the template
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomFromTemplateStatusWrapper>> CreateRoomFromTemplateWithHttpInfoAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a room logo
        /// </summary>
        /// <remarks>
        /// Creates a logo for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> CreateRoomLogoAsync(int id, LogoRequest? logoRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a room logo
        /// </summary>
        /// <remarks>
        /// Creates a logo for a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> CreateRoomLogoWithHttpInfoAsync(int id, LogoRequest? logoRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a tag
        /// </summary>
        /// <remarks>
        /// Creates a custom tag with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> CreateRoomTagAsync(CreateTagRequestDto? createTagRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a tag
        /// </summary>
        /// <remarks>
        /// Creates a custom tag with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> CreateRoomTagWithHttpInfoAsync(CreateTagRequestDto? createTagRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start creating room template
        /// </summary>
        /// <remarks>
        /// Starts creating the room template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        System.Threading.Tasks.Task<RoomTemplateStatusWrapper> CreateRoomTemplateAsync(RoomTemplateDto? roomTemplateDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start creating room template
        /// </summary>
        /// <remarks>
        /// Starts creating the room template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomTemplateStatusWrapper>> CreateRoomTemplateWithHttpInfoAsync(RoomTemplateDto? roomTemplateDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a third-party room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        System.Threading.Tasks.Task<FolderStringWrapper> CreateRoomThirdPartyAsync(string id, CreateThirdPartyRoom? createThirdPartyRoom = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a third-party room
        /// </summary>
        /// <remarks>
        /// Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderStringWrapper>> CreateRoomThirdPartyWithHttpInfoAsync(string id, CreateThirdPartyRoom? createThirdPartyRoom = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete tags
        /// </summary>
        /// <remarks>
        /// Deletes a bunch of custom tags specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomTagsAsync(BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete tags
        /// </summary>
        /// <remarks>
        /// Deletes a bunch of custom tags specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomTagsWithHttpInfoAsync(BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a room
        /// </summary>
        /// <remarks>
        /// Removes a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        System.Threading.Tasks.Task<FileOperationWrapper> DeleteRoomAsync(int id, DeleteRoomRequest? deleteRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a room
        /// </summary>
        /// <remarks>
        /// Removes a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileOperationWrapper>> DeleteRoomWithHttpInfoAsync(int id, DeleteRoomRequest? deleteRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a room logo
        /// </summary>
        /// <remarks>
        /// Removes a logo from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> DeleteRoomLogoAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a room logo
        /// </summary>
        /// <remarks>
        /// Removes a logo from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomLogoWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove the room tags
        /// </summary>
        /// <remarks>
        /// Removes the tags from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> DeleteRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove the room tags
        /// </summary>
        /// <remarks>
        /// Removes the tags from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> DeleteRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the new room items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of NewItemsFileEntryArrayWrapper</returns>
        System.Threading.Tasks.Task<NewItemsFileEntryArrayWrapper> GetNewRoomItemsAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the new room items
        /// </summary>
        /// <remarks>
        /// Returns a list of all the new items from a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsFileEntryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<NewItemsFileEntryArrayWrapper>> GetNewRoomItemsWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get public settings
        /// </summary>
        /// <remarks>
        /// Returns the public settings of the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> GetPublicSettingsAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get public settings
        /// </summary>
        /// <remarks>
        /// Returns the public settings of the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> GetPublicSettingsWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get covers
        /// </summary>
        /// <remarks>
        /// Returns a list of all covers.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of CoversResultArrayWrapper</returns>
        System.Threading.Tasks.Task<CoversResultArrayWrapper> GetRoomCoversAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get covers
        /// </summary>
        /// <remarks>
        /// Returns a list of all covers.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of ApiResponse (CoversResultArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<CoversResultArrayWrapper>> GetRoomCoversWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room creation progress
        /// </summary>
        /// <remarks>
        /// Returns the progress of creating a room from the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        System.Threading.Tasks.Task<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room creation progress
        /// </summary>
        /// <remarks>
        /// Returns the progress of creating a room from the template.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomFromTemplateStatusWrapper>> GetRoomCreatingStatusWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room index export
        /// </summary>
        /// <remarks>
        /// Returns the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        System.Threading.Tasks.Task<DocumentBuilderTaskWrapper> GetRoomIndexExportAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room index export
        /// </summary>
        /// <remarks>
        /// Returns the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentBuilderTaskWrapper>> GetRoomIndexExportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get room information
        /// </summary>
        /// <remarks>
        /// Returns the room information.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> GetRoomInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get room information
        /// </summary>
        /// <remarks>
        /// Returns the room information.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> GetRoomInfoWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room links
        /// </summary>
        /// <remarks>
        /// Returns the links of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        System.Threading.Tasks.Task<FileShareArrayWrapper> GetRoomLinksAsync(int id, LinkType? type = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room links
        /// </summary>
        /// <remarks>
        /// Returns the links of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> GetRoomLinksWithHttpInfoAsync(int id, LinkType? type = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room access rights
        /// </summary>
        /// <remarks>
        /// Returns the access rights of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        System.Threading.Tasks.Task<FileShareArrayWrapper> GetRoomSecurityInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room access rights
        /// </summary>
        /// <remarks>
        /// Returns the access rights of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> GetRoomSecurityInfoWithHttpInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get tags
        /// </summary>
        /// <remarks>
        /// Returns a list of custom tags.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        System.Threading.Tasks.Task<ObjectArrayWrapper> GetRoomTagsInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get tags
        /// </summary>
        /// <remarks>
        /// Returns a list of custom tags.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectArrayWrapper>> GetRoomTagsInfoWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get status of room template creation
        /// </summary>
        /// <remarks>
        /// Returns the progress status of the room template creation process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        System.Threading.Tasks.Task<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get status of room template creation
        /// </summary>
        /// <remarks>
        /// Returns the progress status of the room template creation process.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomTemplateStatusWrapper>> GetRoomTemplateCreatingStatusWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get rooms
        /// </summary>
        /// <remarks>
        /// Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetRoomsFolderAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get rooms
        /// </summary>
        /// <remarks>
        /// Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        System.Threading.Tasks.Task<ApiResponse<FolderContentIntegerWrapper>> GetRoomsFolderWithHttpInfoAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of NewItemsRoomNewItemsArrayWrapper</returns>
        System.Threading.Tasks.Task<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room new items
        /// </summary>
        /// <remarks>
        /// Returns the room new items.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsRoomNewItemsArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<NewItemsRoomNewItemsArrayWrapper>> GetRoomsNewItemsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the room primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> GetRoomsPrimaryExternalLinkAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get the room primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link of the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> GetRoomsPrimaryExternalLinkWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pin a room
        /// </summary>
        /// <remarks>
        /// Pins a room with the ID specified in the request to the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> PinRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Pin a room
        /// </summary>
        /// <remarks>
        /// Pins a room with the ID specified in the request to the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> PinRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reorder the room
        /// </summary>
        /// <remarks>
        /// Reorders the room with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> ReorderRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reorder the room
        /// </summary>
        /// <remarks>
        /// Reorders the room with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> ReorderRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resend the room invitations
        /// </summary>
        /// <remarks>
        /// Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ResendEmailInvitationsAsync(int id, UserInvitation? userInvitation = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Resend the room invitations
        /// </summary>
        /// <remarks>
        /// Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ResendEmailInvitationsWithHttpInfoAsync(int id, UserInvitation? userInvitation = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set public settings
        /// </summary>
        /// <remarks>
        /// Sets the public settings for the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SetPublicSettingsAsync(SetPublicDto? setPublicDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set public settings
        /// </summary>
        /// <remarks>
        /// Sets the public settings for the room template with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetPublicSettingsWithHttpInfoAsync(SetPublicDto? setPublicDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the room external or invitation link
        /// </summary>
        /// <remarks>
        /// Sets the room external or invitation link with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> SetRoomLinkAsync(int id, RoomLinkRequest? roomLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the room external or invitation link
        /// </summary>
        /// <remarks>
        /// Sets the room external or invitation link with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> SetRoomLinkWithHttpInfoAsync(int id, RoomLinkRequest? roomLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the room access rights
        /// </summary>
        /// <remarks>
        /// Sets the access rights to the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of RoomSecurityWrapper</returns>
        System.Threading.Tasks.Task<RoomSecurityWrapper> SetRoomSecurityAsync(int id, RoomInvitationRequest? roomInvitationRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the room access rights
        /// </summary>
        /// <remarks>
        /// Sets the access rights to the room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (RoomSecurityWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<RoomSecurityWrapper>> SetRoomSecurityWithHttpInfoAsync(int id, RoomInvitationRequest? roomInvitationRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start the room index export
        /// </summary>
        /// <remarks>
        /// Starts the index export of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        System.Threading.Tasks.Task<DocumentBuilderTaskWrapper> StartRoomIndexExportAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the room index export
        /// </summary>
        /// <remarks>
        /// Starts the index export of a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentBuilderTaskWrapper>> StartRoomIndexExportWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminate the room index export
        /// </summary>
        /// <remarks>
        /// Terminates the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TerminateRoomIndexExportAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Terminate the room index export
        /// </summary>
        /// <remarks>
        /// Terminates the room index export.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TerminateRoomIndexExportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unarchive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        System.Threading.Tasks.Task<FileOperationWrapper> UnarchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unarchive a room
        /// </summary>
        /// <remarks>
        /// Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileOperationWrapper>> UnarchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unpin a room
        /// </summary>
        /// <remarks>
        /// Unpins a room with the ID specified in the request from the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> UnpinRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unpin a room
        /// </summary>
        /// <remarks>
        /// Unpins a room with the ID specified in the request from the top of the list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> UnpinRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a room
        /// </summary>
        /// <remarks>
        /// Updates a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        System.Threading.Tasks.Task<FolderIntegerWrapper> UpdateRoomAsync(int id, UpdateRoomRequest? updateRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a room
        /// </summary>
        /// <remarks>
        /// Updates a room with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderIntegerWrapper>> UpdateRoomWithHttpInfoAsync(int id, UpdateRoomRequest? updateRoomRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a room logo image
        /// </summary>
        /// <remarks>
        /// Uploads a temporary image to create a room logo.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of UploadResultWrapper</returns>
        System.Threading.Tasks.Task<UploadResultWrapper> UploadRoomLogoAsync(List<KeyValuePairStringStringValues>? formCollection = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a room logo image
        /// </summary>
        /// <remarks>
        /// Uploads a temporary image to create a room logo.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (UploadResultWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<UploadResultWrapper>> UploadRoomLogoWithHttpInfoAsync(List<KeyValuePairStringStringValues>? formCollection = default, System.Threading.CancellationToken cancellationToken = default);
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
    public partial class RoomsApi : IDisposable, IRoomsApi
    {
        private Docspace.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

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
            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                new Docspace.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Docspace.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public RoomsApi(Docspace.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Docspace.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
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
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                new Docspace.Client.Configuration { BasePath = basePath }
            );
            this.ApiClient = new Docspace.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class using Configuration object.
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
        public RoomsApi(HttpClient client, Docspace.Client.Configuration configuration, HttpClientHandler handler = null)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                Docspace.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new Docspace.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public RoomsApi(Docspace.Client.ISynchronousClient client, Docspace.Client.IAsynchronousClient asyncClient, Docspace.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Docspace.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Docspace.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Docspace.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Docspace.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Docspace.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Add the room tags Adds the tags to a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper AddRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = AddRoomTagsWithHttpInfo(id, batchTagsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add the room tags Adds the tags to a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> AddRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddRoomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add the room tags Adds the tags to a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> AddRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await AddRoomTagsWithHttpInfoAsync(id, batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add the room tags Adds the tags to a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-room-tags/">REST API Reference for AddRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> AddRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddRoomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Archive a room Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper ArchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = ArchiveRoomWithHttpInfo(id, archiveRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Archive a room Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public Docspace.Client.ApiResponse<FileOperationWrapper> ArchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = archiveRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FileOperationWrapper>("/api/2.0/files/rooms/{id}/archive", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ArchiveRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Archive a room Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async System.Threading.Tasks.Task<FileOperationWrapper> ArchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = await ArchiveRoomWithHttpInfoAsync(id, archiveRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Archive a room Moves a room with the ID specified in the request to the \&quot;Archive\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/archive-room/">REST API Reference for ArchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileOperationWrapper>> ArchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = archiveRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}/archive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ArchiveRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the room cover Changes a cover of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper ChangeRoomCover(int id, CoverRequestDto? coverRequestDto = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = ChangeRoomCoverWithHttpInfo(id, coverRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the room cover Changes a cover of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> ChangeRoomCoverWithHttpInfo(int id, CoverRequestDto? coverRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = coverRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/cover", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeRoomCover", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change the room cover Changes a cover of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> ChangeRoomCoverAsync(int id, CoverRequestDto? coverRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await ChangeRoomCoverWithHttpInfoAsync(id, coverRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change the room cover Changes a cover of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="coverRequestDto">The request parameters to change the room cover. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-room-cover/">REST API Reference for ChangeRoomCover Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> ChangeRoomCoverWithHttpInfoAsync(int id, CoverRequestDto? coverRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = coverRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/cover", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ChangeRoomCover", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room Creates a room in the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateRoom(CreateRoomRequestDto? createRoomRequestDto = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = CreateRoomWithHttpInfo(createRoomRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room Creates a room in the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> CreateRoomWithHttpInfo(CreateRoomRequestDto? createRoomRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createRoomRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room Creates a room in the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> CreateRoomAsync(CreateRoomRequestDto? createRoomRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await CreateRoomWithHttpInfoAsync(createRoomRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room Creates a room in the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room/">REST API Reference for CreateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> CreateRoomWithHttpInfoAsync(CreateRoomRequestDto? createRoomRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createRoomRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room from the template Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        public RoomFromTemplateStatusWrapper CreateRoomFromTemplate(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default)
        {
            Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> localVarResponse = CreateRoomFromTemplateWithHttpInfo(createRoomFromTemplateDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room from the template Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        public Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateWithHttpInfo(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createRoomFromTemplateDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomFromTemplate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room from the template Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        public async System.Threading.Tasks.Task<RoomFromTemplateStatusWrapper> CreateRoomFromTemplateAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> localVarResponse = await CreateRoomFromTemplateWithHttpInfoAsync(createRoomFromTemplateDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room from the template Creates a room in the \&quot;Rooms\&quot; section based on the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createRoomFromTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-from-template/">REST API Reference for CreateRoomFromTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper>> CreateRoomFromTemplateWithHttpInfoAsync(CreateRoomFromTemplateDto? createRoomFromTemplateDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createRoomFromTemplateDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomFromTemplate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room logo Creates a logo for a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper CreateRoomLogo(int id, LogoRequest? logoRequest = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = CreateRoomLogoWithHttpInfo(id, logoRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room logo Creates a logo for a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> CreateRoomLogoWithHttpInfo(int id, LogoRequest? logoRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = logoRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a room logo Creates a logo for a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> CreateRoomLogoAsync(int id, LogoRequest? logoRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await CreateRoomLogoWithHttpInfoAsync(id, logoRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a room logo Creates a logo for a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="logoRequest">The logo request parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-logo/">REST API Reference for CreateRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> CreateRoomLogoWithHttpInfoAsync(int id, LogoRequest? logoRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = logoRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a tag Creates a custom tag with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper CreateRoomTag(CreateTagRequestDto? createTagRequestDto = default)
        {
            Docspace.Client.ApiResponse<ObjectWrapper> localVarResponse = CreateRoomTagWithHttpInfo(createTagRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a tag Creates a custom tag with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public Docspace.Client.ApiResponse<ObjectWrapper> CreateRoomTagWithHttpInfo(CreateTagRequestDto? createTagRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createTagRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<ObjectWrapper>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomTag", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a tag Creates a custom tag with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> CreateRoomTagAsync(CreateTagRequestDto? createTagRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ObjectWrapper> localVarResponse = await CreateRoomTagWithHttpInfoAsync(createTagRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a tag Creates a custom tag with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTagRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-tag/">REST API Reference for CreateRoomTag Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ObjectWrapper>> CreateRoomTagWithHttpInfoAsync(CreateTagRequestDto? createTagRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createTagRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomTag", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start creating room template Starts creating the room template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        public RoomTemplateStatusWrapper CreateRoomTemplate(RoomTemplateDto? roomTemplateDto = default)
        {
            Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> localVarResponse = CreateRoomTemplateWithHttpInfo(roomTemplateDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start creating room template Starts creating the room template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        public Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> CreateRoomTemplateWithHttpInfo(RoomTemplateDto? roomTemplateDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = roomTemplateDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomTemplate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start creating room template Starts creating the room template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        public async System.Threading.Tasks.Task<RoomTemplateStatusWrapper> CreateRoomTemplateAsync(RoomTemplateDto? roomTemplateDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> localVarResponse = await CreateRoomTemplateWithHttpInfoAsync(roomTemplateDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start creating room template Starts creating the room template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roomTemplateDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-template/">REST API Reference for CreateRoomTemplate Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<RoomTemplateStatusWrapper>> CreateRoomTemplateWithHttpInfoAsync(RoomTemplateDto? roomTemplateDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = roomTemplateDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomTemplate", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-party room Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>FolderStringWrapper</returns>
        public FolderStringWrapper CreateRoomThirdParty(string id, CreateThirdPartyRoom? createThirdPartyRoom = default)
        {
            Docspace.Client.ApiResponse<FolderStringWrapper> localVarResponse = CreateRoomThirdPartyWithHttpInfo(id, createThirdPartyRoom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a third-party room Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>ApiResponse of FolderStringWrapper</returns>
        public Docspace.Client.ApiResponse<FolderStringWrapper> CreateRoomThirdPartyWithHttpInfo(string id, CreateThirdPartyRoom? createThirdPartyRoom = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'id' when calling RoomsApi->CreateRoomThirdParty");

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = createThirdPartyRoom;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<FolderStringWrapper>("/api/2.0/files/rooms/thirdparty/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomThirdParty", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a third-party room Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of FolderStringWrapper</returns>
        public async System.Threading.Tasks.Task<FolderStringWrapper> CreateRoomThirdPartyAsync(string id, CreateThirdPartyRoom? createThirdPartyRoom = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderStringWrapper> localVarResponse = await CreateRoomThirdPartyWithHttpInfoAsync(id, createThirdPartyRoom, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a third-party room Creates a room in the \&quot;Rooms\&quot; section stored in a third-party storage.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the folder in the third-party storage in which the contents of the room will be stored.</param>
        /// <param name="createThirdPartyRoom">The third-party room information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-room-third-party/">REST API Reference for CreateRoomThirdParty Operation</seealso>
        /// <returns>Task of ApiResponse (FolderStringWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderStringWrapper>> CreateRoomThirdPartyWithHttpInfoAsync(string id, CreateThirdPartyRoom? createThirdPartyRoom = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Docspace.Client.ApiException(400, "Missing required parameter 'id' when calling RoomsApi->CreateRoomThirdParty");


            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = createThirdPartyRoom;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<FolderStringWrapper>("/api/2.0/files/rooms/thirdparty/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateRoomThirdParty", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete tags Deletes a bunch of custom tags specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns></returns>
        public void DeleteCustomTags(BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            DeleteCustomTagsWithHttpInfo(batchTagsRequestDto);
        }

        /// <summary>
        /// Delete tags Deletes a bunch of custom tags specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public Docspace.Client.ApiResponse<Object> DeleteCustomTagsWithHttpInfo(BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete tags Deletes a bunch of custom tags specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomTagsAsync(BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await DeleteCustomTagsWithHttpInfoAsync(batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete tags Deletes a bunch of custom tags specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchTagsRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-custom-tags/">REST API Reference for DeleteCustomTags Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> DeleteCustomTagsWithHttpInfoAsync(BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteCustomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a room Removes a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper DeleteRoom(int id, DeleteRoomRequest? deleteRoomRequest = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = DeleteRoomWithHttpInfo(id, deleteRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a room Removes a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public Docspace.Client.ApiResponse<FileOperationWrapper> DeleteRoomWithHttpInfo(int id, DeleteRoomRequest? deleteRoomRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = deleteRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<FileOperationWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a room Removes a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async System.Threading.Tasks.Task<FileOperationWrapper> DeleteRoomAsync(int id, DeleteRoomRequest? deleteRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = await DeleteRoomWithHttpInfoAsync(id, deleteRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a room Removes a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="deleteRoomRequest">The parameters for deleting a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room/">REST API Reference for DeleteRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileOperationWrapper>> DeleteRoomWithHttpInfoAsync(int id, DeleteRoomRequest? deleteRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = deleteRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a room logo Removes a logo from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper DeleteRoomLogo(int id)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = DeleteRoomLogoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a room logo Removes a logo from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> DeleteRoomLogoWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a room logo Removes a logo from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> DeleteRoomLogoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await DeleteRoomLogoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a room logo Removes a logo from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-logo/">REST API Reference for DeleteRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> DeleteRoomLogoWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/logo", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove the room tags Removes the tags from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper DeleteRoomTags(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = DeleteRoomTagsWithHttpInfo(id, batchTagsRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove the room tags Removes the tags from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> DeleteRoomTagsWithHttpInfo(int id, BatchTagsRequestDto? batchTagsRequestDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove the room tags Removes the tags from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> DeleteRoomTagsAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await DeleteRoomTagsWithHttpInfoAsync(id, batchTagsRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove the room tags Removes the tags from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room Id.</param>
        /// <param name="batchTagsRequestDto">The parameters for adding tags. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-room-tags/">REST API Reference for DeleteRoomTags Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> DeleteRoomTagsWithHttpInfoAsync(int id, BatchTagsRequestDto? batchTagsRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = batchTagsRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteRoomTags", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the new room items Returns a list of all the new items from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>NewItemsFileEntryArrayWrapper</returns>
        public NewItemsFileEntryArrayWrapper GetNewRoomItems(int id)
        {
            Docspace.Client.ApiResponse<NewItemsFileEntryArrayWrapper> localVarResponse = GetNewRoomItemsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the new room items Returns a list of all the new items from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsFileEntryArrayWrapper</returns>
        public Docspace.Client.ApiResponse<NewItemsFileEntryArrayWrapper> GetNewRoomItemsWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<NewItemsFileEntryArrayWrapper>("/api/2.0/files/rooms/{id}/news", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNewRoomItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the new room items Returns a list of all the new items from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of NewItemsFileEntryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<NewItemsFileEntryArrayWrapper> GetNewRoomItemsAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<NewItemsFileEntryArrayWrapper> localVarResponse = await GetNewRoomItemsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the new room items Returns a list of all the new items from a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-new-room-items/">REST API Reference for GetNewRoomItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsFileEntryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<NewItemsFileEntryArrayWrapper>> GetNewRoomItemsWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<NewItemsFileEntryArrayWrapper>("/api/2.0/files/rooms/{id}/news", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetNewRoomItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public settings Returns the public settings of the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper GetPublicSettings(int id)
        {
            Docspace.Client.ApiResponse<BooleanWrapper> localVarResponse = GetPublicSettingsWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public settings Returns the public settings of the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public Docspace.Client.ApiResponse<BooleanWrapper> GetPublicSettingsWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<BooleanWrapper>("/api/2.0/files/roomtemplate/{id}/public", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get public settings Returns the public settings of the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> GetPublicSettingsAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<BooleanWrapper> localVarResponse = await GetPublicSettingsWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get public settings Returns the public settings of the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room template ID.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-public-settings/">REST API Reference for GetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<BooleanWrapper>> GetPublicSettingsWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/roomtemplate/{id}/public", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPublicSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get covers Returns a list of all covers.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>CoversResultArrayWrapper</returns>
        public CoversResultArrayWrapper GetRoomCovers()
        {
            Docspace.Client.ApiResponse<CoversResultArrayWrapper> localVarResponse = GetRoomCoversWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get covers Returns a list of all covers.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>ApiResponse of CoversResultArrayWrapper</returns>
        public Docspace.Client.ApiResponse<CoversResultArrayWrapper> GetRoomCoversWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<CoversResultArrayWrapper>("/api/2.0/files/rooms/covers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomCovers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get covers Returns a list of all covers.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of CoversResultArrayWrapper</returns>
        public async System.Threading.Tasks.Task<CoversResultArrayWrapper> GetRoomCoversAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<CoversResultArrayWrapper> localVarResponse = await GetRoomCoversWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get covers Returns a list of all covers.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-covers/">REST API Reference for GetRoomCovers Operation</seealso>
        /// <returns>Task of ApiResponse (CoversResultArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<CoversResultArrayWrapper>> GetRoomCoversWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CoversResultArrayWrapper>("/api/2.0/files/rooms/covers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomCovers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room creation progress Returns the progress of creating a room from the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>RoomFromTemplateStatusWrapper</returns>
        public RoomFromTemplateStatusWrapper GetRoomCreatingStatus()
        {
            Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> localVarResponse = GetRoomCreatingStatusWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room creation progress Returns the progress of creating a room from the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomFromTemplateStatusWrapper</returns>
        public Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomCreatingStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room creation progress Returns the progress of creating a room from the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of RoomFromTemplateStatusWrapper</returns>
        public async System.Threading.Tasks.Task<RoomFromTemplateStatusWrapper> GetRoomCreatingStatusAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper> localVarResponse = await GetRoomCreatingStatusWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room creation progress Returns the progress of creating a room from the template.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-creating-status/">REST API Reference for GetRoomCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomFromTemplateStatusWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<RoomFromTemplateStatusWrapper>> GetRoomCreatingStatusWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<RoomFromTemplateStatusWrapper>("/api/2.0/files/rooms/fromtemplate/status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomCreatingStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room index export Returns the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper GetRoomIndexExport()
        {
            Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> localVarResponse = GetRoomIndexExportWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room index export Returns the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> GetRoomIndexExportWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room index export Returns the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async System.Threading.Tasks.Task<DocumentBuilderTaskWrapper> GetRoomIndexExportAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> localVarResponse = await GetRoomIndexExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room index export Returns the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-index-export/">REST API Reference for GetRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper>> GetRoomIndexExportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room information Returns the room information.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper GetRoomInfo(int id)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = GetRoomInfoWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room information Returns the room information.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> GetRoomInfoWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get room information Returns the room information.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> GetRoomInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await GetRoomInfoWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get room information Returns the room information.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-info/">REST API Reference for GetRoomInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> GetRoomInfoWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room links Returns the links of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetRoomLinks(int id, LinkType? type = default)
        {
            Docspace.Client.ApiResponse<FileShareArrayWrapper> localVarResponse = GetRoomLinksWithHttpInfo(id, type);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room links Returns the links of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public Docspace.Client.ApiResponse<FileShareArrayWrapper> GetRoomLinksWithHttpInfo(int id, LinkType? type = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomLinks", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room links Returns the links of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareArrayWrapper> GetRoomLinksAsync(int id, LinkType? type = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileShareArrayWrapper> localVarResponse = await GetRoomLinksWithHttpInfoAsync(id, type, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room links Returns the links of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="type">The link type. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-links/">REST API Reference for GetRoomLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileShareArrayWrapper>> GetRoomLinksWithHttpInfoAsync(int id, LinkType? type = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "type", type));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomLinks", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room access rights Returns the access rights of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetRoomSecurityInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            Docspace.Client.ApiResponse<FileShareArrayWrapper> localVarResponse = GetRoomSecurityInfoWithHttpInfo(id, filterType, count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room access rights Returns the access rights of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public Docspace.Client.ApiResponse<FileShareArrayWrapper> GetRoomSecurityInfoWithHttpInfo(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomSecurityInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room access rights Returns the access rights of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareArrayWrapper> GetRoomSecurityInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileShareArrayWrapper> localVarResponse = await GetRoomSecurityInfoWithHttpInfoAsync(id, filterType, count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room access rights Returns the access rights of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="filterType">The filter type of the access rights. (optional)</param>
        /// <param name="count">The number of items to be retrieved or processed. (optional)</param>
        /// <param name="startIndex">The starting index of the items to retrieve in a paginated request. (optional)</param>
        /// <param name="filterValue">The text filter value used for filtering room security information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-security-info/">REST API Reference for GetRoomSecurityInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileShareArrayWrapper>> GetRoomSecurityInfoWithHttpInfoAsync(int id, ShareFilterType? filterType = default, int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (filterType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterType", filterType));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomSecurityInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tags Returns a list of custom tags.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper GetRoomTagsInfo(int? count = default, int? startIndex = default, string? filterValue = default)
        {
            Docspace.Client.ApiResponse<ObjectArrayWrapper> localVarResponse = GetRoomTagsInfoWithHttpInfo(count, startIndex, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get tags Returns a list of custom tags.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public Docspace.Client.ApiResponse<ObjectArrayWrapper> GetRoomTagsInfoWithHttpInfo(int? count = default, int? startIndex = default, string? filterValue = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<ObjectArrayWrapper>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomTagsInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get tags Returns a list of custom tags.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectArrayWrapper> GetRoomTagsInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<ObjectArrayWrapper> localVarResponse = await GetRoomTagsInfoWithHttpInfoAsync(count, startIndex, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get tags Returns a list of custom tags.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="count">Gets or sets the number of tag results to retrieve.  This property specifies the maximum amount of tag data to be included in the result set. (optional)</param>
        /// <param name="startIndex">Represents the starting index from which the tags&#39; information will be retrieved.  This property is used to define the offset for pagination when retrieving a list of tags. It determines  the point in the data set from which the retrieval begins. (optional)</param>
        /// <param name="filterValue">Gets or sets the text value used for searching tags.  This property is typically used as a filter value when retrieving tag information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-tags-info/">REST API Reference for GetRoomTagsInfo Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<ObjectArrayWrapper>> GetRoomTagsInfoWithHttpInfoAsync(int? count = default, int? startIndex = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ObjectArrayWrapper>("/api/2.0/files/tags", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomTagsInfo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get status of room template creation Returns the progress status of the room template creation process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>RoomTemplateStatusWrapper</returns>
        public RoomTemplateStatusWrapper GetRoomTemplateCreatingStatus()
        {
            Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> localVarResponse = GetRoomTemplateCreatingStatusWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of room template creation Returns the progress status of the room template creation process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>ApiResponse of RoomTemplateStatusWrapper</returns>
        public Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate/status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomTemplateCreatingStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get status of room template creation Returns the progress status of the room template creation process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of RoomTemplateStatusWrapper</returns>
        public async System.Threading.Tasks.Task<RoomTemplateStatusWrapper> GetRoomTemplateCreatingStatusAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<RoomTemplateStatusWrapper> localVarResponse = await GetRoomTemplateCreatingStatusWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of room template creation Returns the progress status of the room template creation process.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-room-template-creating-status/">REST API Reference for GetRoomTemplateCreatingStatus Operation</seealso>
        /// <returns>Task of ApiResponse (RoomTemplateStatusWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<RoomTemplateStatusWrapper>> GetRoomTemplateCreatingStatusWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<RoomTemplateStatusWrapper>("/api/2.0/files/roomtemplate/status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomTemplateCreatingStatus", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get rooms Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
            Docspace.Client.ApiResponse<FolderContentIntegerWrapper> localVarResponse = GetRoomsFolderWithHttpInfo(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get rooms Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        public Docspace.Client.ApiResponse<FolderContentIntegerWrapper> GetRoomsFolderWithHttpInfo(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
            }
            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (storageFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "storageFilter", storageFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<FolderContentIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsFolder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get rooms Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<FolderContentIntegerWrapper> GetRoomsFolderAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderContentIntegerWrapper> localVarResponse = await GetRoomsFolderWithHttpInfoAsync(type, subjectId, searchArea, withoutTags, tags, excludeSubject, provider, subjectFilter, quotaFilter, storageFilter, count, startIndex, sortBy, sortOrder, filterValue, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get rooms Returns the contents of the \&quot;Rooms\&quot; section by the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderContentIntegerWrapper>> GetRoomsFolderWithHttpInfoAsync(List<RoomType>? type = default, string? subjectId = default, SearchArea? searchArea = default, bool? withoutTags = default, string? tags = default, bool? excludeSubject = default, ProviderFilter? provider = default, SubjectFilter? subjectFilter = default, QuotaFilter? quotaFilter = default, StorageFilter? storageFilter = default, int? count = default, int? startIndex = default, string? sortBy = default, SortOrder? sortOrder = default, string? filterValue = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (type != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("csv", "type", type));
            }
            if (subjectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "subjectId", subjectId));
            }
            if (searchArea != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "searchArea", searchArea));
            }
            if (withoutTags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "withoutTags", withoutTags));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (excludeSubject != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "excludeSubject", excludeSubject));
            }
            if (provider != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "provider", provider));
            }
            if (subjectFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "subjectFilter", subjectFilter));
            }
            if (quotaFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "quotaFilter", quotaFilter));
            }
            if (storageFilter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "storageFilter", storageFilter));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }
            if (filterValue != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "filterValue", filterValue));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FolderContentIntegerWrapper>("/api/2.0/files/rooms", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsFolder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room new items Returns the room new items.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>NewItemsRoomNewItemsArrayWrapper</returns>
        public NewItemsRoomNewItemsArrayWrapper GetRoomsNewItems()
        {
            Docspace.Client.ApiResponse<NewItemsRoomNewItemsArrayWrapper> localVarResponse = GetRoomsNewItemsWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room new items Returns the room new items.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>ApiResponse of NewItemsRoomNewItemsArrayWrapper</returns>
        public Docspace.Client.ApiResponse<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<NewItemsRoomNewItemsArrayWrapper>("/api/2.0/files/rooms/news", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsNewItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room new items Returns the room new items.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of NewItemsRoomNewItemsArrayWrapper</returns>
        public async System.Threading.Tasks.Task<NewItemsRoomNewItemsArrayWrapper> GetRoomsNewItemsAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<NewItemsRoomNewItemsArrayWrapper> localVarResponse = await GetRoomsNewItemsWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room new items Returns the room new items.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-new-items/">REST API Reference for GetRoomsNewItems Operation</seealso>
        /// <returns>Task of ApiResponse (NewItemsRoomNewItemsArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<NewItemsRoomNewItemsArrayWrapper>> GetRoomsNewItemsWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<NewItemsRoomNewItemsArrayWrapper>("/api/2.0/files/rooms/news", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsNewItems", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room primary external link Returns the primary external link of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetRoomsPrimaryExternalLink(int id)
        {
            Docspace.Client.ApiResponse<FileShareWrapper> localVarResponse = GetRoomsPrimaryExternalLinkWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room primary external link Returns the primary external link of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public Docspace.Client.ApiResponse<FileShareWrapper> GetRoomsPrimaryExternalLinkWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Get<FileShareWrapper>("/api/2.0/files/rooms/{id}/link", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsPrimaryExternalLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the room primary external link Returns the primary external link of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> GetRoomsPrimaryExternalLinkAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileShareWrapper> localVarResponse = await GetRoomsPrimaryExternalLinkWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the room primary external link Returns the primary external link of the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-rooms-primary-external-link/">REST API Reference for GetRoomsPrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileShareWrapper>> GetRoomsPrimaryExternalLinkWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/rooms/{id}/link", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetRoomsPrimaryExternalLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Pin a room Pins a room with the ID specified in the request to the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper PinRoom(int id)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = PinRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Pin a room Pins a room with the ID specified in the request to the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> PinRoomWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/pin", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PinRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Pin a room Pins a room with the ID specified in the request to the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> PinRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await PinRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Pin a room Pins a room with the ID specified in the request to the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/pin-room/">REST API Reference for PinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> PinRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/pin", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PinRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reorder the room Reorders the room with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper ReorderRoom(int id)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = ReorderRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reorder the room Reorders the room with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> ReorderRoomWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/reorder", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReorderRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Reorder the room Reorders the room with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> ReorderRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await ReorderRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Reorder the room Reorders the room with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/reorder-room/">REST API Reference for ReorderRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> ReorderRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/reorder", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReorderRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend the room invitations Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns></returns>
        public void ResendEmailInvitations(int id, UserInvitation? userInvitation = default)
        {
            ResendEmailInvitationsWithHttpInfo(id, userInvitation);
        }

        /// <summary>
        /// Resend the room invitations Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public Docspace.Client.ApiResponse<Object> ResendEmailInvitationsWithHttpInfo(int id, UserInvitation? userInvitation = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = userInvitation;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/2.0/files/rooms/{id}/resend", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResendEmailInvitations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Resend the room invitations Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ResendEmailInvitationsAsync(int id, UserInvitation? userInvitation = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await ResendEmailInvitationsWithHttpInfoAsync(id, userInvitation, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Resend the room invitations Resends the email invitations to a room with the ID specified in the request to the selected users.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="userInvitation">The user invitation parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/resend-email-invitations/">REST API Reference for ResendEmailInvitations Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> ResendEmailInvitationsWithHttpInfoAsync(int id, UserInvitation? userInvitation = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = userInvitation;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/2.0/files/rooms/{id}/resend", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ResendEmailInvitations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set public settings Sets the public settings for the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns></returns>
        public void SetPublicSettings(SetPublicDto? setPublicDto = default)
        {
            SetPublicSettingsWithHttpInfo(setPublicDto);
        }

        /// <summary>
        /// Set public settings Sets the public settings for the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public Docspace.Client.ApiResponse<Object> SetPublicSettingsWithHttpInfo(SetPublicDto? setPublicDto = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = setPublicDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/2.0/files/roomtemplate/public", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPublicSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set public settings Sets the public settings for the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SetPublicSettingsAsync(SetPublicDto? setPublicDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await SetPublicSettingsWithHttpInfoAsync(setPublicDto, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Set public settings Sets the public settings for the room template with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="setPublicDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-public-settings/">REST API Reference for SetPublicSettings Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> SetPublicSettingsWithHttpInfoAsync(SetPublicDto? setPublicDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = setPublicDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/files/roomtemplate/public", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetPublicSettings", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the room external or invitation link Sets the room external or invitation link with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper SetRoomLink(int id, RoomLinkRequest? roomLinkRequest = default)
        {
            Docspace.Client.ApiResponse<FileShareWrapper> localVarResponse = SetRoomLinkWithHttpInfo(id, roomLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the room external or invitation link Sets the room external or invitation link with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public Docspace.Client.ApiResponse<FileShareWrapper> SetRoomLinkWithHttpInfo(int id, RoomLinkRequest? roomLinkRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = roomLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FileShareWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetRoomLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the room external or invitation link Sets the room external or invitation link with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> SetRoomLinkAsync(int id, RoomLinkRequest? roomLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileShareWrapper> localVarResponse = await SetRoomLinkWithHttpInfoAsync(id, roomLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the room external or invitation link Sets the room external or invitation link with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomLinkRequest">The room link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-link/">REST API Reference for SetRoomLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileShareWrapper>> SetRoomLinkWithHttpInfoAsync(int id, RoomLinkRequest? roomLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = roomLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileShareWrapper>("/api/2.0/files/rooms/{id}/links", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetRoomLink", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the room access rights Sets the access rights to the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>RoomSecurityWrapper</returns>
        public RoomSecurityWrapper SetRoomSecurity(int id, RoomInvitationRequest? roomInvitationRequest = default)
        {
            Docspace.Client.ApiResponse<RoomSecurityWrapper> localVarResponse = SetRoomSecurityWithHttpInfo(id, roomInvitationRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the room access rights Sets the access rights to the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>ApiResponse of RoomSecurityWrapper</returns>
        public Docspace.Client.ApiResponse<RoomSecurityWrapper> SetRoomSecurityWithHttpInfo(int id, RoomInvitationRequest? roomInvitationRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = roomInvitationRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<RoomSecurityWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetRoomSecurity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the room access rights Sets the access rights to the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of RoomSecurityWrapper</returns>
        public async System.Threading.Tasks.Task<RoomSecurityWrapper> SetRoomSecurityAsync(int id, RoomInvitationRequest? roomInvitationRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<RoomSecurityWrapper> localVarResponse = await SetRoomSecurityWithHttpInfoAsync(id, roomInvitationRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the room access rights Sets the access rights to the room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="roomInvitationRequest">The room invitation request. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-room-security/">REST API Reference for SetRoomSecurity Operation</seealso>
        /// <returns>Task of ApiResponse (RoomSecurityWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<RoomSecurityWrapper>> SetRoomSecurityWithHttpInfoAsync(int id, RoomInvitationRequest? roomInvitationRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = roomInvitationRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<RoomSecurityWrapper>("/api/2.0/files/rooms/{id}/share", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetRoomSecurity", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the room index export Starts the index export of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>DocumentBuilderTaskWrapper</returns>
        public DocumentBuilderTaskWrapper StartRoomIndexExport(int id)
        {
            Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> localVarResponse = StartRoomIndexExportWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the room index export Starts the index export of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of DocumentBuilderTaskWrapper</returns>
        public Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> StartRoomIndexExportWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/{id}/indexexport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StartRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start the room index export Starts the index export of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of DocumentBuilderTaskWrapper</returns>
        public async System.Threading.Tasks.Task<DocumentBuilderTaskWrapper> StartRoomIndexExportAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper> localVarResponse = await StartRoomIndexExportWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start the room index export Starts the index export of a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-room-index-export/">REST API Reference for StartRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse (DocumentBuilderTaskWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<DocumentBuilderTaskWrapper>> StartRoomIndexExportWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DocumentBuilderTaskWrapper>("/api/2.0/files/rooms/{id}/indexexport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StartRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the room index export Terminates the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns></returns>
        public void TerminateRoomIndexExport()
        {
            TerminateRoomIndexExportWithHttpInfo();
        }

        /// <summary>
        /// Terminate the room index export Terminates the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public Docspace.Client.ApiResponse<Object> TerminateRoomIndexExportWithHttpInfo()
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TerminateRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Terminate the room index export Terminates the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TerminateRoomIndexExportAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            await TerminateRoomIndexExportWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Terminate the room index export Terminates the room index export.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/terminate-room-index-export/">REST API Reference for TerminateRoomIndexExport Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<Object>> TerminateRoomIndexExportWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/api/2.0/files/rooms/indexexport", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TerminateRoomIndexExport", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unarchive a room Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>FileOperationWrapper</returns>
        public FileOperationWrapper UnarchiveRoom(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = UnarchiveRoomWithHttpInfo(id, archiveRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive a room Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>ApiResponse of FileOperationWrapper</returns>
        public Docspace.Client.ApiResponse<FileOperationWrapper> UnarchiveRoomWithHttpInfo(int id, ArchiveRoomRequest? archiveRoomRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = archiveRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FileOperationWrapper>("/api/2.0/files/rooms/{id}/unarchive", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnarchiveRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unarchive a room Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of FileOperationWrapper</returns>
        public async System.Threading.Tasks.Task<FileOperationWrapper> UnarchiveRoomAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FileOperationWrapper> localVarResponse = await UnarchiveRoomWithHttpInfoAsync(id, archiveRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive a room Moves a room with the ID specified in the request from the \&quot;Archive\&quot; section to the \&quot;Rooms\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="archiveRoomRequest">The parameters for archiving a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unarchive-room/">REST API Reference for UnarchiveRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FileOperationWrapper>> UnarchiveRoomWithHttpInfoAsync(int id, ArchiveRoomRequest? archiveRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = archiveRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileOperationWrapper>("/api/2.0/files/rooms/{id}/unarchive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnarchiveRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unpin a room Unpins a room with the ID specified in the request from the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper UnpinRoom(int id)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = UnpinRoomWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unpin a room Unpins a room with the ID specified in the request from the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> UnpinRoomWithHttpInfo(int id)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/unpin", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnpinRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Unpin a room Unpins a room with the ID specified in the request from the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> UnpinRoomAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await UnpinRoomWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Unpin a room Unpins a room with the ID specified in the request from the top of the list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/unpin-room/">REST API Reference for UnpinRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> UnpinRoomWithHttpInfoAsync(int id, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}/unpin", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UnpinRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a room Updates a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>FolderIntegerWrapper</returns>
        public FolderIntegerWrapper UpdateRoom(int id, UpdateRoomRequest? updateRoomRequest = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = UpdateRoomWithHttpInfo(id, updateRoomRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a room Updates a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>ApiResponse of FolderIntegerWrapper</returns>
        public Docspace.Client.ApiResponse<FolderIntegerWrapper> UpdateRoomWithHttpInfo(int id, UpdateRoomRequest? updateRoomRequest = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = updateRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Put<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a room Updates a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of FolderIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FolderIntegerWrapper> UpdateRoomAsync(int id, UpdateRoomRequest? updateRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<FolderIntegerWrapper> localVarResponse = await UpdateRoomWithHttpInfoAsync(id, updateRoomRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a room Updates a room with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The room ID.</param>
        /// <param name="updateRoomRequest">The request parameters for updating a room. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-room/">REST API Reference for UpdateRoom Operation</seealso>
        /// <returns>Task of ApiResponse (FolderIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<FolderIntegerWrapper>> UpdateRoomWithHttpInfoAsync(int id, UpdateRoomRequest? updateRoomRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Docspace.Client.ClientUtils.ParameterToString(id)); // path parameter
            localVarRequestOptions.Data = updateRoomRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FolderIntegerWrapper>("/api/2.0/files/rooms/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateRoom", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a room logo image Uploads a temporary image to create a room logo.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>UploadResultWrapper</returns>
        public UploadResultWrapper UploadRoomLogo(List<KeyValuePairStringStringValues>? formCollection = default)
        {
            Docspace.Client.ApiResponse<UploadResultWrapper> localVarResponse = UploadRoomLogoWithHttpInfo(formCollection);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a room logo image Uploads a temporary image to create a room logo.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>ApiResponse of UploadResultWrapper</returns>
        public Docspace.Client.ApiResponse<UploadResultWrapper> UploadRoomLogoWithHttpInfo(List<KeyValuePairStringStringValues>? formCollection = default)
        {
            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (formCollection != null)
            {
                localVarRequestOptions.FormParameters.Add("FormCollection", Docspace.Client.ClientUtils.ParameterToString(formCollection)); // form parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request
            var localVarResponse = this.Client.Post<UploadResultWrapper>("/api/2.0/files/logos", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UploadRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Upload a room logo image Uploads a temporary image to create a room logo.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of UploadResultWrapper</returns>
        public async System.Threading.Tasks.Task<UploadResultWrapper> UploadRoomLogoAsync(List<KeyValuePairStringStringValues>? formCollection = default, System.Threading.CancellationToken cancellationToken = default)
        {
            Docspace.Client.ApiResponse<UploadResultWrapper> localVarResponse = await UploadRoomLogoWithHttpInfoAsync(formCollection, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a room logo image Uploads a temporary image to create a room logo.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formCollection">The image data. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/upload-room-logo/">REST API Reference for UploadRoomLogo Operation</seealso>
        /// <returns>Task of ApiResponse (UploadResultWrapper)</returns>
        public async System.Threading.Tasks.Task<Docspace.Client.ApiResponse<UploadResultWrapper>> UploadRoomLogoWithHttpInfoAsync(List<KeyValuePairStringStringValues>? formCollection = default, System.Threading.CancellationToken cancellationToken = default)
        {

            Docspace.Client.RequestOptions localVarRequestOptions = new Docspace.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "multipart/form-data"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Docspace.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Docspace.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (formCollection != null)
            {
                localVarRequestOptions.FormParameters.Add("FormCollection", Docspace.Client.ClientUtils.ParameterToString(formCollection)); // form parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Docspace.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (OAuth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (ApiKeyBearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer")))
            {
                localVarRequestOptions.HeaderParameters.Add("ApiKeyBearer", this.Configuration.GetApiKeyWithPrefix("ApiKeyBearer"));
            }
            // authentication (asc_auth_key) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("asc_auth_key")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("asc_auth_key", this.Configuration.GetApiKeyWithPrefix("asc_auth_key")));
            }
            // authentication (Bearer) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (OpenId) required

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<UploadResultWrapper>("/api/2.0/files/logos", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UploadRoomLogo", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
