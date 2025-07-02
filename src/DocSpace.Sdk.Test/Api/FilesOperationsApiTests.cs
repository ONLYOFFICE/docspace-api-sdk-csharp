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
    ///  Class for testing FilesOperationsApi
    /// </summary>
    public class FilesOperationsApiTests : IDisposable
    {
        private FilesOperationsApi instance;

        public FilesOperationsApiTests()
        {
            instance = new FilesOperationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FilesOperationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FilesOperationsApi
            //Assert.IsType<FilesOperationsApi>(instance);
        }

        /// <summary>
        /// Test BulkDownload
        /// </summary>
        [Fact]
        public void BulkDownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DownloadRequestDto? downloadRequestDto = null;
            //var response = instance.BulkDownload(downloadRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test CheckConversionStatus
        /// </summary>
        [Fact]
        public void CheckConversionStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //bool? start = null;
            //var response = instance.CheckConversionStatus(fileId, start);
            //Assert.IsType<ConversationResultArrayWrapper>(response);
        }

        /// <summary>
        /// Test CheckMoveOrCopyBatchItems
        /// </summary>
        [Fact]
        public void CheckMoveOrCopyBatchItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchRequestDto? inDto = null;
            //var response = instance.CheckMoveOrCopyBatchItems(inDto);
            //Assert.IsType<FileEntryArrayWrapper>(response);
        }

        /// <summary>
        /// Test CheckMoveOrCopyDestFolder
        /// </summary>
        [Fact]
        public void CheckMoveOrCopyDestFolderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchRequestDto? inDto = null;
            //var response = instance.CheckMoveOrCopyDestFolder(inDto);
            //Assert.IsType<CheckDestFolderWrapper>(response);
        }

        /// <summary>
        /// Test CopyBatchItems
        /// </summary>
        [Fact]
        public void CopyBatchItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchRequestDto? batchRequestDto = null;
            //var response = instance.CopyBatchItems(batchRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test CreateUploadSession
        /// </summary>
        [Fact]
        public void CreateUploadSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int folderId = null;
            //SessionRequest? sessionRequest = null;
            //var response = instance.CreateUploadSession(folderId, sessionRequest);
            //Assert.IsType<ObjectWrapper>(response);
        }

        /// <summary>
        /// Test DeleteBatchItems
        /// </summary>
        [Fact]
        public void DeleteBatchItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteBatchRequestDto? deleteBatchRequestDto = null;
            //var response = instance.DeleteBatchItems(deleteBatchRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test DeleteFileVersions
        /// </summary>
        [Fact]
        public void DeleteFileVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteVersionBatchRequestDto? deleteVersionBatchRequestDto = null;
            //var response = instance.DeleteFileVersions(deleteVersionBatchRequestDto);
            //Assert.IsType<FileOperationWrapper>(response);
        }

        /// <summary>
        /// Test DuplicateBatchItems
        /// </summary>
        [Fact]
        public void DuplicateBatchItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DuplicateRequestDto? duplicateRequestDto = null;
            //var response = instance.DuplicateBatchItems(duplicateRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test EmptyTrash
        /// </summary>
        [Fact]
        public void EmptyTrashTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? single = null;
            //var response = instance.EmptyTrash(single);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetOperationStatuses
        /// </summary>
        [Fact]
        public void GetOperationStatusesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? id = null;
            //var response = instance.GetOperationStatuses(id);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test GetOperationStatusesByType
        /// </summary>
        [Fact]
        public void GetOperationStatusesByTypeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FileOperationType operationType = null;
            //string? id = null;
            //var response = instance.GetOperationStatusesByType(operationType, id);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test MarkAsRead
        /// </summary>
        [Fact]
        public void MarkAsReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseBatchRequestDto? baseBatchRequestDto = null;
            //var response = instance.MarkAsRead(baseBatchRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test MoveBatchItems
        /// </summary>
        [Fact]
        public void MoveBatchItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BatchRequestDto? batchRequestDto = null;
            //var response = instance.MoveBatchItems(batchRequestDto);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test StartFileConversion
        /// </summary>
        [Fact]
        public void StartFileConversionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //CheckConversionRequestDtoInteger? checkConversionRequestDtoInteger = null;
            //var response = instance.StartFileConversion(fileId, checkConversionRequestDtoInteger);
            //Assert.IsType<ConversationResultArrayWrapper>(response);
        }

        /// <summary>
        /// Test TerminateTasks
        /// </summary>
        [Fact]
        public void TerminateTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TerminateTasks(id);
            //Assert.IsType<FileOperationArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateFileComment
        /// </summary>
        [Fact]
        public void UpdateFileCommentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int fileId = null;
            //UpdateComment? updateComment = null;
            //var response = instance.UpdateFileComment(fileId, updateComment);
            //Assert.IsType<StringWrapper>(response);
        }
    }
}
