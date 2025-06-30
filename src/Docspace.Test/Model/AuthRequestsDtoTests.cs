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
    ///  Class for testing AuthRequestsDto
    /// </summary>
    public class AuthRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AuthRequestsDto
        //private AuthRequestsDto instance;

        public AuthRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of AuthRequestsDto
            //instance = new AuthRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthRequestsDto
        /// </summary>
        [Fact]
        public void AuthRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" AuthRequestsDto
            //Assert.IsType<AuthRequestsDto>(instance);
        }

        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }

        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }

        /// <summary>
        /// Test the property 'PasswordHash'
        /// </summary>
        [Fact]
        public void PasswordHashTest()
        {
            // TODO unit test for the property 'PasswordHash'
        }

        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }

        /// <summary>
        /// Test the property 'AccessToken'
        /// </summary>
        [Fact]
        public void AccessTokenTest()
        {
            // TODO unit test for the property 'AccessToken'
        }

        /// <summary>
        /// Test the property 'SerializedProfile'
        /// </summary>
        [Fact]
        public void SerializedProfileTest()
        {
            // TODO unit test for the property 'SerializedProfile'
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Fact]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }

        /// <summary>
        /// Test the property 'CodeOAuth'
        /// </summary>
        [Fact]
        public void CodeOAuthTest()
        {
            // TODO unit test for the property 'CodeOAuth'
        }

        /// <summary>
        /// Test the property 'Session'
        /// </summary>
        [Fact]
        public void SessionTest()
        {
            // TODO unit test for the property 'Session'
        }

        /// <summary>
        /// Test the property 'ConfirmData'
        /// </summary>
        [Fact]
        public void ConfirmDataTest()
        {
            // TODO unit test for the property 'ConfirmData'
        }

        /// <summary>
        /// Test the property 'RecaptchaType'
        /// </summary>
        [Fact]
        public void RecaptchaTypeTest()
        {
            // TODO unit test for the property 'RecaptchaType'
        }

        /// <summary>
        /// Test the property 'RecaptchaResponse'
        /// </summary>
        [Fact]
        public void RecaptchaResponseTest()
        {
            // TODO unit test for the property 'RecaptchaResponse'
        }

        /// <summary>
        /// Test the property 'Culture'
        /// </summary>
        [Fact]
        public void CultureTest()
        {
            // TODO unit test for the property 'Culture'
        }
    }
}
