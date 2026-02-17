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
    /// [All - All, RoomAdmin - Room admin, Guest - Guest, DocSpaceAdmin - DocSpace admin, User - User]
    /// </summary>
    /// <value>[All - All, RoomAdmin - Room admin, Guest - Guest, DocSpaceAdmin - DocSpace admin, User - User]</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmployeeType
    {
        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum RoomAdmin for value: RoomAdmin
        /// </summary>
        [EnumMember(Value = "RoomAdmin")]
        RoomAdmin,

        /// <summary>
        /// Enum Guest for value: Guest
        /// </summary>
        [EnumMember(Value = "Guest")]
        Guest,

        /// <summary>
        /// Enum DocSpaceAdmin for value: DocSpaceAdmin
        /// </summary>
        [EnumMember(Value = "DocSpaceAdmin")]
        DocSpaceAdmin,

        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }

}
