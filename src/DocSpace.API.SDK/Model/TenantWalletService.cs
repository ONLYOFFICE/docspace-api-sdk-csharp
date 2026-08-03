// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// [-18 - AISearch, -16 - DocsCloudDevPack, -15 - DocsCloud, -14 - Admin, -13 - AITools, -12 - Backup, -11 - Storage]
    /// </summary>
    /// <value>[-18 - AISearch, -16 - DocsCloudDevPack, -15 - DocsCloud, -14 - Admin, -13 - AITools, -12 - Backup, -11 - Storage]</value>
    public enum TenantWalletService
    {
        /// <summary>
        /// Enum AISearch for value: -18
        /// </summary>
        AISearch = -18,

        /// <summary>
        /// Enum DocsCloudDevPack for value: -16
        /// </summary>
        DocsCloudDevPack = -16,

        /// <summary>
        /// Enum DocsCloud for value: -15
        /// </summary>
        DocsCloud = -15,

        /// <summary>
        /// Enum Admin for value: -14
        /// </summary>
        Admin = -14,

        /// <summary>
        /// Enum AITools for value: -13
        /// </summary>
        AITools = -13,

        /// <summary>
        /// Enum Backup for value: -12
        /// </summary>
        Backup = -12,

        /// <summary>
        /// Enum Storage for value: -11
        /// </summary>
        Storage = -11
    }

}
