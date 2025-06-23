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
