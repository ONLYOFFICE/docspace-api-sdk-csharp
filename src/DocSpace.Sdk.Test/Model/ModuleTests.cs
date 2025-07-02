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
    ///  Class for testing Module
    /// </summary>
    public class ModuleTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Module
        //private Module instance;

        public ModuleTests()
        {
            // TODO uncomment below to create an instance of Module
            //instance = new Module();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Module
        /// </summary>
        [Fact]
        public void ModuleInstanceTest()
        {
            // TODO uncomment below to test "IsType" Module
            //Assert.IsType<Module>(instance);
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
        /// Test the property 'AppName'
        /// </summary>
        [Fact]
        public void AppNameTest()
        {
            // TODO unit test for the property 'AppName'
        }

        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'Link'
        /// </summary>
        [Fact]
        public void LinkTest()
        {
            // TODO unit test for the property 'Link'
        }

        /// <summary>
        /// Test the property 'IconUrl'
        /// </summary>
        [Fact]
        public void IconUrlTest()
        {
            // TODO unit test for the property 'IconUrl'
        }

        /// <summary>
        /// Test the property 'ImageUrl'
        /// </summary>
        [Fact]
        public void ImageUrlTest()
        {
            // TODO unit test for the property 'ImageUrl'
        }

        /// <summary>
        /// Test the property 'HelpUrl'
        /// </summary>
        [Fact]
        public void HelpUrlTest()
        {
            // TODO unit test for the property 'HelpUrl'
        }

        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }

        /// <summary>
        /// Test the property 'IsPrimary'
        /// </summary>
        [Fact]
        public void IsPrimaryTest()
        {
            // TODO unit test for the property 'IsPrimary'
        }
    }
}
