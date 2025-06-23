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
    ///  Class for testing ContentType
    /// </summary>
    public class ContentTypeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ContentType
        //private ContentType instance;

        public ContentTypeTests()
        {
            // TODO uncomment below to create an instance of ContentType
            //instance = new ContentType();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContentType
        /// </summary>
        [Fact]
        public void ContentTypeInstanceTest()
        {
            // TODO uncomment below to test "IsType" ContentType
            //Assert.IsType<ContentType>(instance);
        }

        /// <summary>
        /// Test the property 'Boundary'
        /// </summary>
        [Fact]
        public void BoundaryTest()
        {
            // TODO unit test for the property 'Boundary'
        }

        /// <summary>
        /// Test the property 'CharSet'
        /// </summary>
        [Fact]
        public void CharSetTest()
        {
            // TODO unit test for the property 'CharSet'
        }

        /// <summary>
        /// Test the property 'MediaType'
        /// </summary>
        [Fact]
        public void MediaTypeTest()
        {
            // TODO unit test for the property 'MediaType'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Parameters'
        /// </summary>
        [Fact]
        public void ParametersTest()
        {
            // TODO unit test for the property 'Parameters'
        }
    }
}
