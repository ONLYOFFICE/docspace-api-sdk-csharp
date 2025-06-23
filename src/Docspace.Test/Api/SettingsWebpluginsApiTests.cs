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

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Docspace.Client;
using Docspace.Api;
// uncomment below to import models
//using Docspace.Model;

namespace Docspace.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsWebpluginsApi
    /// </summary>
    public class SettingsWebpluginsApiTests : IDisposable
    {
        private SettingsWebpluginsApi instance;

        public SettingsWebpluginsApiTests()
        {
            instance = new SettingsWebpluginsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SettingsWebpluginsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SettingsWebpluginsApi
            //Assert.IsType<SettingsWebpluginsApi>(instance);
        }

        /// <summary>
        /// Test AddWebPluginFromFile
        /// </summary>
        [Fact]
        public void AddWebPluginFromFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? varSystem = null;
            //var response = instance.AddWebPluginFromFile(varSystem);
            //Assert.IsType<WebPluginWrapper>(response);
        }

        /// <summary>
        /// Test DeleteWebPlugin
        /// </summary>
        [Fact]
        public void DeleteWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.DeleteWebPlugin(name);
        }

        /// <summary>
        /// Test GetWebPlugin
        /// </summary>
        [Fact]
        public void GetWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetWebPlugin(name);
            //Assert.IsType<WebPluginWrapper>(response);
        }

        /// <summary>
        /// Test GetWebPlugins
        /// </summary>
        [Fact]
        public void GetWebPluginsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? enabled = null;
            //var response = instance.GetWebPlugins(enabled);
            //Assert.IsType<WebPluginArrayWrapper>(response);
        }

        /// <summary>
        /// Test UpdateWebPlugin
        /// </summary>
        [Fact]
        public void UpdateWebPluginTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //WebPluginRequests? webPluginRequests = null;
            //instance.UpdateWebPlugin(name, webPluginRequests);
        }
    }
}
