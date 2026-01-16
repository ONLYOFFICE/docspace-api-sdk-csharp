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
    /// [Skip - Skip, Overwrite - Overwrite, Duplicate - Duplicate]
    /// </summary>
    /// <value>[Skip - Skip, Overwrite - Overwrite, Duplicate - Duplicate]</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileConflictResolveType
    {
        /// <summary>
        /// Enum Skip for value: Skip
        /// </summary>
        [EnumMember(Value = "Skip")]
        Skip,

        /// <summary>
        /// Enum Overwrite for value: Overwrite
        /// </summary>
        [EnumMember(Value = "Overwrite")]
        Overwrite,

        /// <summary>
        /// Enum Duplicate for value: Duplicate
        /// </summary>
        [EnumMember(Value = "Duplicate")]
        Duplicate
    }

}
