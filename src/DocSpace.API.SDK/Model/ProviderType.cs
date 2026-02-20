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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// [0 - PortalAi, 1 - OpenAi, 2 - TogetherAi, 3 - OpenAiCompatible, 4 - Anthropic, 5 - OpenRouter, 6 - DeepSeek, 7 - XAi, 8 - GoogleAi]
    /// </summary>
    /// <value>[0 - PortalAi, 1 - OpenAi, 2 - TogetherAi, 3 - OpenAiCompatible, 4 - Anthropic, 5 - OpenRouter, 6 - DeepSeek, 7 - XAi, 8 - GoogleAi]</value>
    public enum ProviderType
    {
        /// <summary>
        /// Enum PortalAi for value: 0
        /// </summary>
        PortalAi = 0,

        /// <summary>
        /// Enum OpenAi for value: 1
        /// </summary>
        OpenAi = 1,

        /// <summary>
        /// Enum TogetherAi for value: 2
        /// </summary>
        TogetherAi = 2,

        /// <summary>
        /// Enum OpenAiCompatible for value: 3
        /// </summary>
        OpenAiCompatible = 3,

        /// <summary>
        /// Enum Anthropic for value: 4
        /// </summary>
        Anthropic = 4,

        /// <summary>
        /// Enum OpenRouter for value: 5
        /// </summary>
        OpenRouter = 5,

        /// <summary>
        /// Enum DeepSeek for value: 6
        /// </summary>
        DeepSeek = 6,

        /// <summary>
        /// Enum XAi for value: 7
        /// </summary>
        XAi = 7,

        /// <summary>
        /// Enum GoogleAi for value: 8
        /// </summary>
        GoogleAi = 8
    }

}
