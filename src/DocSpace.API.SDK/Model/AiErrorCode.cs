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
    /// Why a field-scoped operation was refused, independent of the wording of &#x60;message&#x60;, so a host can pick an HTTP status without parsing text:  - &#x60;required&#x60; — the field is empty. - &#x60;conflict&#x60; — the value collides with an existing entry. - &#x60;not_found&#x60; — the referenced entry does not exist. - &#x60;invalid&#x60; — the value has the wrong shape or an unsupported value.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiErrorCode
    {
        /// <summary>
        /// Enum Required for value: required
        /// </summary>
        [EnumMember(Value = "required")]
        Required,

        /// <summary>
        /// Enum Conflict for value: conflict
        /// </summary>
        [EnumMember(Value = "conflict")]
        Conflict,

        /// <summary>
        /// Enum NotFound for value: not_found
        /// </summary>
        [EnumMember(Value = "not_found")]
        NotFound,

        /// <summary>
        /// Enum Invalid for value: invalid
        /// </summary>
        [EnumMember(Value = "invalid")]
        Invalid
    }

}
