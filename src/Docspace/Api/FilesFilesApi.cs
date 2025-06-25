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
    public interface IFilesFilesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add template files
        /// </summary>
        /// <remarks>
        /// Adds files with the IDs specified in the request to the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper AddTemplates(TemplatesRequestDto? templatesRequestDto = default);

        /// <summary>
        /// Add template files
        /// </summary>
        /// <remarks>
        /// Adds files with the IDs specified in the request to the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> AddTemplatesWithHttpInfo(TemplatesRequestDto? templatesRequestDto = default);
        /// <summary>
        /// Change version history
        /// </summary>
        /// <remarks>
        /// Changes the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        FileIntegerArrayWrapper ChangeVersionHistory(int fileId, ChangeHistory? changeHistory = default);

        /// <summary>
        /// Change version history
        /// </summary>
        /// <remarks>
        /// Changes the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        ApiResponse<FileIntegerArrayWrapper> ChangeVersionHistoryWithHttpInfo(int fileId, ChangeHistory? changeHistory = default);
        /// <summary>
        /// Check the form draft filling
        /// </summary>
        /// <remarks>
        /// Checks if the current file is a form draft which can be filled out.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper CheckFillFormDraft(int fileId, CheckFillFormDraft? checkFillFormDraft = default);

        /// <summary>
        /// Check the form draft filling
        /// </summary>
        /// <remarks>
        /// Checks if the current file is a form draft which can be filled out.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> CheckFillFormDraftWithHttpInfo(int fileId, CheckFillFormDraft? checkFillFormDraft = default);
        /// <summary>
        /// Copy a file
        /// </summary>
        /// <remarks>
        /// Copies (and converts if possible) an existing file to the specified folder.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>FileEntryWrapper</returns>
        FileEntryWrapper CopyFileAs(int fileId, CopyAsJsonElement? copyAsJsonElement = default);

        /// <summary>
        /// Copy a file
        /// </summary>
        /// <remarks>
        /// Copies (and converts if possible) an existing file to the specified folder.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>ApiResponse of FileEntryWrapper</returns>
        ApiResponse<FileEntryWrapper> CopyFileAsWithHttpInfo(int fileId, CopyAsJsonElement? copyAsJsonElement = default);
        /// <summary>
        /// Create the editing session
        /// </summary>
        /// <remarks>
        /// Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        ObjectWrapper CreateEditSession(int fileId, long? fileSize = default);

        /// <summary>
        /// Create the editing session
        /// </summary>
        /// <remarks>
        /// Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        ApiResponse<ObjectWrapper> CreateEditSessionWithHttpInfo(int fileId, long? fileSize = default);
        /// <summary>
        /// Create a file
        /// </summary>
        /// <remarks>
        /// Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateFile(int folderId, CreateFileJsonElement? createFileJsonElement = default);

        /// <summary>
        /// Create a file
        /// </summary>
        /// <remarks>
        /// Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateFileWithHttpInfo(int folderId, CreateFileJsonElement? createFileJsonElement = default);
        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateFileInMyDocuments(CreateFileJsonElement? createFileJsonElement = default);

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateFileInMyDocumentsWithHttpInfo(CreateFileJsonElement? createFileJsonElement = default);
        /// <summary>
        /// Create an HTML file
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateHtmlFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// Create an HTML file
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateHtmlFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateHtmlFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateHtmlFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// Create primary external link
        /// </summary>
        /// <remarks>
        /// Creates a primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper CreatePrimaryExternalLink(int id, FileLinkRequest? fileLinkRequest = default);

        /// <summary>
        /// Create primary external link
        /// </summary>
        /// <remarks>
        /// Creates a primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> CreatePrimaryExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default);
        /// <summary>
        /// Create a text file
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateTextFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// Create a text file
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateTextFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper CreateTextFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default);

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> CreateTextFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default);
        /// <summary>
        /// Create file thumbnails
        /// </summary>
        /// <remarks>
        /// Creates thumbnails for the files with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        ObjectArrayWrapper CreateThumbnails(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// Create file thumbnails
        /// </summary>
        /// <remarks>
        /// Creates thumbnails for the files with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        ApiResponse<ObjectArrayWrapper> CreateThumbnailsWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// Delete a file
        /// </summary>
        /// <remarks>
        /// Deletes a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        FileOperationArrayWrapper DeleteFile(int fileId, Delete delete);

        /// <summary>
        /// Delete a file
        /// </summary>
        /// <remarks>
        /// Deletes a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        ApiResponse<FileOperationArrayWrapper> DeleteFileWithHttpInfo(int fileId, Delete delete);
        /// <summary>
        /// Delete recent files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        NoContentResultWrapper DeleteRecent(BaseBatchRequestDto? baseBatchRequestDto = default);

        /// <summary>
        /// Delete recent files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        ApiResponse<NoContentResultWrapper> DeleteRecentWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default);
        /// <summary>
        /// Delete template files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper DeleteTemplates(List<int>? requestBody = default);

        /// <summary>
        /// Delete template files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> DeleteTemplatesWithHttpInfo(List<int>? requestBody = default);
        /// <summary>
        /// Get form roles
        /// </summary>
        /// <remarks>
        /// Returns all roles for the specified form.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>FormRoleArrayWrapper</returns>
        FormRoleArrayWrapper GetAllFormRoles(int fileId);

        /// <summary>
        /// Get form roles
        /// </summary>
        /// <remarks>
        /// Returns all roles for the specified form.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>ApiResponse of FormRoleArrayWrapper</returns>
        ApiResponse<FormRoleArrayWrapper> GetAllFormRolesWithHttpInfo(int fileId);
        /// <summary>
        /// Get changes URL
        /// </summary>
        /// <remarks>
        /// Returns a URL to the changes of a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>EditHistoryDataWrapper</returns>
        EditHistoryDataWrapper GetEditDiffUrl(int fileId, int? version = default);

        /// <summary>
        /// Get changes URL
        /// </summary>
        /// <remarks>
        /// Returns a URL to the changes of a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>ApiResponse of EditHistoryDataWrapper</returns>
        ApiResponse<EditHistoryDataWrapper> GetEditDiffUrlWithHttpInfo(int fileId, int? version = default);
        /// <summary>
        /// Get version history
        /// </summary>
        /// <remarks>
        /// Returns the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        EditHistoryArrayWrapper GetEditHistory(int fileId);

        /// <summary>
        /// Get version history
        /// </summary>
        /// <remarks>
        /// Returns the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        ApiResponse<EditHistoryArrayWrapper> GetEditHistoryWithHttpInfo(int fileId);
        /// <summary>
        /// Get file history
        /// </summary>
        /// <remarks>
        /// Returns the list of actions performed on the file with the specified identifier.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        HistoryArrayWrapper GetFileHistory(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get file history
        /// </summary>
        /// <remarks>
        /// Returns the list of actions performed on the file with the specified identifier.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        ApiResponse<HistoryArrayWrapper> GetFileHistoryWithHttpInfo(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get file information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper GetFileInfo(int fileId, int? version = default);

        /// <summary>
        /// Get file information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> GetFileInfoWithHttpInfo(int fileId, int? version = default);
        /// <summary>
        /// Get file external links
        /// </summary>
        /// <remarks>
        /// Returns the external links of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        FileShareArrayWrapper GetFileLinks(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get file external links
        /// </summary>
        /// <remarks>
        /// Returns the external links of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        ApiResponse<FileShareArrayWrapper> GetFileLinksWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper GetFilePrimaryExternalLink(int id, int? count = default, int? startIndex = default);

        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> GetFilePrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default);
        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        FileIntegerArrayWrapper GetFileVersionInfo(int fileId);

        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        ApiResponse<FileIntegerArrayWrapper> GetFileVersionInfoWithHttpInfo(int fileId);
        /// <summary>
        /// Get form-filling result
        /// </summary>
        /// <remarks>
        /// Retrieves the result of a form-filling session.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>FillingFormResultIntegerWrapper</returns>
        FillingFormResultIntegerWrapper GetFillResult(string? fillingSessionId = default);

        /// <summary>
        /// Get form-filling result
        /// </summary>
        /// <remarks>
        /// Retrieves the result of a form-filling session.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>ApiResponse of FillingFormResultIntegerWrapper</returns>
        ApiResponse<FillingFormResultIntegerWrapper> GetFillResultWithHttpInfo(string? fillingSessionId = default);
        /// <summary>
        /// Get file download link asynchronously
        /// </summary>
        /// <remarks>
        /// Returns a link to download a file with the ID specified in the request asynchronously.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>FileLinkWrapper</returns>
        FileLinkWrapper GetPresignedFileUri(int fileId);

        /// <summary>
        /// Get file download link asynchronously
        /// </summary>
        /// <remarks>
        /// Returns a link to download a file with the ID specified in the request asynchronously.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>ApiResponse of FileLinkWrapper</returns>
        ApiResponse<FileLinkWrapper> GetPresignedFileUriWithHttpInfo(int fileId);
        /// <summary>
        /// Get file download link
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper GetPresignedUri(int fileId);

        /// <summary>
        /// Get file download link
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> GetPresignedUriWithHttpInfo(int fileId);
        /// <summary>
        /// Get users access rights to the protected file
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        MentionWrapperArrayWrapper GetProtectedFileUsers(int fileId);

        /// <summary>
        /// Get users access rights to the protected file
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        ApiResponse<MentionWrapperArrayWrapper> GetProtectedFileUsersWithHttpInfo(int fileId);
        /// <summary>
        /// Get reference data
        /// </summary>
        /// <remarks>
        /// Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>FileReferenceWrapper</returns>
        FileReferenceWrapper GetReferenceData(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default);

        /// <summary>
        /// Get reference data
        /// </summary>
        /// <remarks>
        /// Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>ApiResponse of FileReferenceWrapper</returns>
        ApiResponse<FileReferenceWrapper> GetReferenceDataWithHttpInfo(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default);
        /// <summary>
        /// Check the PDF file
        /// </summary>
        /// <remarks>
        /// Checks if the PDF file is a form or not.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        BooleanWrapper IsFormPDF(int fileId);

        /// <summary>
        /// Check the PDF file
        /// </summary>
        /// <remarks>
        /// Checks if the PDF file is a form or not.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        ApiResponse<BooleanWrapper> IsFormPDFWithHttpInfo(int fileId);
        /// <summary>
        /// Lock a file
        /// </summary>
        /// <remarks>
        /// Locks a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper LockFile(int fileId, LockFileParameters? lockFileParameters = default);

        /// <summary>
        /// Lock a file
        /// </summary>
        /// <remarks>
        /// Locks a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> LockFileWithHttpInfo(int fileId, LockFileParameters? lockFileParameters = default);
        /// <summary>
        /// Perform form filling action
        /// </summary>
        /// <remarks>
        /// Performs the specified form filling action.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns></returns>
        void ManageFormFilling(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default);

        /// <summary>
        /// Perform form filling action
        /// </summary>
        /// <remarks>
        /// Performs the specified form filling action.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ManageFormFillingWithHttpInfo(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default);
        /// <summary>
        /// Open a file configuration
        /// </summary>
        /// <remarks>
        /// Returns the initialization configuration of a file to open it in the editor.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ConfigurationIntegerWrapper</returns>
        ConfigurationIntegerWrapper OpenEditFile(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default);

        /// <summary>
        /// Open a file configuration
        /// </summary>
        /// <remarks>
        /// Returns the initialization configuration of a file to open it in the editor.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ApiResponse of ConfigurationIntegerWrapper</returns>
        ApiResponse<ConfigurationIntegerWrapper> OpenEditFileWithHttpInfo(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default);
        /// <summary>
        /// Restore a file version
        /// </summary>
        /// <remarks>
        /// Restores a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        EditHistoryArrayWrapper RestoreFileVersion(int fileId, int? version = default, string? url = default);

        /// <summary>
        /// Restore a file version
        /// </summary>
        /// <remarks>
        /// Restores a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        ApiResponse<EditHistoryArrayWrapper> RestoreFileVersionWithHttpInfo(int fileId, int? version = default, string? url = default);
        /// <summary>
        /// Save file edits
        /// </summary>
        /// <remarks>
        /// Saves edits to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SaveEditingFileFromForm(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default);

        /// <summary>
        /// Save file edits
        /// </summary>
        /// <remarks>
        /// Saves edits to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SaveEditingFileFromFormWithHttpInfo(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default);
        /// <summary>
        /// Save a file as PDF
        /// </summary>
        /// <remarks>
        /// Saves a file with the identifier specified in the request as a PDF document.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SaveFileAsPdf(int id, SaveAsPdfInteger? saveAsPdfInteger = default);

        /// <summary>
        /// Save a file as PDF
        /// </summary>
        /// <remarks>
        /// Saves a file with the identifier specified in the request as a PDF document.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SaveFileAsPdfWithHttpInfo(int id, SaveAsPdfInteger? saveAsPdfInteger = default);
        /// <summary>
        /// Save form role mapping
        /// </summary>
        /// <remarks>
        /// Saves the form role mapping.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>FormRoleWrapper</returns>
        FormRoleWrapper SaveFormRoleMapping(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default);

        /// <summary>
        /// Save form role mapping
        /// </summary>
        /// <remarks>
        /// Saves the form role mapping.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>ApiResponse of FormRoleWrapper</returns>
        ApiResponse<FormRoleWrapper> SaveFormRoleMappingWithHttpInfo(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default);
        /// <summary>
        /// Set the Custom Filter editing mode
        /// </summary>
        /// <remarks>
        /// Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SetCustomFilterTag(int fileId, CustomFilterParameters? customFilterParameters = default);

        /// <summary>
        /// Set the Custom Filter editing mode
        /// </summary>
        /// <remarks>
        /// Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SetCustomFilterTagWithHttpInfo(int fileId, CustomFilterParameters? customFilterParameters = default);
        /// <summary>
        /// Set an external link
        /// </summary>
        /// <remarks>
        /// Sets an external link to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        FileShareWrapper SetExternalLink(int id, FileLinkRequest? fileLinkRequest = default);

        /// <summary>
        /// Set an external link
        /// </summary>
        /// <remarks>
        /// Sets an external link to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        ApiResponse<FileShareWrapper> SetExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default);
        /// <summary>
        /// Set file order
        /// </summary>
        /// <remarks>
        /// Sets order of the file with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper SetFileOrder(int fileId, OrderRequestDto? orderRequestDto = default);

        /// <summary>
        /// Set file order
        /// </summary>
        /// <remarks>
        /// Sets order of the file with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> SetFileOrderWithHttpInfo(int fileId, OrderRequestDto? orderRequestDto = default);
        /// <summary>
        /// Set order of files
        /// </summary>
        /// <remarks>
        /// Sets order of the files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        FileIntegerArrayWrapper SetFilesOrder(OrdersRequestDtoInteger? ordersRequestDtoInteger = default);

        /// <summary>
        /// Set order of files
        /// </summary>
        /// <remarks>
        /// Sets order of the files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        ApiResponse<FileIntegerArrayWrapper> SetFilesOrderWithHttpInfo(OrdersRequestDtoInteger? ordersRequestDtoInteger = default);
        /// <summary>
        /// Start file editing
        /// </summary>
        /// <remarks>
        /// Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>StringWrapper</returns>
        StringWrapper StartEditFile(int fileId, StartEdit? startEdit = default);

        /// <summary>
        /// Start file editing
        /// </summary>
        /// <remarks>
        /// Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        ApiResponse<StringWrapper> StartEditFileWithHttpInfo(int fileId, StartEdit? startEdit = default);
        /// <summary>
        /// Start file filling
        /// </summary>
        /// <remarks>
        /// Starts filling a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper StartFillingFile(int fileId);

        /// <summary>
        /// Start file filling
        /// </summary>
        /// <remarks>
        /// Starts filling a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> StartFillingFileWithHttpInfo(int fileId);
        /// <summary>
        /// Track file editing
        /// </summary>
        /// <remarks>
        /// Tracks file changes when editing.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>KeyValuePairBooleanStringWrapper</returns>
        KeyValuePairBooleanStringWrapper TrackEditFile(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default);

        /// <summary>
        /// Track file editing
        /// </summary>
        /// <remarks>
        /// Tracks file changes when editing.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>ApiResponse of KeyValuePairBooleanStringWrapper</returns>
        ApiResponse<KeyValuePairBooleanStringWrapper> TrackEditFileWithHttpInfo(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default);
        /// <summary>
        /// Update a file
        /// </summary>
        /// <remarks>
        /// Updates the information of the selected file with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        FileIntegerWrapper UpdateFile(int fileId, UpdateFile? updateFile = default);

        /// <summary>
        /// Update a file
        /// </summary>
        /// <remarks>
        /// Updates the information of the selected file with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        ApiResponse<FileIntegerWrapper> UpdateFileWithHttpInfo(int fileId, UpdateFile? updateFile = default);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesFilesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add template files
        /// </summary>
        /// <remarks>
        /// Adds files with the IDs specified in the request to the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> AddTemplatesAsync(TemplatesRequestDto? templatesRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add template files
        /// </summary>
        /// <remarks>
        /// Adds files with the IDs specified in the request to the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> AddTemplatesWithHttpInfoAsync(TemplatesRequestDto? templatesRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change version history
        /// </summary>
        /// <remarks>
        /// Changes the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerArrayWrapper> ChangeVersionHistoryAsync(int fileId, ChangeHistory? changeHistory = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Change version history
        /// </summary>
        /// <remarks>
        /// Changes the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> ChangeVersionHistoryWithHttpInfoAsync(int fileId, ChangeHistory? changeHistory = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the form draft filling
        /// </summary>
        /// <remarks>
        /// Checks if the current file is a form draft which can be filled out.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> CheckFillFormDraftAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the form draft filling
        /// </summary>
        /// <remarks>
        /// Checks if the current file is a form draft which can be filled out.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> CheckFillFormDraftWithHttpInfoAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy a file
        /// </summary>
        /// <remarks>
        /// Copies (and converts if possible) an existing file to the specified folder.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of FileEntryWrapper</returns>
        System.Threading.Tasks.Task<FileEntryWrapper> CopyFileAsAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Copy a file
        /// </summary>
        /// <remarks>
        /// Copies (and converts if possible) an existing file to the specified folder.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileEntryWrapper>> CopyFileAsWithHttpInfoAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create the editing session
        /// </summary>
        /// <remarks>
        /// Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        System.Threading.Tasks.Task<ObjectWrapper> CreateEditSessionAsync(int fileId, long? fileSize = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create the editing session
        /// </summary>
        /// <remarks>
        /// Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> CreateEditSessionWithHttpInfoAsync(int fileId, long? fileSize = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a file
        /// </summary>
        /// <remarks>
        /// Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateFileAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file
        /// </summary>
        /// <remarks>
        /// Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateFileWithHttpInfoAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateFileInMyDocumentsAsync(CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateFileInMyDocumentsWithHttpInfoAsync(CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an HTML file
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateHtmlFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an HTML file
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateHtmlFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create primary external link
        /// </summary>
        /// <remarks>
        /// Creates a primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> CreatePrimaryExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create primary external link
        /// </summary>
        /// <remarks>
        /// Creates a primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> CreatePrimaryExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a text file
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateTextFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a text file
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateTextFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> CreateTextFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section
        /// </summary>
        /// <remarks>
        /// Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateTextFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create file thumbnails
        /// </summary>
        /// <remarks>
        /// Creates thumbnails for the files with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        System.Threading.Tasks.Task<ObjectArrayWrapper> CreateThumbnailsAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create file thumbnails
        /// </summary>
        /// <remarks>
        /// Creates thumbnails for the files with the IDs specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectArrayWrapper>> CreateThumbnailsWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a file
        /// </summary>
        /// <remarks>
        /// Deletes a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        System.Threading.Tasks.Task<FileOperationArrayWrapper> DeleteFileAsync(int fileId, Delete delete, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a file
        /// </summary>
        /// <remarks>
        /// Deletes a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileWithHttpInfoAsync(int fileId, Delete delete, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete recent files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        System.Threading.Tasks.Task<NoContentResultWrapper> DeleteRecentAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete recent files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoContentResultWrapper>> DeleteRecentWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete template files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> DeleteTemplatesAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete template files
        /// </summary>
        /// <remarks>
        /// Removes files with the IDs specified in the request from the template list.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> DeleteTemplatesWithHttpInfoAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get form roles
        /// </summary>
        /// <remarks>
        /// Returns all roles for the specified form.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of FormRoleArrayWrapper</returns>
        System.Threading.Tasks.Task<FormRoleArrayWrapper> GetAllFormRolesAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get form roles
        /// </summary>
        /// <remarks>
        /// Returns all roles for the specified form.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormRoleArrayWrapper>> GetAllFormRolesWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get changes URL
        /// </summary>
        /// <remarks>
        /// Returns a URL to the changes of a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of EditHistoryDataWrapper</returns>
        System.Threading.Tasks.Task<EditHistoryDataWrapper> GetEditDiffUrlAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get changes URL
        /// </summary>
        /// <remarks>
        /// Returns a URL to the changes of a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryDataWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EditHistoryDataWrapper>> GetEditDiffUrlWithHttpInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get version history
        /// </summary>
        /// <remarks>
        /// Returns the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        System.Threading.Tasks.Task<EditHistoryArrayWrapper> GetEditHistoryAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get version history
        /// </summary>
        /// <remarks>
        /// Returns the version history of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EditHistoryArrayWrapper>> GetEditHistoryWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file history
        /// </summary>
        /// <remarks>
        /// Returns the list of actions performed on the file with the specified identifier.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        System.Threading.Tasks.Task<HistoryArrayWrapper> GetFileHistoryAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file history
        /// </summary>
        /// <remarks>
        /// Returns the list of actions performed on the file with the specified identifier.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoryArrayWrapper>> GetFileHistoryWithHttpInfoAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> GetFileInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file information
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> GetFileInfoWithHttpInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file external links
        /// </summary>
        /// <remarks>
        /// Returns the external links of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        System.Threading.Tasks.Task<FileShareArrayWrapper> GetFileLinksAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file external links
        /// </summary>
        /// <remarks>
        /// Returns the external links of a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> GetFileLinksWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> GetFilePrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get primary external link
        /// </summary>
        /// <remarks>
        /// Returns the primary external link by the identifier specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> GetFilePrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerArrayWrapper> GetFileVersionInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file versions
        /// </summary>
        /// <remarks>
        /// Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> GetFileVersionInfoWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get form-filling result
        /// </summary>
        /// <remarks>
        /// Retrieves the result of a form-filling session.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of FillingFormResultIntegerWrapper</returns>
        System.Threading.Tasks.Task<FillingFormResultIntegerWrapper> GetFillResultAsync(string? fillingSessionId = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get form-filling result
        /// </summary>
        /// <remarks>
        /// Retrieves the result of a form-filling session.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of ApiResponse (FillingFormResultIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FillingFormResultIntegerWrapper>> GetFillResultWithHttpInfoAsync(string? fillingSessionId = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file download link asynchronously
        /// </summary>
        /// <remarks>
        /// Returns a link to download a file with the ID specified in the request asynchronously.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of FileLinkWrapper</returns>
        System.Threading.Tasks.Task<FileLinkWrapper> GetPresignedFileUriAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file download link asynchronously
        /// </summary>
        /// <remarks>
        /// Returns a link to download a file with the ID specified in the request asynchronously.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of ApiResponse (FileLinkWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileLinkWrapper>> GetPresignedFileUriWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file download link
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> GetPresignedUriAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get file download link
        /// </summary>
        /// <remarks>
        /// Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetPresignedUriWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get users access rights to the protected file
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        System.Threading.Tasks.Task<MentionWrapperArrayWrapper> GetProtectedFileUsersAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get users access rights to the protected file
        /// </summary>
        /// <remarks>
        /// Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<MentionWrapperArrayWrapper>> GetProtectedFileUsersWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get reference data
        /// </summary>
        /// <remarks>
        /// Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of FileReferenceWrapper</returns>
        System.Threading.Tasks.Task<FileReferenceWrapper> GetReferenceDataAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get reference data
        /// </summary>
        /// <remarks>
        /// Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of ApiResponse (FileReferenceWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileReferenceWrapper>> GetReferenceDataWithHttpInfoAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check the PDF file
        /// </summary>
        /// <remarks>
        /// Checks if the PDF file is a form or not.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        System.Threading.Tasks.Task<BooleanWrapper> IsFormPDFAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check the PDF file
        /// </summary>
        /// <remarks>
        /// Checks if the PDF file is a form or not.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> IsFormPDFWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lock a file
        /// </summary>
        /// <remarks>
        /// Locks a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> LockFileAsync(int fileId, LockFileParameters? lockFileParameters = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Lock a file
        /// </summary>
        /// <remarks>
        /// Locks a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> LockFileWithHttpInfoAsync(int fileId, LockFileParameters? lockFileParameters = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Perform form filling action
        /// </summary>
        /// <remarks>
        /// Performs the specified form filling action.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ManageFormFillingAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Perform form filling action
        /// </summary>
        /// <remarks>
        /// Performs the specified form filling action.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ManageFormFillingWithHttpInfoAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Open a file configuration
        /// </summary>
        /// <remarks>
        /// Returns the initialization configuration of a file to open it in the editor.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ConfigurationIntegerWrapper</returns>
        System.Threading.Tasks.Task<ConfigurationIntegerWrapper> OpenEditFileAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Open a file configuration
        /// </summary>
        /// <remarks>
        /// Returns the initialization configuration of a file to open it in the editor.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (ConfigurationIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigurationIntegerWrapper>> OpenEditFileWithHttpInfoAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore a file version
        /// </summary>
        /// <remarks>
        /// Restores a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        System.Threading.Tasks.Task<EditHistoryArrayWrapper> RestoreFileVersionAsync(int fileId, int? version = default, string? url = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Restore a file version
        /// </summary>
        /// <remarks>
        /// Restores a file version specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<EditHistoryArrayWrapper>> RestoreFileVersionWithHttpInfoAsync(int fileId, int? version = default, string? url = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save file edits
        /// </summary>
        /// <remarks>
        /// Saves edits to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> SaveEditingFileFromFormAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save file edits
        /// </summary>
        /// <remarks>
        /// Saves edits to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SaveEditingFileFromFormWithHttpInfoAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save a file as PDF
        /// </summary>
        /// <remarks>
        /// Saves a file with the identifier specified in the request as a PDF document.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> SaveFileAsPdfAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save a file as PDF
        /// </summary>
        /// <remarks>
        /// Saves a file with the identifier specified in the request as a PDF document.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SaveFileAsPdfWithHttpInfoAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Save form role mapping
        /// </summary>
        /// <remarks>
        /// Saves the form role mapping.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of FormRoleWrapper</returns>
        System.Threading.Tasks.Task<FormRoleWrapper> SaveFormRoleMappingAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Save form role mapping
        /// </summary>
        /// <remarks>
        /// Saves the form role mapping.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormRoleWrapper>> SaveFormRoleMappingWithHttpInfoAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set the Custom Filter editing mode
        /// </summary>
        /// <remarks>
        /// Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> SetCustomFilterTagAsync(int fileId, CustomFilterParameters? customFilterParameters = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the Custom Filter editing mode
        /// </summary>
        /// <remarks>
        /// Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SetCustomFilterTagWithHttpInfoAsync(int fileId, CustomFilterParameters? customFilterParameters = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set an external link
        /// </summary>
        /// <remarks>
        /// Sets an external link to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        System.Threading.Tasks.Task<FileShareWrapper> SetExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set an external link
        /// </summary>
        /// <remarks>
        /// Sets an external link to a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> SetExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set file order
        /// </summary>
        /// <remarks>
        /// Sets order of the file with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> SetFileOrderAsync(int fileId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set file order
        /// </summary>
        /// <remarks>
        /// Sets order of the file with ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SetFileOrderWithHttpInfoAsync(int fileId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set order of files
        /// </summary>
        /// <remarks>
        /// Sets order of the files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerArrayWrapper> SetFilesOrderAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set order of files
        /// </summary>
        /// <remarks>
        /// Sets order of the files.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> SetFilesOrderWithHttpInfoAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start file editing
        /// </summary>
        /// <remarks>
        /// Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        System.Threading.Tasks.Task<StringWrapper> StartEditFileAsync(int fileId, StartEdit? startEdit = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start file editing
        /// </summary>
        /// <remarks>
        /// Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<StringWrapper>> StartEditFileWithHttpInfoAsync(int fileId, StartEdit? startEdit = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start file filling
        /// </summary>
        /// <remarks>
        /// Starts filling a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> StartFillingFileAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start file filling
        /// </summary>
        /// <remarks>
        /// Starts filling a file with the ID specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> StartFillingFileWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track file editing
        /// </summary>
        /// <remarks>
        /// Tracks file changes when editing.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of KeyValuePairBooleanStringWrapper</returns>
        System.Threading.Tasks.Task<KeyValuePairBooleanStringWrapper> TrackEditFileAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Track file editing
        /// </summary>
        /// <remarks>
        /// Tracks file changes when editing.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (KeyValuePairBooleanStringWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyValuePairBooleanStringWrapper>> TrackEditFileWithHttpInfoAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a file
        /// </summary>
        /// <remarks>
        /// Updates the information of the selected file with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        System.Threading.Tasks.Task<FileIntegerWrapper> UpdateFileAsync(int fileId, UpdateFile? updateFile = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a file
        /// </summary>
        /// <remarks>
        /// Updates the information of the selected file with the parameters specified in the request.
        /// </remarks>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> UpdateFileWithHttpInfoAsync(int fileId, UpdateFile? updateFile = default, System.Threading.CancellationToken cancellationToken = default);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFilesFilesApi : IFilesFilesApiSync, IFilesFilesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FilesFilesApi : IDisposable, IFilesFilesApi
    {
        private ExceptionFactory _exceptionFactory = (_, _) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public FilesFilesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public FilesFilesApi(string basePath)
        {
            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class using a Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public FilesFilesApi(Configuration configuration)
        {
            ArgumentNullException.ThrowIfNull(configuration);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public FilesFilesApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class.
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
        public FilesFilesApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class using a Configuration object.
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
        public FilesFilesApi(HttpClient client, Configuration configuration, HttpClientHandler handler = null)
        {
            ArgumentNullException.ThrowIfNull(configuration);
            ArgumentNullException.ThrowIfNull(client);

            this.Configuration = Docspace.Client.Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.ApiClient = new ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Docspace.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFilesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public FilesFilesApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(client);
            ArgumentNullException.ThrowIfNull(asyncClient);
            ArgumentNullException.ThrowIfNull(configuration);

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
            this.ApiClient.Dispose();
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
            return this.Configuration.BasePath;
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

        /// <summary>
        /// Add template files Adds files with the IDs specified in the request to the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper AddTemplates(TemplatesRequestDto? templatesRequestDto = default)
        {
            var localVarResponse = AddTemplatesWithHttpInfo(templatesRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add template files Adds files with the IDs specified in the request to the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> AddTemplatesWithHttpInfo(TemplatesRequestDto? templatesRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (templatesRequestDto != null) localVarRequestOptions.Data = templatesRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AddTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add template files Adds files with the IDs specified in the request to the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> AddTemplatesAsync(TemplatesRequestDto? templatesRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await AddTemplatesWithHttpInfoAsync(templatesRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Add template files Adds files with the IDs specified in the request to the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="templatesRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/add-templates/">REST API Reference for AddTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> AddTemplatesWithHttpInfoAsync(TemplatesRequestDto? templatesRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (templatesRequestDto != null) localVarRequestOptions.Data = templatesRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("AddTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change version history Changes the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        public FileIntegerArrayWrapper ChangeVersionHistory(int fileId, ChangeHistory? changeHistory = default)
        {
            var localVarResponse = ChangeVersionHistoryWithHttpInfo(fileId, changeHistory);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change version history Changes the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        public ApiResponse<FileIntegerArrayWrapper> ChangeVersionHistoryWithHttpInfo(int fileId, ChangeHistory? changeHistory = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (changeHistory != null) localVarRequestOptions.Data = changeHistory;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeVersionHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Change version history Changes the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerArrayWrapper> ChangeVersionHistoryAsync(int fileId, ChangeHistory? changeHistory = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerArrayWrapper> localVarResponse = await ChangeVersionHistoryWithHttpInfoAsync(fileId, changeHistory, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Change version history Changes the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file Id to change its version history.</param>
        /// <param name="changeHistory">The parameters for changing version history. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/change-version-history/">REST API Reference for ChangeVersionHistory Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> ChangeVersionHistoryWithHttpInfoAsync(int fileId, ChangeHistory? changeHistory = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (changeHistory != null) localVarRequestOptions.Data = changeHistory;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ChangeVersionHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the form draft filling Checks if the current file is a form draft which can be filled out.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper CheckFillFormDraft(int fileId, CheckFillFormDraft? checkFillFormDraft = default)
        {
            var localVarResponse = CheckFillFormDraftWithHttpInfo(fileId, checkFillFormDraft);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the form draft filling Checks if the current file is a form draft which can be filled out.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> CheckFillFormDraftWithHttpInfo(int fileId, CheckFillFormDraft? checkFillFormDraft = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (checkFillFormDraft != null) localVarRequestOptions.Data = checkFillFormDraft;


            // make the HTTP request
            var localVarResponse = this.Client.Post<StringWrapper>("/api/2.0/files/masterform/{fileId}/checkfillformdraft", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckFillFormDraft", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the form draft filling Checks if the current file is a form draft which can be filled out.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> CheckFillFormDraftAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await CheckFillFormDraftWithHttpInfoAsync(fileId, checkFillFormDraft, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the form draft filling Checks if the current file is a form draft which can be filled out.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the form draft.</param>
        /// <param name="checkFillFormDraft">The parameters for checking the form draft filling. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/check-fill-form-draft/">REST API Reference for CheckFillFormDraft Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> CheckFillFormDraftWithHttpInfoAsync(int fileId, CheckFillFormDraft? checkFillFormDraft = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (checkFillFormDraft != null) localVarRequestOptions.Data = checkFillFormDraft;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/files/masterform/{fileId}/checkfillformdraft", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CheckFillFormDraft", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Copy a file Copies (and converts if possible) an existing file to the specified folder.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>FileEntryWrapper</returns>
        public FileEntryWrapper CopyFileAs(int fileId, CopyAsJsonElement? copyAsJsonElement = default)
        {
            var localVarResponse = CopyFileAsWithHttpInfo(fileId, copyAsJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Copy a file Copies (and converts if possible) an existing file to the specified folder.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>ApiResponse of FileEntryWrapper</returns>
        public ApiResponse<FileEntryWrapper> CopyFileAsWithHttpInfo(int fileId, CopyAsJsonElement? copyAsJsonElement = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (copyAsJsonElement != null) localVarRequestOptions.Data = copyAsJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileEntryWrapper>("/api/2.0/files/file/{fileId}/copyas", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CopyFileAs", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Copy a file Copies (and converts if possible) an existing file to the specified folder.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of FileEntryWrapper</returns>
        public async System.Threading.Tasks.Task<FileEntryWrapper> CopyFileAsAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileEntryWrapper> localVarResponse = await CopyFileAsWithHttpInfoAsync(fileId, copyAsJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Copy a file Copies (and converts if possible) an existing file to the specified folder.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to copy.</param>
        /// <param name="copyAsJsonElement">The parameters for copying a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/copy-file-as/">REST API Reference for CopyFileAs Operation</seealso>
        /// <returns>Task of ApiResponse (FileEntryWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileEntryWrapper>> CopyFileAsWithHttpInfoAsync(int fileId, CopyAsJsonElement? copyAsJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (copyAsJsonElement != null) localVarRequestOptions.Data = copyAsJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileEntryWrapper>("/api/2.0/files/file/{fileId}/copyas", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CopyFileAs", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create the editing session Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ObjectWrapper</returns>
        public ObjectWrapper CreateEditSession(int fileId, long? fileSize = default)
        {
            var localVarResponse = CreateEditSessionWithHttpInfo(fileId, fileSize);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create the editing session Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>ApiResponse of ObjectWrapper</returns>
        public ApiResponse<ObjectWrapper> CreateEditSessionWithHttpInfo(int fileId, long? fileSize = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fileSize", fileSize));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<ObjectWrapper>("/api/2.0/files/file/{fileId}/edit_session", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateEditSession", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create the editing session Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ObjectWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectWrapper> CreateEditSessionAsync(int fileId, long? fileSize = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectWrapper> localVarResponse = await CreateEditSessionWithHttpInfoAsync(fileId, fileSize, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create the editing session Creates a session to edit the existing file with multiple chunks (needed for WebDAV).   **Note**: Information about created session which includes:  &lt;ul&gt;  &lt;li&gt;&lt;b&gt;id:&lt;/b&gt; unique ID of this upload session,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;created:&lt;/b&gt; UTC time when the session was created,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;expired:&lt;/b&gt; UTC time when the session will expire if no chunks are sent before that time,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;location:&lt;/b&gt; URL where you should send your next chunk,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_uploaded:&lt;/b&gt; number of bytes uploaded for the specific upload ID,&lt;/li&gt;  &lt;li&gt;&lt;b&gt;bytes_total:&lt;/b&gt; total number of bytes which will be uploaded.&lt;/li&gt;  &lt;/ul&gt;
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="fileSize">The file size in bytes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-edit-session/">REST API Reference for CreateEditSession Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectWrapper>> CreateEditSessionWithHttpInfoAsync(int fileId, long? fileSize = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "fileSize", fileSize));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<ObjectWrapper>("/api/2.0/files/file/{fileId}/edit_session", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateEditSession", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a file Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateFile(int folderId, CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarResponse = CreateFileWithHttpInfo(folderId, createFileJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a file Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateFileWithHttpInfo(int folderId, CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/file", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a file Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateFileAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateFileWithHttpInfoAsync(folderId, createFileJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a file Creates a new file in the specified folder with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID for the file creation.</param>
        /// <param name="createFileJsonElement">The parameters for creating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file/">REST API Reference for CreateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateFileWithHttpInfoAsync(int folderId, CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/file", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateFileInMyDocuments(CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarResponse = CreateFileInMyDocumentsWithHttpInfo(createFileJsonElement);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateFileInMyDocumentsWithHttpInfo(CreateFileJsonElement? createFileJsonElement = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/file", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateFileInMyDocumentsAsync(CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateFileInMyDocumentsWithHttpInfoAsync(createFileJsonElement, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a file in the \&quot;My documents\&quot; section Creates a new file in the \&quot;My documents\&quot; section with the title specified in the request.   **Note**: If a file extension is different from DOCX/XLSX/PPTX and refers to one of the known text, spreadsheet, or presentation formats, it will be changed to DOCX/XLSX/PPTX accordingly. If the file extension is not specified or is unknown, the DOCX extension will be added to the file title.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createFileJsonElement"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-file-in-my-documents/">REST API Reference for CreateFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateFileInMyDocumentsWithHttpInfoAsync(CreateFileJsonElement? createFileJsonElement = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createFileJsonElement != null) localVarRequestOptions.Data = createFileJsonElement;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/file", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an HTML file Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateHtmlFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateHtmlFileWithHttpInfo(folderId, createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an HTML file Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateHtmlFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/html", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateHtmlFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an HTML file Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateHtmlFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateHtmlFileWithHttpInfoAsync(folderId, createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an HTML file Creates an HTML (.html) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file/">REST API Reference for CreateHtmlFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/html", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateHtmlFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateHtmlFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateHtmlFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateHtmlFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/html", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateHtmlFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateHtmlFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateHtmlFileInMyDocumentsWithHttpInfoAsync(createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an HTML file in the \&quot;My documents\&quot; section Creates an HTML (.html) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-html-file-in-my-documents/">REST API Reference for CreateHtmlFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateHtmlFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/html", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateHtmlFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create primary external link Creates a primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper CreatePrimaryExternalLink(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarResponse = CreatePrimaryExternalLinkWithHttpInfo(id, fileLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create primary external link Creates a primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> CreatePrimaryExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default)
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
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreatePrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create primary external link Creates a primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> CreatePrimaryExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareWrapper> localVarResponse = await CreatePrimaryExternalLinkWithHttpInfoAsync(id, fileLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create primary external link Creates a primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-primary-external-link/">REST API Reference for CreatePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> CreatePrimaryExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreatePrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a text file Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateTextFile(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateTextFileWithHttpInfo(folderId, createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a text file Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateTextFileWithHttpInfo(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/{folderId}/text", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateTextFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a text file Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateTextFileAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateTextFileWithHttpInfoAsync(folderId, createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a text file Creates a text (.txt) file in the selected folder with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="folderId">The folder ID to create the text or HTML file.</param>
        /// <param name="createTextOrHtmlFile">The parameters for creating an HTML or text file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file/">REST API Reference for CreateTextFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateTextFileWithHttpInfoAsync(int folderId, CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("folderId", ClientUtils.ParameterToString(folderId)); // path parameter
            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/{folderId}/text", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateTextFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper CreateTextFileInMyDocuments(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarResponse = CreateTextFileInMyDocumentsWithHttpInfo(createTextOrHtmlFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> CreateTextFileInMyDocumentsWithHttpInfo(CreateTextOrHtmlFile? createTextOrHtmlFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/@my/text", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateTextFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> CreateTextFileInMyDocumentsAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await CreateTextFileInMyDocumentsWithHttpInfoAsync(createTextOrHtmlFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a text file in the \&quot;My documents\&quot; section Creates a text (.txt) file in the \&quot;My documents\&quot; section with the title and contents specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTextOrHtmlFile"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-text-file-in-my-documents/">REST API Reference for CreateTextFileInMyDocuments Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> CreateTextFileInMyDocumentsWithHttpInfoAsync(CreateTextOrHtmlFile? createTextOrHtmlFile = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (createTextOrHtmlFile != null) localVarRequestOptions.Data = createTextOrHtmlFile;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/@my/text", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateTextFileInMyDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create file thumbnails Creates thumbnails for the files with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ObjectArrayWrapper</returns>
        public ObjectArrayWrapper CreateThumbnails(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = CreateThumbnailsWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create file thumbnails Creates thumbnails for the files with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>ApiResponse of ObjectArrayWrapper</returns>
        public ApiResponse<ObjectArrayWrapper> CreateThumbnailsWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ObjectArrayWrapper>("/api/2.0/files/thumbnails", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateThumbnails", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create file thumbnails Creates thumbnails for the files with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ObjectArrayWrapper</returns>
        public async System.Threading.Tasks.Task<ObjectArrayWrapper> CreateThumbnailsAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ObjectArrayWrapper> localVarResponse = await CreateThumbnailsWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create file thumbnails Creates thumbnails for the files with the IDs specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/create-thumbnails/">REST API Reference for CreateThumbnails Operation</seealso>
        /// <returns>Task of ApiResponse (ObjectArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectArrayWrapper>> CreateThumbnailsWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<ObjectArrayWrapper>("/api/2.0/files/thumbnails", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("CreateThumbnails", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a file Deletes a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>FileOperationArrayWrapper</returns>
        public FileOperationArrayWrapper DeleteFile(int fileId, Delete delete)
        {
            var localVarResponse = DeleteFileWithHttpInfo(fileId, delete);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a file Deletes a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>ApiResponse of FileOperationArrayWrapper</returns>
        public ApiResponse<FileOperationArrayWrapper> DeleteFileWithHttpInfo(int fileId, Delete delete)
        {
            // verify the required parameter 'delete' is set
            if (delete == null)
                throw new ApiException(400, "Missing required parameter 'delete' when calling FilesFilesApi->DeleteFile");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (delete != null) localVarRequestOptions.Data = delete;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Delete<FileOperationArrayWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a file Deletes a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of FileOperationArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileOperationArrayWrapper> DeleteFileAsync(int fileId, Delete delete, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileOperationArrayWrapper> localVarResponse = await DeleteFileWithHttpInfoAsync(fileId, delete, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a file Deletes a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to delete.</param>
        /// <param name="delete">The parameters for deleting a file.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-file/">REST API Reference for DeleteFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileOperationArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileOperationArrayWrapper>> DeleteFileWithHttpInfoAsync(int fileId, Delete delete, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'delete' is set
            if (delete == null)
                throw new ApiException(400, "Missing required parameter 'delete' when calling FilesFilesApi->DeleteFile");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (delete != null) localVarRequestOptions.Data = delete;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<FileOperationArrayWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete recent files Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>NoContentResultWrapper</returns>
        public NoContentResultWrapper DeleteRecent(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarResponse = DeleteRecentWithHttpInfo(baseBatchRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete recent files Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>ApiResponse of NoContentResultWrapper</returns>
        public ApiResponse<NoContentResultWrapper> DeleteRecentWithHttpInfo(BaseBatchRequestDto? baseBatchRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Delete<NoContentResultWrapper>("/api/2.0/files/recent", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteRecent", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete recent files Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of NoContentResultWrapper</returns>
        public async System.Threading.Tasks.Task<NoContentResultWrapper> DeleteRecentAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<NoContentResultWrapper> localVarResponse = await DeleteRecentWithHttpInfoAsync(baseBatchRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete recent files Removes files with the IDs specified in the request from the \&quot;Recent\&quot; section.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseBatchRequestDto"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-recent/">REST API Reference for DeleteRecent Operation</seealso>
        /// <returns>Task of ApiResponse (NoContentResultWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NoContentResultWrapper>> DeleteRecentWithHttpInfoAsync(BaseBatchRequestDto? baseBatchRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (baseBatchRequestDto != null) localVarRequestOptions.Data = baseBatchRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<NoContentResultWrapper>("/api/2.0/files/recent", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteRecent", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete template files Removes files with the IDs specified in the request from the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper DeleteTemplates(List<int>? requestBody = default)
        {
            var localVarResponse = DeleteTemplatesWithHttpInfo(requestBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete template files Removes files with the IDs specified in the request from the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> DeleteTemplatesWithHttpInfo(List<int>? requestBody = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Delete<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete template files Removes files with the IDs specified in the request from the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> DeleteTemplatesAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await DeleteTemplatesWithHttpInfoAsync(requestBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Delete template files Removes files with the IDs specified in the request from the template list.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody">The file IDs. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/delete-templates/">REST API Reference for DeleteTemplates Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> DeleteTemplatesWithHttpInfoAsync(List<int>? requestBody = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (requestBody != null) localVarRequestOptions.Data = requestBody;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<BooleanWrapper>("/api/2.0/files/templates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("DeleteTemplates", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form roles Returns all roles for the specified form.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>FormRoleArrayWrapper</returns>
        public FormRoleArrayWrapper GetAllFormRoles(int fileId)
        {
            var localVarResponse = GetAllFormRolesWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form roles Returns all roles for the specified form.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>ApiResponse of FormRoleArrayWrapper</returns>
        public ApiResponse<FormRoleArrayWrapper> GetAllFormRolesWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<FormRoleArrayWrapper>("/api/2.0/files/file/{fileId}/formroles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAllFormRoles", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form roles Returns all roles for the specified form.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of FormRoleArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FormRoleArrayWrapper> GetAllFormRolesAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FormRoleArrayWrapper> localVarResponse = await GetAllFormRolesWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form roles Returns all roles for the specified form.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-all-form-roles/">REST API Reference for GetAllFormRoles Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormRoleArrayWrapper>> GetAllFormRolesWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FormRoleArrayWrapper>("/api/2.0/files/file/{fileId}/formroles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetAllFormRoles", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get changes URL Returns a URL to the changes of a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>EditHistoryDataWrapper</returns>
        public EditHistoryDataWrapper GetEditDiffUrl(int fileId, int? version = default)
        {
            var localVarResponse = GetEditDiffUrlWithHttpInfo(fileId, version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get changes URL Returns a URL to the changes of a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>ApiResponse of EditHistoryDataWrapper</returns>
        public ApiResponse<EditHistoryDataWrapper> GetEditDiffUrlWithHttpInfo(int fileId, int? version = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<EditHistoryDataWrapper>("/api/2.0/files/file/{fileId}/edit/diff", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEditDiffUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get changes URL Returns a URL to the changes of a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of EditHistoryDataWrapper</returns>
        public async System.Threading.Tasks.Task<EditHistoryDataWrapper> GetEditDiffUrlAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EditHistoryDataWrapper> localVarResponse = await GetEditDiffUrlWithHttpInfoAsync(fileId, version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get changes URL Returns a URL to the changes of a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-diff-url/">REST API Reference for GetEditDiffUrl Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryDataWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EditHistoryDataWrapper>> GetEditDiffUrlWithHttpInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EditHistoryDataWrapper>("/api/2.0/files/file/{fileId}/edit/diff", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEditDiffUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get version history Returns the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        public EditHistoryArrayWrapper GetEditHistory(int fileId)
        {
            var localVarResponse = GetEditHistoryWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get version history Returns the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        public ApiResponse<EditHistoryArrayWrapper> GetEditHistoryWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/edit/history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEditHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get version history Returns the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EditHistoryArrayWrapper> GetEditHistoryAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EditHistoryArrayWrapper> localVarResponse = await GetEditHistoryWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get version history Returns the version history of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-edit-history/">REST API Reference for GetEditHistory Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EditHistoryArrayWrapper>> GetEditHistoryWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/edit/history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetEditHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file history Returns the list of actions performed on the file with the specified identifier.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>HistoryArrayWrapper</returns>
        public HistoryArrayWrapper GetFileHistory(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFileHistoryWithHttpInfo(fileId, fromDate, toDate, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file history Returns the list of actions performed on the file with the specified identifier.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>ApiResponse of HistoryArrayWrapper</returns>
        public ApiResponse<HistoryArrayWrapper> GetFileHistoryWithHttpInfo(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<HistoryArrayWrapper>("/api/2.0/files/file/{fileId}/log", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file history Returns the list of actions performed on the file with the specified identifier.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of HistoryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<HistoryArrayWrapper> GetFileHistoryAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<HistoryArrayWrapper> localVarResponse = await GetFileHistoryWithHttpInfoAsync(fileId, fromDate, toDate, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file history Returns the list of actions performed on the file with the specified identifier.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the history request.</param>
        /// <param name="fromDate">The start date of the history. (optional)</param>
        /// <param name="toDate">The end date of the history. (optional)</param>
        /// <param name="count">The number of history entries to retrieve for the file log. (optional)</param>
        /// <param name="startIndex">The starting index for retrieving a subset of file history entries. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-history/">REST API Reference for GetFileHistory Operation</seealso>
        /// <returns>Task of ApiResponse (HistoryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoryArrayWrapper>> GetFileHistoryWithHttpInfoAsync(int fileId, ApiDateTime? fromDate = default, ApiDateTime? toDate = default, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fromDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "fromDate", fromDate));
            }
            if (toDate != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "toDate", toDate));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<HistoryArrayWrapper>("/api/2.0/files/file/{fileId}/log", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileHistory", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file information Returns the detailed information about a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper GetFileInfo(int fileId, int? version = default)
        {
            var localVarResponse = GetFileInfoWithHttpInfo(fileId, version);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file information Returns the detailed information about a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> GetFileInfoWithHttpInfo(int fileId, int? version = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file information Returns the detailed information about a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> GetFileInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await GetFileInfoWithHttpInfoAsync(fileId, version, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file information Returns the detailed information about a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="version">The file version. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-info/">REST API Reference for GetFileInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> GetFileInfoWithHttpInfoAsync(int fileId, int? version = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file external links Returns the external links of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>FileShareArrayWrapper</returns>
        public FileShareArrayWrapper GetFileLinks(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFileLinksWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file external links Returns the external links of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>ApiResponse of FileShareArrayWrapper</returns>
        public ApiResponse<FileShareArrayWrapper> GetFileLinksWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<FileShareArrayWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileLinks", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file external links Returns the external links of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of FileShareArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareArrayWrapper> GetFileLinksAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareArrayWrapper> localVarResponse = await GetFileLinksWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file external links Returns the external links of a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-links/">REST API Reference for GetFileLinks Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareArrayWrapper>> GetFileLinksWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareArrayWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileLinks", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper GetFilePrimaryExternalLink(int id, int? count = default, int? startIndex = default)
        {
            var localVarResponse = GetFilePrimaryExternalLinkWithHttpInfo(id, count, startIndex);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> GetFilePrimaryExternalLinkWithHttpInfo(int id, int? count = default, int? startIndex = default)
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilePrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> GetFilePrimaryExternalLinkAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareWrapper> localVarResponse = await GetFilePrimaryExternalLinkWithHttpInfoAsync(id, count, startIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get primary external link Returns the primary external link by the identifier specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID of the request.</param>
        /// <param name="count">The number of items to retrieve in the request. (optional)</param>
        /// <param name="startIndex">The starting index for the query results. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-primary-external-link/">REST API Reference for GetFilePrimaryExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> GetFilePrimaryExternalLinkWithHttpInfoAsync(int id, int? count = default, int? startIndex = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (startIndex != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "startIndex", startIndex));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileShareWrapper>("/api/2.0/files/file/{id}/link", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFilePrimaryExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file versions Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        public FileIntegerArrayWrapper GetFileVersionInfo(int fileId)
        {
            var localVarResponse = GetFileVersionInfoWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file versions Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        public ApiResponse<FileIntegerArrayWrapper> GetFileVersionInfoWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<FileIntegerArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileVersionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file versions Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerArrayWrapper> GetFileVersionInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerArrayWrapper> localVarResponse = await GetFileVersionInfoWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file versions Returns the detailed information about all the available file versions with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-file-version-info/">REST API Reference for GetFileVersionInfo Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> GetFileVersionInfoWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileIntegerArrayWrapper>("/api/2.0/files/file/{fileId}/history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFileVersionInfo", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form-filling result Retrieves the result of a form-filling session.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>FillingFormResultIntegerWrapper</returns>
        public FillingFormResultIntegerWrapper GetFillResult(string? fillingSessionId = default)
        {
            var localVarResponse = GetFillResultWithHttpInfo(fillingSessionId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form-filling result Retrieves the result of a form-filling session.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>ApiResponse of FillingFormResultIntegerWrapper</returns>
        public ApiResponse<FillingFormResultIntegerWrapper> GetFillResultWithHttpInfo(string? fillingSessionId = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fillingSessionId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fillingSessionId", fillingSessionId));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<FillingFormResultIntegerWrapper>("/api/2.0/files/file/fillresult", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFillResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get form-filling result Retrieves the result of a form-filling session.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of FillingFormResultIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FillingFormResultIntegerWrapper> GetFillResultAsync(string? fillingSessionId = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FillingFormResultIntegerWrapper> localVarResponse = await GetFillResultWithHttpInfoAsync(fillingSessionId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get form-filling result Retrieves the result of a form-filling session.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fillingSessionId">The form-filling session ID. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-fill-result/">REST API Reference for GetFillResult Operation</seealso>
        /// <returns>Task of ApiResponse (FillingFormResultIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FillingFormResultIntegerWrapper>> GetFillResultWithHttpInfoAsync(string? fillingSessionId = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (fillingSessionId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "fillingSessionId", fillingSessionId));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<FillingFormResultIntegerWrapper>("/api/2.0/files/file/fillresult", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetFillResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file download link asynchronously Returns a link to download a file with the ID specified in the request asynchronously.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>FileLinkWrapper</returns>
        public FileLinkWrapper GetPresignedFileUri(int fileId)
        {
            var localVarResponse = GetPresignedFileUriWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file download link asynchronously Returns a link to download a file with the ID specified in the request asynchronously.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>ApiResponse of FileLinkWrapper</returns>
        public ApiResponse<FileLinkWrapper> GetPresignedFileUriWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<FileLinkWrapper>("/api/2.0/files/file/{fileId}/presigned", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPresignedFileUri", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file download link asynchronously Returns a link to download a file with the ID specified in the request asynchronously.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of FileLinkWrapper</returns>
        public async System.Threading.Tasks.Task<FileLinkWrapper> GetPresignedFileUriAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileLinkWrapper> localVarResponse = await GetPresignedFileUriWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file download link asynchronously Returns a link to download a file with the ID specified in the request asynchronously.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-file-uri/">REST API Reference for GetPresignedFileUri Operation</seealso>
        /// <returns>Task of ApiResponse (FileLinkWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileLinkWrapper>> GetPresignedFileUriWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<FileLinkWrapper>("/api/2.0/files/file/{fileId}/presigned", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPresignedFileUri", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file download link Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper GetPresignedUri(int fileId)
        {
            var localVarResponse = GetPresignedUriWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file download link Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> GetPresignedUriWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<StringWrapper>("/api/2.0/files/file/{fileId}/presigneduri", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPresignedUri", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get file download link Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> GetPresignedUriAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await GetPresignedUriWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get file download link Returns a pre-signed URL to download a file with the specified ID.  This temporary link provides secure access to the file.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-presigned-uri/">REST API Reference for GetPresignedUri Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> GetPresignedUriWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<StringWrapper>("/api/2.0/files/file/{fileId}/presigneduri", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetPresignedUri", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users access rights to the protected file Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>MentionWrapperArrayWrapper</returns>
        public MentionWrapperArrayWrapper GetProtectedFileUsers(int fileId)
        {
            var localVarResponse = GetProtectedFileUsersWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users access rights to the protected file Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>ApiResponse of MentionWrapperArrayWrapper</returns>
        public ApiResponse<MentionWrapperArrayWrapper> GetProtectedFileUsersWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/protectusers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetProtectedFileUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get users access rights to the protected file Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of MentionWrapperArrayWrapper</returns>
        public async System.Threading.Tasks.Task<MentionWrapperArrayWrapper> GetProtectedFileUsersAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<MentionWrapperArrayWrapper> localVarResponse = await GetProtectedFileUsersWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get users access rights to the protected file Returns a list of users with their access rights to the protected file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-protected-file-users/">REST API Reference for GetProtectedFileUsers Operation</seealso>
        /// <returns>Task of ApiResponse (MentionWrapperArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MentionWrapperArrayWrapper>> GetProtectedFileUsersWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<MentionWrapperArrayWrapper>("/api/2.0/files/file/{fileId}/protectusers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetProtectedFileUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get reference data Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>FileReferenceWrapper</returns>
        public FileReferenceWrapper GetReferenceData(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default)
        {
            var localVarResponse = GetReferenceDataWithHttpInfo(getReferenceDataDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get reference data Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>ApiResponse of FileReferenceWrapper</returns>
        public ApiResponse<FileReferenceWrapper> GetReferenceDataWithHttpInfo(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (getReferenceDataDtoInteger != null) localVarRequestOptions.Data = getReferenceDataDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileReferenceWrapper>("/api/2.0/files/file/referencedata", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetReferenceData", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get reference data Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of FileReferenceWrapper</returns>
        public async System.Threading.Tasks.Task<FileReferenceWrapper> GetReferenceDataAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileReferenceWrapper> localVarResponse = await GetReferenceDataWithHttpInfoAsync(getReferenceDataDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get reference data Returns the reference data to uniquely identify a file in its system and check the availability of insering data into the destination spreadsheet by the external link.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="getReferenceDataDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/get-reference-data/">REST API Reference for GetReferenceData Operation</seealso>
        /// <returns>Task of ApiResponse (FileReferenceWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileReferenceWrapper>> GetReferenceDataWithHttpInfoAsync(GetReferenceDataDtoInteger? getReferenceDataDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (getReferenceDataDtoInteger != null) localVarRequestOptions.Data = getReferenceDataDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileReferenceWrapper>("/api/2.0/files/file/referencedata", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("GetReferenceData", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the PDF file Checks if the PDF file is a form or not.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>BooleanWrapper</returns>
        public BooleanWrapper IsFormPDF(int fileId)
        {
            var localVarResponse = IsFormPDFWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the PDF file Checks if the PDF file is a form or not.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>ApiResponse of BooleanWrapper</returns>
        public ApiResponse<BooleanWrapper> IsFormPDFWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Get<BooleanWrapper>("/api/2.0/files/file/{fileId}/isformpdf", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("IsFormPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check the PDF file Checks if the PDF file is a form or not.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of BooleanWrapper</returns>
        public async System.Threading.Tasks.Task<BooleanWrapper> IsFormPDFAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<BooleanWrapper> localVarResponse = await IsFormPDFWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check the PDF file Checks if the PDF file is a form or not.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the request.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/is-form-pdf/">REST API Reference for IsFormPDF Operation</seealso>
        /// <returns>Task of ApiResponse (BooleanWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BooleanWrapper>> IsFormPDFWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<BooleanWrapper>("/api/2.0/files/file/{fileId}/isformpdf", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("IsFormPDF", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lock a file Locks a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper LockFile(int fileId, LockFileParameters? lockFileParameters = default)
        {
            var localVarResponse = LockFileWithHttpInfo(fileId, lockFileParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lock a file Locks a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> LockFileWithHttpInfo(int fileId, LockFileParameters? lockFileParameters = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (lockFileParameters != null) localVarRequestOptions.Data = lockFileParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/lock", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("LockFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Lock a file Locks a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> LockFileAsync(int fileId, LockFileParameters? lockFileParameters = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await LockFileWithHttpInfoAsync(fileId, lockFileParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Lock a file Locks a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID for locking.</param>
        /// <param name="lockFileParameters">The parameters for locking a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/lock-file/">REST API Reference for LockFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> LockFileWithHttpInfoAsync(int fileId, LockFileParameters? lockFileParameters = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (lockFileParameters != null) localVarRequestOptions.Data = lockFileParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/lock", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("LockFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Perform form filling action Performs the specified form filling action.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns></returns>
        public void ManageFormFilling(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default)
        {
            ManageFormFillingWithHttpInfo(fileId, manageFormFillingDtoInteger);
        }

        /// <summary>
        /// Perform form filling action Performs the specified form filling action.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ManageFormFillingWithHttpInfo(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesFilesApi->ManageFormFilling");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (manageFormFillingDtoInteger != null) localVarRequestOptions.Data = manageFormFillingDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<Object>("/api/2.0/files/file/{fileId}/manageformfilling", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ManageFormFilling", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Perform form filling action Performs the specified form filling action.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ManageFormFillingAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            await ManageFormFillingWithHttpInfoAsync(fileId, manageFormFillingDtoInteger, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Perform form filling action Performs the specified form filling action.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="manageFormFillingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/manage-form-filling/">REST API Reference for ManageFormFilling Operation</seealso>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ManageFormFillingWithHttpInfoAsync(string fileId, ManageFormFillingDtoInteger? manageFormFillingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesFilesApi->ManageFormFilling");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (manageFormFillingDtoInteger != null) localVarRequestOptions.Data = manageFormFillingDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/api/2.0/files/file/{fileId}/manageformfilling", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("ManageFormFilling", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open a file configuration Returns the initialization configuration of a file to open it in the editor.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ConfigurationIntegerWrapper</returns>
        public ConfigurationIntegerWrapper OpenEditFile(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default)
        {
            var localVarResponse = OpenEditFileWithHttpInfo(fileId, version, view, editorType, edit, fill);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open a file configuration Returns the initialization configuration of a file to open it in the editor.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>ApiResponse of ConfigurationIntegerWrapper</returns>
        public ApiResponse<ConfigurationIntegerWrapper> OpenEditFileWithHttpInfo(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (view != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "view", view));
            }
            if (editorType != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "editorType", editorType));
            }
            if (edit != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "edit", edit));
            }
            if (fill != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "fill", fill));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<ConfigurationIntegerWrapper>("/api/2.0/files/file/{fileId}/openedit", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("OpenEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Open a file configuration Returns the initialization configuration of a file to open it in the editor.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ConfigurationIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<ConfigurationIntegerWrapper> OpenEditFileAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<ConfigurationIntegerWrapper> localVarResponse = await OpenEditFileWithHttpInfoAsync(fileId, version, view, editorType, edit, fill, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Open a file configuration Returns the initialization configuration of a file to open it in the editor.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to open.</param>
        /// <param name="version">The file version to open. (optional)</param>
        /// <param name="view">Specifies if the document will be opened for viewing only or not. (optional)</param>
        /// <param name="editorType">The editor type to open the file. (optional)</param>
        /// <param name="edit">Specifies if the document is opened in the editing mode or not. (optional)</param>
        /// <param name="fill">Specifies if the document is opened in the form-filling mode or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/open-edit-file/">REST API Reference for OpenEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (ConfigurationIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ConfigurationIntegerWrapper>> OpenEditFileWithHttpInfoAsync(int fileId, int? version = default, bool? view = default, EditorType? editorType = default, bool? edit = default, bool? fill = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (view != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "view", view));
            }
            if (editorType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "editorType", editorType));
            }
            if (edit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "edit", edit));
            }
            if (fill != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "fill", fill));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ConfigurationIntegerWrapper>("/api/2.0/files/file/{fileId}/openedit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("OpenEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore a file version Restores a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>EditHistoryArrayWrapper</returns>
        public EditHistoryArrayWrapper RestoreFileVersion(int fileId, int? version = default, string? url = default)
        {
            var localVarResponse = RestoreFileVersionWithHttpInfo(fileId, version, url);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore a file version Restores a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>ApiResponse of EditHistoryArrayWrapper</returns>
        public ApiResponse<EditHistoryArrayWrapper> RestoreFileVersionWithHttpInfo(int fileId, int? version = default, string? url = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (url != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "url", url));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/restoreversion", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Restore a file version Restores a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of EditHistoryArrayWrapper</returns>
        public async System.Threading.Tasks.Task<EditHistoryArrayWrapper> RestoreFileVersionAsync(int fileId, int? version = default, string? url = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<EditHistoryArrayWrapper> localVarResponse = await RestoreFileVersionWithHttpInfoAsync(fileId, version, url, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Restore a file version Restores a file version specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID of the restore version.</param>
        /// <param name="version">The file version of the restore. (optional)</param>
        /// <param name="url">The file version URL of the restore. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/restore-file-version/">REST API Reference for RestoreFileVersion Operation</seealso>
        /// <returns>Task of ApiResponse (EditHistoryArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EditHistoryArrayWrapper>> RestoreFileVersionWithHttpInfoAsync(int fileId, int? version = default, string? url = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (version != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "version", version));
            }
            if (url != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "url", url));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<EditHistoryArrayWrapper>("/api/2.0/files/file/{fileId}/restoreversion", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("RestoreFileVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save file edits Saves edits to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SaveEditingFileFromForm(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default)
        {
            var localVarResponse = SaveEditingFileFromFormWithHttpInfo(fileId, fileExtension, downloadUri, file, forcesave);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file edits Saves edits to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SaveEditingFileFromFormWithHttpInfo(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileExtension != null)
            {
                localVarRequestOptions.FormParameters.Add("FileExtension",ClientUtils.ParameterToString(fileExtension)); // form parameter
            }
            if (downloadUri != null)
            {
                localVarRequestOptions.FormParameters.Add("DownloadUri",ClientUtils.ParameterToString(downloadUri)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (forcesave != null)
            {
                localVarRequestOptions.FormParameters.Add("Forcesave",ClientUtils.ParameterToString(forcesave)); // form parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/saveediting", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveEditingFileFromForm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save file edits Saves edits to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> SaveEditingFileFromFormAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await SaveEditingFileFromFormWithHttpInfoAsync(fileId, fileExtension, downloadUri, file, forcesave, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save file edits Saves edits to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The editing file ID from the request.</param>
        /// <param name="fileExtension">The editing file extension from the request. (optional)</param>
        /// <param name="downloadUri">The URI to download the editing file. (optional)</param>
        /// <param name="file">The request file stream. (optional)</param>
        /// <param name="forcesave">Specifies whether to force save the file or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-editing-file-from-form/">REST API Reference for SaveEditingFileFromForm Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SaveEditingFileFromFormWithHttpInfoAsync(int fileId, string? fileExtension = default, string? downloadUri = default, FileParameter? file = default, bool? forcesave = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "multipart/form-data"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (fileExtension != null)
            {
                localVarRequestOptions.FormParameters.Add("FileExtension", Docspace.Client.ClientUtils.ParameterToString(fileExtension)); // form parameter
            }
            if (downloadUri != null)
            {
                localVarRequestOptions.FormParameters.Add("DownloadUri", Docspace.Client.ClientUtils.ParameterToString(downloadUri)); // form parameter
            }
            if (file != null)
            {
                localVarRequestOptions.FileParameters.Add("File", file);
            }
            if (forcesave != null)
            {
                localVarRequestOptions.FormParameters.Add("Forcesave", Docspace.Client.ClientUtils.ParameterToString(forcesave)); // form parameter
            }

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/saveediting", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveEditingFileFromForm", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a file as PDF Saves a file with the identifier specified in the request as a PDF document.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SaveFileAsPdf(int id, SaveAsPdfInteger? saveAsPdfInteger = default)
        {
            var localVarResponse = SaveFileAsPdfWithHttpInfo(id, saveAsPdfInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a file as PDF Saves a file with the identifier specified in the request as a PDF document.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SaveFileAsPdfWithHttpInfo(int id, SaveAsPdfInteger? saveAsPdfInteger = default)
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
            if (saveAsPdfInteger != null) localVarRequestOptions.Data = saveAsPdfInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FileIntegerWrapper>("/api/2.0/files/file/{id}/saveaspdf", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveFileAsPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save a file as PDF Saves a file with the identifier specified in the request as a PDF document.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> SaveFileAsPdfAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await SaveFileAsPdfWithHttpInfoAsync(id, saveAsPdfInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save a file as PDF Saves a file with the identifier specified in the request as a PDF document.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID to save as PDF.</param>
        /// <param name="saveAsPdfInteger">The parameters for saving file as PDF. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-file-as-pdf/">REST API Reference for SaveFileAsPdf Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SaveFileAsPdfWithHttpInfoAsync(int id, SaveAsPdfInteger? saveAsPdfInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (saveAsPdfInteger != null) localVarRequestOptions.Data = saveAsPdfInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FileIntegerWrapper>("/api/2.0/files/file/{id}/saveaspdf", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveFileAsPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save form role mapping Saves the form role mapping.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>FormRoleWrapper</returns>
        public FormRoleWrapper SaveFormRoleMapping(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default)
        {
            var localVarResponse = SaveFormRoleMappingWithHttpInfo(fileId, saveFormRoleMappingDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save form role mapping Saves the form role mapping.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>ApiResponse of FormRoleWrapper</returns>
        public ApiResponse<FormRoleWrapper> SaveFormRoleMappingWithHttpInfo(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesFilesApi->SaveFormRoleMapping");

            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (saveFormRoleMappingDtoInteger != null) localVarRequestOptions.Data = saveFormRoleMappingDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Post<FormRoleWrapper>("/api/2.0/files/file/{fileId}/formrolemapping", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveFormRoleMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Save form role mapping Saves the form role mapping.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of FormRoleWrapper</returns>
        public async System.Threading.Tasks.Task<FormRoleWrapper> SaveFormRoleMappingAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FormRoleWrapper> localVarResponse = await SaveFormRoleMappingWithHttpInfoAsync(fileId, saveFormRoleMappingDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Save form role mapping Saves the form role mapping.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId"></param>
        /// <param name="saveFormRoleMappingDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/save-form-role-mapping/">REST API Reference for SaveFormRoleMapping Operation</seealso>
        /// <returns>Task of ApiResponse (FormRoleWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormRoleWrapper>> SaveFormRoleMappingWithHttpInfoAsync(string fileId, SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fileId' is set
            if (fileId == null)
                throw new ApiException(400, "Missing required parameter 'fileId' when calling FilesFilesApi->SaveFormRoleMapping");


            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (saveFormRoleMappingDtoInteger != null) localVarRequestOptions.Data = saveFormRoleMappingDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PostAsync<FormRoleWrapper>("/api/2.0/files/file/{fileId}/formrolemapping", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SaveFormRoleMapping", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the Custom Filter editing mode Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SetCustomFilterTag(int fileId, CustomFilterParameters? customFilterParameters = default)
        {
            var localVarResponse = SetCustomFilterTagWithHttpInfo(fileId, customFilterParameters);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the Custom Filter editing mode Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SetCustomFilterTagWithHttpInfo(int fileId, CustomFilterParameters? customFilterParameters = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (customFilterParameters != null) localVarRequestOptions.Data = customFilterParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/customfilter", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetCustomFilterTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the Custom Filter editing mode Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> SetCustomFilterTagAsync(int fileId, CustomFilterParameters? customFilterParameters = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await SetCustomFilterTagWithHttpInfoAsync(fileId, customFilterParameters, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set the Custom Filter editing mode Sets the Custom Filter editing mode to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID.</param>
        /// <param name="customFilterParameters">The parameters for setting the Custom Filter editing mode. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-custom-filter-tag/">REST API Reference for SetCustomFilterTag Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SetCustomFilterTagWithHttpInfoAsync(int fileId, CustomFilterParameters? customFilterParameters = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (customFilterParameters != null) localVarRequestOptions.Data = customFilterParameters;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/customfilter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetCustomFilterTag", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set an external link Sets an external link to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>FileShareWrapper</returns>
        public FileShareWrapper SetExternalLink(int id, FileLinkRequest? fileLinkRequest = default)
        {
            var localVarResponse = SetExternalLinkWithHttpInfo(id, fileLinkRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set an external link Sets an external link to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>ApiResponse of FileShareWrapper</returns>
        public ApiResponse<FileShareWrapper> SetExternalLinkWithHttpInfo(int id, FileLinkRequest? fileLinkRequest = default)
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
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileShareWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set an external link Sets an external link to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of FileShareWrapper</returns>
        public async System.Threading.Tasks.Task<FileShareWrapper> SetExternalLinkAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileShareWrapper> localVarResponse = await SetExternalLinkWithHttpInfoAsync(id, fileLinkRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set an external link Sets an external link to a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The file ID.</param>
        /// <param name="fileLinkRequest">The file external link parameters. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-external-link/">REST API Reference for SetExternalLink Operation</seealso>
        /// <returns>Task of ApiResponse (FileShareWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileShareWrapper>> SetExternalLinkWithHttpInfoAsync(int id, FileLinkRequest? fileLinkRequest = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter
            if (fileLinkRequest != null) localVarRequestOptions.Data = fileLinkRequest;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileShareWrapper>("/api/2.0/files/file/{id}/links", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetExternalLink", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file order Sets order of the file with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper SetFileOrder(int fileId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarResponse = SetFileOrderWithHttpInfo(fileId, orderRequestDto);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file order Sets order of the file with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> SetFileOrderWithHttpInfo(int fileId, OrderRequestDto? orderRequestDto = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/{fileId}/order", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFileOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set file order Sets order of the file with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> SetFileOrderAsync(int fileId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await SetFileOrderWithHttpInfoAsync(fileId, orderRequestDto, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set file order Sets order of the file with ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file unique identifier.</param>
        /// <param name="orderRequestDto">The file order information. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-file-order/">REST API Reference for SetFileOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> SetFileOrderWithHttpInfoAsync(int fileId, OrderRequestDto? orderRequestDto = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (orderRequestDto != null) localVarRequestOptions.Data = orderRequestDto;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/{fileId}/order", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFileOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set order of files Sets order of the files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>FileIntegerArrayWrapper</returns>
        public FileIntegerArrayWrapper SetFilesOrder(OrdersRequestDtoInteger? ordersRequestDtoInteger = default)
        {
            var localVarResponse = SetFilesOrderWithHttpInfo(ordersRequestDtoInteger);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set order of files Sets order of the files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>ApiResponse of FileIntegerArrayWrapper</returns>
        public ApiResponse<FileIntegerArrayWrapper> SetFilesOrderWithHttpInfo(OrdersRequestDtoInteger? ordersRequestDtoInteger = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ordersRequestDtoInteger != null) localVarRequestOptions.Data = ordersRequestDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerArrayWrapper>("/api/2.0/files/order", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFilesOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set order of files Sets order of the files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of FileIntegerArrayWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerArrayWrapper> SetFilesOrderAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerArrayWrapper> localVarResponse = await SetFilesOrderWithHttpInfoAsync(ordersRequestDtoInteger, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set order of files Sets order of the files.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ordersRequestDtoInteger"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/set-files-order/">REST API Reference for SetFilesOrder Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerArrayWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerArrayWrapper>> SetFilesOrderWithHttpInfoAsync(OrdersRequestDtoInteger? ordersRequestDtoInteger = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (ordersRequestDtoInteger != null) localVarRequestOptions.Data = ordersRequestDtoInteger;

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerArrayWrapper>("/api/2.0/files/order", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("SetFilesOrder", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file editing Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>StringWrapper</returns>
        public StringWrapper StartEditFile(int fileId, StartEdit? startEdit = default)
        {
            var localVarResponse = StartEditFileWithHttpInfo(fileId, startEdit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file editing Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>ApiResponse of StringWrapper</returns>
        public ApiResponse<StringWrapper> StartEditFileWithHttpInfo(int fileId, StartEdit? startEdit = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (startEdit != null) localVarRequestOptions.Data = startEdit;


            // make the HTTP request
            var localVarResponse = this.Client.Post<StringWrapper>("/api/2.0/files/file/{fileId}/startedit", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file editing Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of StringWrapper</returns>
        public async System.Threading.Tasks.Task<StringWrapper> StartEditFileAsync(int fileId, StartEdit? startEdit = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<StringWrapper> localVarResponse = await StartEditFileWithHttpInfoAsync(fileId, startEdit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file editing Informs about opening a file with the ID specified in the request for editing, locking it from being deleted or moved (this method is called by the mobile editors).
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start editing.</param>
        /// <param name="startEdit">The file parameters to start editing. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-edit-file/">REST API Reference for StartEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (StringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StringWrapper>> StartEditFileWithHttpInfoAsync(int fileId, StartEdit? startEdit = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (startEdit != null) localVarRequestOptions.Data = startEdit;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<StringWrapper>("/api/2.0/files/file/{fileId}/startedit", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file filling Starts filling a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper StartFillingFile(int fileId)
        {
            var localVarResponse = StartFillingFileWithHttpInfo(fileId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file filling Starts filling a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> StartFillingFileWithHttpInfo(int fileId)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/startfilling", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartFillingFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Start file filling Starts filling a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> StartFillingFileAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await StartFillingFileWithHttpInfoAsync(fileId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Start file filling Starts filling a file with the ID specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to start filling.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/start-filling-file/">REST API Reference for StartFillingFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> StartFillingFileWithHttpInfoAsync(int fileId, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter

            // authentication (Basic) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
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

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}/startfilling", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("StartFillingFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Track file editing Tracks file changes when editing.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>KeyValuePairBooleanStringWrapper</returns>
        public KeyValuePairBooleanStringWrapper TrackEditFile(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default)
        {
            var localVarResponse = TrackEditFileWithHttpInfo(fileId, tabId, docKeyForTrack, isFinish);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Track file editing Tracks file changes when editing.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>ApiResponse of KeyValuePairBooleanStringWrapper</returns>
        public ApiResponse<KeyValuePairBooleanStringWrapper> TrackEditFileWithHttpInfo(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (tabId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "tabId", tabId));
            }
            if (docKeyForTrack != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "docKeyForTrack", docKeyForTrack));
            }
            if (isFinish != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "isFinish", isFinish));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<KeyValuePairBooleanStringWrapper>("/api/2.0/files/file/{fileId}/trackeditfile", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("TrackEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Track file editing Tracks file changes when editing.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of KeyValuePairBooleanStringWrapper</returns>
        public async System.Threading.Tasks.Task<KeyValuePairBooleanStringWrapper> TrackEditFileAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<KeyValuePairBooleanStringWrapper> localVarResponse = await TrackEditFileWithHttpInfoAsync(fileId, tabId, docKeyForTrack, isFinish, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Track file editing Tracks file changes when editing.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to track editing changes.</param>
        /// <param name="tabId">The tab ID to track editing changes. (optional)</param>
        /// <param name="docKeyForTrack">The document key for tracking changes. (optional)</param>
        /// <param name="isFinish">Specifies whether to finish file tracking or not. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/track-edit-file/">REST API Reference for TrackEditFile Operation</seealso>
        /// <returns>Task of ApiResponse (KeyValuePairBooleanStringWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyValuePairBooleanStringWrapper>> TrackEditFileWithHttpInfoAsync(int fileId, Guid? tabId = default, string? docKeyForTrack = default, bool? isFinish = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (tabId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "tabId", tabId));
            }
            if (docKeyForTrack != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "docKeyForTrack", docKeyForTrack));
            }
            if (isFinish != null)
            {
                localVarRequestOptions.QueryParameters.Add(Docspace.Client.ClientUtils.ParameterToMultiMap("", "isFinish", isFinish));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<KeyValuePairBooleanStringWrapper>("/api/2.0/files/file/{fileId}/trackeditfile", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("TrackEditFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a file Updates the information of the selected file with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>FileIntegerWrapper</returns>
        public FileIntegerWrapper UpdateFile(int fileId, UpdateFile? updateFile = default)
        {
            var localVarResponse = UpdateFileWithHttpInfo(fileId, updateFile);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a file Updates the information of the selected file with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>ApiResponse of FileIntegerWrapper</returns>
        public ApiResponse<FileIntegerWrapper> UpdateFileWithHttpInfo(int fileId, UpdateFile? updateFile = default)
        {
            var localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = ["application/json"];

            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (updateFile != null) localVarRequestOptions.Data = updateFile;


            // make the HTTP request
            var localVarResponse = this.Client.Put<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update a file Updates the information of the selected file with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of FileIntegerWrapper</returns>
        public async System.Threading.Tasks.Task<FileIntegerWrapper> UpdateFileAsync(int fileId, UpdateFile? updateFile = default, System.Threading.CancellationToken cancellationToken = default)
        {
            ApiResponse<FileIntegerWrapper> localVarResponse = await UpdateFileWithHttpInfoAsync(fileId, updateFile, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Update a file Updates the information of the selected file with the parameters specified in the request.
        /// </summary>
        /// <exception cref="Docspace.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileId">The file ID to update.</param>
        /// <param name="updateFile">The parameters for updating a file. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <seealso href="https://api.onlyoffice.com/docspace/api-backend/usage-api/update-file/">REST API Reference for UpdateFile Operation</seealso>
        /// <returns>Task of ApiResponse (FileIntegerWrapper)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FileIntegerWrapper>> UpdateFileWithHttpInfoAsync(int fileId, UpdateFile? updateFile = default, System.Threading.CancellationToken cancellationToken = default)
        {

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] contentTypes = [ "application/json"];

            // to determine the Accept header
            string[] accepts = [" application/json"];


            var localVarContentType = ClientUtils.SelectHeaderContentType(contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ClientUtils.SelectHeaderAccept(accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("fileId", ClientUtils.ParameterToString(fileId)); // path parameter
            if (updateFile != null) localVarRequestOptions.Data = updateFile;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PutAsync<FileIntegerWrapper>("/api/2.0/files/file/{fileId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                var exception = this.ExceptionFactory("UpdateFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return localVarResponse;
        }

    }
}
