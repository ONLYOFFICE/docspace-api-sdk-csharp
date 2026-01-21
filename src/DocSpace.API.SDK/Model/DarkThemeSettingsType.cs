// (c) Copyright Ascensio System SIA 2025
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
    /// [Base - Base, Dark - Dark, System - System]
    /// </summary>
    /// <value>[Base - Base, Dark - Dark, System - System]</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DarkThemeSettingsType
    {
        /// <summary>
        /// Enum Base for value: Base
        /// </summary>
        [EnumMember(Value = "Base")]
        Base = 0,

        /// <summary>
        /// Enum Dark for value: Dark
        /// </summary>
        [EnumMember(Value = "Dark")]
        Dark = 1,

        /// <summary>
        /// Enum System for value: System
        /// </summary>
        [EnumMember(Value = "System")]
        System = 2
    }

}
