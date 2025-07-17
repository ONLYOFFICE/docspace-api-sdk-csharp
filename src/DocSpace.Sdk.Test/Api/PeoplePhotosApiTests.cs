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
    ///  Class for testing PeoplePhotosApi
    /// </summary>
    public class PeoplePhotosApiTests : IDisposable
    {
        private PeoplePhotosApi instance;

        public PeoplePhotosApiTests()
        {
            instance = new PeoplePhotosApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PeoplePhotosApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PeoplePhotosApi
            //Assert.IsType<PeoplePhotosApi>(instance);
        }

        /// <summary>
        /// Test CreateMemberPhotoThumbnails
        /// </summary>
        [Fact]
        public void CreateMemberPhotoThumbnailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //ThumbnailsRequest? thumbnailsRequest = null;
            //var response = instance.CreateMemberPhotoThumbnails(userid, thumbnailsRequest);
            //Assert.IsType<ThumbnailsDataWrapper>(response);
        }

        /// <summary>
        /// Test DeleteMemberPhoto
        /// </summary>
        [Fact]
        public void DeleteMemberPhotoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //var response = instance.DeleteMemberPhoto(userid);
            //Assert.IsType<ThumbnailsDataWrapper>(response);
        }

        /// <summary>
        /// Test GetMemberPhoto
        /// </summary>
        [Fact]
        public void GetMemberPhotoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //var response = instance.GetMemberPhoto(userid);
            //Assert.IsType<ThumbnailsDataWrapper>(response);
        }

        /// <summary>
        /// Test UpdateMemberPhoto
        /// </summary>
        [Fact]
        public void UpdateMemberPhotoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //UpdatePhotoMemberRequest? updatePhotoMemberRequest = null;
            //var response = instance.UpdateMemberPhoto(userid, updatePhotoMemberRequest);
            //Assert.IsType<ThumbnailsDataWrapper>(response);
        }

        /// <summary>
        /// Test UploadMemberPhoto
        /// </summary>
        [Fact]
        public void UploadMemberPhotoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userid = null;
            //List<KeyValuePairStringStringValues> formCollection = null;
            //var response = instance.UploadMemberPhoto(userid, formCollection);
            //Assert.IsType<FileUploadResultWrapper>(response);
        }
    }
}
