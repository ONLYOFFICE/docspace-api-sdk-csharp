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
    /// [0 - Move, 1 - Copy, 2 - Delete, 3 - Download, 4 - MarkAsRead, 5 - Import, 6 - Convert, 7 - Duplicate]
    /// </summary>
    /// <value>[0 - Move, 1 - Copy, 2 - Delete, 3 - Download, 4 - MarkAsRead, 5 - Import, 6 - Convert, 7 - Duplicate]</value>
    public enum FileOperationType
    {
        /// <summary>
        /// Enum Move for value: 0
        /// </summary>
        Move = 0,

        /// <summary>
        /// Enum Copy for value: 1
        /// </summary>
        Copy = 1,

        /// <summary>
        /// Enum Delete for value: 2
        /// </summary>
        Delete = 2,

        /// <summary>
        /// Enum Download for value: 3
        /// </summary>
        Download = 3,

        /// <summary>
        /// Enum MarkAsRead for value: 4
        /// </summary>
        MarkAsRead = 4,

        /// <summary>
        /// Enum Import for value: 5
        /// </summary>
        Import = 5,

        /// <summary>
        /// Enum Convert for value: 6
        /// </summary>
        Convert = 6,

        /// <summary>
        /// Enum Duplicate for value: 7
        /// </summary>
        Duplicate = 7
    }

}
