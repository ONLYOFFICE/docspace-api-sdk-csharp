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
    /// Union of all 17 built-in AI provider type identifiers.  The &#x60;external&#x60; provider has no built-in transport — it delegates every HTTP request to &#x60;PlatformAdapter.externalFetch&#x60; and parses the response with the inner provider selected by &#x60;Profile.basedOn&#x60;.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiBuiltinProviderType
    {
        /// <summary>
        /// Enum Anthropic for value: anthropic
        /// </summary>
        [EnumMember(Value = "anthropic")]
        Anthropic,

        /// <summary>
        /// Enum Ollama for value: ollama
        /// </summary>
        [EnumMember(Value = "ollama")]
        Ollama,

        /// <summary>
        /// Enum Openai for value: openai
        /// </summary>
        [EnumMember(Value = "openai")]
        Openai,

        /// <summary>
        /// Enum Openaicompatible for value: openaicompatible
        /// </summary>
        [EnumMember(Value = "openaicompatible")]
        Openaicompatible,

        /// <summary>
        /// Enum Together for value: together
        /// </summary>
        [EnumMember(Value = "together")]
        Together,

        /// <summary>
        /// Enum Openrouter for value: openrouter
        /// </summary>
        [EnumMember(Value = "openrouter")]
        Openrouter,

        /// <summary>
        /// Enum Genai for value: genai
        /// </summary>
        [EnumMember(Value = "genai")]
        Genai,

        /// <summary>
        /// Enum Deepseek for value: deepseek
        /// </summary>
        [EnumMember(Value = "deepseek")]
        Deepseek,

        /// <summary>
        /// Enum Xai for value: xai
        /// </summary>
        [EnumMember(Value = "xai")]
        Xai,

        /// <summary>
        /// Enum LmStudio for value: lm-studio
        /// </summary>
        [EnumMember(Value = "lm-studio")]
        LmStudio,

        /// <summary>
        /// Enum Mistral for value: mistral
        /// </summary>
        [EnumMember(Value = "mistral")]
        Mistral,

        /// <summary>
        /// Enum Groq for value: groq
        /// </summary>
        [EnumMember(Value = "groq")]
        Groq,

        /// <summary>
        /// Enum Zhipu for value: zhipu
        /// </summary>
        [EnumMember(Value = "zhipu")]
        Zhipu,

        /// <summary>
        /// Enum Stabilityai for value: stabilityai
        /// </summary>
        [EnumMember(Value = "stabilityai")]
        Stabilityai,

        /// <summary>
        /// Enum Gpt4all for value: gpt4all
        /// </summary>
        [EnumMember(Value = "gpt4all")]
        Gpt4all,

        /// <summary>
        /// Enum Onlyoffice for value: onlyoffice
        /// </summary>
        [EnumMember(Value = "onlyoffice")]
        Onlyoffice,

        /// <summary>
        /// Enum External for value: external
        /// </summary>
        [EnumMember(Value = "external")]
        External
    }

}
