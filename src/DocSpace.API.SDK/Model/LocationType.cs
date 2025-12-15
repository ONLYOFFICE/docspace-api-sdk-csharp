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
    /// [0 - None, 1 - Files, 2 - Folders, 3 - Documents settings, 27 - Rooms, 29 - Settings, 30 - Contacts, 31 - Agents]
    /// </summary>
    /// <value>[0 - None, 1 - Files, 2 - Folders, 3 - Documents settings, 27 - Rooms, 29 - Settings, 30 - Contacts, 31 - Agents]</value>
    public enum LocationType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum Files for value: 1
        /// </summary>
        Files = 1,

        /// <summary>
        /// Enum Folders for value: 2
        /// </summary>
        Folders = 2,

        /// <summary>
        /// Enum DocumentsSettings for value: 3
        /// </summary>
        DocumentsSettings = 3,

        /// <summary>
        /// Enum Rooms for value: 27
        /// </summary>
        Rooms = 27,

        /// <summary>
        /// Enum Settings for value: 29
        /// </summary>
        Settings = 29,

        /// <summary>
        /// Enum Contacts for value: 30
        /// </summary>
        Contacts = 30,

        /// <summary>
        /// Enum Agents for value: 31
        /// </summary>
        Agents = 31
    }

}
