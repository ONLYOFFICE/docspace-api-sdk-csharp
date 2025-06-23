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
    ///  Class for testing SsoCertificate
    /// </summary>
    public class SsoCertificateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SsoCertificate
        //private SsoCertificate instance;

        public SsoCertificateTests()
        {
            // TODO uncomment below to create an instance of SsoCertificate
            //instance = new SsoCertificate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SsoCertificate
        /// </summary>
        [Fact]
        public void SsoCertificateInstanceTest()
        {
            // TODO uncomment below to test "IsType" SsoCertificate
            //Assert.IsType<SsoCertificate>(instance);
        }

        /// <summary>
        /// Test the property 'SelfSigned'
        /// </summary>
        [Fact]
        public void SelfSignedTest()
        {
            // TODO unit test for the property 'SelfSigned'
        }

        /// <summary>
        /// Test the property 'Crt'
        /// </summary>
        [Fact]
        public void CrtTest()
        {
            // TODO unit test for the property 'Crt'
        }

        /// <summary>
        /// Test the property 'Key'
        /// </summary>
        [Fact]
        public void KeyTest()
        {
            // TODO unit test for the property 'Key'
        }

        /// <summary>
        /// Test the property 'Action'
        /// </summary>
        [Fact]
        public void ActionTest()
        {
            // TODO unit test for the property 'Action'
        }

        /// <summary>
        /// Test the property 'DomainName'
        /// </summary>
        [Fact]
        public void DomainNameTest()
        {
            // TODO unit test for the property 'DomainName'
        }

        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }

        /// <summary>
        /// Test the property 'ExpiredDate'
        /// </summary>
        [Fact]
        public void ExpiredDateTest()
        {
            // TODO unit test for the property 'ExpiredDate'
        }
    }
}
