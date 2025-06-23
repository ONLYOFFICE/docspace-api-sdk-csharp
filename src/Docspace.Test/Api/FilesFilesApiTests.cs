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

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
{
    /// <summary>
    ///  Class for testing FilesFilesApi
    /// </summary>
    public class FilesFilesApiTests : IDisposable
    {
        private FilesFilesApi instance;

        public FilesFilesApiTests()
        {
            instance = new FilesFilesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesFilesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesFilesApi
            //Assert.IsType<FilesFilesApi>(instance);
        }

        /// <summary>
        /// Test AddTemplates
        /// </summary>
        [Fact]
        public void AddTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TemplatesRequestDto? templatesRequestDto = null;
            //var response = instance.AddTemplates(templatesRequestDto);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test ChangeVersionHistory
        /// </summary>
        [Fact]
        public void ChangeVersionHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //ChangeHistory? changeHistory = null;
            //var response = instance.ChangeVersionHistory(fileId, changeHistory);
            //Assert.IsType<FileIntegerArrayWrapper>(response);
        }

        /// <summary>
        /// Test CheckFillFormDraft
        /// </summary>
        [Fact]
        public void CheckFillFormDraftTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //CheckFillFormDraft? checkFillFormDraft = null;
            //var response = instance.CheckFillFormDraft(fileId, checkFillFormDraft);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test CopyFileAs
        /// </summary>
        [Fact]
        public void CopyFileAsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //CopyAsJsonElement? copyAsJsonElement = null;
            //var response = instance.CopyFileAs(fileId, copyAsJsonElement);
            //Assert.IsType<FileEntryWrapper>(response);
        }

        /// <summary>
        /// Test CreateEditSession
        /// </summary>
        [Fact]
        public void CreateEditSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //long? fileSize = null;
            //var response = instance.CreateEditSession(fileId, fileSize);
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test CreateFile
        /// </summary>
        [Fact]
        public void CreateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int folderId = null;
            //CreateFileJsonElement? createFileJsonElement = null;
            //var response = instance.CreateFile(folderId, createFileJsonElement);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateFileInMyDocuments
        /// </summary>
        [Fact]
        public void CreateFileInMyDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateFileJsonElement? createFileJsonElement = null;
            //var response = instance.CreateFileInMyDocuments(createFileJsonElement);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateHtmlFile
        /// </summary>
        [Fact]
        public void CreateHtmlFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int folderId = null;
            //CreateTextOrHtmlFile? createTextOrHtmlFile = null;
            //var response = instance.CreateHtmlFile(folderId, createTextOrHtmlFile);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateHtmlFileInMyDocuments
        /// </summary>
        [Fact]
        public void CreateHtmlFileInMyDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTextOrHtmlFile? createTextOrHtmlFile = null;
            //var response = instance.CreateHtmlFileInMyDocuments(createTextOrHtmlFile);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreatePrimaryExternalLink
        /// </summary>
        [Fact]
        public void CreatePrimaryExternalLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //FileLinkRequest? fileLinkRequest = null;
            //var response = instance.CreatePrimaryExternalLink(id, fileLinkRequest);
            //Assert.IsType<FileShareWrapper>(response);
        }

        /// <summary>
        /// Test CreateTextFile
        /// </summary>
        [Fact]
        public void CreateTextFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int folderId = null;
            //CreateTextOrHtmlFile? createTextOrHtmlFile = null;
            //var response = instance.CreateTextFile(folderId, createTextOrHtmlFile);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateTextFileInMyDocuments
        /// </summary>
        [Fact]
        public void CreateTextFileInMyDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTextOrHtmlFile? createTextOrHtmlFile = null;
            //var response = instance.CreateTextFileInMyDocuments(createTextOrHtmlFile);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test CreateThumbnails
        /// </summary>
        [Fact]
        public void CreateThumbnailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseBatchRequestDto? baseBatchRequestDto = null;
            //var response = instance.CreateThumbnails(baseBatchRequestDto);
            //Assert.IsType<ObjectArrayWrapper>(response);
        }

        /// <summary>
        /// Test DeleteFile
        /// </summary>
        [Fact]
        public void DeleteFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //Delete delete = null;
            //var response = instance.DeleteFile(fileId, delete);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test DeleteRecent
        /// </summary>
        [Fact]
        public void DeleteRecentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseBatchRequestDto? baseBatchRequestDto = null;
            //var response = instance.DeleteRecent(baseBatchRequestDto);
            //Assert.IsType<NoContentResultWrapper>(response);
        }

        /// <summary>
        /// Test DeleteTemplates
        /// </summary>
        [Fact]
        public void DeleteTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int>? requestBody = null;
            //var response = instance.DeleteTemplates(requestBody);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test GetAllFormRoles
        /// </summary>
        [Fact]
        public void GetAllFormRolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetAllFormRoles(fileId);
            //Assert.IsType<FormRoleArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetEditDiffUrl
        /// </summary>
        [Fact]
        public void GetEditDiffUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //int? version = null;
            //var response = instance.GetEditDiffUrl(fileId, version);
            //Assert.IsType<EditHistoryDataWrapper>(response);
        }

        /// <summary>
        /// Test GetEditHistory
        /// </summary>
        [Fact]
        public void GetEditHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetEditHistory(fileId);
            //Assert.IsType<EditHistoryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetFileHistory
        /// </summary>
        [Fact]
        public void GetFileHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //ApiDateTime? fromDate = null;
            //ApiDateTime? toDate = null;
            //int? count = null;
            //int? startIndex = null;
            //var response = instance.GetFileHistory(fileId, fromDate, toDate, count, startIndex);
            //Assert.IsType<HistoryArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetFileInfo
        /// </summary>
        [Fact]
        public void GetFileInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //int? version = null;
            //var response = instance.GetFileInfo(fileId, version);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test GetFileLinks
        /// </summary>
        [Fact]
        public void GetFileLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? count = null;
            //int? startIndex = null;
            //var response = instance.GetFileLinks(id, count, startIndex);
            //Assert.IsType<FileShareArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetFilePrimaryExternalLink
        /// </summary>
        [Fact]
        public void GetFilePrimaryExternalLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? count = null;
            //int? startIndex = null;
            //var response = instance.GetFilePrimaryExternalLink(id, count, startIndex);
            //Assert.IsType<FileShareWrapper>(response);
        }

        /// <summary>
        /// Test GetFileVersionInfo
        /// </summary>
        [Fact]
        public void GetFileVersionInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetFileVersionInfo(fileId);
            //Assert.IsType<FileIntegerArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetFillResult
        /// </summary>
        [Fact]
        public void GetFillResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? fillingSessionId = null;
            //var response = instance.GetFillResult(fillingSessionId);
            //Assert.IsType<FillingFormResultIntegerWrapper>(response);
        }

        /// <summary>
        /// Test GetPresignedFileUri
        /// </summary>
        [Fact]
        public void GetPresignedFileUriTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetPresignedFileUri(fileId);
            //Assert.IsType<FileLinkWrapper>(response);
        }

        /// <summary>
        /// Test GetPresignedUri
        /// </summary>
        [Fact]
        public void GetPresignedUriTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetPresignedUri(fileId);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test GetProtectedFileUsers
        /// </summary>
        [Fact]
        public void GetProtectedFileUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.GetProtectedFileUsers(fileId);
            //Assert.IsType<MentionWrapperArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetReferenceData
        /// </summary>
        [Fact]
        public void GetReferenceDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetReferenceDataDtoInteger? getReferenceDataDtoInteger = null;
            //var response = instance.GetReferenceData(getReferenceDataDtoInteger);
            //Assert.IsType<FileReferenceWrapper>(response);
        }

        /// <summary>
        /// Test IsFormPDF
        /// </summary>
        [Fact]
        public void IsFormPDFTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.IsFormPDF(fileId);
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test LockFile
        /// </summary>
        [Fact]
        public void LockFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //LockFileParameters? lockFileParameters = null;
            //var response = instance.LockFile(fileId, lockFileParameters);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test ManageFormFilling
        /// </summary>
        [Fact]
        public void ManageFormFillingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //ManageFormFillingDtoInteger? manageFormFillingDtoInteger = null;
            //instance.ManageFormFilling(fileId, manageFormFillingDtoInteger);
        }

        /// <summary>
        /// Test OpenEditFile
        /// </summary>
        [Fact]
        public void OpenEditFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //int? version = null;
            //bool? view = null;
            //EditorType? editorType = null;
            //bool? edit = null;
            //bool? fill = null;
            //var response = instance.OpenEditFile(fileId, version, view, editorType, edit, fill);
            //Assert.IsType<ConfigurationIntegerWrapper>(response);
        }

        /// <summary>
        /// Test RestoreFileVersion
        /// </summary>
        [Fact]
        public void RestoreFileVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //int? version = null;
            //string? url = null;
            //var response = instance.RestoreFileVersion(fileId, version, url);
            //Assert.IsType<EditHistoryArrayWrapper>(response);
        }

        /// <summary>
        /// Test SaveEditingFileFromForm
        /// </summary>
        [Fact]
        public void SaveEditingFileFromFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //string? fileExtension = null;
            //string? downloadUri = null;
            //FileParameter? file = null;
            //bool? forcesave = null;
            //var response = instance.SaveEditingFileFromForm(fileId, fileExtension, downloadUri, file, forcesave);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test SaveFileAsPdf
        /// </summary>
        [Fact]
        public void SaveFileAsPdfTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //SaveAsPdfInteger? saveAsPdfInteger = null;
            //var response = instance.SaveFileAsPdf(id, saveAsPdfInteger);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test SaveFormRoleMapping
        /// </summary>
        [Fact]
        public void SaveFormRoleMappingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //SaveFormRoleMappingDtoInteger? saveFormRoleMappingDtoInteger = null;
            //var response = instance.SaveFormRoleMapping(fileId, saveFormRoleMappingDtoInteger);
            //Assert.IsType<FormRoleWrapper>(response);
        }

        /// <summary>
        /// Test SetCustomFilterTag
        /// </summary>
        [Fact]
        public void SetCustomFilterTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //CustomFilterParameters? customFilterParameters = null;
            //var response = instance.SetCustomFilterTag(fileId, customFilterParameters);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test SetExternalLink
        /// </summary>
        [Fact]
        public void SetExternalLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //FileLinkRequest? fileLinkRequest = null;
            //var response = instance.SetExternalLink(id, fileLinkRequest);
            //Assert.IsType<FileShareWrapper>(response);
        }

        /// <summary>
        /// Test SetFileOrder
        /// </summary>
        [Fact]
        public void SetFileOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //OrderRequestDto? orderRequestDto = null;
            //var response = instance.SetFileOrder(fileId, orderRequestDto);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test SetFilesOrder
        /// </summary>
        [Fact]
        public void SetFilesOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrdersRequestDtoInteger? ordersRequestDtoInteger = null;
            //var response = instance.SetFilesOrder(ordersRequestDtoInteger);
            //Assert.IsType<FileIntegerArrayWrapper>(response);
        }

        /// <summary>
        /// Test StartEditFile
        /// </summary>
        [Fact]
        public void StartEditFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //StartEdit? startEdit = null;
            //var response = instance.StartEditFile(fileId, startEdit);
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test StartFillingFile
        /// </summary>
        [Fact]
        public void StartFillingFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //var response = instance.StartFillingFile(fileId);
            //Assert.IsType<FileIntegerWrapper>(response);
        }

        /// <summary>
        /// Test TrackEditFile
        /// </summary>
        [Fact]
        public void TrackEditFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //Guid? tabId = null;
            //string? docKeyForTrack = null;
            //bool? isFinish = null;
            //var response = instance.TrackEditFile(fileId, tabId, docKeyForTrack, isFinish);
            //Assert.IsType<KeyValuePairBooleanStringWrapper>(response);
        }

        /// <summary>
        /// Test UpdateFile
        /// </summary>
        [Fact]
        public void UpdateFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //UpdateFile? updateFile = null;
            //var response = instance.UpdateFile(fileId, updateFile);
            //Assert.IsType<FileIntegerWrapper>(response);
        }
    }
}
