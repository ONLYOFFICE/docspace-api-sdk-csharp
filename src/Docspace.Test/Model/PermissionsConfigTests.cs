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
    ///  Class for testing PermissionsConfig
    /// </summary>
    public class PermissionsConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PermissionsConfig
        //private PermissionsConfig instance;

        public PermissionsConfigTests()
        {
            // TODO uncomment below to create an instance of PermissionsConfig
            //instance = new PermissionsConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermissionsConfig
        /// </summary>
        [Fact]
        public void PermissionsConfigInstanceTest()
        {
            // TODO uncomment below to test "IsType" PermissionsConfig
            //Assert.IsType<PermissionsConfig>(instance);
        }

        /// <summary>
        /// Test the property 'ChangeHistory'
        /// </summary>
        [Fact]
        public void ChangeHistoryTest()
        {
            // TODO unit test for the property 'ChangeHistory'
        }

        /// <summary>
        /// Test the property 'Comment'
        /// </summary>
        [Fact]
        public void CommentTest()
        {
            // TODO unit test for the property 'Comment'
        }

        /// <summary>
        /// Test the property 'Chat'
        /// </summary>
        [Fact]
        public void ChatTest()
        {
            // TODO unit test for the property 'Chat'
        }

        /// <summary>
        /// Test the property 'Download'
        /// </summary>
        [Fact]
        public void DownloadTest()
        {
            // TODO unit test for the property 'Download'
        }

        /// <summary>
        /// Test the property 'Edit'
        /// </summary>
        [Fact]
        public void EditTest()
        {
            // TODO unit test for the property 'Edit'
        }

        /// <summary>
        /// Test the property 'FillForms'
        /// </summary>
        [Fact]
        public void FillFormsTest()
        {
            // TODO unit test for the property 'FillForms'
        }

        /// <summary>
        /// Test the property 'ModifyFilter'
        /// </summary>
        [Fact]
        public void ModifyFilterTest()
        {
            // TODO unit test for the property 'ModifyFilter'
        }

        /// <summary>
        /// Test the property 'Protect'
        /// </summary>
        [Fact]
        public void ProtectTest()
        {
            // TODO unit test for the property 'Protect'
        }

        /// <summary>
        /// Test the property 'Print'
        /// </summary>
        [Fact]
        public void PrintTest()
        {
            // TODO unit test for the property 'Print'
        }

        /// <summary>
        /// Test the property 'Rename'
        /// </summary>
        [Fact]
        public void RenameTest()
        {
            // TODO unit test for the property 'Rename'
        }

        /// <summary>
        /// Test the property 'Review'
        /// </summary>
        [Fact]
        public void ReviewTest()
        {
            // TODO unit test for the property 'Review'
        }

        /// <summary>
        /// Test the property 'Copy'
        /// </summary>
        [Fact]
        public void CopyTest()
        {
            // TODO unit test for the property 'Copy'
        }
    }
}
