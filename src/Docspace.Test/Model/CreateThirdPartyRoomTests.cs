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
using DocSpace.Model;
using DocSpace.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Test.Model
{
    /// <summary>
    ///  Class for testing CreateThirdPartyRoom
    /// </summary>
    public class CreateThirdPartyRoomTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateThirdPartyRoom
        //private CreateThirdPartyRoom instance;

        public CreateThirdPartyRoomTests()
        {
            // TODO uncomment below to create an instance of CreateThirdPartyRoom
            //instance = new CreateThirdPartyRoom();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateThirdPartyRoom
        /// </summary>
        [Fact]
        public void CreateThirdPartyRoomInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateThirdPartyRoom
            //Assert.IsType<CreateThirdPartyRoom>(instance);
        }

        /// <summary>
        /// Test the property 'CreateAsNewFolder'
        /// </summary>
        [Fact]
        public void CreateAsNewFolderTest()
        {
            // TODO unit test for the property 'CreateAsNewFolder'
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'RoomType'
        /// </summary>
        [Fact]
        public void RoomTypeTest()
        {
            // TODO unit test for the property 'RoomType'
        }

        /// <summary>
        /// Test the property 'Private'
        /// </summary>
        [Fact]
        public void PrivateTest()
        {
            // TODO unit test for the property 'Private'
        }

        /// <summary>
        /// Test the property 'Indexing'
        /// </summary>
        [Fact]
        public void IndexingTest()
        {
            // TODO unit test for the property 'Indexing'
        }

        /// <summary>
        /// Test the property 'DenyDownload'
        /// </summary>
        [Fact]
        public void DenyDownloadTest()
        {
            // TODO unit test for the property 'DenyDownload'
        }

        /// <summary>
        /// Test the property 'Color'
        /// </summary>
        [Fact]
        public void ColorTest()
        {
            // TODO unit test for the property 'Color'
        }

        /// <summary>
        /// Test the property 'Cover'
        /// </summary>
        [Fact]
        public void CoverTest()
        {
            // TODO unit test for the property 'Cover'
        }

        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Fact]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }

        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Fact]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }
    }
}
