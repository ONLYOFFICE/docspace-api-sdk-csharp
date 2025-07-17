/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

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
