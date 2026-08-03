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
    /// OpenAI Chat Completions streaming shapes.   {@link  toOpenAIChatCompletionStream }  maps the engine&#39;s transport-agnostic  {@link  ChatEvent }  stream onto these chunks so a host can expose an OpenAI-compatible &#x60;POST /v1/chat/completions&#x60; (&#x60;stream: true&#x60;) endpoint backed by the same chat pipeline as the in-app widget. Only the subset of fields the engine can populate is emitted; everything else an OpenAI client tolerates as absent.
    /// </summary>
    /// <value>OpenAI Chat Completions streaming shapes.   {@link  toOpenAIChatCompletionStream }  maps the engine&#39;s transport-agnostic  {@link  ChatEvent }  stream onto these chunks so a host can expose an OpenAI-compatible &#x60;POST /v1/chat/completions&#x60; (&#x60;stream: true&#x60;) endpoint backed by the same chat pipeline as the in-app widget. Only the subset of fields the engine can populate is emitted; everything else an OpenAI client tolerates as absent.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AiOpenAIFinishReason
    {
        /// <summary>
        /// Enum Stop for value: stop
        /// </summary>
        [EnumMember(Value = "stop")]
        Stop,

        /// <summary>
        /// Enum Length for value: length
        /// </summary>
        [EnumMember(Value = "length")]
        Length,

        /// <summary>
        /// Enum ToolCalls for value: tool_calls
        /// </summary>
        [EnumMember(Value = "tool_calls")]
        ToolCalls,

        /// <summary>
        /// Enum ContentFilter for value: content_filter
        /// </summary>
        [EnumMember(Value = "content_filter")]
        ContentFilter
    }

}
