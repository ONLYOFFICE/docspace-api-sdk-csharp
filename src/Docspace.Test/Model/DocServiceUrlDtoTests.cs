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
    ///  Class for testing DocServiceUrlDto
    /// </summary>
    public class DocServiceUrlDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DocServiceUrlDto
        //private DocServiceUrlDto instance;

        public DocServiceUrlDtoTests()
        {
            // TODO uncomment below to create an instance of DocServiceUrlDto
            //instance = new DocServiceUrlDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DocServiceUrlDto
        /// </summary>
        [Fact]
        public void DocServiceUrlDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" DocServiceUrlDto
            //Assert.IsType<DocServiceUrlDto>(instance);
        }

        /// <summary>
        /// Test the property 'VarVersion'
        /// </summary>
        [Fact]
        public void VarVersionTest()
        {
            // TODO unit test for the property 'VarVersion'
        }

        /// <summary>
        /// Test the property 'DocServiceUrlApi'
        /// </summary>
        [Fact]
        public void DocServiceUrlApiTest()
        {
            // TODO unit test for the property 'DocServiceUrlApi'
        }

        /// <summary>
        /// Test the property 'DocServiceUrl'
        /// </summary>
        [Fact]
        public void DocServiceUrlTest()
        {
            // TODO unit test for the property 'DocServiceUrl'
        }

        /// <summary>
        /// Test the property 'DocServiceUrlInternal'
        /// </summary>
        [Fact]
        public void DocServiceUrlInternalTest()
        {
            // TODO unit test for the property 'DocServiceUrlInternal'
        }

        /// <summary>
        /// Test the property 'DocServicePortalUrl'
        /// </summary>
        [Fact]
        public void DocServicePortalUrlTest()
        {
            // TODO unit test for the property 'DocServicePortalUrl'
        }

        /// <summary>
        /// Test the property 'DocServiceSignatureHeader'
        /// </summary>
        [Fact]
        public void DocServiceSignatureHeaderTest()
        {
            // TODO unit test for the property 'DocServiceSignatureHeader'
        }

        /// <summary>
        /// Test the property 'DocServiceSslVerification'
        /// </summary>
        [Fact]
        public void DocServiceSslVerificationTest()
        {
            // TODO unit test for the property 'DocServiceSslVerification'
        }

        /// <summary>
        /// Test the property 'IsDefault'
        /// </summary>
        [Fact]
        public void IsDefaultTest()
        {
            // TODO unit test for the property 'IsDefault'
        }
    }
}
