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
using Docspace.Model;
using Docspace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Docspace.Test.Model
{
    /// <summary>
    ///  Class for testing UploadRequestDto
    /// </summary>
    public class UploadRequestDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for UploadRequestDto
        //private UploadRequestDto instance;

        public UploadRequestDtoTests()
        {
            // TODO uncomment below to create an instance of UploadRequestDto
            //instance = new UploadRequestDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UploadRequestDto
        /// </summary>
        [Fact]
        public void UploadRequestDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" UploadRequestDto
            //Assert.IsType<UploadRequestDto>(instance);
        }

        /// <summary>
        /// Test the property 'File'
        /// </summary>
        [Fact]
        public void FileTest()
        {
            // TODO unit test for the property 'File'
        }

        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }

        /// <summary>
        /// Test the property 'ContentDisposition'
        /// </summary>
        [Fact]
        public void ContentDispositionTest()
        {
            // TODO unit test for the property 'ContentDisposition'
        }

        /// <summary>
        /// Test the property 'Files'
        /// </summary>
        [Fact]
        public void FilesTest()
        {
            // TODO unit test for the property 'Files'
        }

        /// <summary>
        /// Test the property 'CreateNewIfExist'
        /// </summary>
        [Fact]
        public void CreateNewIfExistTest()
        {
            // TODO unit test for the property 'CreateNewIfExist'
        }

        /// <summary>
        /// Test the property 'StoreOriginalFileFlag'
        /// </summary>
        [Fact]
        public void StoreOriginalFileFlagTest()
        {
            // TODO unit test for the property 'StoreOriginalFileFlag'
        }

        /// <summary>
        /// Test the property 'KeepConvertStatus'
        /// </summary>
        [Fact]
        public void KeepConvertStatusTest()
        {
            // TODO unit test for the property 'KeepConvertStatus'
        }

        /// <summary>
        /// Test the property 'Stream'
        /// </summary>
        [Fact]
        public void StreamTest()
        {
            // TODO unit test for the property 'Stream'
        }
    }
}
