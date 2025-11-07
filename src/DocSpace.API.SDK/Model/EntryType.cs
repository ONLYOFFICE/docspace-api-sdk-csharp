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
    /// [0 - None, 1 - File, 2 - Folder, 23 - User, 24 - Group, 25 - Room, 26 - Tag, 27 - Agent]
    /// </summary>
    /// <value>[0 - None, 1 - File, 2 - Folder, 23 - User, 24 - Group, 25 - Room, 26 - Tag, 27 - Agent]</value>
    public enum EntryType
    {
        /// <summary>
        /// Enum None for value: 0
        /// </summary>
        None = 0,

        /// <summary>
        /// Enum File for value: 1
        /// </summary>
        File = 1,

        /// <summary>
        /// Enum Folder for value: 2
        /// </summary>
        Folder = 2,

        /// <summary>
        /// Enum User for value: 23
        /// </summary>
        User = 23,

        /// <summary>
        /// Enum Group for value: 24
        /// </summary>
        Group = 24,

        /// <summary>
        /// Enum Room for value: 25
        /// </summary>
        Room = 25,

        /// <summary>
        /// Enum Tag for value: 26
        /// </summary>
        Tag = 26,

        /// <summary>
        /// Enum Agent for value: 27
        /// </summary>
        Agent = 27
    }

}
