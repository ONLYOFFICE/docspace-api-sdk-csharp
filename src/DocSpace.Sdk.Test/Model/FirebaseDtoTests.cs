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
using DocSpace.Sdk.Model;
using DocSpace.Sdk.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace DocSpace.Sdk.Test.Model
{
    /// <summary>
    ///  Class for testing FirebaseDto
    /// </summary>
    public class FirebaseDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for FirebaseDto
        //private FirebaseDto instance;

        public FirebaseDtoTests()
        {
            // TODO uncomment below to create an instance of FirebaseDto
            //instance = new FirebaseDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FirebaseDto
        /// </summary>
        [Fact]
        public void FirebaseDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" FirebaseDto
            //Assert.IsType<FirebaseDto>(instance);
        }

        /// <summary>
        /// Test the property 'ApiKey'
        /// </summary>
        [Fact]
        public void ApiKeyTest()
        {
            // TODO unit test for the property 'ApiKey'
        }

        /// <summary>
        /// Test the property 'AuthDomain'
        /// </summary>
        [Fact]
        public void AuthDomainTest()
        {
            // TODO unit test for the property 'AuthDomain'
        }

        /// <summary>
        /// Test the property 'ProjectId'
        /// </summary>
        [Fact]
        public void ProjectIdTest()
        {
            // TODO unit test for the property 'ProjectId'
        }

        /// <summary>
        /// Test the property 'StorageBucket'
        /// </summary>
        [Fact]
        public void StorageBucketTest()
        {
            // TODO unit test for the property 'StorageBucket'
        }

        /// <summary>
        /// Test the property 'MessagingSenderId'
        /// </summary>
        [Fact]
        public void MessagingSenderIdTest()
        {
            // TODO unit test for the property 'MessagingSenderId'
        }

        /// <summary>
        /// Test the property 'AppId'
        /// </summary>
        [Fact]
        public void AppIdTest()
        {
            // TODO unit test for the property 'AppId'
        }

        /// <summary>
        /// Test the property 'MeasurementId'
        /// </summary>
        [Fact]
        public void MeasurementIdTest()
        {
            // TODO unit test for the property 'MeasurementId'
        }

        /// <summary>
        /// Test the property 'DatabaseURL'
        /// </summary>
        [Fact]
        public void DatabaseURLTest()
        {
            // TODO unit test for the property 'DatabaseURL'
        }
    }
}
