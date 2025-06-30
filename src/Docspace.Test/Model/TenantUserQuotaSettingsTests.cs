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
    ///  Class for testing TenantUserQuotaSettings
    /// </summary>
    public class TenantUserQuotaSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for TenantUserQuotaSettings
        //private TenantUserQuotaSettings instance;

        public TenantUserQuotaSettingsTests()
        {
            // TODO uncomment below to create an instance of TenantUserQuotaSettings
            //instance = new TenantUserQuotaSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TenantUserQuotaSettings
        /// </summary>
        [Fact]
        public void TenantUserQuotaSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" TenantUserQuotaSettings
            //Assert.IsType<TenantUserQuotaSettings>(instance);
        }

        /// <summary>
        /// Test the property 'EnableQuota'
        /// </summary>
        [Fact]
        public void EnableQuotaTest()
        {
            // TODO unit test for the property 'EnableQuota'
        }

        /// <summary>
        /// Test the property 'DefaultQuota'
        /// </summary>
        [Fact]
        public void DefaultQuotaTest()
        {
            // TODO unit test for the property 'DefaultQuota'
        }

        /// <summary>
        /// Test the property 'LastRecalculateDate'
        /// </summary>
        [Fact]
        public void LastRecalculateDateTest()
        {
            // TODO unit test for the property 'LastRecalculateDate'
        }

        /// <summary>
        /// Test the property 'LastModified'
        /// </summary>
        [Fact]
        public void LastModifiedTest()
        {
            // TODO unit test for the property 'LastModified'
        }
    }
}
