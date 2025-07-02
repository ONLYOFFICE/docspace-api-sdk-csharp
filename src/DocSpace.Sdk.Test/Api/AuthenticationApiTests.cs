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
    ///  Class for testing AuthenticationApi
    /// </summary>
    public class AuthenticationApiTests : IDisposable
    {
        private AuthenticationApi instance;

        public AuthenticationApiTests()
        {
            instance = new AuthenticationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthenticationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthenticationApi
            //Assert.IsType<AuthenticationApi>(instance);
        }

        /// <summary>
        /// Test AuthenticateMe
        /// </summary>
        [Fact]
        public void AuthenticateMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.AuthenticateMe(authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test AuthenticateMeFromBodyWithCode
        /// </summary>
        [Fact]
        public void AuthenticateMeFromBodyWithCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string code = null;
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.AuthenticateMeFromBodyWithCode(code, authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test CheckConfirm
        /// </summary>
        [Fact]
        public void CheckConfirmTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EmailValidationKeyModel? emailValidationKeyModel = null;
            //var response = instance.CheckConfirm(emailValidationKeyModel);
            //Assert.IsType<ConfirmWrapper>(response);
        }

        /// <summary>
        /// Test GetIsAuthentificated
        /// </summary>
        [Fact]
        public void GetIsAuthentificatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetIsAuthentificated();
            //Assert.IsType<BooleanWrapper>(response);
        }

        /// <summary>
        /// Test Logout
        /// </summary>
        [Fact]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Logout();
            //Assert.IsType<StringWrapper>(response);
        }

        /// <summary>
        /// Test SaveMobilePhone
        /// </summary>
        [Fact]
        public void SaveMobilePhoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MobileRequestsDto? mobileRequestsDto = null;
            //var response = instance.SaveMobilePhone(mobileRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }

        /// <summary>
        /// Test SendSmsCode
        /// </summary>
        [Fact]
        public void SendSmsCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthRequestsDto? authRequestsDto = null;
            //var response = instance.SendSmsCode(authRequestsDto);
            //Assert.IsType<AuthenticationTokenWrapper>(response);
        }
    }
}
