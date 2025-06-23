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
    ///  Class for testing CultureSpecificExternalResources
    /// </summary>
    public class CultureSpecificExternalResourcesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CultureSpecificExternalResources
        //private CultureSpecificExternalResources instance;

        public CultureSpecificExternalResourcesTests()
        {
            // TODO uncomment below to create an instance of CultureSpecificExternalResources
            //instance = new CultureSpecificExternalResources();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CultureSpecificExternalResources
        /// </summary>
        [Fact]
        public void CultureSpecificExternalResourcesInstanceTest()
        {
            // TODO uncomment below to test "IsType" CultureSpecificExternalResources
            //Assert.IsType<CultureSpecificExternalResources>(instance);
        }

        /// <summary>
        /// Test the property 'Api'
        /// </summary>
        [Fact]
        public void ApiTest()
        {
            // TODO unit test for the property 'Api'
        }

        /// <summary>
        /// Test the property 'Common'
        /// </summary>
        [Fact]
        public void CommonTest()
        {
            // TODO unit test for the property 'Common'
        }

        /// <summary>
        /// Test the property 'Forum'
        /// </summary>
        [Fact]
        public void ForumTest()
        {
            // TODO unit test for the property 'Forum'
        }

        /// <summary>
        /// Test the property 'Helpcenter'
        /// </summary>
        [Fact]
        public void HelpcenterTest()
        {
            // TODO unit test for the property 'Helpcenter'
        }

        /// <summary>
        /// Test the property 'Integrations'
        /// </summary>
        [Fact]
        public void IntegrationsTest()
        {
            // TODO unit test for the property 'Integrations'
        }

        /// <summary>
        /// Test the property 'Site'
        /// </summary>
        [Fact]
        public void SiteTest()
        {
            // TODO unit test for the property 'Site'
        }

        /// <summary>
        /// Test the property 'SocialNetworks'
        /// </summary>
        [Fact]
        public void SocialNetworksTest()
        {
            // TODO unit test for the property 'SocialNetworks'
        }

        /// <summary>
        /// Test the property 'Support'
        /// </summary>
        [Fact]
        public void SupportTest()
        {
            // TODO unit test for the property 'Support'
        }

        /// <summary>
        /// Test the property 'Videoguides'
        /// </summary>
        [Fact]
        public void VideoguidesTest()
        {
            // TODO unit test for the property 'Videoguides'
        }
    }
}
