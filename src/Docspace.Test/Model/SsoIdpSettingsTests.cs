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
    ///  Class for testing SsoIdpSettings
    /// </summary>
    public class SsoIdpSettingsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoIdpSettings
        //private SsoIdpSettings instance;

        public SsoIdpSettingsTests()
        {
            // TODO uncomment below to create an instance of SsoIdpSettings
            //instance = new SsoIdpSettings();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoIdpSettings
        /// </summary>
        [Fact]
        public void SsoIdpSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoIdpSettings
            //Assert.IsType<SsoIdpSettings>(instance);
        }

        /// <summary>
        /// Test the property 'EntityId'
        /// </summary>
        [Fact]
        public void EntityIdTest()
        {
            // TODO unit test for the property 'EntityId'
        }

        /// <summary>
        /// Test the property 'SsoUrl'
        /// </summary>
        [Fact]
        public void SsoUrlTest()
        {
            // TODO unit test for the property 'SsoUrl'
        }

        /// <summary>
        /// Test the property 'SsoBinding'
        /// </summary>
        [Fact]
        public void SsoBindingTest()
        {
            // TODO unit test for the property 'SsoBinding'
        }

        /// <summary>
        /// Test the property 'SloUrl'
        /// </summary>
        [Fact]
        public void SloUrlTest()
        {
            // TODO unit test for the property 'SloUrl'
        }

        /// <summary>
        /// Test the property 'SloBinding'
        /// </summary>
        [Fact]
        public void SloBindingTest()
        {
            // TODO unit test for the property 'SloBinding'
        }

        /// <summary>
        /// Test the property 'NameIdFormat'
        /// </summary>
        [Fact]
        public void NameIdFormatTest()
        {
            // TODO unit test for the property 'NameIdFormat'
        }
    }
}
