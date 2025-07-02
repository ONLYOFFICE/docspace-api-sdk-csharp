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
    ///  Class for testing QuotaDto
    /// </summary>
    public class QuotaDtoTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for QuotaDto
        //private QuotaDto instance;

        public QuotaDtoTests()
        {
            // TODO uncomment below to create an instance of QuotaDto
            //instance = new QuotaDto();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuotaDto
        /// </summary>
        [Fact]
        public void QuotaDtoInstanceTest()
        {
            // TODO uncomment below to test "IsType" QuotaDto
            //Assert.IsType<QuotaDto>(instance);
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
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }

        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Fact]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }

        /// <summary>
        /// Test the property 'NonProfit'
        /// </summary>
        [Fact]
        public void NonProfitTest()
        {
            // TODO unit test for the property 'NonProfit'
        }

        /// <summary>
        /// Test the property 'Free'
        /// </summary>
        [Fact]
        public void FreeTest()
        {
            // TODO unit test for the property 'Free'
        }

        /// <summary>
        /// Test the property 'Trial'
        /// </summary>
        [Fact]
        public void TrialTest()
        {
            // TODO unit test for the property 'Trial'
        }

        /// <summary>
        /// Test the property 'Features'
        /// </summary>
        [Fact]
        public void FeaturesTest()
        {
            // TODO unit test for the property 'Features'
        }

        /// <summary>
        /// Test the property 'UsersQuota'
        /// </summary>
        [Fact]
        public void UsersQuotaTest()
        {
            // TODO unit test for the property 'UsersQuota'
        }

        /// <summary>
        /// Test the property 'RoomsQuota'
        /// </summary>
        [Fact]
        public void RoomsQuotaTest()
        {
            // TODO unit test for the property 'RoomsQuota'
        }

        /// <summary>
        /// Test the property 'TenantCustomQuota'
        /// </summary>
        [Fact]
        public void TenantCustomQuotaTest()
        {
            // TODO unit test for the property 'TenantCustomQuota'
        }

        /// <summary>
        /// Test the property 'DueDate'
        /// </summary>
        [Fact]
        public void DueDateTest()
        {
            // TODO unit test for the property 'DueDate'
        }
    }
}
