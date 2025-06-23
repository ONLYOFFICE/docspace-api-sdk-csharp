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
    ///  Class for testing WebhooksConfigDto
    /// </summary>
    public class WebhooksConfigDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WebhooksConfigDto
        //private WebhooksConfigDto instance;

        public WebhooksConfigDtoTests()
        {
            // TODO uncomment below to create an instance of WebhooksConfigDto
            //instance = new WebhooksConfigDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhooksConfigDto
        /// </summary>
        [Fact]
        public void WebhooksConfigDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" WebhooksConfigDto
            //Assert.IsType<WebhooksConfigDto>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
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
        /// Test the property 'Uri'
        /// </summary>
        [Fact]
        public void UriTest()
        {
            // TODO unit test for the property 'Uri'
        }

        /// <summary>
        /// Test the property 'Enabled'
        /// </summary>
        [Fact]
        public void EnabledTest()
        {
            // TODO unit test for the property 'Enabled'
        }

        /// <summary>
        /// Test the property 'Ssl'
        /// </summary>
        [Fact]
        public void SslTest()
        {
            // TODO unit test for the property 'Ssl'
        }

        /// <summary>
        /// Test the property 'Triggers'
        /// </summary>
        [Fact]
        public void TriggersTest()
        {
            // TODO unit test for the property 'Triggers'
        }

        /// <summary>
        /// Test the property 'TargetId'
        /// </summary>
        [Fact]
        public void TargetIdTest()
        {
            // TODO unit test for the property 'TargetId'
        }

        /// <summary>
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
        }

        /// <summary>
        /// Test the property 'CreatedOn'
        /// </summary>
        [Fact]
        public void CreatedOnTest()
        {
            // TODO unit test for the property 'CreatedOn'
        }

        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Fact]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
        }

        /// <summary>
        /// Test the property 'ModifiedOn'
        /// </summary>
        [Fact]
        public void ModifiedOnTest()
        {
            // TODO unit test for the property 'ModifiedOn'
        }

        /// <summary>
        /// Test the property 'LastFailureOn'
        /// </summary>
        [Fact]
        public void LastFailureOnTest()
        {
            // TODO unit test for the property 'LastFailureOn'
        }

        /// <summary>
        /// Test the property 'LastFailureContent'
        /// </summary>
        [Fact]
        public void LastFailureContentTest()
        {
            // TODO unit test for the property 'LastFailureContent'
        }

        /// <summary>
        /// Test the property 'LastSuccessOn'
        /// </summary>
        [Fact]
        public void LastSuccessOnTest()
        {
            // TODO unit test for the property 'LastSuccessOn'
        }
    }
}
