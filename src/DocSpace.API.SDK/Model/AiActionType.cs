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
    /// The AI action a request or an assignment applies to. Each action has its own assignment slot; &#x60;Default&#x60; is the profile used when an action&#39;s own slot is empty.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiActionType
    {
        /// <summary>
        /// Enum Default for value: Default
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,

        /// <summary>
        /// Enum Chat for value: Chat
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Code for value: Code
        /// </summary>
        [EnumMember(Value = "Code")]
        Code,

        /// <summary>
        /// Enum Summarization for value: Summarization
        /// </summary>
        [EnumMember(Value = "Summarization")]
        Summarization,

        /// <summary>
        /// Enum Translation for value: Translation
        /// </summary>
        [EnumMember(Value = "Translation")]
        Translation,

        /// <summary>
        /// Enum TextAnalyze for value: TextAnalyze
        /// </summary>
        [EnumMember(Value = "TextAnalyze")]
        TextAnalyze,

        /// <summary>
        /// Enum ImageGeneration for value: ImageGeneration
        /// </summary>
        [EnumMember(Value = "ImageGeneration")]
        ImageGeneration,

        /// <summary>
        /// Enum OCR for value: OCR
        /// </summary>
        [EnumMember(Value = "OCR")]
        OCR,

        /// <summary>
        /// Enum Vision for value: Vision
        /// </summary>
        [EnumMember(Value = "Vision")]
        Vision
    }

}
