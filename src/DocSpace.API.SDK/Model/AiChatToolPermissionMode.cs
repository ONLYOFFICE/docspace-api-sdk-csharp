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
    /// How a tool call the model makes is approved: ask every time, auto-approve opted-out tools, or allow all.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiChatToolPermissionMode
    {
        /// <summary>
        /// Enum Ask for value: ask
        /// </summary>
        [EnumMember(Value = "ask")]
        Ask,

        /// <summary>
        /// Enum Auto for value: auto
        /// </summary>
        [EnumMember(Value = "auto")]
        Auto,

        /// <summary>
        /// Enum Allow for value: allow
        /// </summary>
        [EnumMember(Value = "allow")]
        Allow
    }

}
