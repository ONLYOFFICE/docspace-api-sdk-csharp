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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// [0 - All, 1 - Room admin, 2 - Guest, 3 - DocSpace admin, 4 - User]
    /// </summary>
    /// <value>[0 - All, 1 - Room admin, 2 - Guest, 3 - DocSpace admin, 4 - User]</value>
    public enum EmployeeType
    {
        /// <summary>
        /// Enum All for value: 0
        /// </summary>
        All = 0,

        /// <summary>
        /// Enum RoomAdmin for value: 1
        /// </summary>
        RoomAdmin = 1,

        /// <summary>
        /// Enum Guest for value: 2
        /// </summary>
        Guest = 2,

        /// <summary>
        /// Enum DocSpaceAdmin for value: 3
        /// </summary>
        DocSpaceAdmin = 3,

        /// <summary>
        /// Enum User for value: 4
        /// </summary>
        User = 4
    }

}
