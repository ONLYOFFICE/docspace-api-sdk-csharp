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
    /// [Active - Active, Archive - Archive, Any - Any, RecentByLinks - Recent by links, Templates - Template, Knowledge - Knowledge, ResultStorage - Result storage, AiAgents - AiAgents, Forms - Forms, FormTemplates - Form templates]
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SearchArea
    {
        /// <summary>
        /// Enum Active for value: Active
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Archive for value: Archive
        /// </summary>
        [EnumMember(Value = "Archive")]
        Archive,

        /// <summary>
        /// Enum Any for value: Any
        /// </summary>
        [EnumMember(Value = "Any")]
        Any,

        /// <summary>
        /// Enum RecentByLinks for value: RecentByLinks
        /// </summary>
        [EnumMember(Value = "RecentByLinks")]
        RecentByLinks,

        /// <summary>
        /// Enum Templates for value: Templates
        /// </summary>
        [EnumMember(Value = "Templates")]
        Templates,

        /// <summary>
        /// Enum Knowledge for value: Knowledge
        /// </summary>
        [EnumMember(Value = "Knowledge")]
        Knowledge,

        /// <summary>
        /// Enum ResultStorage for value: ResultStorage
        /// </summary>
        [EnumMember(Value = "ResultStorage")]
        ResultStorage,

        /// <summary>
        /// Enum AiAgents for value: AiAgents
        /// </summary>
        [EnumMember(Value = "AiAgents")]
        AiAgents,

        /// <summary>
        /// Enum Forms for value: Forms
        /// </summary>
        [EnumMember(Value = "Forms")]
        Forms,

        /// <summary>
        /// Enum FormTemplates for value: FormTemplates
        /// </summary>
        [EnumMember(Value = "FormTemplates")]
        FormTemplates
    }

}
