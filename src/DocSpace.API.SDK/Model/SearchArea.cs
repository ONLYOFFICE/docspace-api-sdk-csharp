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
    /// [0 - Active, 1 - Archive, 2 - Any, 3 - Recent by links, 4 - Template, 5 - Knowledge, 6 - Result storage, 7 - AiAgents, 8 - Forms, 9 - Form templates]
    /// </summary>
    /// <value>[0 - Active, 1 - Archive, 2 - Any, 3 - Recent by links, 4 - Template, 5 - Knowledge, 6 - Result storage, 7 - AiAgents, 8 - Forms, 9 - Form templates]</value>
    public enum SearchArea
    {
        /// <summary>
        /// Enum Active for value: 0
        /// </summary>
        Active = 0,

        /// <summary>
        /// Enum Archive for value: 1
        /// </summary>
        Archive = 1,

        /// <summary>
        /// Enum Any for value: 2
        /// </summary>
        Any = 2,

        /// <summary>
        /// Enum RecentByLinks for value: 3
        /// </summary>
        RecentByLinks = 3,

        /// <summary>
        /// Enum Templates for value: 4
        /// </summary>
        Templates = 4,

        /// <summary>
        /// Enum Knowledge for value: 5
        /// </summary>
        Knowledge = 5,

        /// <summary>
        /// Enum ResultStorage for value: 6
        /// </summary>
        ResultStorage = 6,

        /// <summary>
        /// Enum AiAgents for value: 7
        /// </summary>
        AiAgents = 7,

        /// <summary>
        /// Enum Forms for value: 8
        /// </summary>
        Forms = 8,

        /// <summary>
        /// Enum FormTemplates for value: 9
        /// </summary>
        FormTemplates = 9
    }

}
