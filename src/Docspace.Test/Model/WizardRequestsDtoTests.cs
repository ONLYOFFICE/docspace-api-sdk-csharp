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
    ///  Class for testing WizardRequestsDto
    /// </summary>
    public class WizardRequestsDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for WizardRequestsDto
        //private WizardRequestsDto instance;

        public WizardRequestsDtoTests()
        {
            // TODO uncomment below to create an instance of WizardRequestsDto
            //instance = new WizardRequestsDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WizardRequestsDto
        /// </summary>
        [Fact]
        public void WizardRequestsDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" WizardRequestsDto
            //Assert.IsType<WizardRequestsDto>(instance);
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
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
        /// Test the property 'Lng'
        /// </summary>
        [Fact]
        public void LngTest()
        {
            // TODO unit test for the property 'Lng'
        }

        /// <summary>
        /// Test the property 'VarTimeZone'
        /// </summary>
        [Fact]
        public void VarTimeZoneTest()
        {
            // TODO unit test for the property 'VarTimeZone'
        }

        /// <summary>
        /// Test the property 'AmiId'
        /// </summary>
        [Fact]
        public void AmiIdTest()
        {
            // TODO unit test for the property 'AmiId'
        }

        /// <summary>
        /// Test the property 'SubscribeFromSite'
        /// </summary>
        [Fact]
        public void SubscribeFromSiteTest()
        {
            // TODO unit test for the property 'SubscribeFromSite'
        }
    }
}
