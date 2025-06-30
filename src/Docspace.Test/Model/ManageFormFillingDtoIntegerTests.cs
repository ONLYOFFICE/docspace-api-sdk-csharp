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
    ///  Class for testing ManageFormFillingDtoInteger
    /// </summary>
    public class ManageFormFillingDtoIntegerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ManageFormFillingDtoInteger
        //private ManageFormFillingDtoInteger instance;

        public ManageFormFillingDtoIntegerTests()
        {
            // TODO uncomment below to create an instance of ManageFormFillingDtoInteger
            //instance = new ManageFormFillingDtoInteger();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ManageFormFillingDtoInteger
        /// </summary>
        [Fact]
        public void ManageFormFillingDtoIntegerInstanceTest()
        {
            // TODO uncomment below to test "IsType" ManageFormFillingDtoInteger
            //Assert.IsType<ManageFormFillingDtoInteger>(instance);
        }

        /// <summary>
        /// Test the property 'FormId'
        /// </summary>
        [Fact]
        public void FormIdTest()
        {
            // TODO unit test for the property 'FormId'
        }

        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }
    }
}
